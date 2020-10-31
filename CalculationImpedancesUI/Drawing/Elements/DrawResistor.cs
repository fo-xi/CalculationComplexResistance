using CalculationImpedancesApp;

namespace CalculationImpedancesUI.Elements
{
	/// <summary>
	/// Contains methods for working with a resistor.
	/// </summary>
	class DrawResistor : DrawElement
	{
		/// <summary>
		/// Resistor creation.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
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
