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
	public partial class CircuitForm : Form
	{
		//TODO: RSDN (+)
		/// <summary>
		/// New circuit.
		/// </summary>
		public Circuit NewCirciut { get; set; }

		public CircuitForm()
		{
			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			try
			{
				NewCirciut = new Circuit(nameTextBox.Text, new SegmentsObservableCollection());
				this.DialogResult = DialogResult.OK;
			}
			catch (ArgumentException)
			{
				MessageBox.Show("Incorrect Value", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
    }
}
