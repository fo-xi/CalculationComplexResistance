using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    /// <summary>
    /// A class representing a inductor.
    /// </summary>
    public class Inductor : IElement
    {
        /// <summary>
        /// An event that will fire when an element changes.
        /// </summary>
        public event EventHandler SegmentChanged;

        /// <summary>
        /// A collection that stores sub-segments of the circiut.
        /// </summary>
        public ElementObservableCollectioncs<ISegment> SubSegments { get; } = null;

        /// <summary>
        /// Inductor value.
        /// </summary>
        private double _value;

        /// <summary>
        /// Inductor name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Returns and sets the value of a inductor.
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
                    throw new ArgumentOutOfRangeException($"The {nameof(value)} cannot be negative!");
                }
                if (value != _value)
                {
                    SegmentChanged?.Invoke(this,
                    new ElementEventArgs($"The inductor changed the {nameof(value)} to {value}!"));
                }
                _value = value;
            }

        }

        /// <summary>
        /// Creates a inductor.
        /// </summary>
        /// <param name="name">Inductor name.</param>
        /// <param name="value">Inductor value.</param>
        public Inductor(string name, double value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Inductor impedance calculation.
        /// <param name="frequency">Signal frequency.</param>
        /// </summary>
        public Complex CalculateZ(double frequency)
        {
            double result = 2 * Math.PI * frequency * this.Value;
            return new Complex(0, result);
        }

        /// <summary>
        /// Overriding a method that returns the name and value of the capacitor.
        /// </summary>
        public override string ToString()
        {
            return "Inductor: " + Name + " = " + Value;
        }
    }
}
