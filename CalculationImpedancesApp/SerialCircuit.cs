using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Collections.ObjectModel;
using System.Globalization;

namespace CalculationImpedancesApp
{
    public class SerialCircuit : ISegment
    {
        public event EventHandler SegmentChanged;

        public string Name { get; set; }

        public ElementObservableCollectioncs<ISegment> SubSegments { get; set; }

        public SerialCircuit(string name,
            ElementObservableCollectioncs<ISegment> subSegments)
        {
            Name = name;
            SubSegments = subSegments;
            SubSegments.CollectionChanged += OnSegmentChanged;
        }

        private void OnSegmentChanged(object sender, EventArgs e)
        {
            SegmentChanged?.Invoke(sender, e);
        }

        public Complex CalculateZ(double frequencies)
        {
            Complex result = new Complex();

            foreach (ISegment segment in SubSegments)
            {
                result += segment.CalculateZ(frequencies);
            }
            return result;
        }
    }
}
