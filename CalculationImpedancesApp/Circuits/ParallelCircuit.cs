using System;
using System.Numerics;

//TODO: Несоответствие дефолтному namespace (+)
namespace CalculationImpedancesApp.Circuits
{
	/// <summary>
	/// Parallel circuit segment.
	/// </summary>
    public class ParallelCircuit : ISegment
	{
        //TODO: Не используется (+)

        /// <summary>
        /// Collection of serial parallel segment subsegments.
        /// </summary>
        public SegmentsObservableCollection SubSegments { get; set; }

        /// <summary>
        /// Returns and sets the name of the parallel circuit segment.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Create a parallel circuit segment.
        /// </summary>
        /// //TODO Сигнатура XML комментария и метода различны (+)
        /// <param name="subSegmentsObservable">Parallel circuit segment.</param>
        public ParallelCircuit(SegmentsObservableCollection subSegmentsObservable)
        {
            Name = "Parallel";
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

            if (SubSegments.Count == 0)
            {
	            return new Complex(0, 0);
            }

            foreach (ISegment segment in SubSegments)
            {
                //TODO: RSDN (+)
	            if (segment.CalculateZ(frequencies).Real == 0 && 
                    segment.CalculateZ(frequencies).Imaginary == 0)
	            {
		            continue;
	            }

                result += (1.0/(segment.CalculateZ(frequencies)));
            }

            result = 1.0/(result);
            return result;
        }
	}
}
