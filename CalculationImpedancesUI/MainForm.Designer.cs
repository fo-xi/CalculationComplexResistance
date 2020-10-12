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
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.CircuitsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddSegmentButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CircuitSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.CircuitsTreeView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ImpedancesGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveFrequencyButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.FrequencyTextBox = new System.Windows.Forms.TextBox();
            this.ElementsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveElementButton = new System.Windows.Forms.Button();
            this.EditElementButton = new System.Windows.Forms.Button();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.CircuitsGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ImpedancesGroupBox.SuspendLayout();
            this.ElementsGroupBox.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrequenciesListBox
            // 
            this.FrequenciesListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FrequenciesListBox.FormattingEnabled = true;
            this.FrequenciesListBox.Location = new System.Drawing.Point(3, 3);
            this.FrequenciesListBox.Name = "FrequenciesListBox";
            this.FrequenciesListBox.Size = new System.Drawing.Size(410, 173);
            this.FrequenciesListBox.TabIndex = 5;
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(419, 3);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(410, 173);
            this.ResultsListBox.TabIndex = 6;
            // 
            // CircuitsGroupBox
            // 
            this.CircuitsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CircuitsGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.CircuitsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.CircuitsGroupBox.Location = new System.Drawing.Point(15, 12);
            this.CircuitsGroupBox.Name = "CircuitsGroupBox";
            this.CircuitsGroupBox.Size = new System.Drawing.Size(267, 406);
            this.CircuitsGroupBox.TabIndex = 1;
            this.CircuitsGroupBox.TabStop = false;
            this.CircuitsGroupBox.Text = "Circuits";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.RemoveButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddSegmentButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.EditButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 369);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(255, 31);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(129, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(57, 25);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveCircuitButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(2, 3);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(58, 25);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddCircuitButton_Click);
            // 
            // AddSegmentButton
            // 
            this.AddSegmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSegmentButton.Location = new System.Drawing.Point(192, 3);
            this.AddSegmentButton.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.AddSegmentButton.Name = "AddSegmentButton";
            this.AddSegmentButton.Size = new System.Drawing.Size(61, 25);
            this.AddSegmentButton.TabIndex = 3;
            this.AddSegmentButton.Text = "AS";
            this.AddSegmentButton.UseVisualStyleBackColor = true;
            this.AddSegmentButton.Click += new System.EventHandler(this.AddSegmentButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(66, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(57, 25);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditCircuitButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CircuitSelectionComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CircuitsTreeView, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.024692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.97531F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 347);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CircuitSelectionComboBox
            // 
            this.CircuitSelectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CircuitSelectionComboBox.FormattingEnabled = true;
            this.CircuitSelectionComboBox.Location = new System.Drawing.Point(3, 3);
            this.CircuitSelectionComboBox.Name = "CircuitSelectionComboBox";
            this.CircuitSelectionComboBox.Size = new System.Drawing.Size(249, 21);
            this.CircuitSelectionComboBox.TabIndex = 1;
            this.CircuitSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.CircuitSelectionComboBox_SelectedIndexChanged);
            // 
            // CircuitsTreeView
            // 
            this.CircuitsTreeView.AllowDrop = true;
            this.CircuitsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CircuitsTreeView.Location = new System.Drawing.Point(3, 30);
            this.CircuitsTreeView.Name = "CircuitsTreeView";
            this.CircuitsTreeView.Size = new System.Drawing.Size(249, 314);
            this.CircuitsTreeView.TabIndex = 2;
            this.CircuitsTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.CircuitsTreeView_ItemDrag);
            this.CircuitsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CircuitsTreeView_AfterSelect);
            this.CircuitsTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.CircuitsTreeView_DragDrop);
            this.CircuitsTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.CircuitsTreeView_DragEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ImpedancesGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ElementsGroupBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 421);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1122, 256);
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
            this.ImpedancesGroupBox.Size = new System.Drawing.Size(844, 250);
            this.ImpedancesGroupBox.TabIndex = 3;
            this.ImpedancesGroupBox.TabStop = false;
            this.ImpedancesGroupBox.Text = "Impedances";
            // 
            // RemoveFrequencyButton
            // 
            this.RemoveFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFrequencyButton.Location = new System.Drawing.Point(349, 3);
            this.RemoveFrequencyButton.Name = "RemoveFrequencyButton";
            this.RemoveFrequencyButton.Size = new System.Drawing.Size(65, 25);
            this.RemoveFrequencyButton.TabIndex = 1;
            this.RemoveFrequencyButton.Text = "Remove";
            this.RemoveFrequencyButton.UseVisualStyleBackColor = true;
            this.RemoveFrequencyButton.Click += new System.EventHandler(this.RemoveFrequencyButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateButton.Location = new System.Drawing.Point(279, 3);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(64, 25);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Location = new System.Drawing.Point(20, 9);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(60, 13);
            this.FrequencyLabel.TabIndex = 0;
            this.FrequencyLabel.Text = "Frequency:";
            // 
            // FrequencyTextBox
            // 
            this.FrequencyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FrequencyTextBox.Location = new System.Drawing.Point(86, 5);
            this.FrequencyTextBox.Name = "FrequencyTextBox";
            this.FrequencyTextBox.Size = new System.Drawing.Size(187, 20);
            this.FrequencyTextBox.TabIndex = 1;
            this.FrequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ElementsGroupBox
            // 
            this.ElementsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementsGroupBox.Controls.Add(this.tableLayoutPanel9);
            this.ElementsGroupBox.Controls.Add(this.tableLayoutPanel7);
            this.ElementsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ElementsGroupBox.Name = "ElementsGroupBox";
            this.ElementsGroupBox.Size = new System.Drawing.Size(266, 250);
            this.ElementsGroupBox.TabIndex = 0;
            this.ElementsGroupBox.TabStop = false;
            this.ElementsGroupBox.Text = "Elements";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.96262F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.03738F));
            this.tableLayoutPanel9.Controls.Add(this.TypeLabel, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.ValueLabel, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.NameLabel, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.ValueTextBox, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.NameTextBox, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.TypeComboBox, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 48);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(257, 90);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(11, 8);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Type:";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValueLabel
            // 
            this.ValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(9, 68);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(37, 13);
            this.ValueLabel.TabIndex = 1;
            this.ValueLabel.Text = "Value:";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 38);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTextBox.Location = new System.Drawing.Point(59, 65);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(195, 20);
            this.ValueTextBox.TabIndex = 4;
            this.ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(59, 35);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(195, 20);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(59, 4);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(195, 21);
            this.TypeComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.Controls.Add(this.RemoveElementButton, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.EditElementButton, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.AddElementButton, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(59, 141);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(202, 31);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // RemoveElementButton
            // 
            this.RemoveElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveElementButton.Location = new System.Drawing.Point(137, 3);
            this.RemoveElementButton.Name = "RemoveElementButton";
            this.RemoveElementButton.Size = new System.Drawing.Size(62, 25);
            this.RemoveElementButton.TabIndex = 2;
            this.RemoveElementButton.Text = "Remove";
            this.RemoveElementButton.UseVisualStyleBackColor = true;
            this.RemoveElementButton.Click += new System.EventHandler(this.RemoveElementButton_Click);
            // 
            // EditElementButton
            // 
            this.EditElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditElementButton.Location = new System.Drawing.Point(70, 3);
            this.EditElementButton.Name = "EditElementButton";
            this.EditElementButton.Size = new System.Drawing.Size(61, 25);
            this.EditElementButton.TabIndex = 1;
            this.EditElementButton.Text = "Edit";
            this.EditElementButton.UseVisualStyleBackColor = true;
            this.EditElementButton.Click += new System.EventHandler(this.EditElementButton_Click);
            // 
            // AddElementButton
            // 
            this.AddElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElementButton.Location = new System.Drawing.Point(3, 3);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(61, 25);
            this.AddElementButton.TabIndex = 0;
            this.AddElementButton.Text = "Apply";
            this.AddElementButton.UseVisualStyleBackColor = true;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.Controls.Add(this.FrequencyTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.FrequencyLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.CalculateButton, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.RemoveFrequencyButton, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 209);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(417, 31);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.FrequenciesListBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ResultsListBox, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(832, 187);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 689);
            this.Controls.Add(this.CircuitsGroupBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CircuitsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ImpedancesGroupBox.ResumeLayout(false);
            this.ElementsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
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