using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;
using CalculationImpedancesApp.Elements;

namespace NUnitTest.Elements
{
	public class CapacitorTest
    {
        [Test(Description = "Test of the constructor")]
        public void TestConstructor_CorrectValue()
        {
            var name = "gh4";
            var value = 57.2;
            Assert.DoesNotThrow(() =>
            {
                var capacitor = new Capacitor(name, value);
            }, "The Capacitor constructor create a capacitor object");
        }

        [Test(Description = "Negative test of the constructor Capacitor with wrong name")]
        public void TestConstructor_InvalidName()
        {
	        var wrongName = "";
	        var value = 23.2;
	        Assert.Throws<ArgumentException>(() =>
		        {
			        var capacitor = new Capacitor(wrongName, value);
		        }, "An exception should be thrown if the constructor " +
                   "creates a capacitor whose name contains less than one character");
        }

        [Test(Description = "Negative test of the constructor Capacitor with wrong value")]
        public void TestConstructor_InvalidValue()
        {
	        var name = "thh";
	        var wrongValue = -23.2;
	        Assert.Throws<ArgumentException>(() =>
		        {
			        var capacitor = new Capacitor(name, wrongValue);
		        }, "An exception should be thrown if the constructor " +
                   "creates a capacitor with wrong value");
        }

        [Test(Description = "Test of the calculate")]
        public void TestCalculateZ_CorrectValue()
        {
	        var capacitor = new Capacitor("dfr4", 43.5);
	        double expected = -1 / (2 * Math.PI * 7 * 43.5);
            var actual = capacitor.CalculateZ(7);

            Assert.AreEqual(expected,
	            actual.Imaginary, "The calculator does not count correctly");
        }

        [Test(Description = "Test of the ToString")]
        public void TestToString_CorrectValue()
        {
	        var capacitor = new Capacitor("dfr4", 43.5);
	        var expected = "Capacitor: " + "dfr4" + " = " + "43.5 F";
	        var actual = capacitor.ToString();

	        Assert.AreEqual(expected,
		        actual, "Returns an invalid string");
        }
    }
}
