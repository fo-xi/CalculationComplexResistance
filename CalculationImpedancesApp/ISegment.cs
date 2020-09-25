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
        /// An event that will fire when an segment changes.
        /// </summary>
        event EventHandler SegmentChanged;

        /// <summary>
        /// Segment name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// A collection that stores sub-segments of the circiut.
        /// </summary>
        ElementObservableCollectioncs<ISegment> SubSegments { get; }

        /// <summary>
        /// Element or sub - segment impedance calculator.
        /// </summary>
        /// <param name="frequencies"></param>
        /// <returns></returns>
        Complex CalculateZ(double frequencies);
    }
}
