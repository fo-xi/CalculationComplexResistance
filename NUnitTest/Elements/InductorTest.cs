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
	public class InductorTest
    {
        //TODO: Нужно ещё добавить тестирование на корректную установку свойств (+)
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

        [Test(Description = "Negative test of the constructor Inductor with wrong name")]
        public void TestConstructor_InvalidName()
        {
	        var wrongName = "";
	        var value = 23.2;
	        Assert.Throws<ArgumentException>(() =>
		        {
			        var inductor = new Inductor(wrongName, value);
		        }, "An exception should be thrown if the constructor " +
                   "creates a inductor whose name contains less than one character");
        }

        [Test(Description = "Negative test of the constructor Inductor with wrong value")]
        public void TestConstructor_InvalidValue()
        {
	        var name = "thh";
	        var wrongValue = -23.2;
	        Assert.Throws<ArgumentException>(() =>
		        {
			        var inductor = new Inductor(name, wrongValue);
		        }, "An exception should be thrown if the constructor " +
                   "creates a inductor with wrong value");
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
