using CalculationImpedancesApp;
using CalculationImpedancesUI.Drawing;

//TODO: Несоответствие дефолтному namespace (+)
namespace CalculationImpedancesUI.Drawing.Elements
{
	/// <summary>
	/// Contains methods for working with a resistor.
	/// </summary>
	public class DrawableResistor : DrawableElement
	{
		/// <summary>
		/// Resistor creation.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableResistor(ISegment segment) : base(segment)
		{
		}

		/// <summary>
		/// Draws a resistor.
		/// </summary>
		public override void Draw()
		{
			Graphics.DrawRectangle(Pen, StartCoordinate.X, StartCoordinate.Y,
				SizeSegment.Width, SizeSegment.Height);
		}
	}
}
