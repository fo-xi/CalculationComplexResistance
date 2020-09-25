 using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    /// <summary>
    /// IElement interface.
    /// </summary>
    public interface IElement : ISegment
    {
        /// <summary>
        /// Element value.
        /// </summary>
        double Value { get; set; }
    }
}
