using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationImpedancesApp;
using System.Windows.Forms;

namespace CalculationImpedancesUI.Elements
{
	public abstract class DrawElement : DrawSegment
	{
		protected static readonly int elementWidth = 50;
		protected static readonly int elementHeight = 25;
		protected static readonly int distance = 10;
		protected static readonly Point startingPoint = new Point(0, 0);

		public Size SizeSegment { get; set; } = new Size(elementWidth, elementHeight);

		public Point StartCoordinate { get; set; }

		public Point LeftСonnectСoordinate { get; set; }

		public Point RightСonnectСoordinate { get; set; }

		public ISegment Segment { get; set; }

		public Size GetSize()
		{
			return SizeSegment;
		}

		public void FindCoordinate()
		{
			var prevNode = PrevNode as DrawElement;

			if (prevNode == null)
			{
				StartCoordinate = startingPoint;
				return;
			}
			StartCoordinate = new Point(prevNode.StartCoordinate.X + prevNode.SizeSegment.Width + distance,
				prevNode.StartCoordinate.Y);
			LeftСonnectСoordinate = new Point(StartCoordinate.X, (SizeSegment.Height / 2) + StartCoordinate.Y);
			RightСonnectСoordinate = new Point(StartCoordinate.X + SizeSegment.Width,
				(SizeSegment.Height / 2) + StartCoordinate.Y);
		}
	}
}
