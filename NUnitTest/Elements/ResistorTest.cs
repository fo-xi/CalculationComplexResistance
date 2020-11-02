using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;
using CalculationImpedancesApp.Elements;

namespace NUnitTest
{
	class ResistorTest
    {
        [Test(Description = "Test of the constructor Resistor")]
        public void TestConstructor_CorrectValue()
        {
            var name = "uh44";
            var value = 23.2;
            Assert.DoesNotThrow(() =>
            {
                var resistor = new Resistor(name, value);
            }, "The Resistor constructor create a resistor object");
        }

        [Test(Description =  "Test of the calculate")]
        public void TestCalculateZ_CorrectValue()
        {
	        var resistor = new Resistor("dfr4", 43.5);
	        Complex expected = new Complex(43.5,0);
	        var actual = resistor.CalculateZ(7);

	        Assert.AreEqual(expected,
		        actual, "The calculator does not count correctly");
        }

        [Test(Description = "Test of the ToString")]
        public void TestToString_CorrectValue()
        {
	        var resistor = new Resistor("dfr4", 43.5);
	        var expected = "Resistor: " + "dfr4" + " = " + "43.5";
	        var actual = resistor.ToString();

	        Assert.AreEqual(expected,
		        actual, "Returns an invalid string");
        }
    }
}
