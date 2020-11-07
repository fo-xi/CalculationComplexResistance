using System;
using System.Numerics;

namespace CalculationImpedancesApp.Elements
{
    /// <summary>
    /// A class representing a capacitor.
    /// </summary>
    public class Capacitor : ElementBase
    {
	    /// <summary>
        /// Creates a capacitor.
        /// </summary>
        /// <param name="name">Capacitor name.</param>
        /// <param name="value">Capacitor value.</param>
        public Capacitor(string name, double value): base(name, value)
        {
        }

        /// <summary>
        /// Capacitor impedance calculation.
        /// <param name="frequency">Signal frequency.</param>
        /// </summary>
        public override Complex CalculateZ(double frequency)
        {
            var result = -1 / (2 * Math.PI * frequency * this.Value);
            return new Complex(0, result);
        }

        /// <summary>
        /// Overriding a method that returns the name and value of the capacitor.
        /// </summary>
        public override string ToString()
        {
            return "Capacitor: " + Name + " = " + Value + " F";
        }
    }
}
