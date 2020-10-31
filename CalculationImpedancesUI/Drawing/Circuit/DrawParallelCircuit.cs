using System.Drawing;
using CalculationImpedancesApp;

namespace CalculationImpedancesUI
{
	/// <summary>
	/// The class contains methods for working with parallel segment.
	/// </summary>
	class DrawParallelCircuit : DrawSegment
	{
		/// <summary>
		/// Create a parallel segment.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawParallelCircuit(ISegment segment) : base(segment)
		{ 
		}

		public override Size CalculateSize()
		{
			int width = 0;
			int height = 0;
			int distance = 10;
			foreach (DrawSegment segment in Nodes)
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

		public override void FindCoordinate()
		{
			foreach (DrawSegment segment in Nodes)
			{
				int middle = (SizeSegment.Width / 2) - (segment.SizeSegment.Width / 2);

				int distance = 10;
				var prevNode = segment.PrevNode as DrawSegment;
				if (prevNode == null)
				{
					segment.StartCoordinate = new Point(StartCoordinate.X + middle, StartCoordinate.Y);
				}
				else
				{
					segment.StartCoordinate = new Point(StartCoordinate.X + middle,
						prevNode.StartCoordinate.Y + prevNode.SizeSegment.Height + distance);
				}
				if (!(segment is DrawElement))
				{
					segment.FindCoordinate();
				}
				segment.CalculateСonnectСoordinate();
			}
		}

		public override void Draw()
		{
			foreach (DrawSegment node in Nodes)
			{
				node.Draw();

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

			var firstNode = Nodes[0] as DrawSegment;
			var lastNode = Nodes[Nodes.Count - 1] as DrawSegment;

			var firstPointRightConnection = new Point(RightСonnectСoordinate.X, firstNode.RightСonnectСoordinate.Y);
			var lastPointRightConnection = new Point(RightСonnectСoordinate.X, lastNode.RightСonnectСoordinate.Y);

			var firstPointLeftConnection = new Point(LeftСonnectСoordinate.X, firstNode.RightСonnectСoordinate.Y);
			var lastPointLeftConnection = new Point(LeftСonnectСoordinate.X, lastNode.RightСonnectСoordinate.Y);

			Graphics.DrawLine(Pen, firstPointRightConnection, lastPointRightConnection);
			Graphics.DrawLine(Pen, firstPointLeftConnection, lastPointLeftConnection);
		}
	}
}
