using System;
using System.Numerics;

namespace CalculationImpedancesApp.Elements
{
	/// <summary>
	/// Base class for all chain elements.
	/// </summary>
	public abstract class ElementBase : IElement
	{
		/// <summary>
		/// Element name.
		/// </summary>
		private string _name;

		/// <summary>
		/// Element value.
		/// </summary>
		private double _value;

		/// <summary>
		/// A collection that stores sub-segmentsObservable.
		/// </summary>
		public SegmentsObservableCollection SubSegments { get; } = null;

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
				if (value.Length == 0)
				{
					throw new ArgumentException($"The " + 
					     $"{nameof(Name)} cannot be empty!");
				}
				if (value != _name)
				{
					SegmentChanged?.Invoke(this,
						new ElementEventArgs($"The element" +
						  $" changed the {nameof(Name)} to {Name}!"));
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
				if (value <= 0)
				{
					throw new ArgumentException($"The " +
						$"{nameof(Value)} cannot be negative or zero!");
				}

				if (value != _value)
				{
					SegmentChanged?.Invoke(this,
						new ElementEventArgs($"The element" +
						$" changed the {nameof(Value)} to {Value}!"));
				}

				_value = value;
			}
		}

		/// <summary>
		/// Creates an element.
		/// </summary>
		/// <param name="name">Element name</param>
		/// <param name="value">Element value</param>
		protected ElementBase(string name, double value)
		{
			Name = name;
			Value = value;
		}

		/// <summary>
		/// An event that will fire when an segment changes.
		/// </summary>
		public event EventHandler SegmentChanged;

		/// <summary>
		/// Element impedance calculation.
		/// <param name="frequency">Signal frequency.</param>
		/// </summary>
		public abstract Complex CalculateZ(double frequency);
	}
}
