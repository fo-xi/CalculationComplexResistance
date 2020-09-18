 using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public interface IElement
    {
        delegate void ValueChanget(object sender, object e);

        event ValueChanget ValueChangetEvent;

        string Name { get; set; }

        double Value { get; set; }

        Complex CalculateZ(double frequency);
    }
}
