using System;
using System.Numerics;
using System.Collections.Generic;

namespace CalculationImpedancesApp
{
    /// <summary>
    /// A class representing a resistor.
    /// </summary>
    public class Resistor : Element
    {
	    /// <summary>
        /// Creates a resistor.
        /// </summary>
        /// <param name="name">Resistor name.</param>
        /// <param name="value">Resistor value.</param>
        public Resistor(string name, double value): base(name, value)
        {
        }

        /// <summary>
        /// Resistor impedance calculation.
        /// <param name="frequency">Signal frequency.</param>
        /// </summary>
        public override Complex CalculateZ(double frequency)
        {
            Complex result = new Complex(Value, 0);
            return result;
        }

        /// <summary>
        /// Overriding a method that returns the name and value of the resistor.
        /// </summary>
        public override string ToString()
        {
            return "Resistor: " + Name + " = " + Value;
        }
    }
}
