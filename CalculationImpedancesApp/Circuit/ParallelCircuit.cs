using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
	/// <summary>
	/// Parallel circuit segment.
	/// </summary>
    public class ParallelCircuit : ISegment
    {
        /// <summary>
        /// Parallel circuit segment name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Collection of serial parallel segment subsegments.
        /// </summary>
        public SegmentsObservableCollection SubSegments { get; set; }

        /// <summary>
        /// Returns and sets the name of the parallel circuit segment.
        /// </summary>
        public string Name
        {
	        get
	        {
		        return _name;

	        }
	        set
	        {
		        if (value.Length == 0)
		        {
			        throw new ArgumentException($"The {nameof(Name)} cannot be empty!");
		        }

		        _name = value;
	        }
        }
        
        /// <summary>
        /// Create a parallel circuit segment.
        /// </summary>
        /// <param name="name">Parallel circuit name.</param>
        /// <param name="subSegmentsObservable">Parallel circuit segment.</param>
        public ParallelCircuit(string name,
            SegmentsObservableCollection subSegmentsObservable)
        {
            Name = name;
            SubSegments = subSegmentsObservable;
            SubSegments.CollectionChanged += OnSegmentChanged;
        }

        /// <summary>
        /// An event that fires when a parallel circuit segment changes.
        /// </summary>
        public event EventHandler SegmentChanged;

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
        /// Calculating the impedance of a parallel circuit segment.
        /// </summary>
        /// <param name="frequencies">Signal frequency.</param>
        /// <returns></returns>
        public Complex CalculateZ(double frequencies)
        {
            var result = new Complex();

            foreach (ISegment segment in SubSegments)
            {
                result += (1.0/(segment.CalculateZ(frequencies)));
            }
            result = 1/(result);
            return result;
        }
    }
}
