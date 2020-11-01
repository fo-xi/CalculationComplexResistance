using System.Drawing;
using CalculationImpedancesApp;

//TODO: Несоответствие дефолтному namespace
namespace CalculationImpedancesUI
{

	/// <summary>
	/// The class contains methods for working with circuit elements.
	/// </summary>
	public abstract class DrawableElement : DrawableSegmentBase
	{

		/// <summary>
		/// Element width.
		/// </summary>
		protected static readonly int elementWidth = 48;

		/// <summary>
		/// Element height.
		/// </summary>
		protected static readonly int elementHeight = 24;

		/// <summary>
		/// Distance between elements.
		/// </summary>
		protected static readonly int distance = 10;

		/// <summary>
		/// Create a circuit element.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableElement(ISegment segment) : base(segment)
		{
			SizeSegment = new Size(elementWidth, elementHeight);
		}

		public override Size CalculateSize()
		{
			return SizeSegment;
		}
		//TODO: XML
		public override void FindCoordinate()
		{
			var prevNode = PrevNode as DrawableElement;
			if (prevNode == null)
			{
				//TODO: RSDN - длины строк
				StartCoordinate = new Point(StartCoordinate.X, StartCoordinate.Y);
				return;
			}
			//TODO: RSDN - длины строк
			StartCoordinate = new Point(prevNode.StartCoordinate.X + prevNode.SizeSegment.Width + distance,
				prevNode.StartCoordinate.Y);
			CalculateСonnectСoordinate();
		}
	}
}
