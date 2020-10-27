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

		public static Graphics Graphics { get; set; }

		public static Pen Pen { get; set; }

		public static void FillCircuitNodes(Circuit circuit)
		{
			TreeCircuit.Nodes.Clear();
			TreeNode mainCircuitNode = new TreeNode();
			TreeCircuit.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				DrawSegment subSegmentNode = GetSegmentType(subSegment);
				if (!(subSegmentNode.Segment is IElement))
				{
					FillTreeNode(subSegmentNode, subSegment);
				}
				TreeCircuit.Nodes[0].Nodes.Add(subSegmentNode);
			}
		}

		private static void FillTreeNode(DrawSegment parentNode, ISegment segment)
		{
			if (segment is IElement)
			{
				DrawSegment elementNode = GetSegmentType(segment);
				parentNode.Nodes.Add(elementNode);
			}
			else
			{
				foreach (var subSegment in segment.SubSegments)
				{
					DrawSegment segmentNode = GetSegmentType(subSegment);
					parentNode.Nodes.Add(segmentNode);
					if (!(subSegment is IElement))
					{
						FillTreeNode(segmentNode, subSegment);
					}
				}
			}
		}

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
			foreach (DrawSegment segment in TreeCircuit.Nodes[0].Nodes)
			{
				int distance = 10;
				var prevNode = segment.PrevNode as DrawSegment;
				if (prevNode == null)
				{
					segment.StartCoordinate = new Point(0, 0);
				}
				else
				{
					segment.StartCoordinate = new Point(prevNode.StartCoordinate.X +
						  segment.SizeSegment.Width + distance, prevNode.StartCoordinate.Y);
				}
				if (!(segment is DrawElement))
				{
					segment.FindCoordinate();
				}
			}
		}

		public static void Draw()
		{
			foreach (DrawSegment node in TreeCircuit.Nodes[0].Nodes)
			{
				node.FindCoordinate();
				node.Draw();
			}
		}
	}
}
