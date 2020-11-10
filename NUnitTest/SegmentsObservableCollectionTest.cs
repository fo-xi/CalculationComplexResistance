using System;
using CalculationImpedancesApp;
using NUnit.Framework;
using CalculationImpedancesApp.Circuits;
using CalculationImpedancesApp.Elements;

namespace NUnitTest
{
	public class SegmentsObservableCollectionTest
	{
		private Circuit CreateCircuit()
		{
			return new Circuit(" ", new SegmentsObservableCollection
			{
				new SerialCircuit(new SegmentsObservableCollection
				{
					new Inductor("jng5", 56.0),
				}),
			});
		}

		[Test(Description = "Test of the CollectionChanged")]
		public void EventRegistrationTesting_CorrectValue()
		{
			var wasCalled = false;
			var subSegments = CreateCircuit().SubSegments;

			subSegments.CollectionChanged += delegate (object o, EventArgs e)
			{
				wasCalled = true;
			};

			(subSegments[0].SubSegments[0] as IElement).Value = 255;
			Assert.IsTrue(wasCalled);
		}
	}
}
