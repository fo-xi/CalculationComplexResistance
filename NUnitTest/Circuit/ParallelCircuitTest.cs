using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
	class ParallelCircuitTest
    {
		[Test(Description = "Positive test of the getter Name")]
		public void TestParallelCircuitNameGet_CorrectValue()
		{
			var expected = "Parallel";
			var parallelCircuit = new ParallelCircuit(new SegmentsObservableCollection
			{
				new Inductor("jng5", 56.0),
			});
			parallelCircuit.Name = expected;
			var actual = parallelCircuit.Name;
			Assert.AreEqual(expected, actual, "The Name getter " +
				"returns an incorrect name");
		}

		[Test(Description = "Positive test of the setter Name")]
		public void TestParallelCircuitNameSet_CorrectValue()
		{
			var expected = "Parallel";
			var parallelCircuit = new ParallelCircuit(new SegmentsObservableCollection
			{
				new Capacitor("j55t", 32.5),
			});
			Assert.DoesNotThrow(() =>
			{
				parallelCircuit.Name = expected;
			}, "The Name setter accepts the correct name");
		}

		[Test(Description = "Positive test of the getter SubSegments")]
		public void TestSubSegmentsGet_CorrectValue()
		{
			var expected = new SegmentsObservableCollection
			{
				new Inductor("jng5", 56.0),
				new Resistor("fr4tt", 32.6)

			};
			var parallelCircuit = new ParallelCircuit(new SegmentsObservableCollection());
			parallelCircuit.SubSegments = expected;
			var actual = parallelCircuit.SubSegments;
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
			var parallelCircuit = new ParallelCircuit(new SegmentsObservableCollection());
			Assert.DoesNotThrow(() =>
			{
				parallelCircuit.SubSegments = expected;
			}, "The SubSegments setter accepts the correct sub segments");
		}

		[Test(Description = "Positive test of the constructor ParallelCircuit")]
		public void TestParallelCircuitConstructor_CorrectValue()
		{
			var subSegments = new SegmentsObservableCollection
			{
					new Inductor("jng5", 56.0),
			};
			Assert.DoesNotThrow(() =>
			{
				var parallelCircuit = new ParallelCircuit(subSegments);
			}, "The ParallelCircuit constructor create a parallel сircuit object");
		}

		[Test(Description = "Test of the calculate")]
		public void TestCalculateZ_CorrectValue()
		{
			var subSegments = new SegmentsObservableCollection
			{
				new Resistor("g56", 7.8),
				new Capacitor("duj", 22.6)
			};
			var parallelCircuit = new ParallelCircuit(subSegments);

			var frequency = 7;
			var expected =
				1/((1 / (subSegments[0].CalculateZ(frequency)) +
				      (1 / (subSegments[1].CalculateZ(frequency)))));

			var actual = parallelCircuit.CalculateZ(frequency);

			Assert.AreEqual(expected,
				actual, "The calculator does not count correctly");
		}

		[Test(Description = "Test of the OnSegmentChanged")]
		public void EventRegistrationTesting_CorrectValue()
		{
			var wasCalled = false;
			var subSegments = new SegmentsObservableCollection
			{
				new Resistor("g56", 7.8),
				new Capacitor("duj", 22.6)
			};
			var parallelCircuit = new ParallelCircuit(subSegments);

			parallelCircuit.SegmentChanged += delegate (object o, EventArgs e)
			{
				wasCalled = true;
			};

			parallelCircuit.SubSegments.RemoveAt(1);
			Assert.IsTrue(wasCalled);
		}
	}
}
