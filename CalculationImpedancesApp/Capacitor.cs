using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    /// <summary>
    /// A class representing a capacitor.
    /// </summary>
    public class Capacitor : IElement
    {
        /// <summary>
        /// An event that will fire when an segment changes.
        /// </summary>
        public event EventHandler SegmentChanged;

        /// <summary>
        /// A collection that stores sub-segments of the circiut.
        /// </summary>
        public ElementObservableCollectioncs<ISegment> SubSegments { get; } = null;

        /// <summary>
        /// Capacitor value.
        /// </summary>
        private double _value;

        /// <summary>
        /// Capacitor name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Returns and sets the value of a capacitor.
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
                    new ElementEventArgs($"The capacitor changed the {nameof(value)} to {value}!"));
                }
                _value = value;
            }
        }

        /// <summary>
        /// Creates a capacitor.
        /// </summary>
        /// <param name="name">Capacitor name.</param>
        /// <param name="value">Capacitor value.</param>
        public Capacitor(string name, double value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Capacitor impedance calculation.
        /// <param name="frequency">Signal frequency.</param>
        /// </summary>
        public Complex CalculateZ(double frequency)
        {
            double result = -1 / (2 * Math.PI * frequency * this.Value);
            return new Complex(0, result);
        }

        /// <summary>
        /// Overriding a method that returns the name and value of the capacitor.
        /// </summary>
        public override string ToString()
        {
            return "Capacitor: " + Name + " = " + Value;
        }
    }
}
