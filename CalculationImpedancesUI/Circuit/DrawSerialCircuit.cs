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
	public class DrawSerialCircuit : DrawSegment 
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
			foreach (DrawSegment segment in Nodes)
			{
				height = segment.SizeSegment.Height;
				width += segment.SizeSegment.Width + distance;
			}
			width += distance;
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
					segment.StartCoordinate = new Point(prevNode.StartCoordinate.X + 
					      segment.SizeSegment.Width + distance, prevNode.StartCoordinate.Y);
				}
			}
		}
	}
}
