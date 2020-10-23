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
		//TODO: RSDN? (+)
		/// <summary>
		/// Used to create a new circuit segment.
		/// </summary>
		public ISegment NewSegment { get; set; }
		public SegmentForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// New circuit segment type.
		/// </summary>
		//TODO: Почему публично? (+)
		private readonly List<string> SegmentType = new List<string>
		{
			"Serial",
			"Parallel"
		};

		private void OKButton_Click(object sender, EventArgs e)
		{
			var tempSubSegments = NewSegment != null ? NewSegment.SubSegments : new SegmentsObservableCollection();
			switch (TypeComboBox.SelectedIndex)
			{
				case 0:
				{
					NewSegment = new SerialCircuit(tempSubSegments);
					break;
				}
				case 1:
				{
					NewSegment = new ParallelCircuit(tempSubSegments);
					break;
				}
			}
			this.DialogResult = DialogResult.OK;
		}

		private void SegmentForm_Load(object sender, EventArgs e)
		{
			TypeComboBox.DataSource = SegmentType;

			if (NewSegment == null)
			{
				return;
			}

			if (NewSegment is ParallelCircuit)
			{
				TypeComboBox.Text = "Parallel";
			}
			else
			{
				TypeComboBox.Text = "Serial";
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}

