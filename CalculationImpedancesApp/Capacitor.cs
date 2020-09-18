using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class Capacitor : IElement
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
                    $"The capacitor changed the value to {value}!");
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
            Complex result = 2 * Math.PI * frequency * this.Value;
            return result;
        }
    }
}
