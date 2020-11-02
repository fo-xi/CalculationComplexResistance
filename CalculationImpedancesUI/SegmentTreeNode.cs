using CalculationImpedancesApp;
using System.Windows.Forms;

namespace CalculationImpedancesUI
{
	/// <summary>
	/// TreeNode with a circuit segment.
	/// </summary>
	public class SegmentTreeNode: TreeNode
	{
		/// <summary>
		/// Circuit segment.
		/// </summary>
		public ISegment Segment { get; set; }
	}
}
