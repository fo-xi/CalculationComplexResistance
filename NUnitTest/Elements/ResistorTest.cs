using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
    class ResistorTest
    {
        [Test(Description = "Positive test of the constructor Resistor")]
        public void TestResistorConstructor_CorrectValue()
        {
            var name = "uh44";
            var value = 23.2;
            Assert.DoesNotThrow(() =>
            {
                var resistor = new Resistor(name, value);
            }, "The Resistor constructor create a resistor object");
        }
    }
}
