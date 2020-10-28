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

				if (!(segment is DrawElement))
				{
					segment.FindCoordinate();
				}
			}
		}

		public override void Draw()
		{
			foreach (DrawSegment node in Nodes)
			{
				node.Draw();
			}
		}
	}
}
