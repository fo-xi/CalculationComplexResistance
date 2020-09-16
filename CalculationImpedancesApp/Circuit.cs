using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class Circuit
    {
        delegate void CircuitChanget(object sender, object e);

        event CircuitChanget CircuitChangetEvent;

        private List<IElement> _elements;

        public List<IElement> Elements
        {
            get
            {
                return _elements;
            }
            set
            {
                if (value != _elements)
                {
                    CircuitChangetEvent?.Invoke(this,
                    $"Item values have been changed!");
                }
                else
                {
                    _elements = value;
                }
            }

        }

        public Circuit(List<IElement> elements)
        {
            Elements = elements;
        }

        public Complex[] CalculateZ(double[] frequencies)
        {
            Complex[] results = new Complex[frequencies.Length];

            for (int i = 0; i < results.Length; i++)
            {
                foreach (IElement element in Elements)
                {
                    results[i] += element.CalculateZ(frequencies[i]);
                }
            }
            return results;
        }

    }
}
