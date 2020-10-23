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
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace CalculationImpedancesUI
{
	public partial class MainForm : Form
	{
		//TODO: Зачем публично? (+)
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
		}

		private void AddCircuitButton_Click(object sender, EventArgs e)
		{
			var circuit = new CircuitForm();
			circuit.ShowDialog();
			if (circuit.DialogResult == DialogResult.OK)
			{
				Project.Circuits.Add(circuit.NewCirciut);
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
				circuit.NewCirciut = selectedCircuit;
				circuit.ShowDialog();
				if (circuit.DialogResult == DialogResult.OK)
				{
					Project.Circuits[selectedIndex].Name = circuit.NewCirciut.Name;
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
	}
}