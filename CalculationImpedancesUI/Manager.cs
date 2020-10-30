using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CalculationImpedancesApp;
using CalculationImpedancesUI.Elements;

namespace CalculationImpedancesUI
{
	public static class Manager
	{
		public static TreeView TreeCircuit { get; set; } = new TreeView();

		public static void FillCircuitNodes(Circuit circuit)
		{
			TreeCircuit.Nodes.Clear();
			TreeNode mainCircuitNode = new TreeNode();
			TreeCircuit.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				if (!(subSegment is IElement) && subSegment.SubSegments.Count == 0)
				{
					continue;
				}
				DrawSegment subSegmentNode = GetSegmentType(subSegment);
				if (!(subSegmentNode is DrawElement))
				{
					FillTreeNode(subSegmentNode, subSegment);
				}
				TreeCircuit.Nodes[0].Nodes.Add(subSegmentNode);
			}
		}

		private static void FillTreeNode(DrawSegment parentNode, ISegment segment)
		{
			foreach (var subSegment in segment.SubSegments)
			{
				if (!(subSegment is IElement) && subSegment.SubSegments.Count == 0)
				{
					continue;
				}
				DrawSegment segmentNode = GetSegmentType(subSegment);
				parentNode.Nodes.Add(segmentNode);
				if (!(subSegment is IElement))
				{
					FillTreeNode(segmentNode, subSegment);
				}
			}
		}

		//private void rjtgnlnr(ISegment segment)
		//{
		//	foreach (var subSegment in segment.SubSegments)
		//	{

		//	}
		//}

		private static DrawSegment GetSegmentType(ISegment segment)
		{
			DrawSegment drawSegment;
			switch (segment)
			{
				case Resistor resistor:
					{
						drawSegment = new DrawResistor(segment);
						break;
					}
				case Inductor inductor:
					{
						drawSegment = new DrawInductor(segment);
						break;
					}
				case Capacitor capacitor:
					{
						drawSegment = new DrawCapacitor(segment);
						break;
					}
				case SerialCircuit serialCircuit:
					{
						drawSegment = new DrawSerialCircuit(segment);
						break;
					}
				case ParallelCircuit parallelCircuit:
					{
						drawSegment = new DrawParallelCircuit(segment);
						break;
					}
				default:
					{
						throw new ArgumentException("There is no such type of segment");
					}
			}
			return drawSegment;
		}

		public static void FindCoordinateNode()
		{
			int halfHeightSegment = 0;
			foreach (DrawSegment segment in TreeCircuit.Nodes[0].Nodes)
			{
				if (halfHeightSegment < segment.SizeSegment.Height / 2)
				{
					halfHeightSegment = segment.SizeSegment.Height / 2;
				}
			}

			foreach (DrawSegment segment in TreeCircuit.Nodes[0].Nodes)
			{
				segment.CalculateSize();
				int distance = 10;
				var prevNode = segment.PrevNode as DrawSegment;
				if (prevNode == null)
				{
					segment.StartCoordinate = new Point(5, halfHeightSegment - segment.SizeSegment.Height / 2);
				}
				else
				{
					segment.StartCoordinate = new Point(prevNode.StartCoordinate.X + 
					     prevNode.SizeSegment.Width + distance, prevNode.LeftСonnectСoordinate.Y - segment.SizeSegment.Height / 2);
				}
				if (!(segment is DrawElement))
				{
					segment.FindCoordinate();
				}
				segment.CalculateСonnectСoordinate();
			}
		}


		public static Size CalculateCircuitSize()
		{
			if (TreeCircuit.Nodes.Count == 0)
			{
				return new Size(1 ,1);
			}
			int width = 0;
			int height = 0;
			int distance = 10;
			foreach (DrawSegment segment in TreeCircuit.Nodes[0].Nodes)
			{
				var calculateSizeSubsegment = segment.CalculateSize();
				width += calculateSizeSubsegment.Width + distance;
				if (calculateSizeSubsegment.Height > height)
				{
					height = calculateSizeSubsegment.Height;
				}
			}
			width += distance;
			return new Size(width, height + 100); 
		}

		public static void Draw(Graphics graphics, Pen pen)
		{
			if (TreeCircuit.Nodes[0].Nodes.Count == 0)
			{
				return;
			}
			var firstNode = TreeCircuit.Nodes[0] as DrawSegment;
			var lastNode = TreeCircuit.Nodes[0].Nodes[TreeCircuit.Nodes[0].Nodes.Count - 1] as DrawSegment;

			if (firstNode != null)
			{
				var firstPointNode = new Point(firstNode.LeftСonnectСoordinate.X-10, firstNode.LeftСonnectСoordinate.Y);
				if (lastNode != null)
				{
					var lastPointNode = new Point(lastNode.RightСonnectСoordinate.X+10, lastNode.RightСonnectСoordinate.Y);

					graphics.DrawLine(pen, firstPointNode, firstNode.LeftСonnectСoordinate);
					graphics.DrawLine(pen, lastPointNode, lastNode.RightСonnectСoordinate);
				}
			}

			foreach (DrawSegment node in TreeCircuit.Nodes[0].Nodes)
			{
				var prevNode = node.PrevNode as DrawSegment;
				if (prevNode != null)
				{
					if (prevNode.Nodes.Count == 0 && !(prevNode is DrawElement))
					{
						prevNode = prevNode.PrevNode as DrawSegment;
					}

					if (prevNode != null)
					{
						graphics.DrawLine(pen, prevNode.RightСonnectСoordinate, node.LeftСonnectСoordinate);
					}
				}

				node.Draw();
			}
		}
	}
}
