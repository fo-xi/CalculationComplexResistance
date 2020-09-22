using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class Circuit
    {
        public event EventHandler CircuitChanged;

        public string Name { get; set; }

        public List<IElement> Elements;

        public Circuit(string name, List<IElement> elements)
        {
            Name = name;
            Elements = elements;

            foreach (var i in Elements)
            {
                i.ValueChanged += OnElementEvent;
            }
        }

        public List<Complex> CalculateZ(List<double> frequencies)
        {
            List<Complex> results = new List<Complex>();

            for (int i = 0; i < frequencies.Count; i++)
            {
                results.Add(new Complex());
                foreach (IElement element in Elements)
                {
                    results[i] += element.CalculateZ(frequencies[i]);
                }
            }
            return results;
        }

        private void OnElementEvent(object sender, EventArgs e)
        {
            CircuitChanged?.Invoke(sender, e);
        }
    }
}
