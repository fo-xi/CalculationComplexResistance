using CalculationImpedancesApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationImpedancesUI.Elements
{
	class DrawResistor : DrawElement
	{
		public DrawResistor(ISegment segment) : base(segment)
		{
		}

		public override void Draw()
		{
			Graphics.DrawRectangle(Pen, StartCoordinate.X, StartCoordinate.Y,
				SizeSegment.Width, SizeSegment.Height);
		}
	}
}
