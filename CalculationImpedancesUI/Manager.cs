using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CalculationImpedancesApp;
using CalculationImpedancesUI.Elements;

namespace CalculationImpedancesUI
{
	public static class Manager
	{
		public static TreeView TreeCircuit { get; set; } = new TreeView();

		public static Graphics Graphics { get; set; }

		public static Pen Pen { get; set; }

		public static void FillCircuitNodes(Circuit circuit)
		{
			TreeCircuit.Nodes.Clear();
			DrawSegment mainCircuitNode = new DrawSegment
			{
				Text = circuit.Name,
			};
			TreeCircuit.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				DrawSegment subSegmentNode = new DrawSegment
				{
					Text = subSegment is IElement ? subSegment.ToString() : subSegment.Name,
					Segment = subSegment
				};
				if (!(subSegmentNode.Segment is IElement))
				{
					FillTreeNode(subSegmentNode, subSegment);
				}
				TreeCircuit.Nodes[0].Nodes.Add(subSegmentNode);
			}
		}

		private static void FillTreeNode(DrawSegment parentNode, ISegment segment)
		{
			if (segment is IElement)
			{
				DrawSegment elementNode = new DrawSegment
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
					DrawSegment segmentNode = new DrawSegment
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

		public static void FindCoordinateNode()
		{
			foreach (DrawSegment node in TreeCircuit.Nodes[0].Nodes)
			{
				if (node.Segment is SerialCircuit)
				{

				}

				if (node.Segment is ParallelCircuit)
				{

				}

				node.FindCoordinate();
			}
		}

		private static void DrawCapacitor(DrawSegment node)
		{
			int distanceVerticalLines = 5;
			int lengthHorizontalLines = node.SizeSegment.Width / 2 - distanceVerticalLines;
			int lengthVerticalLines = node.SizeSegment.Width / 2;
			int YCoordinatHorizontalLine = node.StartCoordinate.Y + node.SizeSegment.Height / 2;

			Point coordinatesBeginningHorizontalFirstLine = new Point(node.StartCoordinate.X,
				YCoordinatHorizontalLine);
			Point coordinatesEndHorizontalFirstLine = new Point(node.StartCoordinate.X + lengthHorizontalLines,
				YCoordinatHorizontalLine);

			Point coordinatesBeginningHorizontalSecondLine = new Point(coordinatesEndHorizontalFirstLine.X + distanceVerticalLines,
				YCoordinatHorizontalLine);
			Point coordinatesEndHorizontalSecondLine = new Point(coordinatesBeginningHorizontalSecondLine.X + lengthHorizontalLines,
				YCoordinatHorizontalLine);

			Graphics.DrawLine(Pen, coordinatesBeginningHorizontalFirstLine.X, coordinatesBeginningHorizontalFirstLine.Y,
				coordinatesEndHorizontalFirstLine.X, coordinatesEndHorizontalFirstLine.Y);

			Graphics.DrawLine(Pen, coordinatesEndHorizontalFirstLine.X, node.StartCoordinate.Y, 
				coordinatesEndHorizontalFirstLine.X, node.StartCoordinate.Y + node.SizeSegment.Height);

			Graphics.DrawLine(Pen, coordinatesBeginningHorizontalSecondLine.X, node.StartCoordinate.Y,
				coordinatesBeginningHorizontalSecondLine.X, node.StartCoordinate.Y + node.SizeSegment.Height);

			Graphics.DrawLine(Pen, coordinatesBeginningHorizontalSecondLine.X, coordinatesBeginningHorizontalSecondLine.Y,
				coordinatesEndHorizontalSecondLine.X, coordinatesEndHorizontalSecondLine.Y);
		}

		private static void DrawInductor(DrawSegment node)
		{
			int x = node.StartCoordinate.X;
			int y = node.StartCoordinate.Y;
			int semicircleWidth = node.SizeSegment.Width / 4;
			int semicircleHeight = node.SizeSegment.Height / 2;
			int numberSemicircles = 4;

			for (int i = 0; i < numberSemicircles; i++)
			{
				Graphics.DrawArc(Pen, x, y, semicircleWidth, semicircleHeight, 180, 180);
				x += semicircleWidth;
			}
		}

		private static void DrawResistor(DrawSegment node)
		{
			Graphics.DrawRectangle(Pen, node.StartCoordinate.X, node.StartCoordinate.Y,
				node.SizeSegment.Width, node.SizeSegment.Height);
		}

		public static void DrawElement()
		{
			foreach (DrawSegment node in TreeCircuit.Nodes[0].Nodes)
			{
				if (node.Segment is Resistor)
				{
					DrawResistor(node);
				}
				if (node.Segment is Inductor)
				{
					DrawInductor(node);
				}
				if (node.Segment is Capacitor)
				{
					DrawCapacitor(node);
				}
			}
		}
	}
}
