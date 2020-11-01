using CalculationImpedancesApp;
using System.Drawing;

//TODO: Несоответствие дефолтному namespace
namespace CalculationImpedancesUI.Elements
{
	//TODO: RSDN
	/// <summary>
	/// Contains methods for working with a capacitor.
	/// </summary>
	class DrawableCapacitor : DrawableElement
	{
		/// <summary>
		/// Capacitor creation.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableCapacitor(ISegment segment) : base(segment)
		{
		}

		public override void Draw()
		{
			int distanceVerticalLines = 5;
			int lengthHorizontalLines = SizeSegment.Width/2;
			//TODO: RSDN - именование
			//TODO: RSDN - длины строк
			int YCoordinatHorizontalLine = StartCoordinate.Y + SizeSegment.Height / 2;

			Point coordinatesBeginningHorizontalFirstLine = new Point(StartCoordinate.X,
				YCoordinatHorizontalLine);
			Point coordinatesEndHorizontalFirstLine = new Point(StartCoordinate.X + lengthHorizontalLines - 2,
				YCoordinatHorizontalLine);

			Point coordinatesBeginningHorizontalSecondLine = new Point(coordinatesEndHorizontalFirstLine.X + distanceVerticalLines,
				YCoordinatHorizontalLine);
			Point coordinatesEndHorizontalSecondLine = new Point(StartCoordinate.X + SizeSegment.Width,
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
