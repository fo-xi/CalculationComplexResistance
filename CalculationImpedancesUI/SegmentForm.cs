using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CalculationImpedancesApp;
using CalculationImpedancesApp.Circuits;

namespace CalculationImpedancesUI
{
	public partial class SegmentForm : Form
	{
		/// <summary>
		/// Used to create a new circuit segment.
		/// </summary>
		public ISegment NewSegment { get; set; }

		/// <summary>
		/// New circuit segment type.
		/// </summary>
		//TODO: RSDN (+)
		private readonly List<string> _segmentType = new List<string>
		{
			"Serial",
			"Parallel"
		};

		public SegmentForm()
		{
			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			//TODO: RSDN (+)
			var tempSubSegments = NewSegment != null
				? NewSegment.SubSegments : new SegmentsObservableCollection();
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
			TypeComboBox.DataSource = _segmentType;

			if (NewSegment == null)
			{
				return;
			}
			//TODO: switch-case (+)
			switch (NewSegment)
			{
				case ParallelCircuit parallelCircuit:
					{
						TypeComboBox.Text = "Parallel";
						break;
					}
				case SerialCircuit serialCircuit:
					{
						TypeComboBox.Text = "Serial";
						break;
					}
				default:
					{
						return;
					}
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
