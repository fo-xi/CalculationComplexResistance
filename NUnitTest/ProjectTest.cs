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
    }
}
