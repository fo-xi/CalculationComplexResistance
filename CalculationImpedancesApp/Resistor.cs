using System;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class Resistor : IElement
    {
        public event EventHandler ValueChanged;

        private double _value;

        public string Name { get; set; }

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
                    ValueChanged?.Invoke(this,
                    new ElementEventArgs($"The resistor changed the {nameof(value)} to {value}!"));
                }
                _value = value;
            }
        }

        public Resistor(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public Complex CalculateZ(double frequency)
        {
            Complex result = new Complex(Value, 0);
            return result;
        }

        public override string ToString()
        {
            return "Resistor: " + Name + " = " + Value;
        }
    }
}
