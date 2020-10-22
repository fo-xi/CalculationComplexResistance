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
		private Project _project;

		public event EventHandler CircuitChanged;

		/// <summary>
		/// Type of circuit element.
		/// </summary>
		private readonly List<string> Type = new List<string>
		{
			"",
			"Resistor",
			"Inductor",
			"Capacitor",
		};

		public TreeViewControl()
        {
            InitializeComponent();
        }

		private void TreeViewControl_Load(object sender, EventArgs e)
		{
			TypeComboBox.DataSource = Type;
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
					MessageBox.Show("Segment cannot be created from element", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					_project.SelectedCircuit.SubSegments.Add(segment);

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
						_project.SelectedCircuit.SubSegments.Remove(selectedIndex.Segment);
						_project.SelectedCircuit.SubSegments.Add(segmentForm.NewSegment);
					}
					else
					{
						parent.Segment.SubSegments.Remove(selectedIndex.Segment);
						parent.Segment.SubSegments.Add(segmentForm.NewSegment);
					}
					FillCircuitNodes();
					CircuitChanged?.Invoke(sender, e);
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
					_project.SelectedCircuit.SubSegments.Add(elementForm.NewElement);
				}

				if (selectedIndex.Segment is IElement)
				{
					selectedIndex = selectedIndex.Parent as SegmentTreeNode;
					selectedIndex.Segment.SubSegments.Add(elementForm.NewElement);
				}

				if (selectedIndex.Segment is ISegment)
				{
					selectedIndex.Segment.SubSegments.Add(elementForm.NewElement);
				}

				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = elementForm.NewElement.ToString(),
					Segment = elementForm.NewElement
				});

				TypeComboBox.Text = "";
				NameTextBox.Text = "";
				ValueTextBox.Text = "";
				CircuitChanged?.Invoke(this, EventArgs.Empty);
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
					parent.Segment.SubSegments.Add(elementForm.NewElement);
					FillCircuitNodes();
					CircuitChanged?.Invoke(this, EventArgs.Empty);
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
					if (parent.Segment == null)
					{
						_project.SelectedCircuit.SubSegments.Remove(element);
					}
					else
					{
						parent.Segment.SubSegments.Remove(element);
					}

					parent.Nodes.Remove(selectedIndex);
				}
				CircuitChanged?.Invoke(this, EventArgs.Empty);
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.ParamName, "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
    }
}
