﻿using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;
using System.Numerics;
using CalculationImpedancesApp.Circuits;
using CalculationImpedancesApp.Elements;

namespace NUnitTest.Circuits
{
	public class CircuitTest
	{
		//TODO: Корректнее сделать приватным свойством (+)
        private Circuit CreateCircuit
        {
            get
            {
                return new Circuit(" ", new SegmentsObservableCollection
                {
                    new SerialCircuit(new SegmentsObservableCollection
                    {
                        new Resistor("jng5", 56.0),
                    }),
                    new ParallelCircuit(new SegmentsObservableCollection
                    {
                        new Resistor("g56", 8.0),
                    }),
                });
			}
        } 
            

		[Test(Description = "Positive test of the getter Name")]
		public void TestNameGet_CorrectValue()
		{
			var expected = "ht56";
			var circuit = CreateCircuit;
			circuit.Name = expected;
			var actual = circuit.Name;
			Assert.AreEqual(expected, actual, "The Name getter " +
				"returns an incorrect name");
		}

		[Test(Description = "Positive test of the setter Name")]
		public void TestNameSet_CorrectValue()
		{
			var expected = "htt56";
			var circuit = CreateCircuit;
			Assert.DoesNotThrow(() =>
			{
				circuit.Name = expected;
			}, "The Name setter accepts the correct name");
		}

		[TestCase("", "An exception may occur if the name contains less than 1 symbol",
			TestName = "Assigning an incorrect circuit name that contains less than 1 symbol")]
		public void TestName_InvalidName(string wrongName, string message)
		{
			var circuit = CreateCircuit;
			Assert.Throws<ArgumentException>(() =>
			{
				circuit.Name = wrongName;
			}, message);
		}

		[Test(Description = "Positive test of the getter SubSegments")]
		public void TestSubSegmentsGet_CorrectValue()
		{
            var expected = CreateCircuit.SubSegments;
			var circuit = new Circuit(" ", new SegmentsObservableCollection());
			circuit.SubSegments = expected;
			var actual = circuit.SubSegments;
			Assert.AreEqual(expected, actual, "The SubSegments getter " +
			  "returns an incorrect sub segments");
		}

		[Test(Description = "Positive test of the setter SubSegments")]
		public void TestSubSegmentsSet_CorrectValue()
		{
            var expected = CreateCircuit.SubSegments;
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
            var subSegments = CreateCircuit.SubSegments;
			Assert.DoesNotThrow(() =>
			{
				var circuit = new Circuit(name, subSegments);
			}, "The Circuit constructor create a circuit object");
		}

		[Test(Description = "Test of the OnCircuitChanged Circuit")]
		public void EventRegistrationTesting_CorrectValue()
		{
			var wasCalled = false;
			var circuit = CreateCircuit;

			circuit.SegmentChanged += delegate (object o, EventArgs e)
			{
				wasCalled = true;
			};

			circuit.SubSegments.RemoveAt(0);
			Assert.IsTrue(wasCalled);
		}

		[Test(Description = "Test of the calculate")]
		public void TestCalculateZ_CorrectValue()
		{
            List<double> frequencies = new List<double> { 32.5 };

			List<Complex> results = new List<Complex>();
			var serialCircuitResult = 56.0;
			var parallelCircuitResult = 8.0;
			var result = serialCircuitResult + parallelCircuitResult;
			results.Add(result);

			List<Complex> expected = results;
			var actual = CreateCircuit.CalculateZ(frequencies);

			Assert.AreEqual(expected[0],
				actual[0], "The calculator does not count correctly");
		}
	}
}
