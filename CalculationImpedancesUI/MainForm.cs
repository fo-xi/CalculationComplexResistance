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

namespace CalculationImpedances
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

		private void editElementButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = ElementsListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				var element = new ElementForm();
				var selectedElement = project.Elements[selectedIndex];
				element.Value = selectedElement.Value;
				element.ShowDialog();
				if (element.DialogResult == DialogResult.OK)
				{
					selectedElement.Value = element.Value;
					ElementsListBox.DataSource = null;
					ElementsListBox.DataSource = project.Elements;
				}
			}
			Calculate();
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

					FrequenciesListBox.Items.RemoveAt(selectedIndex);
					project.Frequencies.Remove(selectedElement);
					project.Frequencies.Insert(selectedIndex, frequency.Frequency);
					FrequenciesListBox.Items.Insert(selectedIndex, frequency.Frequency);
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
				var selectedContact = project.Frequencies[selectedIndex];
				project.Frequencies.Remove(selectedContact);
				FrequenciesListBox.Items.RemoveAt(selectedIndex);
			}
		}

		private void FillCircuitNodes()
		{
			var circuits = project.Circuits;
			foreach (var circuit in circuits)
			{
				TreeNode circuitNode = new TreeNode
				{
					Text = circuit.Name
				};
				
				FillTreeNode(circuitNode, circuit);
				CircuitTreeView.Nodes.Add(circuitNode);
			}
		}

		private void FillTreeNode(TreeNode circuitNode, ISegment segment)
		{
			if (segment is IElement)
			{
				TreeNode elementNode = new TreeNode
				{
					Text = segment.Name
				};
				circuitNode.Nodes.Add(elementNode);
			}
			else
			{
				foreach (var subSegment in segment.SubSegments)
				{
					TreeNode segmentNode = new TreeNode
					{
						Text = subSegment.Name
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
			FillCircuitNodes();

			СircuitListBox.DataSource = null;
			СircuitListBox.DataSource = project.Circuits;
			СircuitListBox.DisplayMember = "Name";

			foreach (var i in project.Circuits)
			{
				i.SegmentChanged += ShowMessage;
			}
		}

		private void СircuitListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedIndexCircuit = СircuitListBox.SelectedIndex;

			if (selectedIndexCircuit != -1)
			{
				project.CircuitElement = project.Circuits[selectedIndexCircuit];
				project.Elements = new List<IElement>();
				foreach(ISegment segment in project.CircuitElement.SubSegments)
                {
					project.AllElements(segment);
				}
				ElementsListBox.DataSource = null;
				ElementsListBox.DataSource = project.Elements;
			}
			Calculate();
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
				else if (segment.Segment is Circuit circiut)
				{
					project.Segments.Add(circiut);
				}
				else
				{
					project.Segments.Add(segment.Segment);
				}
			}
			Calculate();
		}
	}
}
