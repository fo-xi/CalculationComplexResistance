using CalculationImpedancesApp;
using System.Drawing;

namespace CalculationImpedancesUI.Drawing.Elements
{
	/// <summary>
	/// Contains methods for working with a capacitor.
	/// </summary>
	public class DrawableCapacitor : DrawingElement
	{
		/// <summary>
		/// Capacitor creation.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableCapacitor(ISegment segment) : base(segment)
		{
		}

		/// <summary>
		/// Draws a capacitor.
		/// </summary>
		public override void Draw()
		{
			int distanceVerticalLines = 5;
			int lengthHorizontalLines = SizeSegment.Width/2;
			int horizontalLine = StartCoordinate.Y + SizeSegment.Height / 2;

			Point startFirstLine = new Point(StartCoordinate.X,
				horizontalLine);
			Point endFirstLine = new Point(StartCoordinate.X + 
                  lengthHorizontalLines - 2,
				horizontalLine);

			Point startSecondLine = new Point(endFirstLine.X + 
                  distanceVerticalLines,
				horizontalLine);
			Point endSecondLine = new Point(StartCoordinate.X + 
                  SizeSegment.Width,
				horizontalLine);

			Graphics.DrawLine(Pen, startFirstLine.X, startFirstLine.Y,
				endFirstLine.X, endFirstLine.Y);

			Graphics.DrawLine(Pen, endFirstLine.X, StartCoordinate.Y,
				endFirstLine.X, StartCoordinate.Y + SizeSegment.Height);

			Graphics.DrawLine(Pen, startSecondLine.X, StartCoordinate.Y,
				startSecondLine.X, StartCoordinate.Y + SizeSegment.Height);

			Graphics.DrawLine(Pen, startSecondLine.X, startSecondLine.Y,
				endSecondLine.X, endSecondLine.Y);
		}
	}
}
