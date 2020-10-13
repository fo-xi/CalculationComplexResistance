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
			this.AddButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
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
			this.FrequenciesListBox.ItemHeight = 16;
			this.FrequenciesListBox.Location = new System.Drawing.Point(4, 4);
			this.FrequenciesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.FrequenciesListBox.Name = "FrequenciesListBox";
			this.FrequenciesListBox.Size = new System.Drawing.Size(408, 148);
			this.FrequenciesListBox.TabIndex = 5;
			// 
			// ResultsListBox
			// 
			this.ResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsListBox.FormattingEnabled = true;
			this.ResultsListBox.ItemHeight = 16;
			this.ResultsListBox.Location = new System.Drawing.Point(420, 4);
			this.ResultsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ResultsListBox.Name = "ResultsListBox";
			this.ResultsListBox.Size = new System.Drawing.Size(409, 148);
			this.ResultsListBox.TabIndex = 6;
			// 
			// CircuitsGroupBox
			// 
			this.CircuitsGroupBox.Controls.Add(this.tableLayoutPanel3);
			this.CircuitsGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.CircuitsGroupBox.Controls.Add(this.AddSegmentButton);
			this.CircuitsGroupBox.Location = new System.Drawing.Point(20, 15);
			this.CircuitsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CircuitsGroupBox.Name = "CircuitsGroupBox";
			this.CircuitsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CircuitsGroupBox.Size = new System.Drawing.Size(356, 504);
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
			this.tableLayoutPanel3.Controls.Add(this.AddButton, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.EditButton, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 449);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(141, 44);
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
			this.RemoveButton.Location = new System.Drawing.Point(98, 4);
			this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(39, 36);
			this.RemoveButton.TabIndex = 2;
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveCircuitButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.BackColor = System.Drawing.SystemColors.Control;
			this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
			this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
			this.AddButton.Location = new System.Drawing.Point(3, 4);
			this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(40, 36);
			this.AddButton.TabIndex = 0;
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddCircuitButton_Click);
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
			this.EditButton.Location = new System.Drawing.Point(51, 4);
			this.EditButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(39, 36);
			this.EditButton.TabIndex = 1;
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditCircuitButton_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.CircuitsTreeView, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.CircuitSelectionComboBox, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 23);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.024692F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.97531F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 422);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// CircuitsTreeView
			// 
			this.CircuitsTreeView.AllowDrop = true;
			this.CircuitsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CircuitsTreeView.Location = new System.Drawing.Point(4, 37);
			this.CircuitsTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CircuitsTreeView.Name = "CircuitsTreeView";
			this.CircuitsTreeView.Size = new System.Drawing.Size(332, 381);
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
			this.CircuitSelectionComboBox.Location = new System.Drawing.Point(4, 4);
			this.CircuitSelectionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CircuitSelectionComboBox.Name = "CircuitSelectionComboBox";
			this.CircuitSelectionComboBox.Size = new System.Drawing.Size(332, 24);
			this.CircuitSelectionComboBox.TabIndex = 1;
			this.CircuitSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.CircuitSelectionComboBox_SelectedIndexChanged);
			// 
			// AddSegmentButton
			// 
			this.AddSegmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddSegmentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddSegmentButton.Location = new System.Drawing.Point(233, 453);
			this.AddSegmentButton.Margin = new System.Windows.Forms.Padding(4, 4, 3, 4);
			this.AddSegmentButton.Name = "AddSegmentButton";
			this.AddSegmentButton.Size = new System.Drawing.Size(111, 37);
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
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 363F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.ImpedancesGroupBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.ElementsGroupBox, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 527);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1220, 241);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// ImpedancesGroupBox
			// 
			this.ImpedancesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImpedancesGroupBox.Controls.Add(this.tableLayoutPanel5);
			this.ImpedancesGroupBox.Controls.Add(this.tableLayoutPanel4);
			this.ImpedancesGroupBox.Location = new System.Drawing.Point(367, 4);
			this.ImpedancesGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ImpedancesGroupBox.Name = "ImpedancesGroupBox";
			this.ImpedancesGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ImpedancesGroupBox.Size = new System.Drawing.Size(849, 233);
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
			this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 18);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(833, 159);
			this.tableLayoutPanel5.TabIndex = 4;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel4.ColumnCount = 4;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.07865F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.92135F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
			this.tableLayoutPanel4.Controls.Add(this.FrequencyTextBox, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.FrequencyLabel, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.CalculateButton, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.RemoveFrequencyButton, 3, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 181);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(417, 44);
			this.tableLayoutPanel4.TabIndex = 3;
			// 
			// FrequencyTextBox
			// 
			this.FrequencyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FrequencyTextBox.Location = new System.Drawing.Point(91, 11);
			this.FrequencyTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.FrequencyTextBox.Name = "FrequencyTextBox";
			this.FrequencyTextBox.Size = new System.Drawing.Size(141, 22);
			this.FrequencyTextBox.TabIndex = 1;
			this.FrequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FrequencyLabel
			// 
			this.FrequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.FrequencyLabel.AutoSize = true;
			this.FrequencyLabel.Location = new System.Drawing.Point(4, 13);
			this.FrequencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.FrequencyLabel.Name = "FrequencyLabel";
			this.FrequencyLabel.Size = new System.Drawing.Size(79, 17);
			this.FrequencyLabel.TabIndex = 0;
			this.FrequencyLabel.Text = "Frequency:";
			// 
			// CalculateButton
			// 
			this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CalculateButton.Location = new System.Drawing.Point(240, 4);
			this.CalculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(85, 36);
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
			this.RemoveFrequencyButton.Location = new System.Drawing.Point(333, 4);
			this.RemoveFrequencyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.RemoveFrequencyButton.Name = "RemoveFrequencyButton";
			this.RemoveFrequencyButton.Size = new System.Drawing.Size(80, 36);
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
			this.ElementsGroupBox.Location = new System.Drawing.Point(4, 4);
			this.ElementsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ElementsGroupBox.Name = "ElementsGroupBox";
			this.ElementsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ElementsGroupBox.Size = new System.Drawing.Size(355, 233);
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
			this.tableLayoutPanel9.Location = new System.Drawing.Point(8, 50);
			this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 3;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(340, 96);
			this.tableLayoutPanel9.TabIndex = 5;
			// 
			// ValueLabel
			// 
			this.ValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.ValueLabel.AutoSize = true;
			this.ValueLabel.Location = new System.Drawing.Point(12, 71);
			this.ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.Size = new System.Drawing.Size(48, 17);
			this.ValueLabel.TabIndex = 1;
			this.ValueLabel.Text = "Value:";
			this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NameLabel
			// 
			this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(11, 39);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(49, 17);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Name:";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ValueTextBox
			// 
			this.ValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ValueTextBox.Location = new System.Drawing.Point(68, 69);
			this.ValueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ValueTextBox.Name = "ValueTextBox";
			this.ValueTextBox.Size = new System.Drawing.Size(268, 22);
			this.ValueTextBox.TabIndex = 4;
			this.ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.NameTextBox.Location = new System.Drawing.Point(68, 37);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(268, 22);
			this.NameTextBox.TabIndex = 3;
			this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TypeComboBox
			// 
			this.TypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeComboBox.FormattingEnabled = true;
			this.TypeComboBox.Location = new System.Drawing.Point(68, 4);
			this.TypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TypeComboBox.Name = "TypeComboBox";
			this.TypeComboBox.Size = new System.Drawing.Size(268, 24);
			this.TypeComboBox.TabIndex = 5;
			// 
			// TypeLabel
			// 
			this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.TypeLabel.AutoSize = true;
			this.TypeLabel.Location = new System.Drawing.Point(16, 7);
			this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TypeLabel.Name = "TypeLabel";
			this.TypeLabel.Size = new System.Drawing.Size(44, 17);
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
			this.tableLayoutPanel7.Location = new System.Drawing.Point(203, 151);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(145, 44);
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
			this.EditElementButton.Location = new System.Drawing.Point(52, 4);
			this.EditElementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.EditElementButton.Name = "EditElementButton";
			this.EditElementButton.Size = new System.Drawing.Size(40, 36);
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
			this.AddElementButton.Location = new System.Drawing.Point(4, 4);
			this.AddElementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.AddElementButton.Name = "AddElementButton";
			this.AddElementButton.Size = new System.Drawing.Size(40, 36);
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
			this.RemoveElementButton.Location = new System.Drawing.Point(100, 4);
			this.RemoveElementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.RemoveElementButton.Name = "RemoveElementButton";
			this.RemoveElementButton.Size = new System.Drawing.Size(41, 36);
			this.RemoveElementButton.TabIndex = 2;
			this.RemoveElementButton.UseVisualStyleBackColor = true;
			this.RemoveElementButton.Click += new System.EventHandler(this.RemoveElementButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1252, 783);
			this.Controls.Add(this.CircuitsGroupBox);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
		private System.Windows.Forms.Button AddButton;
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
    }
}