using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
	class CircuitTest
	{
		[Test(Description = "Positive test of the getter Name")]
		public void TestCircuitNameGet_CorrectValue()
		{
			var expected = "ht56";
			var circuit = new Circuit(" ", new SegmentsObservableCollection
			{
				new Capacitor("j55t", 32.5),
			});
			circuit.Name = expected;
			var actual = circuit.Name;
			Assert.AreEqual(expected, actual, "The Name getter " +
				"returns an incorrect name");
		}

		[Test(Description = "Positive test of the setter Name")]
		public void TestCircuitNameSet_CorrectValue()
		{
			var expected = "htt56";
			var circuit = new Circuit(" ", new SegmentsObservableCollection
			{
				new Capacitor("j55t", 32.5),
			});
			Assert.DoesNotThrow(() =>
			{
				circuit.Name = expected;
			}, "The Name setter accepts the correct name");
		}

		[TestCase("", "An exception may occur if the name contains less than 1 symbol",
			TestName = "Assigning an incorrect name that contains less than 1 symbol")]
		public void TestName_InvalidName(string wrongName, string message)
		{
			var circuit = new Circuit(" ", new SegmentsObservableCollection
			{
				new Capacitor("rg4", 32.5)
			});
			Assert.Throws<ArgumentException>(() =>
			{
				circuit.Name = wrongName;
			}, message);
		}

		[Test(Description = "Positive test of the constructor Circuit")]
		public void TestCircuitConstructor_CorrectValue()
		{
			var name = "d345";
			var subSegments = new SegmentsObservableCollection
			{
				new SerialCircuit("fj5", new SegmentsObservableCollection
					{
						new Inductor("jng5", 56.0),
						new Resistor("fr4tt", 32.6)
					}),
				new ParallelCircuit("ut4f", new SegmentsObservableCollection
					{
						new Resistor("g56", 7.8),
						new Capacitor("duj", 22.6)
					}),

			}; 
			Assert.DoesNotThrow(() =>
			{
				var сircuit = new Circuit(name, subSegments);
			}, "The Circuit constructor create a сircuit object");
		}
	}
}
