using System;
using System.Collections.Generic;
using System.Text;

namespace CalculationImpedancesApp
{
	/// <summary>
	/// Own EventArgs.
	/// </summary>
	public class ElementEventArgs : EventArgs
	{
		/// <summary>
		/// Event message.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Creates a ElementEventArgs.
		/// </summary>
		/// <param name="message">Event message.</param>
		public ElementEventArgs(string message)
		{
			Message = message;
		}
	}
}
