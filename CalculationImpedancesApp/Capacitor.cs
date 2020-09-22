using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class Capacitor : IElement
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
                    new ElementEventArgs($"The capacitor changed the {nameof(value)} to {value}!"));
                }
                _value = value;
            }
        }

        public Capacitor(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public Complex CalculateZ(double frequency)
        {
            Complex result = -1 / (2 * Math.PI * frequency * this.Value);
            return result;
        }

        public override string ToString()
        {
            return "Capacitor: " + Name + " = " + Value;
        }
    }
}
