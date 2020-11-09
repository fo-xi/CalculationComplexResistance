using System.Drawing;
using CalculationImpedancesApp;
using System.Windows.Forms;

namespace CalculationImpedancesUI.Drawing
{
	public abstract class DrawableSegmentBase : TreeNode
	{
        /// <summary>
        /// Segment width.
        /// </summary>
        protected int Width = 0;

		/// <summary>
		/// Segment height.
		/// </summary>
		protected int Height = 0;

		/// <summary>
		/// Distance between segments.
		/// </summary>
		protected static readonly int Distance = 10;

		/// <summary>
		/// Gets and sets the segment size.
		/// </summary>
		public Size SizeSegment { get; set; }

		/// <summary>
		/// Gets and sets the starting coordinate.
		/// </summary>
		public Point StartCoordinate { get; set; }

		/// <summary>
		/// Gets and sets the connection point to the left of the segment.
		/// </summary>
		public Point LeftСonnectСoordinate { get; set; }

		/// <summary>
		/// Gets and sets the connection point to the right of the segment.
		/// </summary>
		public Point RightСonnectСoordinate { get; set; }

		/// <summary>
		/// Gets and sets methods for drawing objects.
		/// </summary>
		public static Graphics Graphics { get; set; }

		/// <summary>
		/// Gets and sets a pen that draws lines.
		/// </summary>
		public static Pen Pen { get; set; }

		/// <summary>
		/// Circuit segment.
		/// </summary>
		public ISegment Segment { get; set; }

		/// <summary>
		/// Creates a segment to draw.
		/// </summary>
		/// <param name="segment"></param>
		protected DrawableSegmentBase(ISegment segment)
		{
			Segment = segment;
		}

		/// <summary>
		/// Calculates segment size.
		/// </summary>
		/// <returns></returns>
		public abstract Size CalculateSize();

		/// <summary>
		/// Find segment coordinate.
		/// </summary>
		public abstract void FindCoordinate();

		/// <summary>
		/// Draws a circuit segment.
		/// </summary>
		public abstract void Draw();

		/// <summary>
		/// Calculating the coordinates of the connection of segments.
		/// </summary>
		public void CalculateСonnectСoordinate()
		{
			LeftСonnectСoordinate = 
                new Point(StartCoordinate.X, 
                    (SizeSegment.Height / 2) + StartCoordinate.Y);
			RightСonnectСoordinate = 
                new Point(StartCoordinate.X + SizeSegment.Width,
				(SizeSegment.Height / 2) + StartCoordinate.Y);
		}
	}
}
