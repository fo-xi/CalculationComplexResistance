using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
    class SerialCircuitTest
    {
		[Test(Description = "Positive test of the getter Name")]
		public void TestSerialCircuitNameGet_CorrectValue()
		{
			var expected = "ht56";
			var serialCircuit = new SerialCircuit(" ", new SegmentsObservableCollection
			{
				new Inductor("jng5", 56.0),
			});
			serialCircuit.Name = expected;
			var actual = serialCircuit.Name;
			Assert.AreEqual(expected, actual, "The Name getter " +
				"returns an incorrect name");
		}

		[Test(Description = "Positive test of the setter Name")]
		public void TestSerialCircuitNameSet_CorrectValue()
		{
			var expected = "htt56";
			var serialCircuit = new SerialCircuit(" ", new SegmentsObservableCollection
			{
				new Capacitor("j55t", 32.5),
			});
			Assert.DoesNotThrow(() =>
			{
				serialCircuit.Name = expected;
			}, "The Name setter accepts the correct name");
		}

		[TestCase("", "An exception may occur if the name contains less than 1 symbol",
			TestName = "Assigning an incorrect name that contains less than 1 symbol")]
		public void TestSerialCircuitName_InvalidName(string wrongName, string message)
		{
			var serialCircuit = new SerialCircuit(" ", new SegmentsObservableCollection
			{
				new Capacitor("rg4", 32.5)
			});
			Assert.Throws<ArgumentException>(() =>
			{
				serialCircuit.Name = wrongName;
			}, message);
		}

		[Test(Description = "Positive test of the getter SubSegments")]
		public void TestSubSegmentsGet_CorrectValue()
		{
			var expected = new SegmentsObservableCollection
			{
				new Inductor("jng5", 56.0),
				new Resistor("fr4tt", 32.6)

			};
			var serialCircuit = new SerialCircuit(" ", null);
			serialCircuit.SubSegments = expected;
			var actual = serialCircuit.SubSegments;
			Assert.AreEqual(expected, actual, "The SubSegments getter " +
			  "returns an incorrect sub segments");
		}

		[Test(Description = "Positive test of the setter SubSegments")]
		public void TestSubSegmentsSet_CorrectValue()
		{
			var expected = new SegmentsObservableCollection
			{
				new Inductor("jng5", 56.0),
				new Resistor("fr4tt", 32.6)
			};
			var serialCircuit = new SerialCircuit(" ", null);
			Assert.DoesNotThrow(() =>
			{
				serialCircuit.SubSegments = expected;
			}, "The SubSegments setter accepts the correct sub segments");
		}

		[Test(Description = "Positive test of the constructor SerialCircuit")]
		public void TestSerialCircuitConstructor_CorrectValue()
		{
			var name = "d345";
			var subSegments = new SegmentsObservableCollection
			{
					new Inductor("jng5", 56.0),
			};
			Assert.DoesNotThrow(() =>
			{
				var serialCircuit = new SerialCircuit(name, subSegments);
			}, "The SerialCircuit constructor create a serial circuit object");
		}
	}
}
