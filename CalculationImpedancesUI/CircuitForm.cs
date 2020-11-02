using System;
using System.Windows.Forms;
using CalculationImpedancesApp;
using CalculationImpedancesApp.Circuits;

namespace CalculationImpedancesUI
{
	public partial class CircuitForm : Form
	{
		/// <summary>
		/// Used to create a new circuit.
		/// </summary>
		public Circuit NewCircuit { get; set; }

		public CircuitForm()
		{
			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			try
			{
				//TODO: RSDN (+)
				NewCircuit = new Circuit(nameTextBox.Text,
                    new SegmentsObservableCollection());
				this.DialogResult = DialogResult.OK;
			}
			catch (ArgumentException)
			{
				MessageBox.Show("Incorrect Name", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        //TODO: Не используемый обработчик (+)
		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
