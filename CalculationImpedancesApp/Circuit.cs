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

        public ElementObservableCollectioncs<ISegment> SubSegments { get; set; }

        public Circuit(string name, ElementObservableCollectioncs<ISegment> subSegments)
        {
            Name = name;
            SubSegments = subSegments;
            SubSegments.CollectionChanged += OnCircuitChanged;
        }

        private void OnCircuitChanged(object sender, EventArgs e)
        {
            CircuitChanged?.Invoke(sender, e);
        }

        public List<Complex> CalculateZ(List<double> frequencies)
        {
            List<Complex> results = new List<Complex>();

            for (int i = 0; i < frequencies.Count; i++)
            {
                results.Add(new Complex());
                foreach (ISegment segment in SubSegments)
                {
                    results[i] += segment.CalculateZ(frequencies[i]);
                }
            }
            return results;
        }
    }
}
