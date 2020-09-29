using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    /// <summary>
    /// A class representing a inductor.
    /// </summary>
    public class Inductor : Element
    {
	    /// <summary>
        /// Creates a inductor.
        /// </summary>
        /// <param name="name">Inductor name.</param>
        /// <param name="value">Inductor value.</param>
        public Inductor(string name, double value): base(name, value)
        {
        }

        /// <summary>
        /// Inductor impedance calculation.
        /// <param name="frequency">Signal frequency.</param>
        /// </summary>
        public override Complex CalculateZ(double frequency)
        {
            var result = 2 * Math.PI * frequency * this.Value;
            return new Complex(0, result);
        }

        /// <summary>
        /// Overriding a method that returns the name and value of the inductor.
        /// </summary>
        public override string ToString()
        {
            return "Inductor: " + Name + " = " + Value;
        }
    }
}
