using System.Drawing;
using CalculationImpedancesApp;
using CalculationImpedancesUI.Drawing;

//TODO: Несоответствие дефолтному namespace
namespace CalculationImpedancesUI.Circuits
{
	/// <summary>
	/// The class contains methods for working with serial segment.
	/// </summary>
	public class DrawableSerialCircuit : DrawableSegmentBase 
	{
		/// <summary>
		/// Create a serial segment.
		/// </summary>
		/// <param name="segment">A circuit segment.</param>
		public DrawableSerialCircuit(ISegment segment) : base(segment)
		{ 
		}

		/// <summary>
		/// Calculating the size for a serial circuit segment.
		/// </summary>
		/// <returns></returns>
		public override Size CalculateSize()
		{
            Height = 0;
            Width = 0;
            foreach (DrawableSegmentBase segment in Nodes)
			{
				var calculateSize = segment.CalculateSize();
				Width += calculateSize.Width + Distance;
				if (calculateSize.Height > Height)
				{
					Height = calculateSize.Height;
				}
			}
			Width -= Distance;
			SizeSegment = new Size(Width, Height);
			return SizeSegment;
		}

		/// <summary>
		/// Finding the coordinates of a serial circuit segment.
		/// </summary>
		public override void FindCoordinate()
		{
			int halfHeightSegment = 0;
			foreach (DrawableSegmentBase segment in Nodes)
			{
				if (halfHeightSegment < segment.SizeSegment.Height / 2)
				{
					halfHeightSegment = segment.SizeSegment.Height / 2;
				}
			}

			foreach (DrawableSegmentBase segment in Nodes)
			{
				var prevNode = segment.PrevNode as DrawableSegmentBase;
				
				if (prevNode == null)
				{
					segment.StartCoordinate = new Point(StartCoordinate.X,
						StartCoordinate.Y + halfHeightSegment 
                        - segment.SizeSegment.Height / 2);
				}
				else
				{
					//TODO: RSDN - длины строк
					segment.StartCoordinate = new Point(prevNode.StartCoordinate.X +
					                                    prevNode.SizeSegment.Width + Distance,
						prevNode.LeftСonnectСoordinate.Y - segment.SizeSegment.Height / 2);
				}

				if (!(segment is DrawableElement))
				{
					segment.FindCoordinate();
				}

				segment.CalculateСonnectСoordinate();
			}
		}

		/// <summary>
		/// Draws a serial segment of the circuit.
		/// </summary>
		public override void Draw()
		{
			if (Nodes.Count == 0)
			{
				return;
			}

			//TODO: Не используется
			var lastNode = Nodes[Nodes.Count - 1] as DrawableSegmentBase;
			foreach (DrawableSegmentBase node in Nodes)
			{
                //TODO: Можно переделать в PatternMatching
				var prevNode = node.PrevNode as DrawableSegmentBase;

				if (prevNode != null)
				{
					//TODO: RSDN - длины строк
					Graphics.DrawLine(Pen, prevNode.RightСonnectСoordinate, node.LeftСonnectСoordinate);
				}

				node.Draw();
			}
		}
    }
}
