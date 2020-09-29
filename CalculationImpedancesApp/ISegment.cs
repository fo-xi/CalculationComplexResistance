using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    /// <summary>
    /// ISegment interface.
    /// </summary>
    public interface ISegment
    {
        /// <summary>
        /// A collection that stores sub-segmentsObservable of the circiut.
        /// </summary>
        SegmentsObservableCollection SubSegments { get; }

        /// <summary>
        /// Segment name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// An event that will fire when an segment changes.
        /// </summary>
        event EventHandler SegmentChanged;

        /// <summary>
        /// Element or sub - segment impedance calculator.
        /// </summary>
        /// <param name="frequencies"></param>
        /// <returns></returns>
        Complex CalculateZ(double frequencies);
    }
}
