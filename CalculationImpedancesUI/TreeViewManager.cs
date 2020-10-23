using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using CalculationImpedancesApp;

namespace CalculationImpedancesUI
{
	public static class  TreeViewManager
	{
		public static TreeView CircuitsTreeView { get; set; }

		public static void FillCircuitNodes(Circuit circuit)
		{
			CircuitsTreeView.Nodes.Clear();
			SegmentTreeNode mainCircuitNode = new SegmentTreeNode
			{
				Text = circuit.Name,
			};
			CircuitsTreeView.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				SegmentTreeNode subSegmentNode = new SegmentTreeNode
				{
					Text = subSegment is IElement ? subSegment.ToString() : subSegment.Name,
					Segment = subSegment
				};
				if (!(subSegmentNode.Segment is IElement))
				{
					FillTreeNode(subSegmentNode, subSegment);
				}

				CircuitsTreeView.Nodes[0].Nodes.Add(subSegmentNode);
			}

			CircuitsTreeView.ExpandAll();
		}

		private static void FillTreeNode(SegmentTreeNode circuitNode, ISegment segment)
		{
			if (segment is IElement)
			{
				SegmentTreeNode elementNode = new SegmentTreeNode
				{
					Text = segment.ToString(),
					Segment = segment
				};
				circuitNode.Nodes.Add(elementNode);
			}
			else
			{
				foreach (var subSegment in segment.SubSegments)
				{
					SegmentTreeNode segmentNode = new SegmentTreeNode
					{
						Text = subSegment is IElement ? subSegment.ToString() : subSegment.Name,
						Segment = subSegment
					};
					circuitNode.Nodes.Add(segmentNode);
					if (!(subSegment is IElement))
					{
						FillTreeNode(segmentNode, subSegment);
					}
				}
			}
		}
	}
}
