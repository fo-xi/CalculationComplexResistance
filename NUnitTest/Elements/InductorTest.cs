using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;
using CalculationImpedancesApp.Elements;

namespace NUnitTest
{
	class InductorTest
    {
	    [Test(Description = "Test of the constructor")]
        public void TestConstructor_CorrectValue()
        {
            var name = "d345";
            var value = 4.6;
            Assert.DoesNotThrow(() =>
            {
                var inductor = new Inductor(name, value);
            }, "The Inductor constructor create a inductor object");
        }

        [Test(Description = "Test of the calculate")]
        public void TestCalculateZ_CorrectValue()
        {
	        var inductor = new Inductor("dfr4", 43.5);
	        double expected = 2 * Math.PI * 7 * 43.5;
            var actual = inductor.CalculateZ(7);

	        Assert.AreEqual(expected,
		        actual.Imaginary, "The calculator does not count correctly");
        }

        [Test(Description = "Test of the ToString")]
        public void TestToString_CorrectValue()
        {
	        var inductor = new Inductor("dfr4", 43.5);
	        var expected = "Inductor: " + "dfr4" + " = " + "43.5 H";
	        var actual = inductor.ToString();

	        Assert.AreEqual(expected,
		        actual, "Returns an invalid string");
        }
    }
}
