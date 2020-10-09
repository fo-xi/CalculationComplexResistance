using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
	class ElementTest
	{
		[Test(Description = "Positive test of the getter Name")]
		public void TestNameGet_CorrectValue()
		{
			var expected = "ht56";
			var element = new Resistor("j55t", 32.5);
			element.Name = expected;
			var actual = element.Name;
			Assert.AreEqual(expected, actual, "The Name getter " +
			                                  "returns an incorrect name");
		}

		[Test(Description = "Positive test of the setter Name")]
		public void TestNameSet_CorrectValue()
		{
			var expected = "htt56";
			var element = new Resistor("j55t", 32.5);
			Assert.DoesNotThrow(() =>
			{
				element.Name = expected;
			}, "The Name setter accepts the correct name");
		}

		[TestCase("", "An exception may occur if the name contains less than 1 symbol",
			TestName = "Assigning an incorrect element name that contains less than 1 symbol")]
		public void TestName_InvalidName(string wrongName, string message)
		{
			var element = new Resistor(" ", 32.5);
			Assert.Throws<ArgumentException>(() =>
			{
				element.Name = wrongName;
			}, message);
		}



		[Test(Description = "Positive test of the getter Value")]
		public void TestValueGet_CorrectValue()
		{
			var expected = 4.6;
			var element = new Resistor("j55t", 32.5);
			element.Value = expected;
			var actual = element.Value;
			Assert.AreEqual(expected, actual, "The Value getter " +
			                                  "returns an incorrect value");
		}

		[Test(Description = "Positive test of the setter Value")]
		public void TestValueSet_CorrectValue()
		{
			var expected = 21.6;
			var element = new Resistor("j55t", 32.5);
			Assert.DoesNotThrow(() =>
			{
				element.Value = expected;
			}, "The Value setter accepts the correct value");
		}

		[TestCase(-8.5, "An exception can occur if the value contains a negative number",
			TestName = "Assigning a negative number")]
		public void TestValue_NegativeNumber(double wrongValue, string message)
		{
			var element = new Resistor("thn4", 32.5);
			Assert.Throws<ArgumentException>(() =>
			{
				element.Value = wrongValue;
			}, message);
		}

		[Test(Description = "Positive test of the getter SubSegments")]
		public void TestSubSegmentsGet_CorrectValue()
		{
			var element = new Resistor("g56", 7.8);
			SegmentsObservableCollection expected = null;
			var actual = element.SubSegments;
			Assert.AreEqual(expected, actual, "The SubSegments getter " +
			                                  "returns an incorrect sub segments");
		}

		[Test(Description = "Test of the constructor Circuit")]
		public void TestConstructor_CorrectValue()
		{
			var name = "d345";
			var value = 55.7;
			Assert.DoesNotThrow(() =>
			{
				var element = new Resistor(name, value);
			}, "The Circuit constructor create a circuit object");
		}

		[Test(Description = "Testing an event")]
		public void TestEvent_CorrectValue()
		{
			var wasCalled = false;
			var element = new Resistor(" ", 32.5);
			element.SegmentChanged += delegate (object o, EventArgs e)
			{
				wasCalled = true;
			};
			element.Value = 33.5;
			Assert.IsTrue(wasCalled);
		}
	}
}
