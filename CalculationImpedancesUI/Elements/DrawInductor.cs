using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationImpedancesApp;

namespace CalculationImpedancesUI.Elements
{
	class DrawInductor : DrawElement
	{
		public DrawInductor(ISegment segment) : base(segment)
		{
		}

		public override void Draw()
		{
			int x = StartCoordinate.X;
			int y = StartCoordinate.Y;
			int semicircleWidth = SizeSegment.Width / 4;
			int semicircleHeight = SizeSegment.Height / 2;
			int numberSemicircles = 4;

			for (int i = 0; i < numberSemicircles; i++)
			{
				Graphics.DrawArc(Pen, x, y, semicircleWidth, semicircleHeight, 180, 180);
				x += semicircleWidth;
			}
		}
	}
}
