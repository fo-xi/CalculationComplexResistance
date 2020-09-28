using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CalculationImpedancesApp
{
	/// <summary>
	/// Base class for all chain elements.
	/// </summary>
	public abstract class Element : IElement
	{
		/// <summary>
		/// An event that will fire when an segment changes.
		/// </summary>
		public event EventHandler SegmentChanged;

		/// <summary>
		/// A collection that stores sub-segments.
		/// </summary>
		public ElementObservableCollections SubSegments { get; } = null;

		/// <summary>
		/// Element name.
		/// </summary>
		private string _name;

		/// <summary>
		/// Element value.
		/// </summary>
		private double _value;

		/// <summary>
		/// Returns and sets the name of an element.
		/// </summary>
		public string Name
		{
			get
			{
				return _name;

			}
			set
			{
				if (value.Length < 0)
				{
					throw new ArgumentException($"The {nameof(Name)} cannot be empty!");
				}
				_name = value;
			}
		}

		/// <summary>
		/// Returns and sets the value of an element.
		/// </summary>
		public double Value
		{
			get
			{
				return _value;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException($"The {nameof(Value)} cannot be negative!");
				}
				if (value != _value)
				{
					SegmentChanged?.Invoke(this,
						new ElementEventArgs($"The capacitor changed the {nameof(Value)} to {Value}!"));
				}
				_value = value;
			}
		}

		/// <summary>
		/// Creates an element.
		/// </summary>
		/// <param name="name">Element name</param>
		/// <param name="value">Element value</param>
		public Element(string name, double value)
		{
			Name = name;
			Value = value;
		}

		/// <summary>
		/// Element impedance calculation.
		/// <param name="frequency">Signal frequency.</param>
		/// </summary>
		public abstract Complex CalculateZ(double frequency);

	}
}
