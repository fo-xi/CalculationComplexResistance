using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;
using CalculationImpedancesApp.Elements;

//TODO: Несоответствие дефолтному namespace (+)
namespace NUnitTest.Elements
{
    //TODO: RSDN (+)
	public class CapacitorTest
    {
        //TODO: Нужно ещё добавить тестирование на корректную установку свойств
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
