using System;
using System.Drawing;
using System.Windows.Forms;
using CalculationImpedancesApp;

namespace CalculationImpedancesUI.Control
{
    public partial class TreeViewControl : UserControl
    {
        /// <summary>
		/// Event revealing when calculating circuit impedance.
		/// Used when updating circuit data.
		/// </summary>
		public event EventHandler NotifyCalculate;

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
					MessageBox.Show("Element cannot be created from element",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				NotifyCalculate?.Invoke(this, e);
			}
        }

        private void EditSegmentButton_Click(object sender, EventArgs e)
        {
			try
			{
				var selectedIndex = CheckElementSelection();
				if (selectedIndex == CircuitsTreeView.Nodes[0] || selectedIndex.Segment is IElement)
				{
					return;
				}

				var segmentForm = new SegmentForm
                {
                    NewSegment = selectedIndex.Segment
                };
				segmentForm.ShowDialog();
				if (segmentForm.DialogResult == DialogResult.OK)
				{
					var parent = selectedIndex.Parent as SegmentTreeNode;
					if (parent == CircuitsTreeView.Nodes[0])
					{
						Project.SelectedCircuit.SubSegments[selectedIndex.Index] = segmentForm.NewSegment;
					}
					else
					{
						parent.Segment.SubSegments[selectedIndex.Index] = segmentForm.NewSegment;
					}
					TreeViewManager.FillCircuitNodes(Project.SelectedCircuit);
					NotifyCalculate?.Invoke(this, e);
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

                var subSements = 
	                Project.SelectedCircuit.SubSegments;
                if (!(selectedIndex.Segment is IElement) && 
					(selectedIndex != CircuitsTreeView.Nodes[0]))
                {
                    subSements = selectedIndex.Segment.SubSegments;
                }
                else if (selectedIndex.Parent is 
					SegmentTreeNode parent && parent.Segment != null)
                {
                    subSements = parent.Segment.SubSegments;
                }

				subSements.Add(elementForm.NewElement);
                selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = elementForm.NewElement.ToString(),
					Segment = elementForm.NewElement
				});
				NotifyCalculate?.Invoke(this, e);
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

				var elementForm = new AddEditSegmentForm
                {
                    NewElement = selectedIndex.Segment as IElement
                };
				elementForm.ShowDialog();
				if (elementForm.DialogResult == DialogResult.OK)
				{
					var parent = selectedIndex.Parent as SegmentTreeNode;
					var subSegments = Project.SelectedCircuit.SubSegments;
					if (parent != CircuitsTreeView.Nodes[0])
					{
						subSegments = parent.Segment.SubSegments;
					}
					subSegments[selectedIndex.Index] = elementForm.NewElement;
					parent.Nodes.RemoveAt(selectedIndex.Index);
					parent.Nodes[selectedIndex.Index] = new SegmentTreeNode
					{
						Text = elementForm.NewElement.ToString(),
						Segment = elementForm.NewElement
					};
					NotifyCalculate?.Invoke(this, e);
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
				if (selectedIndex == null)
				{
					MessageBox.Show("Select element/segment", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					MessageBox.Show("Can't delete root element", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					var parent = selectedIndex.Parent as SegmentTreeNode;
					var element = selectedIndex.Segment;

                    var subSegments = Project.SelectedCircuit.SubSegments;
                    if (parent?.Segment != null)
                    {
                        subSegments = parent.Segment.SubSegments;
                    }

                    subSegments.Remove(element);
					parent.Nodes.Remove(selectedIndex);
					NotifyCalculate?.Invoke(this, e);
				}

				CircuitsTreeView.SelectedNode = null;
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
            Point targetPoint = 
				CircuitsTreeView.PointToClient(new Point(e.X, e.Y));

			SegmentTreeNode whereDrag = 
				CircuitsTreeView.GetNodeAt(targetPoint) as SegmentTreeNode;

			SegmentTreeNode whatDragging =
				e.Data.GetData(typeof(SegmentTreeNode)) as SegmentTreeNode;

	        if (whatDragging == null || whatDragging.Segment == null)
	        {
		        return;
	        }

	        if (whereDrag == null)
	        {
		        UpdatingData(whatDragging, whereDrag);
		        whatDragging.Remove();
		        CircuitsTreeView.Nodes[0].Nodes.Add(whatDragging);
		        whatDragging.Expand();
	        }
	        else
	        {
		        TreeNode parentNode = whereDrag;
                if (!whatDragging.Equals(whereDrag) && whereDrag != null)
		        {
			        bool canDrop = true;
                    while (canDrop && (parentNode != null))
			        {
				        canDrop = 
							!Object.ReferenceEquals(whatDragging, parentNode);
				        parentNode = parentNode.Parent;
			        }

			        if (canDrop)
			        {
				        if (whereDrag.Segment is IElement)
				        {
					        return;
				        }

				        UpdatingData(whatDragging, whereDrag);
				        whatDragging.Remove();
				        whereDrag.Nodes.Add(whatDragging);

			        }
			        whereDrag.Expand();
                }
	        }
	        CircuitsTreeView.SelectedNode = whatDragging;
	        NotifyCalculate?.Invoke(this, e);
		}

		/// <summary>
		/// Checking if the selected item is a root.
		/// </summary>
		/// <returns></returns>
		private SegmentTreeNode CheckElementSelection()
        {
            var element = CircuitsTreeView.SelectedNode as SegmentTreeNode;
            return element;
        }

		/// <summary>
		/// Updating data after we changed the tree structure.
		/// </summary>
		/// <param name="whatDragging">What are we dragging.</param>
		/// <param name="whereDrag">Where we drag.</param>
		private void UpdatingData(SegmentTreeNode whatDragging,
            SegmentTreeNode whereDrag)
        {
	        var parent = whatDragging.Parent as SegmentTreeNode;
            if (parent == null)
            {
                return;
            }

            var subSegments = Project.SelectedCircuit.SubSegments;

			if (parent.Segment != null)
            {
                subSegments = parent.Segment.SubSegments;

            }

            subSegments.Remove(whatDragging.Segment);
			if ((whereDrag == null) || (whereDrag.Segment == null))
	        {
		        Project.SelectedCircuit.SubSegments.Add(whatDragging.Segment);
	        }
	        else
	        {
		        whereDrag.Segment.SubSegments.Add(whatDragging.Segment);
	        }
        }

        private void TreeViewControl_Load(object sender, EventArgs e)
		{
			TreeViewManager.CircuitsTreeView = CircuitsTreeView;
		}
	}
}
