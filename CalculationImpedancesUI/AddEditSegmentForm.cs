using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CalculationImpedancesApp;
using CalculationImpedancesApp.Elements;

namespace CalculationImpedancesUI
{
	public partial class AddEditSegmentForm : Form
	{
		/// <summary>
		/// New circuit element.
		/// </summary>
		public IElement NewElement { get; set; }

		//TODO: RSDN - именование (+)
		/// <summary>
		/// _elementType of new circuit element.
		/// </summary>
		private readonly List<string> _elementType = new List<string>
		{
			"",
			"Resistor",
			"Inductor",
			"Capacitor",
		};

		public AddEditSegmentForm()
		{
			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			var name = NameTextBox.Text;
			if (!double.TryParse(ValueTextBox.Text, out var value))
			{
				MessageBox.Show("Wrong value", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				switch (TypeComboBox.SelectedIndex)
				{
					//TODO: RSDN (+)
					case 1:
						{
							NewElement = new Resistor(name, value);
							break;
						}
					case 2:
						{
							NewElement = new Inductor(name, value);
							break;
						}
					case 3:
						{
							NewElement = new Capacitor(name, value);
							break;
						}
					default:
						{
							MessageBox.Show("Select segment type", "Warning",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}
				}
			}
			catch (ArgumentException exception)
			{
				MessageBox.Show("Enter element name", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			this.DialogResult = DialogResult.OK;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void ElementForm_Load(object sender, EventArgs e)
		{
			TypeComboBox.DataSource = _elementType;

			if (NewElement == null)
			{
				return;
			}

			if (NewElement is Resistor)
			{
				TypeComboBox.Text = "Resistor";
			}
			else if (NewElement is Inductor)
			{
				TypeComboBox.Text = "Inductor";
			}
			else
			{
				TypeComboBox.Text = "Capacitor";
			}

			NameTextBox.Text = NewElement.Name;
			ValueTextBox.Text = NewElement.Value.ToString();
		}
	}
}
