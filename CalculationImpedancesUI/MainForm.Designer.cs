namespace CalculationImpedancesUI
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.FrequenciesListBox = new System.Windows.Forms.ListBox();
			this.CircuitsListBox = new System.Windows.Forms.ListBox();
			this.ResultsListBox = new System.Windows.Forms.ListBox();
			this.removeFrequencyButton = new System.Windows.Forms.Button();
			this.addFrequencyButton = new System.Windows.Forms.Button();
			this.editFrequencyButton = new System.Windows.Forms.Button();
			this.removeElementButton = new System.Windows.Forms.Button();
			this.addElementButton = new System.Windows.Forms.Button();
			this.editElementButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
			this.CircuitTreeView = new System.Windows.Forms.TreeView();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.removeCircuitButton = new System.Windows.Forms.Button();
			this.addCircuitButton = new System.Windows.Forms.Button();
			this.editCircuitButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel8.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel10.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel11.SuspendLayout();
			this.SuspendLayout();
			// 
			// FrequenciesListBox
			// 
			this.FrequenciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FrequenciesListBox.FormattingEnabled = true;
			this.FrequenciesListBox.ItemHeight = 16;
			this.FrequenciesListBox.Location = new System.Drawing.Point(578, 4);
			this.FrequenciesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.FrequenciesListBox.Name = "FrequenciesListBox";
			this.FrequenciesListBox.Size = new System.Drawing.Size(279, 212);
			this.FrequenciesListBox.TabIndex = 5;
			// 
			// CircuitsListBox
			// 
			this.CircuitsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CircuitsListBox.FormattingEnabled = true;
			this.CircuitsListBox.ItemHeight = 16;
			this.CircuitsListBox.Location = new System.Drawing.Point(4, 4);
			this.CircuitsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CircuitsListBox.Name = "CircuitsListBox";
			this.CircuitsListBox.Size = new System.Drawing.Size(279, 212);
			this.CircuitsListBox.TabIndex = 0;
			this.CircuitsListBox.SelectedIndexChanged += new System.EventHandler(this.СircuitListBox_SelectedIndexChanged);
			// 
			// ResultsListBox
			// 
			this.ResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsListBox.FormattingEnabled = true;
			this.ResultsListBox.ItemHeight = 16;
			this.ResultsListBox.Location = new System.Drawing.Point(865, 4);
			this.ResultsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ResultsListBox.Name = "ResultsListBox";
			this.ResultsListBox.Size = new System.Drawing.Size(282, 212);
			this.ResultsListBox.TabIndex = 6;
			// 
			// removeFrequencyButton
			// 
			this.removeFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.removeFrequencyButton.Location = new System.Drawing.Point(190, 4);
			this.removeFrequencyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.removeFrequencyButton.Name = "removeFrequencyButton";
			this.removeFrequencyButton.Size = new System.Drawing.Size(85, 32);
			this.removeFrequencyButton.TabIndex = 1;
			this.removeFrequencyButton.Text = "remove";
			this.removeFrequencyButton.UseVisualStyleBackColor = true;
			this.removeFrequencyButton.Click += new System.EventHandler(this.removeFrequencyButton_Click);
			// 
			// addFrequencyButton
			// 
			this.addFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addFrequencyButton.Location = new System.Drawing.Point(4, 4);
			this.addFrequencyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addFrequencyButton.Name = "addFrequencyButton";
			this.addFrequencyButton.Size = new System.Drawing.Size(85, 32);
			this.addFrequencyButton.TabIndex = 0;
			this.addFrequencyButton.Text = "add";
			this.addFrequencyButton.UseVisualStyleBackColor = true;
			this.addFrequencyButton.Click += new System.EventHandler(this.addFrequencyButton_Click);
			// 
			// editFrequencyButton
			// 
			this.editFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editFrequencyButton.Location = new System.Drawing.Point(97, 4);
			this.editFrequencyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.editFrequencyButton.Name = "editFrequencyButton";
			this.editFrequencyButton.Size = new System.Drawing.Size(85, 32);
			this.editFrequencyButton.TabIndex = 2;
			this.editFrequencyButton.Text = "edit";
			this.editFrequencyButton.UseVisualStyleBackColor = true;
			this.editFrequencyButton.Click += new System.EventHandler(this.editFrequencyButton_Click);
			// 
			// removeElementButton
			// 
			this.removeElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.removeElementButton.Location = new System.Drawing.Point(190, 4);
			this.removeElementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.removeElementButton.Name = "removeElementButton";
			this.removeElementButton.Size = new System.Drawing.Size(85, 32);
			this.removeElementButton.TabIndex = 8;
			this.removeElementButton.Text = "remove";
			this.removeElementButton.UseVisualStyleBackColor = true;
			// 
			// addElementButton
			// 
			this.addElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addElementButton.Location = new System.Drawing.Point(4, 4);
			this.addElementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addElementButton.Name = "addElementButton";
			this.addElementButton.Size = new System.Drawing.Size(85, 32);
			this.addElementButton.TabIndex = 8;
			this.addElementButton.Text = "add";
			this.addElementButton.UseVisualStyleBackColor = true;
			// 
			// editElementButton
			// 
			this.editElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editElementButton.Location = new System.Drawing.Point(97, 4);
			this.editElementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.editElementButton.Name = "editElementButton";
			this.editElementButton.Size = new System.Drawing.Size(85, 32);
			this.editElementButton.TabIndex = 1;
			this.editElementButton.Text = "edit";
			this.editElementButton.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel8.ColumnCount = 1;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 1);
			this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel8.Location = new System.Drawing.Point(1, 1);
			this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.36953F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.63047F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(1159, 703);
			this.tableLayoutPanel8.TabIndex = 1;
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel9.ColumnCount = 4;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 1, 1);
			this.tableLayoutPanel9.Controls.Add(this.CircuitTreeView, 1, 0);
			this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel9.Controls.Add(this.CircuitsListBox, 0, 0);
			this.tableLayoutPanel9.Controls.Add(this.ResultsListBox, 3, 0);
			this.tableLayoutPanel9.Controls.Add(this.FrequenciesListBox, 2, 0);
			this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel11, 2, 1);
			this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 421);
			this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 2;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.87037F));
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12963F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(1151, 278);
			this.tableLayoutPanel9.TabIndex = 0;
			// 
			// tableLayoutPanel10
			// 
			this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel10.ColumnCount = 3;
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel10.Controls.Add(this.editElementButton, 1, 0);
			this.tableLayoutPanel10.Controls.Add(this.removeElementButton, 2, 0);
			this.tableLayoutPanel10.Controls.Add(this.addElementButton, 0, 0);
			this.tableLayoutPanel10.Location = new System.Drawing.Point(291, 234);
			this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel10.Name = "tableLayoutPanel10";
			this.tableLayoutPanel10.RowCount = 1;
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel10.Size = new System.Drawing.Size(279, 40);
			this.tableLayoutPanel10.TabIndex = 7;
			// 
			// CircuitTreeView
			// 
			this.CircuitTreeView.Location = new System.Drawing.Point(291, 4);
			this.CircuitTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CircuitTreeView.Name = "CircuitTreeView";
			this.CircuitTreeView.Size = new System.Drawing.Size(277, 212);
			this.CircuitTreeView.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.Controls.Add(this.removeCircuitButton, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.addCircuitButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.editCircuitButton, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 234);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 40);
			this.tableLayoutPanel2.TabIndex = 9;
			// 
			// removeCircuitButton
			// 
			this.removeCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.removeCircuitButton.Location = new System.Drawing.Point(190, 4);
			this.removeCircuitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.removeCircuitButton.Name = "removeCircuitButton";
			this.removeCircuitButton.Size = new System.Drawing.Size(85, 32);
			this.removeCircuitButton.TabIndex = 8;
			this.removeCircuitButton.Text = "remove";
			this.removeCircuitButton.UseVisualStyleBackColor = true;
			this.removeCircuitButton.Click += new System.EventHandler(this.removeCircuitButton_Click);
			// 
			// addCircuitButton
			// 
			this.addCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addCircuitButton.Location = new System.Drawing.Point(4, 4);
			this.addCircuitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addCircuitButton.Name = "addCircuitButton";
			this.addCircuitButton.Size = new System.Drawing.Size(85, 32);
			this.addCircuitButton.TabIndex = 8;
			this.addCircuitButton.Text = "add";
			this.addCircuitButton.UseVisualStyleBackColor = true;
			this.addCircuitButton.Click += new System.EventHandler(this.addCircuitButton_Click);
			// 
			// editCircuitButton
			// 
			this.editCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editCircuitButton.Location = new System.Drawing.Point(97, 4);
			this.editCircuitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.editCircuitButton.Name = "editCircuitButton";
			this.editCircuitButton.Size = new System.Drawing.Size(85, 32);
			this.editCircuitButton.TabIndex = 1;
			this.editCircuitButton.Text = "edit";
			this.editCircuitButton.UseVisualStyleBackColor = true;
			this.editCircuitButton.Click += new System.EventHandler(this.editCircuitButton_Click);
			// 
			// tableLayoutPanel11
			// 
			this.tableLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel11.ColumnCount = 3;
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel11.Controls.Add(this.editFrequencyButton, 1, 0);
			this.tableLayoutPanel11.Controls.Add(this.removeFrequencyButton, 2, 0);
			this.tableLayoutPanel11.Controls.Add(this.addFrequencyButton, 0, 0);
			this.tableLayoutPanel11.Location = new System.Drawing.Point(578, 234);
			this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel11.Name = "tableLayoutPanel11";
			this.tableLayoutPanel11.RowCount = 1;
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel11.Size = new System.Drawing.Size(279, 40);
			this.tableLayoutPanel11.TabIndex = 8;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 409);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1160, 697);
			this.Controls.Add(this.tableLayoutPanel8);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximumSize = new System.Drawing.Size(1178, 744);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel10.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel11.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox FrequenciesListBox;
		private System.Windows.Forms.ListBox CircuitsListBox;
		private System.Windows.Forms.Button removeFrequencyButton;
		private System.Windows.Forms.Button addFrequencyButton;
		private System.Windows.Forms.Button editElementButton;
		private System.Windows.Forms.Button editFrequencyButton;
		private System.Windows.Forms.ListBox ResultsListBox;
		private System.Windows.Forms.Button removeElementButton;
		private System.Windows.Forms.Button addElementButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TreeView CircuitTreeView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button editCircuitButton;
		private System.Windows.Forms.Button removeCircuitButton;
		private System.Windows.Forms.Button addCircuitButton;
	}
}

