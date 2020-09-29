using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
    class InductorTest
    {
        [Test(Description = "Positive test of the constructor Inductor")]
        public void TestInductorConstructor_CorrectValue()
        {
            var name = "d345";
            var value = 4.6;
            Assert.DoesNotThrow(() =>
            {
                var inductor = new Inductor(name, value);
            }, "The Inductor constructor create a inductor object");
        }
    }
}
