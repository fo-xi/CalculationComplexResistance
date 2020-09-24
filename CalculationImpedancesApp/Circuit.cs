using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class Circuit: ISegment
    {
        public event EventHandler SegmentChanged;

        public string Name { get; set; }

        public ElementObservableCollectioncs<ISegment> SubSegments { get; set; }

        public Circuit(string name, ElementObservableCollectioncs<ISegment> subSegments)
        {
            Name = name;
            SubSegments = subSegments;
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

        Complex ISegment.CalculateZ(double frequencies)
        {
            throw new NotImplementedException();
        }
    }
}
