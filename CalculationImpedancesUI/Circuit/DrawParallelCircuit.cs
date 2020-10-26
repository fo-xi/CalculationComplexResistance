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
	class DrawParallelCircuit : DrawSegment
	{
		public Size SizeSegment { get; set; }

		public Point StartCoordinate { get; set; }

		public Point LeftСonnectСoordinate { get; set; }

		public Point RightСonnectСoordinate { get; set; }

		public ISegment Segment { get; set; }

		public override Size GetSize()
		{
			int width = 0;
			int height = 0;
			int distance = 10;
			if (Segment is ParallelCircuit)
			{
				foreach (DrawSegment segment in Nodes)
				{
					height += segment.SizeSegment.Height + distance;
					width = segment.SizeSegment.Width;
				}
			}
			SizeSegment = new Size(width, height);
			return SizeSegment;
		}

		public override void FindCoordinate()
		{
			foreach (DrawSegment segment in Nodes)
			{
				int distance = 10;
				var prevNode = segment.PrevNode as DrawSegment;
				if (prevNode == null)
				{
					segment.StartCoordinate = StartCoordinate;
				}
				else
				{
					segment.StartCoordinate = new Point(prevNode.StartCoordinate.X,
						prevNode.StartCoordinate.Y + segment.SizeSegment.Height + distance);
				}
			}
		}
	}
}
