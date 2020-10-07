using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationImpedancesApp;
using System.Numerics;

namespace CalculationImpedancesUI
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// All program data.
		/// </summary>
		Project project = new Project();

		public MainForm()
		{
			InitializeComponent();
		}


		private void addFrequencyButton_Click(object sender, EventArgs e)
		{
			var frequency = new FrequencyForm();
			frequency.ShowDialog();
			if (frequency.DialogResult == DialogResult.OK)
			{
				project.Frequencies.Add(frequency.Frequency);
				FrequenciesListBox.Items.Add(frequency.Frequency);
			}
			Calculate();
		}

		private void editFrequencyButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = FrequenciesListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a frequency from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{

				var frequency = new FrequencyForm();
				var selectedElement = project.Frequencies[selectedIndex];
				frequency.Frequency = selectedElement;
				frequency.ShowDialog();
				if (frequency.DialogResult == DialogResult.OK)
				{
					project.Frequencies[selectedIndex] = frequency.Frequency;
				}
			}
			Calculate();
		}

		private void removeFrequencyButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = FrequenciesListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a frequency from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DialogResult result = MessageBox.Show("Do you really want to remove this frequency?",
							"Remove frequency", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				var selectedFrequency = project.Frequencies[selectedIndex];
				project.Frequencies.Remove(selectedFrequency);
				FrequenciesListBox.Items.RemoveAt(selectedIndex);
			}
		}

		private void FillCircuitNodes()
		{
			CircuitTreeView.Nodes.Clear();
			var segment = project.CircuitElement;
			foreach (var subSegment in segment.SubSegments)
			{
				SegmentTreeNode circuitNode = new SegmentTreeNode
				{
					Text = subSegment.Name,
					Segment = subSegment
				};
				FillTreeNode(circuitNode, subSegment);
				CircuitTreeView.Nodes.Add(circuitNode);
			}
		}

		private void FillTreeNode(SegmentTreeNode circuitNode, ISegment segment)
		{
			if (segment is IElement)
			{
				SegmentTreeNode elementNode = new SegmentTreeNode
				{
					Text = segment.ToString(),
					Segment = segment
				};
				circuitNode.Nodes.Add(elementNode);
			}
			else
			{
				foreach (var subSegment in segment.SubSegments)
				{
					SegmentTreeNode segmentNode = new SegmentTreeNode
					{
						Text = subSegment is IElement ? subSegment.ToString() : subSegment.Name,
						Segment = subSegment
					};
					circuitNode.Nodes.Add(segmentNode);
					if (!(subSegment is IElement))
					{
						FillTreeNode(segmentNode, subSegment);
					}
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

			CircuitsListBox.DataSource = null;
			CircuitsListBox.DataSource = project.Circuits;
			CircuitsListBox.DisplayMember = "Name";

			foreach (var i in project.Circuits)
			{
				i.SegmentChanged += ShowMessage;
			}
		}

		private void СircuitListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedIndexCircuit = CircuitsListBox.SelectedIndex;

			if (selectedIndexCircuit != -1)
			{
				project.CircuitElement = project.Circuits[selectedIndexCircuit];
				project.Elements = new List<IElement>();
				foreach (ISegment segment in project.CircuitElement.SubSegments)
				{
					project.AllElements(segment);
				}
			}
			Calculate();
			FillCircuitNodes();
		}

		private void Calculate()
		{
			project.Results = project.CircuitElement.CalculateZ(project.Frequencies);
			ImpedanceValues();
			ResultsListBox.DataSource = null;
			ResultsListBox.DataSource = project.ImpedanceValues;
		}

		private void ShowMessage(object sender, EventArgs e)
		{
			var message = e as ElementEventArgs;
			MessageBox.Show(message.Message, "Information",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ImpedanceValues()
		{
			project.ImpedanceValues = new List<string>();
			foreach (var i in project.Results)
			{
				project.ImpedanceValues.Add($"{i.Real} + {i.Imaginary}*j");
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var segment = new ElementForm();
			segment.ShowDialog();
			if (segment.DialogResult == DialogResult.OK)
			{
				if (segment.Segment is IElement element)
				{
					project.Elements.Add(element);
				}
				else
				{
					project.Segments.Add(segment.Segment);
				}
			}
			Calculate();
		}

		private void addCircuitButton_Click(object sender, EventArgs e)
		{
			var circuit = new CircuitForm();
			circuit.ShowDialog();
			if (circuit.DialogResult == DialogResult.OK)
			{
				project.Circuits.Add(circuit.Circiut);
				CircuitsListBox.DataSource = null;
				CircuitsListBox.DataSource = project.Circuits;
				CircuitsListBox.DisplayMember = "Name";
			}
		}

		private void editCircuitButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitsListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a circuit from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{

				var circuit = new CircuitForm();
				var selectedCircuit = project.Circuits[selectedIndex];
				circuit.Circiut = selectedCircuit;
				circuit.ShowDialog();
				if (circuit.DialogResult == DialogResult.OK)
				{
					project.Circuits[selectedIndex].Name = circuit.Circiut.Name;

					CircuitsListBox.DataSource = null;
					CircuitsListBox.DataSource = project.Circuits;
					CircuitsListBox.DisplayMember = "Name";
				}
			}
			Calculate();
		}

		private void removeCircuitButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitsListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a circuit from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DialogResult result = MessageBox.Show("Do you really want to remove this circuit?",
				"Remove circuit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				var selectedCircuit = project.Circuits[selectedIndex];
				project.Circuits.Remove(selectedCircuit);

				CircuitsListBox.DataSource = null;
				CircuitsListBox.DataSource = project.Circuits;
				CircuitsListBox.DisplayMember = "Name";
			}
		}

		private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
