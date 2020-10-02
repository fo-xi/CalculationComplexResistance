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

namespace CalculationImpedancesUI
{
	public partial class ElementForm : Form
	{
		/// <summary>
		/// Entered element value.
		/// </summary>
		public double Value { get; set; }

		/// <summary>
		/// Entered element Circiut.
		/// </summary>
		public string Name { get; set; }

		public readonly List<string> Type = new List<string>
		{
			" ",
			"Resistor",
			"Inductor",
			"Capacitor",
			"Serial circuit",
			"Parallel circuit",
		};

		public ISegment Segment = null;

		public ElementForm()
		{
			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			if ((valueTextBox.Text.Length != 0) && (nameTextBox.Text.Length != 0))
			{
				try
				{
					Name = nameTextBox.Text;
					Value = double.Parse(valueTextBox.Text);
					switch (typeComboBox.SelectedIndex)
					{
						case 1:
						{
							Segment = new Resistor(Name, Value);
							break;
						}
						case 2:
						{
							Segment = new Inductor(Name, Value);
							break;
						}
						case 3:
						{
							Segment = new Capacitor(Name, Value);
							break;
						}
						case 4:
						{
							Segment = new SerialCircuit(Name, new SegmentsObservableCollection());
							break;
						}
						case 5:
						{
							Segment = new ParallelCircuit(Name, new SegmentsObservableCollection());
							break;
						}
					}

					this.DialogResult = DialogResult.OK;
				}
				catch (ArgumentException exception)
				{
					MessageBox.Show(exception.Message, "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void ElementForm_Load(object sender, EventArgs e)
		{

			typeComboBox.DataSource = Type;
		}

		private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (typeComboBox.SelectedIndex)
			{
				case 1:
				{
					valueTextBox.Enabled = true;
					break;
				}
				case 2:
				{
					valueTextBox.Enabled = true;
					break;
				}
				case 3:
				{
					valueTextBox.Enabled = true;
					break;
				}
				case 4:
				{
					valueTextBox.Enabled = false;
					break;
				}
				case 5:
				{
					valueTextBox.Enabled = false;
					break;
				}
			}
		}
	}
}