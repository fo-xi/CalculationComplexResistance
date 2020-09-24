using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public interface ISegment
    {
        event EventHandler SegmentChanged;

        string Name { get; set; }

        ElementObservableCollectioncs<ISegment> SubSegments { get; }

        Complex CalculateZ(double frequencies);
    }
}
