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

		public static Graphics Graphics { get; set; }

		public static Pen Pen { get; set; }

		public ISegment Segment { get; set; }

		public DrawSegment(ISegment segment)
		{
			Segment = segment;
		}

		public virtual Size GetSize()
		{
			throw new NotImplementedException();
		}

		public virtual void FindCoordinate()
		{
			
		}

		public virtual void Draw()
		{ 
			
		}
	}
}
