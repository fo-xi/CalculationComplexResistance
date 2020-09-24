using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class ParallelCircuit : ISegment
    {
        public event EventHandler SegmentChanged;

        public string Name { get; set; }

        public ElementObservableCollectioncs<ISegment> SubSegments { get; set; }

        public ParallelCircuit(string name,
            ElementObservableCollectioncs<ISegment> subSegments)
        {
            Name = name;
            SubSegments = subSegments;
        }

        public Complex CalculateZ(double frequencies)
        {
            Complex result = new Complex();

            foreach (ISegment segment in SubSegments)
            {
                result += (1.0/(segment.CalculateZ(frequencies)));
            }
            result = Complex.Pow(result, -1);
            return result;
        }
    }
}
