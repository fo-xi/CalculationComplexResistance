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
	public class DrawSegment : TreeNode
	{
		public Size SizeSegment { get; set; }

		public Point StartCoordinate { get; set; }

		public Point LeftСonnectСoordinate { get; set; }

		public Point RightСonnectСoordinate { get; set; }

		public ISegment Segment { get; set; }

		public virtual Size GetSize()
		{
			throw new NotImplementedException();
		}

		public virtual void FindCoordinate()
		{
			throw new NotImplementedException();
		}
	}
}
