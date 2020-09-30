using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
    class ProjectTest
    {
	    [Test(Description = "Test of the constructor")]
		public void TestConstructor_CorrectValue()
	    {
		    Assert.DoesNotThrow(() =>
		    {
			    var project = new Project();
		    }, "The Project constructor create a capacitor project");
	    }

		[Test(Description = "Test of the AllElements")]
		public void TestAllElements_CorrectValue()
		{
			Project project = new Project();

			var segments = new List<ISegment>
			{
				new SerialCircuit("gh6", new SegmentsObservableCollection
				{
					new Capacitor("j55", 12.4),
					new Capacitor("sc2", 78.4)
				}),
				new ParallelCircuit("u7y", new SegmentsObservableCollection
				{
					new Inductor("aa2", 2.5),
					new Capacitor("byb6", 8.7)
				})
			};

			var expected = new List<IElement>
			{
				new Capacitor("j55", 12.4),
				new Capacitor("sc2", 78.4),
				new Inductor("aa2", 2.5),
				new Capacitor("byb6", 8.7)
			};

			foreach (var segment in segments)
			{
				project.AllElements(segment);
			}
			var actual = project.Elements;

			for (int i = 0; i < actual.Count; i++)
			{
				Assert.AreEqual(expected[i].Name,
					actual[i].Name, "AllElements does not work correctly");
			}
		}
	}
}
