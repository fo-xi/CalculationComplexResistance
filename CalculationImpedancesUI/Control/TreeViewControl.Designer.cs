namespace CalculationImpedancesUI.Control
{
    partial class TreeViewControl
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

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.SegmentLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.EditSegmentButton = new System.Windows.Forms.Button();
			this.AddSegmentButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.EditElementButton = new System.Windows.Forms.Button();
			this.AddElementButton = new System.Windows.Forms.Button();
			this.RemoveElementButton = new System.Windows.Forms.Button();
			this.ElementLabel = new System.Windows.Forms.Label();
			this.CircuitsTreeView = new System.Windows.Forms.TreeView();
			this.tableLayoutPanel6.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// SegmentLabel
			// 
			this.SegmentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.SegmentLabel.AutoSize = true;
			this.SegmentLabel.Location = new System.Drawing.Point(4, 376);
			this.SegmentLabel.Name = "SegmentLabel";
			this.SegmentLabel.Size = new System.Drawing.Size(52, 13);
			this.SegmentLabel.TabIndex = 2;
			this.SegmentLabel.Text = "Segment:";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel6.ColumnCount = 2;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.Controls.Add(this.EditSegmentButton, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.AddSegmentButton, 0, 0);
			this.tableLayoutPanel6.Location = new System.Drawing.Point(62, 364);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(69, 36);
			this.tableLayoutPanel6.TabIndex = 1;
			// 
			// EditSegmentButton
			// 
			this.EditSegmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditSegmentButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.edit_button;
			this.EditSegmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.EditSegmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditSegmentButton.ForeColor = System.Drawing.SystemColors.Control;
			this.EditSegmentButton.Location = new System.Drawing.Point(37, 3);
			this.EditSegmentButton.Name = "EditSegmentButton";
			this.EditSegmentButton.Size = new System.Drawing.Size(29, 30);
			this.EditSegmentButton.TabIndex = 1;
			this.EditSegmentButton.UseVisualStyleBackColor = true;
			this.EditSegmentButton.Click += new System.EventHandler(this.EditSegmentButton_Click);
			// 
			// AddSegmentButton
			// 
			this.AddSegmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddSegmentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddSegmentButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.add;
			this.AddSegmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.AddSegmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddSegmentButton.ForeColor = System.Drawing.SystemColors.Control;
			this.AddSegmentButton.Location = new System.Drawing.Point(3, 3);
			this.AddSegmentButton.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
			this.AddSegmentButton.Name = "AddSegmentButton";
			this.AddSegmentButton.Size = new System.Drawing.Size(29, 30);
			this.AddSegmentButton.TabIndex = 3;
			this.AddSegmentButton.UseVisualStyleBackColor = true;
			this.AddSegmentButton.Click += new System.EventHandler(this.AddSegmentButton_Click);
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.69231F));
			this.tableLayoutPanel7.Controls.Add(this.EditElementButton, 1, 0);
			this.tableLayoutPanel7.Controls.Add(this.AddElementButton, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.RemoveElementButton, 2, 0);
			this.tableLayoutPanel7.Location = new System.Drawing.Point(62, 406);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(105, 36);
			this.tableLayoutPanel7.TabIndex = 4;
			// 
			// EditElementButton
			// 
			this.EditElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditElementButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.edit_button;
			this.EditElementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.EditElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditElementButton.ForeColor = System.Drawing.SystemColors.Control;
			this.EditElementButton.Location = new System.Drawing.Point(38, 3);
			this.EditElementButton.Name = "EditElementButton";
			this.EditElementButton.Size = new System.Drawing.Size(29, 30);
			this.EditElementButton.TabIndex = 1;
			this.EditElementButton.UseVisualStyleBackColor = true;
			this.EditElementButton.Click += new System.EventHandler(this.EditElementButton_Click);
			// 
			// AddElementButton
			// 
			this.AddElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddElementButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.add;
			this.AddElementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.AddElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddElementButton.ForeColor = System.Drawing.SystemColors.Control;
			this.AddElementButton.Location = new System.Drawing.Point(3, 3);
			this.AddElementButton.Name = "AddElementButton";
			this.AddElementButton.Size = new System.Drawing.Size(29, 30);
			this.AddElementButton.TabIndex = 0;
			this.AddElementButton.UseVisualStyleBackColor = true;
			this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
			// 
			// RemoveElementButton
			// 
			this.RemoveElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveElementButton.BackgroundImage = global::CalculationImpedancesUI.Properties.Resources.minus;
			this.RemoveElementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.RemoveElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveElementButton.ForeColor = System.Drawing.SystemColors.Control;
			this.RemoveElementButton.Location = new System.Drawing.Point(73, 3);
			this.RemoveElementButton.Name = "RemoveElementButton";
			this.RemoveElementButton.Size = new System.Drawing.Size(29, 30);
			this.RemoveElementButton.TabIndex = 2;
			this.RemoveElementButton.UseVisualStyleBackColor = true;
			this.RemoveElementButton.Click += new System.EventHandler(this.RemoveElementButton_Click);
			// 
			// ElementLabel
			// 
			this.ElementLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ElementLabel.AutoSize = true;
			this.ElementLabel.Location = new System.Drawing.Point(8, 418);
			this.ElementLabel.Name = "ElementLabel";
			this.ElementLabel.Size = new System.Drawing.Size(48, 13);
			this.ElementLabel.TabIndex = 5;
			this.ElementLabel.Text = "Element:";
			// 
			// CircuitsTreeView
			// 
			this.CircuitsTreeView.AllowDrop = true;
			this.CircuitsTreeView.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.CircuitsTreeView.Location = new System.Drawing.Point(3, 0);
			this.CircuitsTreeView.Name = "CircuitsTreeView";
			this.CircuitsTreeView.Size = new System.Drawing.Size(255, 350);
			this.CircuitsTreeView.TabIndex = 6;
			this.CircuitsTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.CircuitsTreeView_ItemDrag);
			this.CircuitsTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.CircuitsTreeView_DragDrop);
			this.CircuitsTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.CircuitsTreeView_DragEnter);
			// 
			// TreeViewControl
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CircuitsTreeView);
			this.Controls.Add(this.ElementLabel);
			this.Controls.Add(this.tableLayoutPanel6);
			this.Controls.Add(this.SegmentLabel);
			this.Controls.Add(this.tableLayoutPanel7);
			this.Name = "TreeViewControl";
			this.Size = new System.Drawing.Size(261, 456);
			this.Load += new System.EventHandler(this.TreeViewControl_Load);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private System.Windows.Forms.Label SegmentLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button EditSegmentButton;
        private System.Windows.Forms.Button AddSegmentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button EditElementButton;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.Button RemoveElementButton;
        private System.Windows.Forms.Label ElementLabel;
		private System.Windows.Forms.TreeView CircuitsTreeView;
    }
}
