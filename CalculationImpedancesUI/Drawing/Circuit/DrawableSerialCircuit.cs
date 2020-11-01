using System.Drawing;
using CalculationImpedancesApp;
//TODO: Несоответствие дефолтному namespace
namespace CalculationImpedancesUI
{
	/// <summary>
	/// The class contains methods for working with serial segment.
	/// </summary>
	public class DrawableSerialCircuit : DrawableSegmentBase 
	{
		/// <summary>
		/// Create a serial segment.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableSerialCircuit(ISegment segment) : base(segment)
		{ 
		}
		//TODO: XML
		public override Size CalculateSize()
		{
			//TODO: Дубль
			int width = 0;
			int height = 0;
			int distance = 10;
			foreach (DrawableSegmentBase segment in Nodes)
			{
				var calculateSize = segment.CalculateSize();
				width += calculateSize.Width + distance;
				if (calculateSize.Height > height)
				{
					height = calculateSize.Height;
				}
			}
			width -= distance;
			SizeSegment = new Size(width, height);
			return SizeSegment;
		}

		public override void FindCoordinate()
		{
			int halfHeightSegment = 0;
			foreach (DrawableSegmentBase segment in Nodes)
			{
				if (halfHeightSegment < segment.SizeSegment.Height / 2)
				{
					halfHeightSegment = segment.SizeSegment.Height / 2;
				}
			}

			foreach (DrawableSegmentBase segment in Nodes)
			{
				int distance = 10;
				var prevNode = segment.PrevNode as DrawableSegmentBase;
				//TODO: RSDN - длины строк
				if (prevNode == null)
				{
					segment.StartCoordinate = new Point(StartCoordinate.X,
						StartCoordinate.Y + halfHeightSegment - segment.SizeSegment.Height / 2);
				}
				else
				{
					segment.StartCoordinate = new Point(prevNode.StartCoordinate.X + 
					      segment.SizeSegment.Width + distance, prevNode.LeftСonnectСoordinate.Y - segment.SizeSegment.Height / 2);
				}

				if (!(segment is DrawableElement))
				{
					segment.FindCoordinate();
				}
				segment.CalculateСonnectСoordinate();
			}
		}
		//TODO: XML
		public override void Draw()
		{
			if (Nodes.Count == 0)
			{
				return;
			}
			var lastNode = Nodes[Nodes.Count - 1] as DrawableSegmentBase;
			foreach (DrawableSegmentBase node in Nodes)
			{
				var prevNode = node.PrevNode as DrawableSegmentBase;

				if (prevNode != null)
				{
					Graphics.DrawLine(Pen, prevNode.RightСonnectСoordinate, node.LeftСonnectСoordinate);
				}
				node.Draw();
			}
		}

	}
}
