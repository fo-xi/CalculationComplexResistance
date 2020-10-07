using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationImpedancesApp;
using System.Windows.Forms;

namespace CalculationImpedancesUI
{
	class SegmentTreeNode: TreeNode
	{
		public ISegment Segment { get; set; }
	}
}
