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
        /// An event that fires when a serial circuit segment changes.
        /// </summary>
        public event EventHandler SegmentChanged;

        /// <summary>
        /// Serial circuit segment name.
        /// </summary>
        private string _name;

        /// <summary>
        ///Returns and sets the name of the serial circuit segment.
        /// </summary>
        public string Name
        {
	        get
	        {
		        return _name;

	        }
	        set
	        {
		        if (value.Length < 0)
		        {
			        throw new ArgumentException($"The {nameof(Name)} cannot be empty!");
		        }
		        _name = value;
            }
        }

        /// <summary>
        /// Collection of serial circuit segment subsegments.
        /// </summary>
        public SegmentsObservableCollection SubSegmentsObservable { get; set; }

        /// <summary>
        /// Create a serial circuit segment.
        /// </summary>
        /// <param name="name">Serial circuit name.</param>
        /// <param name="subSegmentsObservable">Serial circuit segment.</param>
        public SerialCircuit(string name,
            SegmentsObservableCollection subSegmentsObservable)
        {
            Name = name;
            SubSegmentsObservable = subSegmentsObservable;
            SubSegmentsObservable.CollectionChanged += OnSegmentChanged;
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
        /// Calculating the impedance of a serial circuit segment.
        /// </summary>
        /// <param name="frequencies">Signal frequency.</param>
        /// <returns></returns>
        public Complex CalculateZ(double frequencies)
        {
            Complex result = new Complex();

            foreach (ISegment segment in SubSegmentsObservable)
            {
                result += segment.CalculateZ(frequencies);
            }
            return result;
        }
    }
}
