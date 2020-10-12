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
	public partial class SegmentForm : Form
	{
		public ISegment Segment { get; set; }
		public SegmentForm()
		{
			InitializeComponent();
		}

		public readonly List<string> SegmentType = new List<string>
		{
			"Serial",
			"Parallel"
		};

		private void OKButton_Click(object sender, EventArgs e)
		{
			switch (SegmentComboBox.SelectedIndex)
			{
				case 0:
				{
					Segment = new SerialCircuit(new SegmentsObservableCollection());
					break;
				}
				case 1:
				{
					Segment = new ParallelCircuit(new SegmentsObservableCollection());
					break;
				}
			}
            this.DialogResult = DialogResult.OK;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

        private void SegmentForm_Load(object sender, EventArgs e)
        {
            SegmentComboBox.DataSource = SegmentType;
		}
    }
}
