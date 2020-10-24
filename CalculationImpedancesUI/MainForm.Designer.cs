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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.FrequenciesListBox = new System.Windows.Forms.ListBox();
			this.ResultsListBox = new System.Windows.Forms.ListBox();
			this.CircuitsGroupBox = new System.Windows.Forms.GroupBox();
			this.TreeViewControl = new CalculationImpedancesUI.TreeViewControl();
			this.CircuitSelectionComboBox = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.AddCircuitButton = new System.Windows.Forms.Button();
			this.ImpedancesGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.FrequencyTextBox = new System.Windows.Forms.TextBox();
			this.FrequencyLabel = new System.Windows.Forms.Label();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.RemoveFrequencyButton = new System.Windows.Forms.Button();
			this.CircuitsGroupBox.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.ImpedancesGroupBox.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// FrequenciesListBox
			// 
			this.FrequenciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FrequenciesListBox.FormattingEnabled = true;
			this.FrequenciesListBox.Location = new System.Drawing.Point(3, 3);
			this.FrequenciesListBox.Name = "FrequenciesListBox";
			this.FrequenciesListBox.Size = new System.Drawing.Size(307, 121);
			this.FrequenciesListBox.TabIndex = 5;
			// 
			// ResultsListBox
			// 
			this.ResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsListBox.FormattingEnabled = true;
			this.ResultsListBox.Location = new System.Drawing.Point(316, 3);
			this.ResultsListBox.Name = "ResultsListBox";
			this.ResultsListBox.Size = new System.Drawing.Size(308, 121);
			this.ResultsListBox.TabIndex = 6;
			// 
			// CircuitsGroupBox
			// 
			this.CircuitsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.CircuitsGroupBox.Controls.Add(this.TreeViewControl);
			this.CircuitsGroupBox.Controls.Add(this.CircuitSelectionComboBox);
			this.CircuitsGroupBox.Controls.Add(this.tableLayoutPanel3);
			this.CircuitsGroupBox.Location = new System.Drawing.Point(15, 12);
			this.CircuitsGroupBox.Name = "CircuitsGroupBox";
			this.CircuitsGroupBox.Size = new System.Drawing.Size(267, 612);
			this.CircuitsGroupBox.TabIndex = 1;
			this.CircuitsGroupBox.TabStop = false;
			this.CircuitsGroupBox.Text = "Circuits";
			// 
			// TreeViewControl
			// 
			this.TreeViewControl.AllowDrop = true;
			this.TreeViewControl.Location = new System.Drawing.Point(6, 88);
			this.TreeViewControl.Name = "TreeViewControl";
			this.TreeViewControl.Size = new System.Drawing.Size(255, 456);
			this.TreeViewControl.TabIndex = 2;
			// 
			// CircuitSelectionComboBox
			// 
			this.CircuitSelectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CircuitSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CircuitSelectionComboBox.FormattingEnabled = true;
			this.CircuitSelectionComboBox.Location = new System.Drawing.Point(6, 19);
			this.CircuitSelectionComboBox.Name = "CircuitSelectionComboBox";
			this.CircuitSelectionComboBox.Size = new System.Drawing.Size(255, 21);
			this.CircuitSelectionComboBox.TabIndex = 1;
			this.CircuitSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.CircuitSelectionComboBox_SelectedIndexChanged);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.Controls.Add(this.RemoveButton, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.EditButton, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.AddCircuitButton, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 46);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(106, 36);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// RemoveButton
			// 
			this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.minus;
			this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveButton.ForeColor = System.Drawing.SystemColors.Control;
			this.RemoveButton.Location = new System.Drawing.Point(73, 3);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(30, 30);
			this.RemoveButton.TabIndex = 2;
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveCircuitButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.edit_button;
			this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.ForeColor = System.Drawing.SystemColors.Control;
			this.EditButton.Location = new System.Drawing.Point(38, 3);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(29, 30);
			this.EditButton.TabIndex = 1;
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditCircuitButton_Click);
			// 
			// AddCircuitButton
			// 
			this.AddCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddCircuitButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.add;
			this.AddCircuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.AddCircuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddCircuitButton.ForeColor = System.Drawing.SystemColors.Control;
			this.AddCircuitButton.Location = new System.Drawing.Point(3, 3);
			this.AddCircuitButton.Name = "AddCircuitButton";
			this.AddCircuitButton.Size = new System.Drawing.Size(29, 30);
			this.AddCircuitButton.TabIndex = 3;
			this.AddCircuitButton.UseVisualStyleBackColor = true;
			this.AddCircuitButton.Click += new System.EventHandler(this.AddCircuitButton_Click);
			// 
			// ImpedancesGroupBox
			// 
			this.ImpedancesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImpedancesGroupBox.Controls.Add(this.tableLayoutPanel5);
			this.ImpedancesGroupBox.Controls.Add(this.tableLayoutPanel4);
			this.ImpedancesGroupBox.Location = new System.Drawing.Point(288, 434);
			this.ImpedancesGroupBox.Name = "ImpedancesGroupBox";
			this.ImpedancesGroupBox.Size = new System.Drawing.Size(639, 190);
			this.ImpedancesGroupBox.TabIndex = 3;
			this.ImpedancesGroupBox.TabStop = false;
			this.ImpedancesGroupBox.Text = "Impedances";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.FrequenciesListBox, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.ResultsListBox, 1, 0);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 15);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(627, 130);
			this.tableLayoutPanel5.TabIndex = 4;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel4.ColumnCount = 4;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.90129F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.09871F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel4.Controls.Add(this.FrequencyTextBox, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.FrequencyLabel, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.CalculateButton, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.RemoveFrequencyButton, 3, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 148);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(310, 36);
			this.tableLayoutPanel4.TabIndex = 3;
			// 
			// FrequencyTextBox
			// 
			this.FrequencyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FrequencyTextBox.Location = new System.Drawing.Point(76, 8);
			this.FrequencyTextBox.Name = "FrequencyTextBox";
			this.FrequencyTextBox.Size = new System.Drawing.Size(158, 20);
			this.FrequencyTextBox.TabIndex = 1;
			this.FrequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FrequencyLabel
			// 
			this.FrequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.FrequencyLabel.AutoSize = true;
			this.FrequencyLabel.Location = new System.Drawing.Point(10, 11);
			this.FrequencyLabel.Name = "FrequencyLabel";
			this.FrequencyLabel.Size = new System.Drawing.Size(60, 13);
			this.FrequencyLabel.TabIndex = 0;
			this.FrequencyLabel.Text = "Frequency:";
			// 
			// CalculateButton
			// 
			this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CalculateButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.add;
			this.CalculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CalculateButton.ForeColor = System.Drawing.SystemColors.Control;
			this.CalculateButton.Location = new System.Drawing.Point(240, 3);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(29, 30);
			this.CalculateButton.TabIndex = 0;
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// RemoveFrequencyButton
			// 
			this.RemoveFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveFrequencyButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.minus;
			this.RemoveFrequencyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.RemoveFrequencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveFrequencyButton.ForeColor = System.Drawing.SystemColors.Control;
			this.RemoveFrequencyButton.Location = new System.Drawing.Point(275, 3);
			this.RemoveFrequencyButton.Name = "RemoveFrequencyButton";
			this.RemoveFrequencyButton.Size = new System.Drawing.Size(32, 30);
			this.RemoveFrequencyButton.TabIndex = 1;
			this.RemoveFrequencyButton.UseVisualStyleBackColor = true;
			this.RemoveFrequencyButton.Click += new System.EventHandler(this.RemoveFrequencyButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 636);
			this.Controls.Add(this.ImpedancesGroupBox);
			this.Controls.Add(this.CircuitsGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(955, 675);
			this.Name = "MainForm";
			this.Text = "CalculationImpedancesApp";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.CircuitsGroupBox.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ImpedancesGroupBox.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox FrequenciesListBox;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.GroupBox CircuitsGroupBox;
        private System.Windows.Forms.GroupBox ImpedancesGroupBox;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.TextBox FrequencyTextBox;
        private System.Windows.Forms.Button RemoveFrequencyButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.ComboBox CircuitSelectionComboBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button AddCircuitButton;
		private TreeViewControl TreeViewControl;
	}
}