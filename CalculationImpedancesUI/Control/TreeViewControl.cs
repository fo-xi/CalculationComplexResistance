using System;
using System.Drawing;
using System.Windows.Forms;
using CalculationImpedancesApp;
using CalculationImpedancesUI.Control;

namespace CalculationImpedancesUI
{
    public partial class TreeViewControl : UserControl
    {
        //TODO: Убрать этот делегат, использовать обычный EventHandler (+)

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
					//TODO: RSDN (+)
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
				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					return;
				}
				//TODO: RSDN (+)
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
						Project.SelectedCircuit.SubSegments.Remove(selectedIndex.Segment);
						Project.SelectedCircuit.SubSegments.Add(segmentForm.NewSegment);
					}
					else
					{
						parent.Segment.SubSegments.Remove(selectedIndex.Segment);
						parent.Segment.SubSegments.Add(segmentForm.NewSegment);
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

				//TODO: Есть ощущение, что ниже дубль логики (+)
                var subSements = Project.SelectedCircuit.SubSegments;
                if (!(selectedIndex.Segment is IElement) && 
					(selectedIndex != CircuitsTreeView.Nodes[0]))
                {
                    subSements = selectedIndex.Segment.SubSegments;
                }
                else if (selectedIndex.Parent is SegmentTreeNode parent && parent.Segment != null)
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
				//TODO: RSDN (+)
				var elementForm = new AddEditSegmentForm
                {
                    NewElement = selectedIndex.Segment as IElement
                };
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
				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					MessageBox.Show("Can't delete root element", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					var parent = selectedIndex.Parent as SegmentTreeNode;
					var element = selectedIndex.Segment;
					//TODO: Дубль (+)
                    var subSegments = Project.SelectedCircuit.SubSegments;
                    if (parent?.Segment != null)
                    {
                        subSegments = parent.Segment.SubSegments;
                    }

                    subSegments.Remove(element);
					parent.Nodes.Remove(selectedIndex);
					NotifyCalculate?.Invoke(this, e);
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
	        //TODO: Подозрительно много комментариев... Всё ещё, переименуйте переменные, чтобы не нужны были комментарии (+)
	        Point targetPoint = CircuitsTreeView.PointToClient(new Point(e.X, e.Y));

			SegmentTreeNode whereDrag = CircuitsTreeView.GetNodeAt(targetPoint) as SegmentTreeNode;

			SegmentTreeNode whatDragging = e.Data.GetData(typeof(SegmentTreeNode)) as SegmentTreeNode;

	        if (whatDragging == null || whatDragging.Segment == null)
	        {
		        return;
	        }

	        if (whereDrag == null)
	        {
		        UpdateTreeView(whatDragging, whereDrag);
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
				        canDrop = !Object.ReferenceEquals(whatDragging, parentNode);
				        parentNode = parentNode.Parent;
			        }

			        if (canDrop)
			        {
				        if (whereDrag.Segment is IElement)
				        {
					        return;
				        }

				        UpdateTreeView(whatDragging, whereDrag);
				        whatDragging.Remove();
				        whereDrag.Nodes.Add(whatDragging);

			        }
			        whereDrag.Expand();
                }
	        }
	        CircuitsTreeView.SelectedNode = whatDragging;
	        NotifyCalculate?.Invoke(this, e);
		}

        private SegmentTreeNode CheckElementSelection()
        {
			//TODO: RSDN (+)
	        var element = CircuitsTreeView.SelectedNode as SegmentTreeNode;
	        if (element == null)
	        {
		        return CircuitsTreeView.Nodes[0] as SegmentTreeNode;
	        }

            return element;
        }

		//TODO: RSDN (+)
        private void UpdateTreeView(SegmentTreeNode draggedNode,
            SegmentTreeNode targetNode)
        {
	        var parent = draggedNode.Parent as SegmentTreeNode;
            if (parent == null)
            {
                return;
            }

			//TODO: Дубль (+)
            var subSegments = Project.SelectedCircuit.SubSegments;

			if (parent.Segment != null)
            {
                subSegments = parent.Segment.SubSegments;

            }

            subSegments.Remove(draggedNode.Segment);
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
