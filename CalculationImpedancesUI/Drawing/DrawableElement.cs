using System.Drawing;
using CalculationImpedancesApp;

//TODO: Несоответствие дефолтному namespace (+)
namespace CalculationImpedancesUI.Drawing
{

	/// <summary>
	/// The class contains methods for working with circuit elements.
	/// </summary>
	public abstract class DrawableElement : DrawableSegmentBase
	{
        /// <summary>
		/// Create a circuit element.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableElement(ISegment segment) : base(segment)
		{
            Width = 48;
            Height = 24;
			SizeSegment = new Size(Width, Height);
        }

		/// <summary>
		/// Calculating the element size.
		/// </summary>
		/// <returns></returns>
		public override Size CalculateSize()
		{
			return SizeSegment;
		}
		//TODO: XML (+)
		/// <summary>
		/// Find the coordinate of an element.
		/// </summary>
		public override void FindCoordinate()
		{
			var prevNode = PrevNode as DrawableElement;
			if (prevNode == null)
			{
				//TODO: RSDN - длины строк (+)
				StartCoordinate = 
                    new Point(StartCoordinate.X, StartCoordinate.Y);
				return;
			}
			//TODO: RSDN - длины строк (+)
			StartCoordinate = 
                new Point(prevNode.StartCoordinate.X + 
                    prevNode.SizeSegment.Width + Distance, 
                    prevNode.StartCoordinate.Y);
			CalculateСonnectСoordinate();
		}
	}
}
