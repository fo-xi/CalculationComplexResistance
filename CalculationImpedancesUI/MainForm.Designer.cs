namespace CalculationImpedances
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
			this.ElementsListBox = new System.Windows.Forms.ListBox();
			this.СircuitListBox = new System.Windows.Forms.ListBox();
			this.ResultsListBox = new System.Windows.Forms.ListBox();
			this.removeFrequencyButton = new System.Windows.Forms.Button();
			this.addFrequencyButton = new System.Windows.Forms.Button();
			this.editFrequencyButton = new System.Windows.Forms.Button();
			this.removeElementButton = new System.Windows.Forms.Button();
			this.addElementButton = new System.Windows.Forms.Button();
			this.editElementButton = new System.Windows.Forms.Button();
			this.removeCitcuitButton = new System.Windows.Forms.Button();
			this.editCitcuitButton = new System.Windows.Forms.Button();
			this.addCitcuitButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel10.SuspendLayout();
			this.tableLayoutPanel11.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// FrequenciesListBox
			// 
			this.FrequenciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FrequenciesListBox.FormattingEnabled = true;
			this.FrequenciesListBox.Location = new System.Drawing.Point(206, 3);
			this.FrequenciesListBox.Name = "FrequenciesListBox";
			this.FrequenciesListBox.Size = new System.Drawing.Size(197, 186);
			this.FrequenciesListBox.TabIndex = 5;
			// 
			// ElementsListBox
			// 
			this.ElementsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ElementsListBox.FormattingEnabled = true;
			this.ElementsListBox.Location = new System.Drawing.Point(3, 3);
			this.ElementsListBox.Name = "ElementsListBox";
			this.ElementsListBox.Size = new System.Drawing.Size(197, 186);
			this.ElementsListBox.TabIndex = 4;
			// 
			// СircuitListBox
			// 
			this.СircuitListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.СircuitListBox.FormattingEnabled = true;
			this.СircuitListBox.Location = new System.Drawing.Point(3, 6);
			this.СircuitListBox.Name = "СircuitListBox";
			this.СircuitListBox.Size = new System.Drawing.Size(228, 498);
			this.СircuitListBox.TabIndex = 0;
			this.СircuitListBox.SelectedIndexChanged += new System.EventHandler(this.ChainsListBox_SelectedIndexChanged);
			// 
			// ResultsListBox
			// 
			this.ResultsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ResultsListBox.FormattingEnabled = true;
			this.ResultsListBox.Location = new System.Drawing.Point(409, 3);
			this.ResultsListBox.Name = "ResultsListBox";
			this.ResultsListBox.Size = new System.Drawing.Size(197, 186);
			this.ResultsListBox.TabIndex = 6;
			// 
			// removeFrequencyButton
			// 
			this.removeFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.removeFrequencyButton.Location = new System.Drawing.Point(133, 3);
			this.removeFrequencyButton.Name = "removeFrequencyButton";
			this.removeFrequencyButton.Size = new System.Drawing.Size(61, 28);
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
			this.addFrequencyButton.Location = new System.Drawing.Point(3, 3);
			this.addFrequencyButton.Name = "addFrequencyButton";
			this.addFrequencyButton.Size = new System.Drawing.Size(59, 28);
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
			this.editFrequencyButton.Location = new System.Drawing.Point(68, 3);
			this.editFrequencyButton.Name = "editFrequencyButton";
			this.editFrequencyButton.Size = new System.Drawing.Size(59, 28);
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
			this.removeElementButton.Location = new System.Drawing.Point(133, 3);
			this.removeElementButton.Name = "removeElementButton";
			this.removeElementButton.Size = new System.Drawing.Size(61, 28);
			this.removeElementButton.TabIndex = 8;
			this.removeElementButton.Text = "remove";
			this.removeElementButton.UseVisualStyleBackColor = true;
			// 
			// addElementButton
			// 
			this.addElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addElementButton.Location = new System.Drawing.Point(3, 3);
			this.addElementButton.Name = "addElementButton";
			this.addElementButton.Size = new System.Drawing.Size(59, 28);
			this.addElementButton.TabIndex = 8;
			this.addElementButton.Text = "add";
			this.addElementButton.UseVisualStyleBackColor = true;
			// 
			// editElementButton
			// 
			this.editElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editElementButton.Location = new System.Drawing.Point(68, 3);
			this.editElementButton.Name = "editElementButton";
			this.editElementButton.Size = new System.Drawing.Size(59, 28);
			this.editElementButton.TabIndex = 1;
			this.editElementButton.Text = "edit";
			this.editElementButton.UseVisualStyleBackColor = true;
			this.editElementButton.Click += new System.EventHandler(this.editElementButton_Click);
			// 
			// removeCitcuitButton
			// 
			this.removeCitcuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.removeCitcuitButton.Location = new System.Drawing.Point(155, 3);
			this.removeCitcuitButton.Name = "removeCitcuitButton";
			this.removeCitcuitButton.Size = new System.Drawing.Size(70, 26);
			this.removeCitcuitButton.TabIndex = 8;
			this.removeCitcuitButton.Text = "remove";
			this.removeCitcuitButton.UseVisualStyleBackColor = true;
			// 
			// editCitcuitButton
			// 
			this.editCitcuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editCitcuitButton.Location = new System.Drawing.Point(79, 3);
			this.editCitcuitButton.Name = "editCitcuitButton";
			this.editCitcuitButton.Size = new System.Drawing.Size(70, 26);
			this.editCitcuitButton.TabIndex = 8;
			this.editCitcuitButton.Text = "edit";
			this.editCitcuitButton.UseVisualStyleBackColor = true;
			// 
			// addCitcuitButton
			// 
			this.addCitcuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addCitcuitButton.Location = new System.Drawing.Point(3, 3);
			this.addCitcuitButton.Name = "addCitcuitButton";
			this.addCitcuitButton.Size = new System.Drawing.Size(70, 26);
			this.addCitcuitButton.TabIndex = 8;
			this.addCitcuitButton.Text = "add";
			this.addCitcuitButton.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 621F));
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 1, 0);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 4);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(867, 566);
			this.tableLayoutPanel5.TabIndex = 8;
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 1;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.14286F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.857143F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(240, 560);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel7.Controls.Add(this.removeCitcuitButton, 2, 0);
			this.tableLayoutPanel7.Controls.Add(this.addCitcuitButton, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.editCitcuitButton, 1, 0);
			this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(228, 32);
			this.tableLayoutPanel7.TabIndex = 1;
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel8.ColumnCount = 1;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 1);
			this.tableLayoutPanel8.Location = new System.Drawing.Point(249, 3);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.67857F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.32143F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(615, 560);
			this.tableLayoutPanel8.TabIndex = 1;
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel9.ColumnCount = 3;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.Controls.Add(this.ResultsListBox, 2, 0);
			this.tableLayoutPanel9.Controls.Add(this.ElementsListBox, 0, 0);
			this.tableLayoutPanel9.Controls.Add(this.FrequenciesListBox, 1, 0);
			this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 1);
			this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel11, 1, 1);
			this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 325);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 2;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.87037F));
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12963F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(609, 232);
			this.tableLayoutPanel9.TabIndex = 0;
			// 
			// tableLayoutPanel10
			// 
			this.tableLayoutPanel10.ColumnCount = 3;
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel10.Controls.Add(this.editElementButton, 1, 0);
			this.tableLayoutPanel10.Controls.Add(this.removeElementButton, 2, 0);
			this.tableLayoutPanel10.Controls.Add(this.addElementButton, 0, 0);
			this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 195);
			this.tableLayoutPanel10.Name = "tableLayoutPanel10";
			this.tableLayoutPanel10.RowCount = 1;
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel10.Size = new System.Drawing.Size(197, 34);
			this.tableLayoutPanel10.TabIndex = 7;
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
			this.tableLayoutPanel11.Location = new System.Drawing.Point(206, 195);
			this.tableLayoutPanel11.Name = "tableLayoutPanel11";
			this.tableLayoutPanel11.RowCount = 1;
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel11.Size = new System.Drawing.Size(197, 34);
			this.tableLayoutPanel11.TabIndex = 8;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.СircuitListBox, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 510);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 519);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 38);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 573);
			this.Controls.Add(this.tableLayoutPanel5);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel10.ResumeLayout(false);
			this.tableLayoutPanel11.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox FrequenciesListBox;
        private System.Windows.Forms.ListBox ElementsListBox;
        private System.Windows.Forms.ListBox СircuitListBox;
        private System.Windows.Forms.Button removeFrequencyButton;
        private System.Windows.Forms.Button addFrequencyButton;
        private System.Windows.Forms.Button editElementButton;
        private System.Windows.Forms.Button editFrequencyButton;
        private System.Windows.Forms.ListBox ResultsListBox;
		private System.Windows.Forms.Button removeElementButton;
		private System.Windows.Forms.Button addElementButton;
		private System.Windows.Forms.Button removeCitcuitButton;
		private System.Windows.Forms.Button editCitcuitButton;
		private System.Windows.Forms.Button addCitcuitButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
	}
}

