using CalculationImpedancesApp;
using CalculationImpedancesUI.Drawing;

namespace CalculationImpedancesUI.Drawing.Elements
{
	/// <summary>
	/// Contains methods for working with a inductor.
	/// </summary>
	public class DrawableInductor : DrawingElement
	{
		/// <summary>
		/// Inductor creation.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableInductor(ISegment segment) : base(segment)
		{
		}

		/// <summary>
		/// Draws a inductor.
		/// </summary>
		public override void Draw()
		{
			int x = StartCoordinate.X;
			int y = StartCoordinate.Y + SizeSegment.Height / 4;
			int semicircleWidth = SizeSegment.Width / 4;
			int semicircleHeight = SizeSegment.Height / 2;
			int numberSemicircles = 4;

			for (int i = 0; i < numberSemicircles; i++)
			{
				Graphics.DrawArc(Pen, x, y, 
                    semicircleWidth, semicircleHeight, 
                    180, 180);
				x += semicircleWidth;
			}
		}	
	}
}
