using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CalculationImpedancesApp;

namespace CalculationImpedancesUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			TreeViewControl.NotifyCalculate += Calculate;
			UpdateComboBox();
			foreach (var i in Project.Circuits)
			{
				i.SegmentChanged += ShowMessage;
			}
		}

		private void CircuitSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedIndexCircuit = CircuitSelectionComboBox.SelectedIndex;
			if (selectedIndexCircuit != -1)
			{
				Project.SelectedCircuit = Project.Circuits[selectedIndexCircuit];
			}

			Calculate();
			TreeViewManager.FillCircuitNodes(Project.SelectedCircuit);
			UpdatePictureBox();
		}

		private void AddCircuitButton_Click(object sender, EventArgs e)
		{
			var circuit = new CircuitForm();
			circuit.ShowDialog();
			if (circuit.DialogResult == DialogResult.OK)
			{
				Project.Circuits.Add(circuit.NewCircuit);
				//TODO: Дубль (+)
				UpdateComboBox();
			}
		}

		private void EditCircuitButton_Click(object sender, EventArgs e)
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
				var selectedCircuit = Project.Circuits[selectedIndex];
				circuit.NewCircuit = selectedCircuit;
				circuit.ShowDialog();
				if (circuit.DialogResult == DialogResult.OK)
				{
					Project.Circuits[selectedIndex].Name = circuit.NewCircuit.Name;
					//TODO: Дубль (+)
					UpdateComboBox();
				}
				Calculate();
			}
		}

		private void RemoveCircuitButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitSelectionComboBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a circuit from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			//TODO: RSDN (+)
			var result = MessageBox.Show("Do you really want to remove this circuit?",
				"Remove Circuit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				var selectedCircuit = Project.Circuits[selectedIndex];
				Project.Circuits.Remove(selectedCircuit);
				//TODO: Дубль (+)
				UpdateComboBox();
			}
		}

		private void CalculateButton_Click(object sender, EventArgs e)
		{
			if (FrequencyTextBox.Text.Length != 0)
			{
				try
				{
					Project.Frequencies.Add(double.Parse(FrequencyTextBox.Text));
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
			Project.Results = Project.SelectedCircuit.CalculateZ(Project.Frequencies);
			ImpedanceValues();
			ResultsListBox.DataSource = null;
			ResultsListBox.DataSource = Project.ImpedanceValues;
			UpdatePictureBox();
		}

		private void RemoveFrequencyButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = FrequenciesListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a frequency from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var result = MessageBox.Show("Do you really want to remove this frequency?",
				"Remove Frequency", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				Project.Frequencies.RemoveAt(selectedIndex);
				FrequenciesListBox.Items.RemoveAt(selectedIndex);
			}
		}

		private void ShowMessage(object sender, EventArgs e)
		{
			//var message = e as ElementEventArgs;
			//MessageBox.Show(message.Message, "Information",
			//	MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ImpedanceValues()
		{
			Project.ImpedanceValues = new List<string>();
			foreach (var i in Project.Results)
			{
				Project.ImpedanceValues.Add($"{Math.Round(i.Real, 5)} " +
				                            $"+ {Math.Round(i.Imaginary, 5)}*j");
			}
		}

		private void UpdateComboBox()
		{
			CircuitSelectionComboBox.DataSource = null;
			CircuitSelectionComboBox.DataSource = Project.Circuits;
			CircuitSelectionComboBox.DisplayMember = "Name";
		}

		private void UpdatePictureBox()
		{
			Manager.FillCircuitNodes(Project.SelectedCircuit);
			var circuitSize = Manager.CalculateCircuitSize();
			Bitmap bitmap = new Bitmap(circuitSize.Width, circuitSize.Height);
			DrawSegment.Graphics = Graphics.FromImage(bitmap);
			DrawSegment.Pen = new Pen(Color.Black);

			Manager.FindCoordinateNode();
			Manager.Draw(DrawSegment.Graphics, DrawSegment.Pen);

			PictureBox.Image = bitmap;
		}
	}
}