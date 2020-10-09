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
using System.Security.Cryptography.X509Certificates;

namespace CalculationImpedancesUI
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// All program data.
		/// </summary>
		Project project = new Project();

		public readonly List<string> Type = new List<string>
		{
			"",
			"Resistor",
			"Inductor",
			"Capacitor",
		};

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

			CircuitSelectionComboBox.DataSource = null;
			CircuitSelectionComboBox.DataSource = project.Circuits;
			CircuitSelectionComboBox.DisplayMember = "Name";

			TypeComboBox.DataSource = Type;

			foreach (var i in project.Circuits)
			{
				i.SegmentChanged += ShowMessage;
			}
		}

		private void FillCircuitNodes() 
		{
			CircuitsTreeView.Nodes.Clear();
			var circuit = project.SelectedCircuit;
			SegmentTreeNode mainCircuitNode= new SegmentTreeNode
			{
				Text = circuit.Name,
			};
			CircuitsTreeView.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				SegmentTreeNode subSegmentNode = new SegmentTreeNode
				{
					Text = subSegment.Name,
					Segment = subSegment
				};
				FillTreeNode(subSegmentNode, subSegment);
				CircuitsTreeView.Nodes[0].Nodes.Add(subSegmentNode);
			}
			CircuitsTreeView.ExpandAll();
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

		private void CircuitSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)

		{
			var selectedIndexCircuit = CircuitSelectionComboBox.SelectedIndex;
			if (selectedIndexCircuit != -1)
			{
				project.SelectedCircuit = project.Circuits[selectedIndexCircuit];
			}

			Calculate();
			FillCircuitNodes();
		}
		
		private void addCircuitButton_Click(object sender, EventArgs e)
		{
			var circuit = new CircuitForm();
			circuit.ShowDialog();
			if (circuit.DialogResult == DialogResult.OK)
			{
				project.Circuits.Add(circuit.Circiut);
				CircuitSelectionComboBox.DataSource = null;
				CircuitSelectionComboBox.DataSource = project.Circuits;
				CircuitSelectionComboBox.DisplayMember = "Name";
			}
		}

		private void editCircuitButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitSelectionComboBox.SelectedIndex;
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

					CircuitSelectionComboBox.DataSource = null;
					CircuitSelectionComboBox.DataSource = project.Circuits;
					CircuitSelectionComboBox.DisplayMember = "Name";
				}
			}

			Calculate();
		}

		private void removeCircuitButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitSelectionComboBox.SelectedIndex;
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

				CircuitSelectionComboBox.DataSource = null;
				CircuitSelectionComboBox.DataSource = project.Circuits;
				CircuitSelectionComboBox.DisplayMember = "Name";
			}
		}

		private void CalculateButton_Click(object sender, EventArgs e)
		{
			if (FrequencyTextBox.Text.Length != 0)
			{
				try
				{
					project.Frequencies.Add(double.Parse(FrequencyTextBox.Text));
					FrequenciesListBox.Items.Add(double.Parse(FrequencyTextBox.Text));
				}
				catch
				{
					MessageBox.Show("Incorrect Value", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

			Calculate();
		}

		private void Calculate()
		{
			project.Results = project.SelectedCircuit.CalculateZ(project.Frequencies);
			ImpedanceValues();
			ResultsListBox.DataSource = null;
			ResultsListBox.DataSource = project.ImpedanceValues;
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

		private void AddElementButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (selectedIndex == null)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (selectedIndex == CircuitsTreeView.Nodes[0])
			{
				var element = CreateElement();
				if (element == null)
				{
					return;
				}
				project.SelectedCircuit.SubSegments.Add(element);
				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = element.ToString(),
					Segment = element
				});
			}
			else if (selectedIndex.Segment is IElement)
			{
				var parent = selectedIndex.Parent as SegmentTreeNode;
				var element = CreateElement();
				if (element == null)
				{
					return;
				}

				parent.Segment.SubSegments.Add(element);
				parent.Nodes.Add(new SegmentTreeNode
				{
					Text = element.ToString(),
					Segment = element
				});
			}
			else
			{
				var element = CreateElement();
				if (element == null)
				{
					return;
				}
				selectedIndex.Segment.SubSegments.Add(element);
				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = element.ToString(),
					Segment = element
				});
			}
			TypeComboBox.Text = "";
			NameTextBox.Text = "";
			ValueTextBox.Text = "";
			Calculate();
		}

		private void EditElementButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (selectedIndex == null)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (selectedIndex.Segment is IElement)
			{
				var parent = selectedIndex.Parent as SegmentTreeNode;
				var element = CreateElement();
				if (element == null)
				{
					return;
				}

				parent.Segment.SubSegments.Remove(selectedIndex.Segment);
				parent.Segment.SubSegments.Add(element);
				parent.Nodes.Remove(selectedIndex);
				parent.Nodes.Add(new SegmentTreeNode
				{
					Text = element.ToString(),
					Segment = element
				});
			}
			else
			{
				var element = CreateElement();
				if (element == null)
				{
					return;
				}
				selectedIndex.Segment.SubSegments.Remove(selectedIndex.Segment);
				selectedIndex.Segment.SubSegments.Add(element);
				selectedIndex.Nodes.Remove(selectedIndex);
				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = element.ToString(),
					Segment = element
				});
			}
			Calculate();
		}

		private void RemoveElementButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (selectedIndex == null)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

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
					project.SelectedCircuit.SubSegments.Remove(element);
				}
				else
				{
					parent.Segment.SubSegments.Remove(element);
				}
				parent.Nodes.Remove(selectedIndex);
			}
			Calculate();
		}

		private void AddParallelElementButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (selectedIndex == null)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (selectedIndex == CircuitsTreeView.Nodes[0])
			{
				var segment = new ParallelCircuit(new SegmentsObservableCollection());
				project.SelectedCircuit.SubSegments.Add(segment);
				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = "Parallel",
					Segment = segment
				});
			}
			else if (selectedIndex.Segment is IElement)
			{
				MessageBox.Show("Segment cannot be created from element", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				var segment = new ParallelCircuit(new SegmentsObservableCollection());
				selectedIndex.Segment.SubSegments.Add(segment);
				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = "Parallel",
					Segment = segment
				});
			}
		}

		private void AddSerialElementButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (selectedIndex == null)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (selectedIndex == CircuitsTreeView.Nodes[0])
			{
				var segment = new SerialCircuit(new SegmentsObservableCollection());
				project.SelectedCircuit.SubSegments.Add(segment);
				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = "Serial",
					Segment = segment
				});
			}
			else if (selectedIndex.Segment is IElement)
			{
				MessageBox.Show("Segment cannot be created from element", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				var segment = new SerialCircuit(new SegmentsObservableCollection());
				selectedIndex.Segment.SubSegments.Add(segment);
				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = "Serial",
					Segment = segment
				});
			}
		}

		private IElement CreateElement()
		{
			IElement segment = null;
			try
			{
				var name = NameTextBox.Text;
				var value = double.Parse(ValueTextBox.Text);
				switch (TypeComboBox.SelectedIndex)
				{
					case 1:
					{
						segment = new Resistor(name, value);
						break;
					}
					case 2:
					{
						segment = new Inductor(name, value);
						break;
					}
					case 3:
					{
						segment = new Capacitor(name, value);
						break;
					}
				}
			}
			catch (FormatException exception)
			{
				MessageBox.Show(exception.Message, "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return segment;
		}

		private void CircuitsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (selectedIndex == null)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (selectedIndex.Segment is Resistor)
			{
				TypeComboBox.Text = "Resistor";
			}
			else if (selectedIndex.Segment is Inductor)
			{
				TypeComboBox.Text = "Inductor";
			}
			else if (selectedIndex.Segment is Capacitor)
			{
				TypeComboBox.Text = "Capacitor";
			}
			else
			{
				TypeComboBox.Text = "";
			}

			if (selectedIndex.Segment is IElement element)
			{
				NameTextBox.Text = selectedIndex.Segment.Name;
				ValueTextBox.Text = element.Value.ToString();
				EditElementButton.Enabled = true;
			}
			else
			{
				TypeComboBox.Text = "";
				NameTextBox.Text = "";
				ValueTextBox.Text = "";
				EditElementButton.Enabled = false;
			}
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
	}
}

