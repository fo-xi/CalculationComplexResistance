using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;
using System.Numerics;

namespace NUnitTest
{
    class SerialCircuitTest
    {
		[Test(Description = "Positive test of the getter Name")]
		public void TestSerialCircuitNameGet_CorrectValue()
		{
			var expected = "Serial";
			var serialCircuit = new SerialCircuit(new SegmentsObservableCollection
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
			var expected = "Serial";
			var serialCircuit = new SerialCircuit(new SegmentsObservableCollection
			{
				new Capacitor("j55t", 32.5),
			});
			Assert.DoesNotThrow(() =>
			{
				serialCircuit.Name = expected;
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
			var serialCircuit = new SerialCircuit(new SegmentsObservableCollection());
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
			var serialCircuit = new SerialCircuit(new SegmentsObservableCollection());
			Assert.DoesNotThrow(() =>
			{
				serialCircuit.SubSegments = expected;
			}, "The SubSegments setter accepts the correct sub segments");
		}

		[Test(Description = "Positive test of the constructor SerialCircuit")]
		public void TestSerialCircuitConstructor_CorrectValue()
		{
			var subSegments = new SegmentsObservableCollection
			{
				new Inductor("jng5", 56.0),
			};
			Assert.DoesNotThrow(() =>
			{
				var serialCircuit = new SerialCircuit(subSegments);
			}, "The SerialCircuit constructor create a serial circuit object");
		} 

		[Test(Description = "Test of the calculate")]
		public void TestCalculateZ_CorrectValue()
		{
			var subSegments = new SegmentsObservableCollection
			{
				new Inductor("jng5", 56.0),
				new Resistor("fr4tt", 32.6)
			};
			var serialCircuit = new SerialCircuit(subSegments);

			var frequency = 7;
			var expected = 
				subSegments[0].CalculateZ(frequency) +
				subSegments[1].CalculateZ(frequency);

			var actual = serialCircuit.CalculateZ(frequency);

			Assert.AreEqual(expected,
				actual, "The calculator does not count correctly");
		}

		[Test(Description = "Test of the OnSegmentChanged")]
		public void EventRegistrationTesting_CorrectValue()
		{
			var wasCalled = false;
			var subSegments = new SegmentsObservableCollection
			{
				new Inductor("jng5", 56.0),
				new Resistor("fr4tt", 32.6)
			};
			var serialCircuit = new SerialCircuit(subSegments);

			serialCircuit.SegmentChanged += delegate (object o, EventArgs e)
			{
				wasCalled = true;
			};

			serialCircuit.SubSegments.RemoveAt(1);
			Assert.IsTrue(wasCalled);
		}
    }
}
