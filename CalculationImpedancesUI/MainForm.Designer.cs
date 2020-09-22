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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FrequenciesListBox = new System.Windows.Forms.ListBox();
            this.ElementsListBox = new System.Windows.Forms.ListBox();
            this.СircuitListBox = new System.Windows.Forms.ListBox();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.editFrequencyButton = new System.Windows.Forms.Button();
            this.removeFrequencyButton = new System.Windows.Forms.Button();
            this.addFrequencyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.editElementButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.18657F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.18657F));
            this.tableLayoutPanel1.Controls.Add(this.FrequenciesListBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ElementsListBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.СircuitListBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResultsListBox, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 302);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FrequenciesListBox
            // 
            this.FrequenciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrequenciesListBox.FormattingEnabled = true;
            this.FrequenciesListBox.ItemHeight = 15;
            this.FrequenciesListBox.Location = new System.Drawing.Point(362, 3);
            this.FrequenciesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FrequenciesListBox.Name = "FrequenciesListBox";
            this.FrequenciesListBox.Size = new System.Drawing.Size(173, 289);
            this.FrequenciesListBox.TabIndex = 5;
            // 
            // ElementsListBox
            // 
            this.ElementsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementsListBox.FormattingEnabled = true;
            this.ElementsListBox.ItemHeight = 15;
            this.ElementsListBox.Location = new System.Drawing.Point(183, 3);
            this.ElementsListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ElementsListBox.Name = "ElementsListBox";
            this.ElementsListBox.Size = new System.Drawing.Size(171, 289);
            this.ElementsListBox.TabIndex = 4;
            // 
            // СircuitListBox
            // 
            this.СircuitListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.СircuitListBox.FormattingEnabled = true;
            this.СircuitListBox.ItemHeight = 15;
            this.СircuitListBox.Location = new System.Drawing.Point(4, 3);
            this.СircuitListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.СircuitListBox.Name = "СircuitListBox";
            this.СircuitListBox.Size = new System.Drawing.Size(171, 289);
            this.СircuitListBox.TabIndex = 0;
            this.СircuitListBox.SelectedIndexChanged += new System.EventHandler(this.ChainsListBox_SelectedIndexChanged);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 15;
            this.ResultsListBox.Location = new System.Drawing.Point(542, 3);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(177, 289);
            this.ResultsListBox.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(730, 377);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.71483F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96832F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96832F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.2218F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(722, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.editFrequencyButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.removeFrequencyButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.addFrequencyButton, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(362, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(172, 24);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // editFrequencyButton
            // 
            this.editFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editFrequencyButton.Location = new System.Drawing.Point(61, 3);
            this.editFrequencyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editFrequencyButton.Name = "editFrequencyButton";
            this.editFrequencyButton.Size = new System.Drawing.Size(49, 18);
            this.editFrequencyButton.TabIndex = 2;
            this.editFrequencyButton.Text = "edit";
            this.editFrequencyButton.UseVisualStyleBackColor = true;
            this.editFrequencyButton.Click += new System.EventHandler(this.editFrequencyButton_Click);
            // 
            // removeFrequencyButton
            // 
            this.removeFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeFrequencyButton.Location = new System.Drawing.Point(118, 3);
            this.removeFrequencyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeFrequencyButton.Name = "removeFrequencyButton";
            this.removeFrequencyButton.Size = new System.Drawing.Size(50, 18);
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
            this.addFrequencyButton.Location = new System.Drawing.Point(4, 3);
            this.addFrequencyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addFrequencyButton.Name = "addFrequencyButton";
            this.addFrequencyButton.Size = new System.Drawing.Size(49, 18);
            this.addFrequencyButton.TabIndex = 0;
            this.addFrequencyButton.Text = "add";
            this.addFrequencyButton.UseVisualStyleBackColor = true;
            this.addFrequencyButton.Click += new System.EventHandler(this.addFrequencyButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.editElementButton, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(182, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(172, 24);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // editElementButton
            // 
            this.editElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editElementButton.Location = new System.Drawing.Point(61, 3);
            this.editElementButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editElementButton.Name = "editElementButton";
            this.editElementButton.Size = new System.Drawing.Size(49, 18);
            this.editElementButton.TabIndex = 1;
            this.editElementButton.Text = "edit";
            this.editElementButton.UseVisualStyleBackColor = true;
            this.editElementButton.Click += new System.EventHandler(this.editElementButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 381);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox FrequenciesListBox;
        private System.Windows.Forms.ListBox ElementsListBox;
        private System.Windows.Forms.ListBox СircuitListBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button removeFrequencyButton;
        private System.Windows.Forms.Button addFrequencyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button editElementButton;
        private System.Windows.Forms.Button editFrequencyButton;
        private System.Windows.Forms.ListBox ResultsListBox;
    }
}

