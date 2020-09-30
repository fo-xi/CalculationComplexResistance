using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
    class InductorTest
    {
        [Test(Description = "Positive test of the constructor")]
        public void TestInductorConstructor_CorrectValue()
        {
            var name = "d345";
            var value = 4.6;
            Assert.DoesNotThrow(() =>
            {
                var inductor = new Inductor(name, value);
            }, "The Inductor constructor create a inductor object");
        }

        [Test(Description = "Positive test of the calculate")]
        public void TestCalculateZ_CorrectValue()
        {
	        var inductor = new Inductor("dfr4", 43.5);
	        double expected = 2 * Math.PI * 7 * 43.5;
            var actual = inductor.CalculateZ(7);

	        Assert.AreEqual(expected,
		        actual.Imaginary, "The calculator does not count correctly");
        }

        [Test(Description = "Positive test of the ToString")]
        public void TestToString_CorrectValue()
        {
	        var inductor = new Inductor("dfr4", 43.5);
	        var expected = "Inductor: " + "dfr4" + " = " + "43.5";
	        var actual = inductor.ToString();

	        Assert.AreEqual(expected,
		        actual, "Returns an invalid string");
        }
    }
}
