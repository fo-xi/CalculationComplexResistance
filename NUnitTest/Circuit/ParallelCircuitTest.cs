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
			var expected = "ht56";
			var parallelCircuit = new ParallelCircuit(" ", new SegmentsObservableCollection
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
			var expected = "htt56";
			var parallelCircuit = new ParallelCircuit(" ", new SegmentsObservableCollection
			{
				new Capacitor("j55t", 32.5),
			});
			Assert.DoesNotThrow(() =>
			{
				parallelCircuit.Name = expected;
			}, "The Name setter accepts the correct name");
		}

		[TestCase("", "An exception may occur if the name contains less than 1 symbol",
			TestName = "Assigning an incorrect name that contains less than 1 symbol")]
		public void TestParallelCircuitName_InvalidName(string wrongName, string message)
		{
			var parallelCircuit = new ParallelCircuit(" ", new SegmentsObservableCollection
			{
				new Capacitor("rg4", 32.5)
			});
			Assert.Throws<ArgumentException>(() =>
			{
				parallelCircuit.Name = wrongName;
			}, message);
		}

		[Test(Description = "Positive test of the constructor ParallelCircuit")]
		public void TestParallelCircuitConstructor_CorrectValue()
		{
			var name = "d345";
			var subSegments = new SegmentsObservableCollection
			{
					new Inductor("jng5", 56.0),
			};
			Assert.DoesNotThrow(() =>
			{
				var parallelCircuit = new ParallelCircuit(name, subSegments);
			}, "The ParallelCircuit constructor create a parallel сircuit object");
		}
	}
}
