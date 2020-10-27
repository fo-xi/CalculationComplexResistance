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
		protected static readonly int elementWidth = 50;
		protected static readonly int elementHeight = 25;
		protected static readonly int distance = 10;
		protected static readonly Point startingPoint = new Point(0, 0);

		public DrawElement(ISegment segment) : base(segment)
		{
			SizeSegment = new Size(elementWidth, elementHeight);
		}

		public Size GetSize()
		{
			return SizeSegment;
		}

		public void FindCoordinate()
		{
			var prevNode = PrevNode as DrawElement;

			if (prevNode == null)
			{
				StartCoordinate = startingPoint;
				return;
			}
			StartCoordinate = new Point(prevNode.StartCoordinate.X + prevNode.SizeSegment.Width + distance,
				prevNode.StartCoordinate.Y);
			LeftСonnectСoordinate = new Point(StartCoordinate.X, (SizeSegment.Height / 2) + StartCoordinate.Y);
			RightСonnectСoordinate = new Point(StartCoordinate.X + SizeSegment.Width,
				(SizeSegment.Height / 2) + StartCoordinate.Y);
		}
	}
}
