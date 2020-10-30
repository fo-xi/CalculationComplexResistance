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
		public DrawSerialCircuit(ISegment segment) : base(segment)
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
			foreach (DrawSegment segment in Nodes)
			{
				if (halfHeightSegment < segment.SizeSegment.Height / 2)
				{
					halfHeightSegment = segment.SizeSegment.Height / 2;
				}
			}

			foreach (DrawSegment segment in Nodes)
			{
				int distance = 10;
				var prevNode = segment.PrevNode as DrawSegment;

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

				if (!(segment is DrawElement))
				{
					segment.FindCoordinate();
				}
				segment.CalculateСonnectСoordinate();
			}
		}
		public override void Draw()
		{
			if (Nodes.Count == 0)
			{
				return;
			}
			var lastNode = Nodes[Nodes.Count - 1] as DrawSegment;
			foreach (DrawSegment node in Nodes)
			{
				var prevNode = node.PrevNode as DrawSegment;

				if (prevNode != null)
				{
					Graphics.DrawLine(Pen, prevNode.RightСonnectСoordinate, node.LeftСonnectСoordinate);
				}
				node.Draw();
			}
		}

	}
}
