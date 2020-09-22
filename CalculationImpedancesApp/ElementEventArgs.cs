﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculationImpedancesApp
{
	public class ElementEventArgs : EventArgs
	{
		public string Message { get; set; }

		public ElementEventArgs(string message)
		{
			Message = message;
		}
	}
}
