using CalculationImpedancesApp;

namespace CalculationImpedancesUI.Elements
{
	/// <summary>
	/// Contains methods for working with a resistor.
	/// </summary>
	class DrawableResistor : DrawableElement
	{
		/// <summary>
		/// Resistor creation.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableResistor(ISegment segment) : base(segment)
		{
		}

		public override void Draw()
		{
			Graphics.DrawRectangle(Pen, StartCoordinate.X, StartCoordinate.Y,
				SizeSegment.Width, SizeSegment.Height);
		}
	}
}
