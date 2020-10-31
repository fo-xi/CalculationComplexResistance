using System;
using System.Drawing;
using System.Windows.Forms;
using CalculationImpedancesApp;
using CalculationImpedancesUI.Elements;

namespace CalculationImpedancesUI
{
	/// <summary>
	/// The class is intended for working with the main circuit. 
	/// Contains methods for rendering the main circuit.
	/// </summary>
	public static class Manager
	{
		/// <summary>
		/// Circuit for the drawing.
		/// </summary>
		public static TreeView TreeCircuit { get; set; } = new TreeView();

		/// <summary>
		/// Fills the tree with nodes.
		/// </summary>
		/// <param name="circuit">Selected circuit</param>
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

			ClearTree(TreeCircuit.Nodes[0]);
		}

		/// <summary>
		/// Fills segments with elements or sub-segments.
		/// </summary>
		/// <param name="parentNode">Parent segment of a sub-segment.</param>
		/// <param name="segment">Sub-segment</param>
		private static void FillTreeNode(DrawSegment parentNode, ISegment segment)
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

		/// <summary>
		/// Clearing empty nodes from a tree.
		/// </summary>
		/// <param name="root">Tree root.</param>
		private static void ClearTree(TreeNode root)
		{
			if (root.Nodes.Count == 0)
			{
				return;
			}
			DrawSegment node = root.Nodes[0] as DrawSegment;
			while (node != null)
			{
				DrawSegment nextSegment = node.NextNode as DrawSegment;
				if (!(node is DrawElement))
				{
					if (node.Nodes.Count != 0)
					{
						ClearTree(node);
					}
					if (node.Nodes.Count == 0)
					{
						node.Remove();
					}
				}
				node = nextSegment;
			}
		}

		/// <summary>
		/// Find out the type of segment.
		/// </summary>
		/// <param name="segment">Segment to be checked.</param>
		/// <returns></returns>
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

		/// <summary>
		/// Finding the coordinates of the circuit nodes.
		/// </summary>
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

		/// <summary>
		/// Counting circuit size.
		/// </summary>
		/// <returns></returns>
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
			return new Size(width, height + 1); 
		}

		/// <summary>
		/// Drawing the circuit. 
		/// </summary>
		/// <param name="graphics">Provides methods for drawing objects.</param>
		/// <param name="pen">Draws a line.</param>
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
