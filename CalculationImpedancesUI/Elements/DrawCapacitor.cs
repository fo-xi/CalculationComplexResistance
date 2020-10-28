using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationImpedancesApp;
using System.Drawing;

namespace CalculationImpedancesUI.Elements
{
	class DrawCapacitor : DrawElement
	{
		public DrawCapacitor(ISegment segment) : base(segment)
		{
		}

		public override void Draw()
		{
			int distanceVerticalLines = 5;
			int lengthHorizontalLines = SizeSegment.Width / 2 - distanceVerticalLines;
			int YCoordinatHorizontalLine = StartCoordinate.Y + SizeSegment.Height / 2;

			Point coordinatesBeginningHorizontalFirstLine = new Point(StartCoordinate.X,
				YCoordinatHorizontalLine);
			Point coordinatesEndHorizontalFirstLine = new Point(StartCoordinate.X + lengthHorizontalLines,
				YCoordinatHorizontalLine);

			Point coordinatesBeginningHorizontalSecondLine = new Point(coordinatesEndHorizontalFirstLine.X + distanceVerticalLines,
				YCoordinatHorizontalLine);
			Point coordinatesEndHorizontalSecondLine = new Point(coordinatesBeginningHorizontalSecondLine.X + lengthHorizontalLines,
				YCoordinatHorizontalLine);

			Graphics.DrawLine(Pen, coordinatesBeginningHorizontalFirstLine.X, coordinatesBeginningHorizontalFirstLine.Y,
				coordinatesEndHorizontalFirstLine.X, coordinatesEndHorizontalFirstLine.Y);

			Graphics.DrawLine(Pen, coordinatesEndHorizontalFirstLine.X, StartCoordinate.Y,
				coordinatesEndHorizontalFirstLine.X, StartCoordinate.Y + SizeSegment.Height);

			Graphics.DrawLine(Pen, coordinatesBeginningHorizontalSecondLine.X, StartCoordinate.Y,
				coordinatesBeginningHorizontalSecondLine.X, StartCoordinate.Y + SizeSegment.Height);

			Graphics.DrawLine(Pen, coordinatesBeginningHorizontalSecondLine.X, coordinatesBeginningHorizontalSecondLine.Y,
				coordinatesEndHorizontalSecondLine.X, coordinatesEndHorizontalSecondLine.Y);
		}
	}
}
