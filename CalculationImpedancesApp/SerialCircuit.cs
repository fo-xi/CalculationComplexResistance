using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Collections.ObjectModel;
using System.Globalization;

namespace CalculationImpedancesApp
{
    /// <summary>
    /// Serial circuit segment.
    /// </summary>
    public class SerialCircuit : ISegment
    {
        /// <summary>
        /// An event that fires when a parallel segment changes.
        /// </summary>
        public event EventHandler SegmentChanged;

        /// <summary>
        /// Serial circuit name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Collection of parallel segment subsegments.
        /// </summary>
        public ElementObservableCollectioncs<ISegment> SubSegments { get; set; }

        /// <summary>
        /// Create a serial segment.
        /// </summary>
        /// <param name="name">Serial circuit name.</param>
        /// <param name="subSegments">Serial circuit segment.</param>
        public SerialCircuit(string name,
            ElementObservableCollectioncs<ISegment> subSegments)
        {
            Name = name;
            SubSegments = subSegments;
            SubSegments.CollectionChanged += OnSegmentChanged;
        }

        /// <summary>
        /// SegmentChanged event registration.
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">EventArgs.</param>
        private void OnSegmentChanged(object sender, EventArgs e)
        {
            SegmentChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Calculating the impedance of a serial segment.
        /// </summary>
        /// <param name="frequencies">Signal frequency.</param>
        /// <returns></returns>
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
