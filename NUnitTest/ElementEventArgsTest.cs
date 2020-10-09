using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using NUnit.Framework;

namespace NUnitTest
{
	class ElementEventArgsTest
    {
	    [Test(Description = "Positive test of the getter Message")]
	    public void TestMessageGet_CorrectValue()
	    {
		    var expected = "Message";
			var element = new ElementEventArgs("Message");
		    var actual = element.Message;
		    Assert.AreEqual(expected, actual, "The SubSegments getter " +
		                                      "returns an incorrect sub segments");
	    }

	    [Test(Description = "Positive test of the setter Message")]
	    public void TestMessageSet_CorrectValue()
	    {
		    var expected = "Message";
		    var element = new ElementEventArgs("Message");
			Assert.DoesNotThrow(() =>
		    {
			    element.Message = expected;
		    }, "The Message setter accepts the correct message");
	    }

	    [Test(Description = "Test of the constructor Message")]
	    public void TestConstructor_CorrectValue()
	    {
		    var message = "Message";
		    Assert.DoesNotThrow(() =>
		    {
			    var element = new ElementEventArgs(message);
			}, "The Circuit constructor create a circuit object");
	    }
	}
}
