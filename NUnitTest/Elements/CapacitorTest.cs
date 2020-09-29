using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
    class CapacitorTest
    {
        [Test(Description = "Positive test of the constructor Capacitor")]
        public void TestCapacitorConstructor_CorrectValue()
        {
            var name = "gh4";
            var value = 57.2;
            Assert.DoesNotThrow(() =>
            {
                var capacitor = new Capacitor(name, value);
            }, "The Capacitor constructor create a capacitor object");
        }
    }
}
