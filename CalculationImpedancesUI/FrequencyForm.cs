using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationImpedancesUI
{
	public partial class FrequencyForm : Form
	{
		/// <summary>
		/// Frequency entered.
		/// </summary>
		public double Frequency { get; set; }

		public FrequencyForm()
		{
			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			if (frequencyTextBox.Text.Length != 0)
			{
				try
				{
					Frequency = double.Parse(frequencyTextBox.Text);
					this.DialogResult = DialogResult.OK;
				}
				catch
				{
					MessageBox.Show("Incorrect Value", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
