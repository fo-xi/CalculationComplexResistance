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

namespace CalculationImpedancesUI
{
	public static class Manager
	{
		public static DrawingNode TreeCircuit { get; set; } = new DrawingNode();

		public static Graphics Graphics { get; set; }

		public static Pen Pen { get; set; }

		public static void FillCircuitNodes(Circuit circuit)
		{
			TreeCircuit.Nodes.Clear();
			DrawingNode mainCircuitNode = new DrawingNode
			{
				Text = circuit.Name,
			};
			TreeCircuit.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				DrawingNode subSegmentNode = new DrawingNode
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

		private static void FillTreeNode(DrawingNode parentNode, ISegment segment)
		{
			if (segment is IElement)
			{
				DrawingNode elementNode = new DrawingNode
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
					DrawingNode segmentNode = new DrawingNode
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
			foreach (DrawingNode node in TreeCircuit.Nodes[0].Nodes)
			{
				node.FindCoordinate();
			}
		}

		private static void DrawCapacitor(DrawingNode node)
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

		private static void DrawInductor(DrawingNode node)
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

		private static void DrawResistor(DrawingNode node)
		{
			Graphics.DrawRectangle(Pen, node.StartCoordinate.X, node.StartCoordinate.Y,
				node.SizeSegment.Width, node.SizeSegment.Height);
		}

		public static void DrawSerialCircuit()
		{
			foreach (DrawingNode node in TreeCircuit.Nodes[0].Nodes)
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
