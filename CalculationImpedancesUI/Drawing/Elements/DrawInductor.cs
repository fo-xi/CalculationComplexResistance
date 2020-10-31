using CalculationImpedancesApp;

namespace CalculationImpedancesUI.Elements
{
	/// <summary>
	/// Contains methods for working with a inductor.
	/// </summary>
	class DrawInductor : DrawElement
	{
		/// <summary>
		/// Inductor creation.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawInductor(ISegment segment) : base(segment)
		{
		}

		public override void Draw()
		{
			int x = StartCoordinate.X;
			int y = StartCoordinate.Y + SizeSegment.Height / 4;
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
