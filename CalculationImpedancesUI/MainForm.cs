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
        private List<Circuit> _circuits = new List<Circuit>();

        private List<IElement> _elements = new List<IElement>();

        private List<double> _frequencies = new List<double>();

        private List<Complex> _results = new List<Complex>();

        private Circuit SupportCircuitry = null;

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
                var selectedElement = _elements[selectedIndex];
                element.Value = selectedElement.Value;
                element.ShowDialog();
                if (element.DialogResult == DialogResult.OK)
                {
                    selectedElement.Value = element.Value;
                    ElementsListBox.DataSource = null;
                    ElementsListBox.DataSource = _elements;
                    //ElementsListBox.Items.RemoveAt(selectedIndex);
                    //_elements.Remove(selectedElement);
                    //_elements.Insert(selectedIndex, element.Element);
                    //ElementsListBox.Items.Insert(selectedIndex, element.Element);
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
                _frequencies.Add(frequency.Frequency);
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
                var selectedElement = _frequencies[selectedIndex];
                frequency.Frequency = selectedElement;
                frequency.ShowDialog();
                if (frequency.DialogResult == DialogResult.OK)
                {

                    FrequenciesListBox.Items.RemoveAt(selectedIndex);
                    _frequencies.Remove(selectedElement);
                    _frequencies.Insert(selectedIndex, frequency.Frequency);
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
                var selectedContact = _frequencies[selectedIndex];
                _frequencies.Remove(selectedContact);
                FrequenciesListBox.Items.RemoveAt(selectedIndex);
            }
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            List<IElement> elements = new List<IElement>
            {
                new Resistor("i694", 30.0),
                new Resistor("86u", 45.4),
                new Inductor("ut7", 32.6),
                new Inductor("it6", 33.9)
            };
            _circuits.Add(new Circuit("Circuit No. 1", elements));

            elements = new List<IElement>
            {
                new Inductor("re94", 20.0),
                new Resistor("8u", 5.3),
                new Inductor("2e7", 12.2),
                new Capacitor("ft5", 36.0)
            };
            _circuits.Add(new Circuit("Circuit No. 2", elements));

            elements = new List<IElement>
            {
                new Capacitor("ty6", 12.4),
                new Capacitor("fb7", 17.4),
                new Inductor("j877", 56.7),
                new Capacitor("df56", 21.0)
            };
            _circuits.Add(new Circuit("Circuit No. 3", elements));

            elements = new List<IElement>
            {
                new Resistor("re4", 11.1),
                new Capacitor("bg7", 66.4),
                new Inductor("21e", 38.6),
                new Inductor("ki4", 90.7)
            };
            _circuits.Add(new Circuit("Circuit No. 4", elements));


            elements = new List<IElement>
            {
                new Resistor("mb6", 21.7),
                new Resistor("w2", 2.3),
                new Capacitor("hji", 6.2),
                new Inductor("r43", 3.0)
            };
            _circuits.Add(new Circuit("Circuit No. 5", elements));

            ChainsListBox.DataSource = null;
            ChainsListBox.DataSource = _circuits;
            ChainsListBox.DisplayMember = "Name";

            foreach (var i in _circuits)
            {
                i.CircuitChangetEvent += Message;
            }
        }

        private void ChainsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndexCircuit = ChainsListBox.SelectedIndex;

            if (selectedIndexCircuit != -1)
            {
                SupportCircuitry = _circuits[selectedIndexCircuit];
                _elements = SupportCircuitry.Elements;
                ElementsListBox.DataSource = null;
                ElementsListBox.DataSource = SupportCircuitry.Elements;
                ElementsListBox.DisplayMember = "Name";
            }
            Calculate();
        }

        private void Calculate()
        {
            _results = SupportCircuitry.CalculateZ(_frequencies);
            ResultsListBox.DataSource = null;
            ResultsListBox.DataSource = _results;
        }

        private void Message(object sender, object e)
        {
            MessageBox.Show(e.ToString(), "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
