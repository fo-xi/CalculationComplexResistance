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
        public IElement Element { set; get; }

        public ElementForm()
        {
            InitializeComponent();
        }

        private void DisplayInformation(object sender, EventArgs e)
        {
            if (Element != null)
            {
                elementTextBox.Text = Convert.ToString(Element.Value);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
