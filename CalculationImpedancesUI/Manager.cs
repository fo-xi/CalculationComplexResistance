using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CalculationImpedancesApp;

namespace CalculationImpedancesUI
{
	class Manager
	{
		public DrawingNode TreeCircuit { get; set; }

		private void FillCircuitNodes(Circuit circuit)
		{
			DrawingNode mainCircuitNode = new DrawingNode
			{
				Text = circuit.Name,
			};
			TreeCircuit.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				DrawingNode subSegmentNode = new DrawingNode
				{
					Text = subSegment is IElement ? subSegment.ToString() : subSegment.Name,
					Segment = subSegment
				};
				if (!(subSegmentNode.Segment is IElement))
				{
					FillTreeNode(subSegmentNode, subSegment);
				}
				TreeCircuit.Nodes[0].Nodes.Add(subSegmentNode);
			}
		}

		private void FillTreeNode(DrawingNode parentNode, ISegment segment)
		{
			if (segment is IElement)
			{
				DrawingNode elementNode = new DrawingNode
				{
					Text = segment.ToString(),
					Segment = segment
				};
				parentNode.Nodes.Add(elementNode);
			}
			else
			{
				foreach (var subSegment in segment.SubSegments)
				{
					DrawingNode segmentNode = new DrawingNode
					{
						Text = subSegment is IElement ? subSegment.ToString() : subSegment.Name,
						Segment = subSegment
					};
					parentNode.Nodes.Add(segmentNode);
					if (!(subSegment is IElement))
					{
						FillTreeNode(segmentNode, subSegment);
					}
				}
			}
		}

		private void FindCoordinateNode()
		{
			foreach (DrawingNode node in TreeCircuit.Nodes)
			{
				node.FindCoordinate();
			}
		}


	}
}
