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
	public abstract class DrawElement : DrawSegment
	{
		protected static readonly int elementWidth = 48;
		protected static readonly int elementHeight = 24;
		protected static readonly int distance = 10;
		protected static readonly Point startingPoint = new Point(0, 0);

		public DrawElement(ISegment segment) : base(segment)
		{
			SizeSegment = new Size(elementWidth, elementHeight);
		}

		public override Size CalculateSize()
		{
			return SizeSegment;
		}

		public override void FindCoordinate()
		{
			var prevNode = PrevNode as DrawElement;

			if (prevNode == null)
			{
				StartCoordinate = startingPoint;
				return;
			}
			StartCoordinate = new Point(prevNode.StartCoordinate.X + prevNode.SizeSegment.Width + distance,
				prevNode.StartCoordinate.Y);

			CalculateСonnectСoordinate();
		}
	}
}
