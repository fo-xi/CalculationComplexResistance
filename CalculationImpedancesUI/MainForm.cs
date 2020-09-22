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
                var selectedElement = project._elements[selectedIndex];
                element.Value = selectedElement.Value;
                element.ShowDialog();
                if (element.DialogResult == DialogResult.OK)
                {
                    selectedElement.Value = element.Value;
                    ElementsListBox.DataSource = null;
                    ElementsListBox.DataSource = project._elements;
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
                project._frequencies.Add(frequency.Frequency);
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
                var selectedElement = project._frequencies[selectedIndex];
                frequency.Frequency = selectedElement;
                frequency.ShowDialog();
                if (frequency.DialogResult == DialogResult.OK)
                {

                    FrequenciesListBox.Items.RemoveAt(selectedIndex);
                    project._frequencies.Remove(selectedElement);
                    project._frequencies.Insert(selectedIndex, frequency.Frequency);
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
                var selectedContact = project._frequencies[selectedIndex];
                project._frequencies.Remove(selectedContact);
                FrequenciesListBox.Items.RemoveAt(selectedIndex);
            }
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            ChainsListBox.DataSource = null;
            ChainsListBox.DataSource = project._circuits;
            ChainsListBox.DisplayMember = "Name";

            foreach (var i in project._circuits)
            {
                i.CircuitChanged += ShowMessage;
            }
        }

        private void ChainsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndexCircuit = ChainsListBox.SelectedIndex;

            if (selectedIndexCircuit != -1)
            {
                project.CircuitElement = project._circuits[selectedIndexCircuit];
                project._elements = project.CircuitElement.Elements;
                ElementsListBox.DataSource = null;
                ElementsListBox.DataSource = project.CircuitElement.Elements;
            }
            Calculate();
        }

        private void Calculate()
        {
            project._results = project.CircuitElement.CalculateZ(project._frequencies);
            ResultsListBox.DataSource = null;
            ResultsListBox.DataSource = project._results;
        }

        private void ShowMessage(object sender, object e)
        {
            MessageBox.Show(e.ToString(), "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
