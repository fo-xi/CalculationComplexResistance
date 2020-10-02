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

namespace CalculationImpedances
{
	public partial class ElementForm : Form
	{
		/// <summary>
		/// Entered element value.
		/// </summary>
		public double Value { get; set; }

		public ElementForm()
		{
			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			if (elementTextBox.Text.Length != 0)
			{
				try
				{
					Value = double.Parse(elementTextBox.Text);
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
	}
}
