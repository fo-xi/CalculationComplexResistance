using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationImpedancesApp;

namespace CalculationImpedancesUI
{
    public partial class TreeViewControl : UserControl
    {
	    public delegate void CalculateHandler();

		/// <summary>
		/// Event revealing when calculating circuit impedance.
		/// Used when updating circuit data.
		/// </summary>
		public event CalculateHandler NotifyCalculate;

		public TreeViewControl()
        {
            InitializeComponent();
        }

		private void AddSegmentButton_Click(object sender, EventArgs e)
        {
			var segmentForm = new SegmentForm();
			segmentForm.ShowDialog();
			if (segmentForm.DialogResult == DialogResult.OK)
			{
				var selectedIndex = CheckElementSelection();
				var segment = segmentForm.NewSegment;

				if (selectedIndex.Segment is IElement)
				{
					MessageBox.Show("Element cannot be created from element", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					Project.SelectedCircuit.SubSegments.Add(segment);
				}
				else
				{
					selectedIndex.Segment.SubSegments.Add(segment);
				}

				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = segmentForm.NewSegment.Name,
					Segment = segment
				});
				NotifyCalculate?.Invoke();
			}
        }

        private void EditSegmentButton_Click(object sender, EventArgs e)
        {
			try
			{
				var selectedIndex = CheckElementSelection();
				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					return;
				}
				var segmentForm = new SegmentForm { NewSegment = selectedIndex.Segment };
				segmentForm.ShowDialog();
				if (segmentForm.DialogResult == DialogResult.OK)
				{
					var parent = selectedIndex.Parent as SegmentTreeNode;
					if (parent == CircuitsTreeView.Nodes[0])
					{
						Project.SelectedCircuit.SubSegments.Remove(selectedIndex.Segment);
						Project.SelectedCircuit.SubSegments.Add(segmentForm.NewSegment);
					}
					else
					{
						parent.Segment.SubSegments.Remove(selectedIndex.Segment);
						parent.Segment.SubSegments.Add(segmentForm.NewSegment);
					}
					TreeViewManager.FillCircuitNodes(Project.SelectedCircuit);
					NotifyCalculate?.Invoke();
				}
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.ParamName, "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void AddElementButton_Click(object sender, EventArgs e)
        {
			try
			{
				var selectedIndex = CheckElementSelection();
				var elementForm = new AddEditSegmentForm();
				elementForm.ShowDialog();
				if (elementForm.DialogResult != DialogResult.OK)
				{
					return;
				}

				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					Project.SelectedCircuit.SubSegments.Add(elementForm.NewElement);
				}
				else if (!(selectedIndex.Segment is IElement))
				{
					selectedIndex.Segment.SubSegments.Add(elementForm.NewElement);
				}
				else
				{
					selectedIndex = selectedIndex.Parent as SegmentTreeNode;
					if (selectedIndex == CircuitsTreeView.Nodes[0])
					{
						Project.SelectedCircuit.SubSegments.Add(elementForm.NewElement);
					}
					else
					{
						selectedIndex.Segment.SubSegments.Add(elementForm.NewElement);
					}
				}

				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = elementForm.NewElement.ToString(),
					Segment = elementForm.NewElement
				});
				NotifyCalculate?.Invoke();
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.ParamName, "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void EditElementButton_Click(object sender, EventArgs e)
        {
			try
			{
				var selectedIndex = CheckElementSelection();
				var elementForm = new AddEditSegmentForm { NewElement = selectedIndex.Segment as IElement };
				elementForm.ShowDialog();
				if (elementForm.DialogResult == DialogResult.OK)
				{
					var parent = selectedIndex.Parent as SegmentTreeNode;
					parent.Segment.SubSegments.Remove(selectedIndex.Segment);
					parent.Nodes.Remove(selectedIndex);
					parent.Segment.SubSegments.Add(elementForm.NewElement);
					parent.Nodes.Add(new SegmentTreeNode
					{
						Text = elementForm.NewElement.ToString(),
						Segment = elementForm.NewElement
					});
					NotifyCalculate?.Invoke();
				}
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.ParamName, "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void RemoveElementButton_Click(object sender, EventArgs e)
        {
			try
			{
				var selectedIndex = CheckElementSelection();
				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					MessageBox.Show("Can't delete root element", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					var parent = selectedIndex.Parent as SegmentTreeNode;
					var element = selectedIndex.Segment;
					if (parent?.Segment == null)
					{
						Project.SelectedCircuit.SubSegments.Remove(element);
					}
					else
					{
						parent.Segment.SubSegments.Remove(element);
					}
					parent.Nodes.Remove(selectedIndex);
					NotifyCalculate?.Invoke();
				}
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.ParamName, "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void CircuitsTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
	        DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void CircuitsTreeView_DragEnter(object sender, DragEventArgs e)
        {
	        e.Effect = DragDropEffects.Move;
        }

        private void CircuitsTreeView_DragDrop(object sender, DragEventArgs e)
        {
	        //TODO: Подозрительно много комментариев... (+)
	        Point targetPoint = CircuitsTreeView.PointToClient(new Point(e.X, e.Y));

	        // Куда перетаскиваем
	        SegmentTreeNode targetNode = CircuitsTreeView.GetNodeAt(targetPoint) as SegmentTreeNode;

	        // Что перетаскиваем
	        SegmentTreeNode draggedNode = e.Data.GetData(typeof(SegmentTreeNode)) as SegmentTreeNode;

	        if (draggedNode == null || draggedNode.Segment == null)
	        {
		        return;
	        }

	        if (targetNode == null)
	        {
		        UpdateTreeView(draggedNode, targetNode);
		        draggedNode.Remove();
		        CircuitsTreeView.Nodes[0].Nodes.Add(draggedNode);
		        draggedNode.Expand();
	        }
	        else
	        {
		        TreeNode parentNode = targetNode;

		        if (!draggedNode.Equals(targetNode) && targetNode != null)
		        {
			        bool canDrop = true;

			        // Поднимаемся вверх от узла, на который мы упали,
			        // чтобы узнать, является ли targetNode нашим родителем
			        while (canDrop && (parentNode != null))
			        {
				        canDrop = !Object.ReferenceEquals(draggedNode, parentNode);
				        parentNode = parentNode.Parent;
			        }

			        if (canDrop)
			        {
				        if (targetNode.Segment is IElement)
				        {
					        return;
				        }
				        UpdateTreeView(draggedNode, targetNode);
				        draggedNode.Remove();
				        targetNode.Nodes.Add(draggedNode);

			        }
			        targetNode.Expand();

		        }
	        }
	        CircuitsTreeView.SelectedNode = draggedNode;
	        NotifyCalculate?.Invoke();
		}

        private SegmentTreeNode CheckElementSelection()
        {
	        SegmentTreeNode element = CircuitsTreeView.SelectedNode as SegmentTreeNode;
	        if (element == null)
	        {
		        return CircuitsTreeView.Nodes[0] as SegmentTreeNode;
	        }
	        else
	        {
		        return element;
	        }
        }

        private void UpdateTreeView(SegmentTreeNode draggedNode, SegmentTreeNode targetNode)
        {
	        var parent = draggedNode.Parent as SegmentTreeNode;
			if (parent == null) return;
	        if (parent.Segment == null)
	        {
		        Project.SelectedCircuit.SubSegments.Remove(draggedNode.Segment);
	        }
	        else
	        {
		        parent.Segment.SubSegments.Remove(draggedNode.Segment);
	        }

	        if ((targetNode == null) || (targetNode.Segment == null))
	        {
		        Project.SelectedCircuit.SubSegments.Add(draggedNode.Segment);
	        }
	        else
	        {
		        targetNode.Segment.SubSegments.Add(draggedNode.Segment);
	        }

        }

        private void TreeViewControl_Load(object sender, EventArgs e)
		{
			TreeViewManager.CircuitsTreeView = CircuitsTreeView;
		}
	}
}
