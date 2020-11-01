using System.Drawing;
using CalculationImpedancesApp;
//TODO: Несоответствие дефолтному namespace
namespace CalculationImpedancesUI
{
	//TODO: RSDN
	/// <summary>
	/// The class contains methods for working with parallel segment.
	/// </summary>
	class DrawableParallelCircuit : DrawableSegmentBase
	{
		/// <summary>
		/// Create a parallel segment.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableParallelCircuit(ISegment segment) : base(segment)
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
				height += calculateSize.Height + distance;
				if (calculateSize.Width > width)
				{
					width = calculateSize.Width;
				}
			}

			height -= distance;
			SizeSegment = new Size(width + distance, height);
			return SizeSegment;
		}

		//TODO: XML
		public override void FindCoordinate()
		{
			foreach (DrawableSegmentBase segment in Nodes)
			{
				//TODO: RSDN - длины строк
				int middle = (SizeSegment.Width / 2) - (segment.SizeSegment.Width / 2);

				int distance = 10;
				var prevNode = segment.PrevNode as DrawableSegmentBase;
				if (prevNode == null)
				{
					segment.StartCoordinate = new Point(StartCoordinate.X + middle, StartCoordinate.Y);
				}
				else
				{
					segment.StartCoordinate = new Point(StartCoordinate.X + middle,
						prevNode.StartCoordinate.Y + prevNode.SizeSegment.Height + distance);
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
			foreach (DrawableSegmentBase node in Nodes)
			{
				node.Draw();
				//TODO: RSDN - длины строк
				var leftConnect = new Point(LeftСonnectСoordinate.X, node.LeftСonnectСoordinate.Y);
				var rightConnect = new Point(RightСonnectСoordinate.X, node.RightСonnectСoordinate.Y);

				if (Index != 0 || Nodes.Count > 1)
				{
					Graphics.DrawLine(Pen, leftConnect, node.LeftСonnectСoordinate);
				}
				Graphics.DrawLine(Pen, rightConnect, node.RightСonnectСoordinate);
			}

			if (Nodes.Count == 0)
			{
				return;
			}

			var firstNode = Nodes[0] as DrawableSegmentBase;
			var lastNode = Nodes[Nodes.Count - 1] as DrawableSegmentBase;
			//TODO: RSDN - длины строк
			var firstPointRightConnection = new Point(RightСonnectСoordinate.X, firstNode.RightСonnectСoordinate.Y);
			var lastPointRightConnection = new Point(RightСonnectСoordinate.X, lastNode.RightСonnectСoordinate.Y);

			var firstPointLeftConnection = new Point(LeftСonnectСoordinate.X, firstNode.RightСonnectСoordinate.Y);
			var lastPointLeftConnection = new Point(LeftСonnectСoordinate.X, lastNode.RightСonnectСoordinate.Y);

			Graphics.DrawLine(Pen, firstPointRightConnection, lastPointRightConnection);
			Graphics.DrawLine(Pen, firstPointLeftConnection, lastPointLeftConnection);
		}
	}
}
