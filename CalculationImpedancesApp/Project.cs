﻿using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Numerics;

namespace CalculationImpedancesApp
{
	public class Project
	{
		/// <summary>
		/// Circuits list.
		/// </summary>
		public List<Circuit> Circuits = new List<Circuit>();

		/// <summary>
		/// Segments list.
		/// </summary>
		public List<ISegment> Segments = new List<ISegment>();

		/// <summary>
		/// All elements of the selected circuit
		/// </summary>
		public List<IElement> Elements = new List<IElement>();

		/// <summary>
		/// Frequencies list.
		/// </summary>
		public List<double> Frequencies = new List<double>();

		/// <summary>
		/// Results list.
		/// </summary>
		public List<Complex> Results = new List<Complex>();

		/// <summary>
		/// Selected circuit from the list of circuits.
		/// </summary>
		public Circuit CircuitElement = null;

		/// <summary>
		/// The list necessary for a nice display 
		/// of the result of calculating the impedance of the circuit.
		/// </summary>
		public List<string> ImpedanceValues = new List<string>();

		/// <summary>
		/// Create a circuits.
		/// </summary>
		public Project()
		{
			ElementObservableCollections segments =
				new ElementObservableCollections
				{
					new SerialCircuit("fj5", new ElementObservableCollections
					{
						new Inductor("jng5", 56.0),
						new Resistor("fr4tt", 32.6)
					}),
					new ParallelCircuit("ut4f", new ElementObservableCollections
					{
						new Resistor("g56", 7.8),
						new Capacitor("duj", 22.6)
					}),

				};
			Circuits.Add(new Circuit("Circuit No. 1", segments));

			segments = new ElementObservableCollections
			{
				new SerialCircuit("ew5", new ElementObservableCollections
				{
					new Capacitor("j55t", 32.5),
					new Resistor("sct", 4.6)
				}),
				new ParallelCircuit("ut4f", new ElementObservableCollections
				{
					new Inductor("bb7", 11.3),
					new Resistor("ji9", 81.0)
				}),

			};
			Circuits.Add(new Circuit("Circuit No. 2", segments));

			segments = new ElementObservableCollections
			{
				new ParallelCircuit("dt5", new ElementObservableCollections
				{
					new Inductor("yu8", 22.5),
					new Inductor("ff5", 7.8)
				}),
				new SerialCircuit("ee4", new ElementObservableCollections
				{
					new Inductor("nh78", 57.8),
					new Capacitor("d45t", 90.4),
				}),

			};
			Circuits.Add(new Circuit("Circuit No. 3", segments));

			segments = new ElementObservableCollections
			{
				new SerialCircuit("ddc4", new ElementObservableCollections
				{
					new Resistor("h6j7", 32.5),
					new Resistor("s23", 4.6)
				}),
				new ParallelCircuit("", new ElementObservableCollections
				{
					new Inductor("bb7", 11.3),
					new Inductor("d4t", 88.9),
				}),

			};
			Circuits.Add(new Circuit("Circuit No. 4", segments));

			segments = new ElementObservableCollections
			{
				new SerialCircuit("gh6", new ElementObservableCollections
				{
					new Capacitor("j55", 12.4),
					new Capacitor("sc2", 78.4)
				}),
				new ParallelCircuit("u7y", new ElementObservableCollections
				{
					new Inductor("aa2", 2.5),
					new Capacitor("byb6", 8.7)
				}),

			};
			Circuits.Add(new Circuit("Circuit No. 5", segments));
		}

		/// <summary>
		/// Find all elements of a sub-segment.
		/// </summary>
		/// <param name="segment"></param>
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
