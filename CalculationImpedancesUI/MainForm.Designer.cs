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
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.AddCircuitButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.CircuitsTreeView = new System.Windows.Forms.TreeView();
			this.CircuitSelectionComboBox = new System.Windows.Forms.ComboBox();
			this.AddSegmentButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.ImpedancesGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.FrequencyTextBox = new System.Windows.Forms.TextBox();
			this.FrequencyLabel = new System.Windows.Forms.Label();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.RemoveFrequencyButton = new System.Windows.Forms.Button();
			this.ElementsGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.ValueLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.ValueTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.TypeComboBox = new System.Windows.Forms.ComboBox();
			this.TypeLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.EditElementButton = new System.Windows.Forms.Button();
			this.AddElementButton = new System.Windows.Forms.Button();
			this.RemoveElementButton = new System.Windows.Forms.Button();
			this.CircuitsGroupBox.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.ImpedancesGroupBox.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.ElementsGroupBox.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
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
			this.FrequenciesListBox.Size = new System.Drawing.Size(306, 121);
			this.FrequenciesListBox.TabIndex = 5;
			// 
			// ResultsListBox
			// 
			this.ResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsListBox.FormattingEnabled = true;
			this.ResultsListBox.Location = new System.Drawing.Point(315, 3);
			this.ResultsListBox.Name = "ResultsListBox";
			this.ResultsListBox.Size = new System.Drawing.Size(307, 121);
			this.ResultsListBox.TabIndex = 6;
			// 
			// CircuitsGroupBox
			// 
			this.CircuitsGroupBox.Controls.Add(this.tableLayoutPanel3);
			this.CircuitsGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.CircuitsGroupBox.Controls.Add(this.AddSegmentButton);
			this.CircuitsGroupBox.Location = new System.Drawing.Point(15, 12);
			this.CircuitsGroupBox.Name = "CircuitsGroupBox";
			this.CircuitsGroupBox.Size = new System.Drawing.Size(267, 410);
			this.CircuitsGroupBox.TabIndex = 1;
			this.CircuitsGroupBox.TabStop = false;
			this.CircuitsGroupBox.Text = "Circuits";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.Controls.Add(this.RemoveButton, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.EditButton, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.AddCircuitButton, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 365);
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
			this.RemoveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveButton.BackgroundImage")));
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
			this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
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
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.CircuitsTreeView, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.CircuitSelectionComboBox, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.024692F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.97531F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 343);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// CircuitsTreeView
			// 
			this.CircuitsTreeView.AllowDrop = true;
			this.CircuitsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CircuitsTreeView.Location = new System.Drawing.Point(3, 30);
			this.CircuitsTreeView.Name = "CircuitsTreeView";
			this.CircuitsTreeView.Size = new System.Drawing.Size(249, 310);
			this.CircuitsTreeView.TabIndex = 2;
			this.CircuitsTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.CircuitsTreeView_ItemDrag);
			this.CircuitsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CircuitsTreeView_AfterSelect);
			this.CircuitsTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.CircuitsTreeView_DragDrop);
			this.CircuitsTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.CircuitsTreeView_DragEnter);
			// 
			// CircuitSelectionComboBox
			// 
			this.CircuitSelectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CircuitSelectionComboBox.FormattingEnabled = true;
			this.CircuitSelectionComboBox.Location = new System.Drawing.Point(3, 3);
			this.CircuitSelectionComboBox.Name = "CircuitSelectionComboBox";
			this.CircuitSelectionComboBox.Size = new System.Drawing.Size(249, 21);
			this.CircuitSelectionComboBox.TabIndex = 1;
			this.CircuitSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.CircuitSelectionComboBox_SelectedIndexChanged);
			// 
			// AddSegmentButton
			// 
			this.AddSegmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddSegmentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddSegmentButton.Location = new System.Drawing.Point(175, 368);
			this.AddSegmentButton.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
			this.AddSegmentButton.Name = "AddSegmentButton";
			this.AddSegmentButton.Size = new System.Drawing.Size(83, 30);
			this.AddSegmentButton.TabIndex = 3;
			this.AddSegmentButton.Text = "Add Segment";
			this.AddSegmentButton.UseVisualStyleBackColor = true;
			this.AddSegmentButton.Click += new System.EventHandler(this.AddSegmentButton_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.ImpedancesGroupBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.ElementsGroupBox, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 428);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(915, 196);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// ImpedancesGroupBox
			// 
			this.ImpedancesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImpedancesGroupBox.Controls.Add(this.tableLayoutPanel5);
			this.ImpedancesGroupBox.Controls.Add(this.tableLayoutPanel4);
			this.ImpedancesGroupBox.Location = new System.Drawing.Point(275, 3);
			this.ImpedancesGroupBox.Name = "ImpedancesGroupBox";
			this.ImpedancesGroupBox.Size = new System.Drawing.Size(637, 190);
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
			this.tableLayoutPanel5.Size = new System.Drawing.Size(625, 130);
			this.tableLayoutPanel5.TabIndex = 4;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel4.ColumnCount = 4;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.07865F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.92135F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
			this.tableLayoutPanel4.Controls.Add(this.FrequencyTextBox, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.FrequencyLabel, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.CalculateButton, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.RemoveFrequencyButton, 3, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 148);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(313, 36);
			this.tableLayoutPanel4.TabIndex = 3;
			// 
			// FrequencyTextBox
			// 
			this.FrequencyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FrequencyTextBox.Location = new System.Drawing.Point(67, 8);
			this.FrequencyTextBox.Name = "FrequencyTextBox";
			this.FrequencyTextBox.Size = new System.Drawing.Size(103, 20);
			this.FrequencyTextBox.TabIndex = 1;
			this.FrequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FrequencyLabel
			// 
			this.FrequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.FrequencyLabel.AutoSize = true;
			this.FrequencyLabel.Location = new System.Drawing.Point(4, 5);
			this.FrequencyLabel.Name = "FrequencyLabel";
			this.FrequencyLabel.Size = new System.Drawing.Size(57, 26);
			this.FrequencyLabel.TabIndex = 0;
			this.FrequencyLabel.Text = "Frequency:";
			// 
			// CalculateButton
			// 
			this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CalculateButton.Location = new System.Drawing.Point(176, 3);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(64, 30);
			this.CalculateButton.TabIndex = 0;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// RemoveFrequencyButton
			// 
			this.RemoveFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveFrequencyButton.Location = new System.Drawing.Point(246, 3);
			this.RemoveFrequencyButton.Name = "RemoveFrequencyButton";
			this.RemoveFrequencyButton.Size = new System.Drawing.Size(64, 30);
			this.RemoveFrequencyButton.TabIndex = 1;
			this.RemoveFrequencyButton.Text = "Remove";
			this.RemoveFrequencyButton.UseVisualStyleBackColor = true;
			this.RemoveFrequencyButton.Click += new System.EventHandler(this.RemoveFrequencyButton_Click);
			// 
			// ElementsGroupBox
			// 
			this.ElementsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ElementsGroupBox.Controls.Add(this.tableLayoutPanel9);
			this.ElementsGroupBox.Controls.Add(this.tableLayoutPanel7);
			this.ElementsGroupBox.Location = new System.Drawing.Point(3, 3);
			this.ElementsGroupBox.Name = "ElementsGroupBox";
			this.ElementsGroupBox.Size = new System.Drawing.Size(266, 190);
			this.ElementsGroupBox.TabIndex = 0;
			this.ElementsGroupBox.TabStop = false;
			this.ElementsGroupBox.Text = "Element";
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.ColumnCount = 2;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.82353F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.17647F));
			this.tableLayoutPanel9.Controls.Add(this.ValueLabel, 0, 2);
			this.tableLayoutPanel9.Controls.Add(this.NameLabel, 0, 1);
			this.tableLayoutPanel9.Controls.Add(this.ValueTextBox, 1, 2);
			this.tableLayoutPanel9.Controls.Add(this.NameTextBox, 1, 1);
			this.tableLayoutPanel9.Controls.Add(this.TypeComboBox, 1, 0);
			this.tableLayoutPanel9.Controls.Add(this.TypeLabel, 0, 0);
			this.tableLayoutPanel9.Location = new System.Drawing.Point(6, 41);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 3;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(255, 78);
			this.tableLayoutPanel9.TabIndex = 5;
			// 
			// ValueLabel
			// 
			this.ValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.ValueLabel.AutoSize = true;
			this.ValueLabel.Location = new System.Drawing.Point(8, 58);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.Size = new System.Drawing.Size(37, 13);
			this.ValueLabel.TabIndex = 1;
			this.ValueLabel.Text = "Value:";
			this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NameLabel
			// 
			this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(7, 32);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(38, 13);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Name:";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ValueTextBox
			// 
			this.ValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ValueTextBox.Location = new System.Drawing.Point(51, 55);
			this.ValueTextBox.Name = "ValueTextBox";
			this.ValueTextBox.Size = new System.Drawing.Size(201, 20);
			this.ValueTextBox.TabIndex = 4;
			this.ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.NameTextBox.Location = new System.Drawing.Point(51, 29);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(201, 20);
			this.NameTextBox.TabIndex = 3;
			this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TypeComboBox
			// 
			this.TypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeComboBox.FormattingEnabled = true;
			this.TypeComboBox.Location = new System.Drawing.Point(51, 3);
			this.TypeComboBox.Name = "TypeComboBox";
			this.TypeComboBox.Size = new System.Drawing.Size(201, 21);
			this.TypeComboBox.TabIndex = 5;
			// 
			// TypeLabel
			// 
			this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.TypeLabel.AutoSize = true;
			this.TypeLabel.Location = new System.Drawing.Point(11, 6);
			this.TypeLabel.Name = "TypeLabel";
			this.TypeLabel.Size = new System.Drawing.Size(34, 13);
			this.TypeLabel.TabIndex = 2;
			this.TypeLabel.Text = "Type:";
			this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel7.Controls.Add(this.EditElementButton, 1, 0);
			this.tableLayoutPanel7.Controls.Add(this.AddElementButton, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.RemoveElementButton, 2, 0);
			this.tableLayoutPanel7.Location = new System.Drawing.Point(152, 123);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(109, 36);
			this.tableLayoutPanel7.TabIndex = 4;
			// 
			// EditElementButton
			// 
			this.EditElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditElementButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditElementButton.BackgroundImage")));
			this.EditElementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.EditElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditElementButton.ForeColor = System.Drawing.SystemColors.Control;
			this.EditElementButton.Location = new System.Drawing.Point(39, 3);
			this.EditElementButton.Name = "EditElementButton";
			this.EditElementButton.Size = new System.Drawing.Size(30, 30);
			this.EditElementButton.TabIndex = 1;
			this.EditElementButton.UseVisualStyleBackColor = true;
			this.EditElementButton.Click += new System.EventHandler(this.EditElementButton_Click);
			// 
			// AddElementButton
			// 
			this.AddElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddElementButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddElementButton.BackgroundImage")));
			this.AddElementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.AddElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddElementButton.ForeColor = System.Drawing.SystemColors.Control;
			this.AddElementButton.Location = new System.Drawing.Point(3, 3);
			this.AddElementButton.Name = "AddElementButton";
			this.AddElementButton.Size = new System.Drawing.Size(30, 30);
			this.AddElementButton.TabIndex = 0;
			this.AddElementButton.UseVisualStyleBackColor = true;
			this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
			// 
			// RemoveElementButton
			// 
			this.RemoveElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveElementButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveElementButton.BackgroundImage")));
			this.RemoveElementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.RemoveElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveElementButton.ForeColor = System.Drawing.SystemColors.Control;
			this.RemoveElementButton.Location = new System.Drawing.Point(75, 3);
			this.RemoveElementButton.Name = "RemoveElementButton";
			this.RemoveElementButton.Size = new System.Drawing.Size(31, 30);
			this.RemoveElementButton.TabIndex = 2;
			this.RemoveElementButton.UseVisualStyleBackColor = true;
			this.RemoveElementButton.Click += new System.EventHandler(this.RemoveElementButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 636);
			this.Controls.Add(this.CircuitsGroupBox);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "CalculationImpedancesApp";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.CircuitsGroupBox.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ImpedancesGroupBox.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ElementsGroupBox.ResumeLayout(false);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel9.PerformLayout();
			this.tableLayoutPanel7.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox FrequenciesListBox;
		private System.Windows.Forms.ListBox ResultsListBox;
		private System.Windows.Forms.GroupBox CircuitsGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox ImpedancesGroupBox;
		private System.Windows.Forms.GroupBox ElementsGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.ComboBox CircuitSelectionComboBox;
		private System.Windows.Forms.TreeView CircuitsTreeView;
		private System.Windows.Forms.Label FrequencyLabel;
		private System.Windows.Forms.TextBox FrequencyTextBox;
		private System.Windows.Forms.Button RemoveFrequencyButton;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.Button RemoveElementButton;
		private System.Windows.Forms.Button EditElementButton;
		private System.Windows.Forms.Button AddElementButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private System.Windows.Forms.TextBox ValueTextBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label ValueLabel;
		private System.Windows.Forms.Label TypeLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.ComboBox TypeComboBox;
		private System.Windows.Forms.Button AddSegmentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Button AddCircuitButton;
	}
}