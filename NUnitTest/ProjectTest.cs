using System;
using System.Collections.Generic;
using System.Text;
using CalculationImpedancesApp;
using CalculationImpedancesApp.Circuits;
using CalculationImpedancesApp.Elements;
using NUnit.Framework;

namespace NUnitTest
{
	public class ProjectTest
    {
        [Test(Description = "Test of the constructor")]
        public void TestConstructor_CorrectValue()
        {
            List<Circuit> expected = new List<Circuit>();

            SegmentsObservableCollection segmentsObservable =
                new SegmentsObservableCollection
                {
                    new Inductor("jng5", 56.9),
                    new Resistor("fr4tt", 32.6),
                    new Resistor("ghj5", 45.8),
                    new Inductor("i76", 12.4),
                    new Capacitor("fg4", 22.6)
                };
            expected.Add(new Circuit("Circuit No. 1", segmentsObservable));

            segmentsObservable = new SegmentsObservableCollection
            {
                new Resistor("asf", 54),
                new ParallelCircuit(new SegmentsObservableCollection
                {
                    new Inductor("bb7", 11.3),
                    new Resistor("ji9", 81.0)
                })
            };
            expected.Add(new Circuit("Circuit No. 2", segmentsObservable));

            segmentsObservable = new SegmentsObservableCollection
            {
                new ParallelCircuit(new SegmentsObservableCollection
                {
                    new SerialCircuit(new SegmentsObservableCollection
                    {
                        new Resistor("dht5", 32.9),
                        new Resistor("ret3", 33.7),
                    }),
                    new SerialCircuit(new SegmentsObservableCollection
                    {
                        new Inductor("fhj7", 43.9),
                        new Capacitor("lop8", 11.2),
                        new Resistor("rte3", 66.9),
                    }),
                    new Inductor("ff5", 7.8)
                }),
                new SerialCircuit(new SegmentsObservableCollection
                {
                    new Inductor("nh78", 57.8),
                    new Capacitor("d45t", 90.4),
                    new Capacitor("rgr", 41.2),
                    new Capacitor("rdg5", 77.3),
                }),

            };
            expected.Add(new Circuit("Circuit No. 3", segmentsObservable));

            segmentsObservable = new SegmentsObservableCollection
            {
                new SerialCircuit(new SegmentsObservableCollection
                {
                    new Resistor("h6j7", 32.5),
                    new Resistor("s23", 4.6),
                    new Resistor("rtr4", 54.8)
                }),
                new ParallelCircuit(new SegmentsObservableCollection
                {
                    new SerialCircuit(new SegmentsObservableCollection
                    {
                        new Resistor("g5h6", 44.7),
                        new Capacitor("a23", 1.9),
                        new Capacitor("ty6k", 87.0)
                    }),
                    new SerialCircuit(new SegmentsObservableCollection
                    {
                        new Resistor("f67", 55.2),
                        new Capacitor("h89", 77.3),
                    }),
                    new Inductor("bb7", 11.3),
                    new Inductor("d4t", 88.9),
                }),

            };
            expected.Add(new Circuit("Circuit No. 4", segmentsObservable));

            segmentsObservable = new SegmentsObservableCollection
            {
                new ParallelCircuit(new SegmentsObservableCollection
                {
                    new Inductor("gr4", 33.9),
                    new Capacitor("lo9", 2.5),
                    new SerialCircuit(new SegmentsObservableCollection
                    {
                        new Inductor("tt6", 18.6),
                        new Inductor("sv5", 77.6)
                    }),
                    new SerialCircuit(new SegmentsObservableCollection
                    {
                        new Resistor("gt6", 10.2),
                        new Resistor("lo9", 20.6)
                    }),
                }),
                new ParallelCircuit(new SegmentsObservableCollection
                {
                    new Inductor("dd3", 50.6),
                    new Capacitor("uy77", 70.6)
                }),
                new SerialCircuit(new SegmentsObservableCollection
                {
                    new Capacitor("j55", 12.4),
                    new Capacitor("sc2", 78.4)
                }),
                new ParallelCircuit(new SegmentsObservableCollection
                {
                    new Inductor("aa2", 2.5),
                    new Capacitor("byb6", 8.7)
                }),

            };
            expected.Add(new Circuit("Circuit No. 5", segmentsObservable));

            var actual = Project.Circuits;

            for (int i =0; i<expected.Count;i++)
            {
                Assert.AreEqual(expected[i].Name,
                    actual[i].Name, 
                    "The constructor doesn't work correctly");
            }
        }
    }
}
