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

			segments = new ElementObservableCollectioncs<ISegment>
			{
				new SerialCircuit("ew5", new ElementObservableCollectioncs<ISegment>
				{
					new Capacitor("j55t", 32.5),
					new Resistor("sct", 4.6)
				}),
				new ParallelCircuit("ut4f", new ElementObservableCollectioncs<ISegment>
				{
					new Inductor("bb7", 11.3),
					new Resistor("ji9", 81.0)
				}),

			};
			Circuits.Add(new Circuit("Circuit No. 2", segments));

			segments = new ElementObservableCollectioncs<ISegment>
			{
				new ParallelCircuit("dt5", new ElementObservableCollectioncs<ISegment>
				{
					new Inductor("yu8", 22.5),
					new Inductor("ff5", 7.8)
				}),
				new SerialCircuit("ee4", new ElementObservableCollectioncs<ISegment>
				{
					new Inductor("nh78", 57.8),
					new Capacitor("d45t", 90.4),
				}),

			};
			Circuits.Add(new Circuit("Circuit No. 3", segments));

			segments = new ElementObservableCollectioncs<ISegment>
			{
				new SerialCircuit("ddc4", new ElementObservableCollectioncs<ISegment>
				{
					new Resistor("h6j7", 32.5),
					new Resistor("s23", 4.6)
				}),
				new ParallelCircuit("", new ElementObservableCollectioncs<ISegment>
				{
					new Inductor("bb7", 11.3),
					new Inductor("d4t", 88.9),
				}),

			};
			Circuits.Add(new Circuit("Circuit No. 4", segments));

			segments = new ElementObservableCollectioncs<ISegment>
			{
				new SerialCircuit("gh6", new ElementObservableCollectioncs<ISegment>
				{
					new Capacitor("j55", 12.4),
					new Capacitor("sc2", 78.4)
				}),
				new ParallelCircuit("u7y", new ElementObservableCollectioncs<ISegment>
				{
					new Inductor("aa2", 2.5),
					new Capacitor("byb6", 8.7)
				}),

			};
			Circuits.Add(new Circuit("Circuit No. 5", segments));
		}

		public void AllElements(ISegment segment)
		{
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
