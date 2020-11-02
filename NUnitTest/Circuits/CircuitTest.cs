using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;
using System.Numerics;
using CalculationImpedancesApp.Circuits;
using CalculationImpedancesApp.Elements;

namespace NUnitTest
{
	class CircuitTest
	{
		[Test(Description = "Positive test of the getter Name")]
		public void TestNameGet_CorrectValue()
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
		public void TestNameSet_CorrectValue()
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
			TestName = "Assigning an incorrect circuit name that contains less than 1 symbol")]
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

		[Test(Description = "Positive test of the getter SubSegments")]
		public void TestSubSegmentsGet_CorrectValue()
		{
			var expected = new SegmentsObservableCollection
			{
				new SerialCircuit(new SegmentsObservableCollection
				{
					new Inductor("jng5", 56.0),
				}),
				new ParallelCircuit(new SegmentsObservableCollection
				{
					new Resistor("g56", 7.8),
					new Capacitor("duj", 22.6)
				}),
			};
			var circuit = new Circuit(" ", new SegmentsObservableCollection());
			circuit.SubSegments = expected;
			var actual = circuit.SubSegments;
			Assert.AreEqual(expected, actual, "The SubSegments getter " +
			  "returns an incorrect sub segments");
		}

		[Test(Description = "Positive test of the setter SubSegments")]
		public void TestSubSegmentsSet_CorrectValue()
		{
			var expected = new SegmentsObservableCollection
			{
				new SerialCircuit(new SegmentsObservableCollection
				{
					new Inductor("jng5", 56.0),
				}),
				new ParallelCircuit(new SegmentsObservableCollection
				{
					new Resistor("g56", 7.8),
					new Capacitor("duj", 22.6)
				}),
			};
			var circuit = new Circuit(" ", new SegmentsObservableCollection());
			Assert.DoesNotThrow(() =>
			{
				circuit.SubSegments = expected;
			}, "The SubSegments setter accepts the correct sub segments");
		}

		[Test(Description = "Test of the constructor Circuit")]
		public void TestConstructor_CorrectValue()
		{
			var name = "d345";
			var subSegments = new SegmentsObservableCollection
			{
				new SerialCircuit(new SegmentsObservableCollection
				{
					new Inductor("jng5", 56.0),
					new Resistor("fr4tt", 32.6)
				}),
				new ParallelCircuit(new SegmentsObservableCollection
				{
					new Resistor("g56", 7.8),
					new Capacitor("duj", 22.6)
				}),
			}; 
			Assert.DoesNotThrow(() =>
			{
				var circuit = new Circuit(name, subSegments);
			}, "The Circuit constructor create a circuit object");
		}

		[Test(Description = "Test of the OnCircuitChanged Circuit")]
		public void EventRegistrationTesting_CorrectValue()
		{
			var wasCalled = false;
			var subSegments = new SegmentsObservableCollection
			{
				new SerialCircuit(new SegmentsObservableCollection
				{
					new Inductor("jng5", 56.0),
					new Resistor("fr4tt", 32.6)
				}),
				new ParallelCircuit(new SegmentsObservableCollection
				{
					new Resistor("g56", 7.8),
					new Capacitor("duj", 22.6)
				}),
			};
			var circuit = new Circuit("fdr4", subSegments);

			circuit.SegmentChanged += delegate (object o, EventArgs e)
			{
				wasCalled = true;
			};

			circuit.SubSegments.RemoveAt(1);
			Assert.IsTrue(wasCalled);
		}

		[Test(Description = "Test of the calculate")]
		public void TestCalculateZ_CorrectValue()
		{
			var subSegments = new SegmentsObservableCollection
			{
				new SerialCircuit(new SegmentsObservableCollection
				{
					new Inductor("jng5", 56.0),
					new Resistor("fr4tt", 32.6)
				}),
				new ParallelCircuit(new SegmentsObservableCollection
				{
					new Resistor("g56", 7.8),
					new Capacitor("duj", 22.6)
				}),
			};
			var circuit = new Circuit("fdr4", subSegments);

			List<double> frequencies = new List<double> { 32.5, 21.4, 11.9 };

			List<Complex> results = new List<Complex>();
			foreach (var frequency in frequencies)
			{
				var serialCircuitResult = 
					subSegments[0].SubSegments[0].CalculateZ(frequency) +
				    subSegments[0].SubSegments[1].CalculateZ(frequency);
				var parallelCircuitResult = 
					1/((1/(subSegments[1].SubSegments[0].CalculateZ(frequency)) + 
				    (1/(subSegments[1].SubSegments[1].CalculateZ(frequency)))));
				var result = serialCircuitResult + parallelCircuitResult;
				results.Add(result);
			}
			List<Complex> expected = results;
			var actual = circuit.CalculateZ(frequencies);

			Assert.AreEqual(expected,
				actual, "The calculator does not count correctly");
		}
	}
}
