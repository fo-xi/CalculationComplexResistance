namespace CalculationImpedancesUI
{
	partial class SegmentForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.CancelButton = new System.Windows.Forms.Button();
			this.OKButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.SegmentLabel = new System.Windows.Forms.Label();
			this.SegmentComboBox = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.CancelButton, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.OKButton, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(103, 42);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(154, 33);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(80, 3);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(71, 27);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// OKButton
			// 
			this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OKButton.Location = new System.Drawing.Point(3, 3);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(71, 27);
			this.OKButton.TabIndex = 0;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.46939F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.53061F));
			this.tableLayoutPanel3.Controls.Add(this.SegmentLabel, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.SegmentComboBox, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(245, 28);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// SegmentLabel
			// 
			this.SegmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.SegmentLabel.AutoSize = true;
			this.SegmentLabel.Location = new System.Drawing.Point(4, 7);
			this.SegmentLabel.Name = "SegmentLabel";
			this.SegmentLabel.Size = new System.Drawing.Size(74, 13);
			this.SegmentLabel.TabIndex = 0;
			this.SegmentLabel.Text = "NewSegment:";
			this.SegmentLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// SegmentComboBox
			// 
			this.SegmentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SegmentComboBox.FormattingEnabled = true;
			this.SegmentComboBox.Location = new System.Drawing.Point(84, 3);
			this.SegmentComboBox.Name = "SegmentComboBox";
			this.SegmentComboBox.Size = new System.Drawing.Size(158, 21);
			this.SegmentComboBox.TabIndex = 1;
			// 
			// SegmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 86);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel3);
			this.MaximumSize = new System.Drawing.Size(285, 125);
			this.MinimumSize = new System.Drawing.Size(285, 125);
			this.Name = "SegmentForm";
			this.Text = "SegmentForm";
			this.Load += new System.EventHandler(this.SegmentForm_Load);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label SegmentLabel;
		private System.Windows.Forms.ComboBox SegmentComboBox;
	}
}