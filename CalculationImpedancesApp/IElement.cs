 using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public interface IElement
    {
        event EventHandler ValueChanged;

        string Name { get; set; }

        double Value { get; set; }

        Complex CalculateZ(double frequency);
    }
}
