using System;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class Resistor : IElement
    {
        public event IElement.ValueChanget ValueChangetEvent;

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
                if (value != _value)
                {
                    ValueChangetEvent?.Invoke(this,
                    $"The resistor changed the value to {value}!");
                }
                else
                {
                    _value = value;
                }
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
    }
}
