﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Collections.ObjectModel;
using System.Globalization;

//TODO: Несоответствие дефолтному namespace
namespace CalculationImpedancesApp
{
	/// <summary>
    /// Serial circuit segment.
    /// </summary>
    public class SerialCircuit : ISegment
    {
        //TODO: Не используется
	    /// <summary>
        /// Serial circuit segment name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Collection of serial circuit segment subsegments.
        /// </summary>
        public SegmentsObservableCollection SubSegments { get; set; }

        /// <summary>
        ///Returns and sets the name of the serial circuit segment.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Create a serial circuit segment.
        /// </summary>
        /// //TODO Сигнатура XML комментария и метода различны
        /// <param name="name">Serial circuit name.</param>
        /// <param name="subSegmentsObservable">Serial circuit segment.</param>
        public SerialCircuit(SegmentsObservableCollection subSegmentsObservable)
        {
            Name = "Serial";
            SubSegments = subSegmentsObservable;
            SubSegments.CollectionChanged += OnSegmentChanged;
        }

        /// <summary>
        /// An event that fires when a serial circuit segment changes.
        /// </summary>
        public event EventHandler SegmentChanged;

        /// <summary>
        /// SegmentChanged event registration.
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">EventArgs.</param>
        private void OnSegmentChanged(object sender, EventArgs e)
        {
            SegmentChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Calculating the impedance of a serial circuit segment.
        /// </summary>
        /// <param name="frequencies">Signal frequency.</param>
        /// <returns></returns>
        public Complex CalculateZ(double frequencies)
        {
            var result = new Complex();

            foreach (ISegment segment in SubSegments)
            {
                result += segment.CalculateZ(frequencies);
            }
            return result;
        }
    }
}
