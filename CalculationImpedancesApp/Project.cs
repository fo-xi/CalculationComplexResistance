using System.Collections.Generic;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class Project
    {
        public List<Circuit> _circuits = new List<Circuit>();

        public List<IElement> _elements = new List<IElement>();

        public List<double> _frequencies = new List<double>();

        public List<Complex> _results = new List<Complex>();

        public Circuit CircuitElement = null;

        public Project()
        {
            List<IElement> elements = new List<IElement>
            {
                new Resistor("i694", 30.0),
                new Resistor("86u", 45.4),
                new Inductor("ut7", 32.6),
                new Inductor("it6", 33.9)
            };
            _circuits.Add(new Circuit("Circuit No. 1", elements));

            elements = new List<IElement>
            {
                new Inductor("re94", 20.0),
                new Resistor("8u", 5.3),
                new Inductor("2e7", 12.2),
                new Capacitor("ft5", 36.0)
            };
            _circuits.Add(new Circuit("Circuit No. 2", elements));

            elements = new List<IElement>
            {
                new Capacitor("ty6", 12.4),
                new Capacitor("fb7", 17.4),
                new Inductor("j877", 56.7),
                new Capacitor("df56", 21.0)
            };
            _circuits.Add(new Circuit("Circuit No. 3", elements));

            elements = new List<IElement>
            {
                new Resistor("re4", 11.1),
                new Capacitor("bg7", 66.4),
                new Inductor("21e", 38.6),
                new Inductor("ki4", 90.7)
            };
            _circuits.Add(new Circuit("Circuit No. 4", elements));


            elements = new List<IElement>
            {
                new Resistor("mb6", 21.7),
                new Resistor("w2", 2.3),
                new Capacitor("hji", 6.2),
                new Inductor("r43", 3.0)
            };
            _circuits.Add(new Circuit("Circuit No. 5", elements));
        }
    }
}
