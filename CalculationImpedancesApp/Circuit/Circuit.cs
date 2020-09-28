using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculationImpedancesApp
{
    /// <summary>
    /// Circuit class
    /// </summary>
    public class Circuit
    {
        /// <summary>
        /// Event that fires when the circuit changes
        /// </summary>
        public event EventHandler CircuitChanged;

        /// <summary>
        /// Circuit name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Returns and sets the name of a circuit.
        /// </summary>
        public string Name
        {
	        get
	        {
		        return _name;

	        }
	        set
	        {
		        if (value.Length < 0)
		        {
			        throw new ArgumentException($"The {nameof(Name)} cannot be empty!");
		        }
		        _name = value;
	        }
        }

        /// <summary>
        /// A collection that stores sub-segmentsObservable of the circuit.
        /// </summary>
        public SegmentsObservableCollection SubSegmentsObservable { get; set; }

        /// <summary>
        /// Creates a circuit.
        /// </summary>
        /// <param name="name">Circuit name</param>
        /// <param name="subSegmentsObservable">Circuit sub segmentsObservable</param>
        public Circuit(string name, SegmentsObservableCollection subSegmentsObservable)
        {
            Name = name;
            SubSegmentsObservable = subSegmentsObservable;
            SubSegmentsObservable.CollectionChanged += OnCircuitChanged;
        }

        /// <summary>
        /// CircuitChanged event registration.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">EventArgs</param>
        private void OnCircuitChanged(object sender, EventArgs e)
        {
            CircuitChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Calculating the impedance of a serial connection.
        /// </summary>
        /// <param name="frequencies">Signal frequency</param>
        /// <returns></returns>
        public List<Complex> CalculateZ(List<double> frequencies)
        {
            List<Complex> results = new List<Complex>();

            for (int i = 0; i < frequencies.Count; i++)
            {
                results.Add(new Complex());
                foreach (ISegment segment in SubSegmentsObservable)
                {
                    results[i] += segment.CalculateZ(frequencies[i]);
                }
            }
            return results;
        }
    }
}
