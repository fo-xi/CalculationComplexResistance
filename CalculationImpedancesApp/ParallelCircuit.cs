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
        /// An event that fires when a parallel circuit segment changes.
        /// </summary>
        public event EventHandler SegmentChanged;

        /// <summary>
        /// Parallel circuit segment name.
        /// </summary>
        private string _name;

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
		        if (value.Length < 0)
		        {
			        throw new ArgumentException($"The {nameof(Name)} cannot be empty!");
		        }

		        _name = value;
	        }
        }

        /// <summary>
        /// Collection of serial parallel segment subsegments.
        /// </summary>
        public ElementObservableCollectioncs<ISegment> SubSegments { get; set; }
        
        /// <summary>
        /// Create a parallel circuit segment.
        /// </summary>
        /// <param name="name">Parallel circuit name.</param>
        /// <param name="subSegments">Parallel circuit segment.</param>
        public ParallelCircuit(string name,
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
        /// Calculating the impedance of a parallel circuit segment.
        /// </summary>
        /// <param name="frequencies">Signal frequency.</param>
        /// <returns></returns>
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
