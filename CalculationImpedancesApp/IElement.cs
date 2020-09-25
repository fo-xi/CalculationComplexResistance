using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public interface IElement: ISegment
    {
        double Value { get; set; }
    }
}
