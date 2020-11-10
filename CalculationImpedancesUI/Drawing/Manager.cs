using System;
using System.Drawing;
using System.Windows.Forms;
using CalculationImpedancesApp;
using CalculationImpedancesApp.Circuits;
using CalculationImpedancesApp.Elements;
using CalculationImpedancesUI.Drawing.Elements;
using CalculationImpedancesUI.Drawing.Circuits;

namespace CalculationImpedancesUI.Drawing
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
			DrawableSegmentBase mainCircuitNode = new DrawableSerialCircuit(null);
			TreeCircuit.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				if (!(subSegment is IElement) && 
					subSegment.SubSegments.Count == 0)
				{
					continue;
				}
				DrawableSegmentBase subSegmentNode = GetSegmentType(subSegment);

				if (!(subSegmentNode is DrawingElement))
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
		private static void FillTreeNode(DrawableSegmentBase parentNode, ISegment segment)
		{
			foreach (var subSegment in segment.SubSegments)
			{
				DrawableSegmentBase segmentNode = GetSegmentType(subSegment);
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
			DrawableSegmentBase node = root.Nodes[0] as DrawableSegmentBase;
			while (node != null)
			{
				DrawableSegmentBase nextSegment 
					= node.NextNode as DrawableSegmentBase;
				if (!(node is DrawingElement))
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
		private static DrawableSegmentBase GetSegmentType(ISegment segment)
		{
			switch (segment)
			{
                //TODO: Можно сразу возвращать экземпляры из case-ов (+)
				case Resistor resistor:
                {
                    return new DrawableResistor(segment);
                }
				case Inductor inductor:
                {
					return new DrawableInductor(segment);
                }
				case Capacitor capacitor:
                {
					return new DrawableCapacitor(segment);
                }
				case SerialCircuit serialCircuit:
                {
					return new DrawableSerialCircuit(segment);

                }
				case ParallelCircuit parallelCircuit:
                {
					return new DrawableParallelCircuit(segment);
                }
				default:
                {
                    throw new ArgumentException("There is no such type of segment");
                }
			}
		}

		/// <summary>
		/// Finding the coordinates of the circuit nodes.
		/// </summary>
		public static void FindCoordinateNode()
		{
			int halfHeightSegment = 0;
			//TODO: Нужны два форыча?
			//Нужно сначала найти самую высокую ноду из всех нод, а потом, в следующем foreach произвести операции
			//Это необходимо для выравнивания
			foreach (DrawableSegmentBase segment in TreeCircuit.Nodes[0].Nodes)
			{
				if (halfHeightSegment < segment.SizeSegment.Height / 2)
				{
					halfHeightSegment = segment.SizeSegment.Height / 2;
				}
			}

			foreach (DrawableSegmentBase segment in TreeCircuit.Nodes[0].Nodes)
			{
				segment.CalculateSize();
				int distance = 10;
				var prevNode = segment.PrevNode as DrawableSegmentBase;
				if (prevNode == null)
				{
					//TODO: RSDN - длины строк (+)
					segment.StartCoordinate = 
						new Point(5, halfHeightSegment - 
						segment.SizeSegment.Height / 2);
				}
				else
				{
					//TODO: RSDN - длины строк (+)
					segment.StartCoordinate = 
						new Point(prevNode.StartCoordinate.X + 
					     prevNode.SizeSegment.Width + 
						 distance, 
						 prevNode.LeftСonnectСoordinate.Y - 
						 segment.SizeSegment.Height / 2);
				}

				if (!(segment is DrawingElement))
				{
					segment.FindCoordinate();
				}

				segment.CalculateСonnectСoordinate();
			}
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

			foreach (DrawableSegmentBase node in TreeCircuit.Nodes[0].Nodes)
			{
				var prevNode = node.PrevNode as DrawableSegmentBase;
				if (prevNode != null)
				{
					if (prevNode.Nodes.Count == 0 && !(prevNode is DrawingElement))
					{
						prevNode = prevNode.PrevNode as DrawableSegmentBase;
					}

					if (prevNode != null)
					{
						//TODO: RSDN - длины строк (+)
						graphics.DrawLine(pen, 
							prevNode.RightСonnectСoordinate, 
							node.LeftСonnectСoordinate);
					}
				}
				node.Draw();
			}
		}
	}
}
