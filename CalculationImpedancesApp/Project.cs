using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Numerics;

namespace CalculationImpedancesApp
{
	public class Project
	{
		public List<Circuit> Circuits = new List<Circuit>();

		public List<ISegment> Segments = new List<ISegment>();

		public List<IElement> Elements = new List<IElement>();

		public List<double> Frequencies = new List<double>();

		public List<Complex> Results = new List<Complex>();

		public Circuit CircuitElement = null;

		public List<string> ImpedanceValues = new List<string>();


		public Project()
		{
			ElementObservableCollectioncs<ISegment> segments =
				new ElementObservableCollectioncs<ISegment>
				{
					new SerialCircuit("fj5", new ElementObservableCollectioncs<ISegment>
					{
						new Inductor("jng5", 56.0),
						new Resistor("fr4tt", 32.6)
					}),
					new ParallelCircuit("ut4f", new ElementObservableCollectioncs<ISegment>
					{
						new Resistor("g56", 7.8),
						new Capacitor("duj", 22.6)
					}),

				};
			Circuits.Add(new Circuit("Circuit No. 1", segments));
		}

		public void AllElements(ISegment segment)
		{
			if (segment == CircuitElement)
			{
				Elements = new List<IElement>();
			}
			foreach (var element in segment.SubSegments)
			{
				if (element is IElement trueElement)
				{
					Elements.Add(trueElement);
				}
				else
				{
					AllElements(element);
				}
			}
		}
	}
}
