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
	public abstract class DrawSegment : TreeNode
	{
		public Size SizeSegment { get; set; }

		public Point StartCoordinate { get; set; }

		public Point LeftСonnectСoordinate { get; set; }

		public Point RightСonnectСoordinate { get; set; }

		public static Graphics Graphics { get; set; }

		public static Pen Pen { get; set; }

		public ISegment Segment { get; set; }

		protected DrawSegment(ISegment segment)
		{
			Segment = segment;
		}

		public abstract Size GetSize();

		public abstract void FindCoordinate();

		public abstract void Draw();
	}
}
