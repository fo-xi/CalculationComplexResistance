﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    public class Circuit
    {
        public delegate void CircuitChanget(object sender, object e);

        public event CircuitChanget CircuitChangetEvent;

        public string Name { get; set; }

        private List<IElement> _elements;

        public List<IElement> Elements
        {
            get
            {
                return _elements;
            }
            set
            {
                if (value != _elements)
                {
                    CircuitChangetEvent?.Invoke(this,
                    $"Item values have been changed!");
                }
                _elements = value;
            }

        }

        public Circuit(string name, List<IElement> elements)
        {
            Name = name;
            Elements = elements;

            foreach (var i in Elements)
            {
                i.ValueChangetEvent += CallingAnElementEvent;
            }
        }

        public List<Complex> CalculateZ(List<double> frequencies)
        {
            List<Complex> results = new List<Complex>();

            for (int i = 0; i < frequencies.Count; i++)
            {
                results.Add(new Complex());
                foreach (IElement element in Elements)
                {
                    results[i] += element.CalculateZ(frequencies[i]);
                }
            }
            return results;
        }

        private void CallingAnElementEvent(object sender, object e)
        {
            CircuitChangetEvent?.Invoke(sender, e);
        }

    }
}
