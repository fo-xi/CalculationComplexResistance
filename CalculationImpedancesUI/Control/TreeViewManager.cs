using System.Windows.Forms;
using CalculationImpedancesApp;

namespace CalculationImpedancesUI
{
	/// <summary>
	/// The class contains methods for filling the tree.
	/// </summary>
	public static class TreeViewManager
	{
		/// <summary>
		/// Circuit tree.
		/// </summary>
		public static TreeView CircuitsTreeView { get; set; }

		/// <summary>
		/// Fills the tree with nodes.
		/// </summary>
		/// <param name="circuit"></param>
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

		/// <summary>
		/// Fills segments with elements or sub-segments.
		/// </summary>
		/// <param name="parentNode">Parent node.</param>
		/// <param name="segment">Element.</param>
		private static void FillTreeNode(SegmentTreeNode parentNode, ISegment segment)
		{
			if (segment is IElement)
			{
				SegmentTreeNode elementNode = new SegmentTreeNode
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
					SegmentTreeNode segmentNode = new SegmentTreeNode
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
	}
}
