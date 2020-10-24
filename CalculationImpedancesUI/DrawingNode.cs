using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationImpedancesApp;
using System.Windows.Forms;

namespace CalculationImpedancesUI
{
	public class DrawingNode: TreeNode
	{
		private static readonly int elementLength = 50;
		private static readonly int elementWidth = 25;
		private static readonly int distance = 10;
		private static readonly Point startingPoint = new Point(0, 0);

		public Size SizeSegment { get; } = new Size(elementLength, elementWidth);

		public Point StartCoordinate { get; private set; }

		public Point LeftСonnectСoordinate { get; private set; }

		public Point RightСonnectСoordinate { get; private set; }

		public ISegment Segment { get; set; }

		public void FindCoordinate()
		{
			var prevNode = PrevNode as DrawingNode;

			if (prevNode == null)
			{
				StartCoordinate = startingPoint;
				return;
			}
			StartCoordinate = new Point(prevNode.StartCoordinate.X + prevNode.SizeSegment.Width + distance,
				prevNode.StartCoordinate.Y);
			LeftСonnectСoordinate = new Point(StartCoordinate.X,(SizeSegment.Height / 2) + StartCoordinate.Y );
			RightСonnectСoordinate = new Point(StartCoordinate.X + SizeSegment.Width, 
				(SizeSegment.Height / 2) + StartCoordinate.Y);
		}
	}
}
