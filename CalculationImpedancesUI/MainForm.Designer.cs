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
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.CircuitsGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.CircuitSelectionComboBox = new System.Windows.Forms.ComboBox();
			this.CircuitsTreeView = new System.Windows.Forms.TreeView();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.ImpedancesGroupBox = new System.Windows.Forms.GroupBox();
			this.FrequenciesGroupBox = new System.Windows.Forms.GroupBox();
			this.FrequencyGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.RemoveFrequencyButton = new System.Windows.Forms.Button();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
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
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.AddSerialElementButton = new System.Windows.Forms.Button();
			this.AddParallelElementButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel8.SuspendLayout();
			this.CircuitsGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.ImpedancesGroupBox.SuspendLayout();
			this.FrequenciesGroupBox.SuspendLayout();
			this.FrequencyGroupBox.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.ElementsGroupBox.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// FrequenciesListBox
			// 
			this.FrequenciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FrequenciesListBox.FormattingEnabled = true;
			this.FrequenciesListBox.Location = new System.Drawing.Point(6, 19);
			this.FrequenciesListBox.Name = "FrequenciesListBox";
			this.FrequenciesListBox.Size = new System.Drawing.Size(222, 186);
			this.FrequenciesListBox.TabIndex = 5;
			// 
			// ResultsListBox
			// 
			this.ResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsListBox.FormattingEnabled = true;
			this.ResultsListBox.Location = new System.Drawing.Point(6, 19);
			this.ResultsListBox.Name = "ResultsListBox";
			this.ResultsListBox.Size = new System.Drawing.Size(224, 186);
			this.ResultsListBox.TabIndex = 6;
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel8.ColumnCount = 1;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel8.Controls.Add(this.CircuitsGroupBox, 0, 0);
			this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel8.Location = new System.Drawing.Point(1, 1);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.22581F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.77419F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(1074, 620);
			this.tableLayoutPanel8.TabIndex = 1;
			// 
			// CircuitsGroupBox
			// 
			this.CircuitsGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.CircuitsGroupBox.Location = new System.Drawing.Point(3, 3);
			this.CircuitsGroupBox.Name = "CircuitsGroupBox";
			this.CircuitsGroupBox.Size = new System.Drawing.Size(267, 386);
			this.CircuitsGroupBox.TabIndex = 1;
			this.CircuitsGroupBox.TabStop = false;
			this.CircuitsGroupBox.Text = "Circuits";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.CircuitSelectionComboBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.CircuitsTreeView, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.202216F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.54848F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 361);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel3.Controls.Add(this.RemoveButton, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.AddButton, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.EditButton, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 327);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(249, 31);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// RemoveButton
			// 
			this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveButton.Location = new System.Drawing.Point(169, 3);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(77, 25);
			this.RemoveButton.TabIndex = 2;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.removeCircuitButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.Location = new System.Drawing.Point(3, 3);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(77, 25);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.addCircuitButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditButton.Location = new System.Drawing.Point(86, 3);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(77, 25);
			this.EditButton.TabIndex = 1;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.editCircuitButton_Click);
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
			this.CircuitsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CircuitsTreeView.Location = new System.Drawing.Point(3, 29);
			this.CircuitsTreeView.Name = "CircuitsTreeView";
			this.CircuitsTreeView.Size = new System.Drawing.Size(249, 292);
			this.CircuitsTreeView.TabIndex = 2;
			this.CircuitsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CircuitsTreeView_AfterSelect);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.14232F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.72659F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
			this.tableLayoutPanel2.Controls.Add(this.ImpedancesGroupBox, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.FrequenciesGroupBox, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.FrequencyGroupBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.ElementsGroupBox, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 395);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1068, 222);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// ImpedancesGroupBox
			// 
			this.ImpedancesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImpedancesGroupBox.Controls.Add(this.ResultsListBox);
			this.ImpedancesGroupBox.Location = new System.Drawing.Point(829, 3);
			this.ImpedancesGroupBox.Name = "ImpedancesGroupBox";
			this.ImpedancesGroupBox.Size = new System.Drawing.Size(236, 216);
			this.ImpedancesGroupBox.TabIndex = 3;
			this.ImpedancesGroupBox.TabStop = false;
			this.ImpedancesGroupBox.Text = "Impedances";
			// 
			// FrequenciesGroupBox
			// 
			this.FrequenciesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FrequenciesGroupBox.Controls.Add(this.FrequenciesListBox);
			this.FrequenciesGroupBox.Location = new System.Drawing.Point(589, 3);
			this.FrequenciesGroupBox.Name = "FrequenciesGroupBox";
			this.FrequenciesGroupBox.Size = new System.Drawing.Size(234, 216);
			this.FrequenciesGroupBox.TabIndex = 2;
			this.FrequenciesGroupBox.TabStop = false;
			this.FrequenciesGroupBox.Text = "Frequencies";
			// 
			// FrequencyGroupBox
			// 
			this.FrequencyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FrequencyGroupBox.Controls.Add(this.tableLayoutPanel5);
			this.FrequencyGroupBox.Controls.Add(this.tableLayoutPanel4);
			this.FrequencyGroupBox.Location = new System.Drawing.Point(389, 3);
			this.FrequencyGroupBox.Name = "FrequencyGroupBox";
			this.FrequencyGroupBox.Size = new System.Drawing.Size(194, 216);
			this.FrequencyGroupBox.TabIndex = 1;
			this.FrequencyGroupBox.TabStop = false;
			this.FrequencyGroupBox.Text = "Frequency";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.RemoveFrequencyButton, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.CalculateButton, 0, 0);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 92);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(182, 80);
			this.tableLayoutPanel5.TabIndex = 2;
			// 
			// RemoveFrequencyButton
			// 
			this.RemoveFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveFrequencyButton.Location = new System.Drawing.Point(3, 43);
			this.RemoveFrequencyButton.Name = "RemoveFrequencyButton";
			this.RemoveFrequencyButton.Size = new System.Drawing.Size(176, 34);
			this.RemoveFrequencyButton.TabIndex = 1;
			this.RemoveFrequencyButton.Text = "Remove frequency";
			this.RemoveFrequencyButton.UseVisualStyleBackColor = true;
			this.RemoveFrequencyButton.Click += new System.EventHandler(this.removeFrequencyButton_Click);
			// 
			// CalculateButton
			// 
			this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CalculateButton.Location = new System.Drawing.Point(3, 3);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(176, 34);
			this.CalculateButton.TabIndex = 0;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.94872F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.05128F));
			this.tableLayoutPanel4.Controls.Add(this.FrequencyLabel, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.FrequencyTextBox, 1, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 42);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(182, 35);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// FrequencyLabel
			// 
			this.FrequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.FrequencyLabel.AutoSize = true;
			this.FrequencyLabel.Location = new System.Drawing.Point(6, 11);
			this.FrequencyLabel.Name = "FrequencyLabel";
			this.FrequencyLabel.Size = new System.Drawing.Size(60, 13);
			this.FrequencyLabel.TabIndex = 0;
			this.FrequencyLabel.Text = "Frequency:";
			// 
			// FrequencyTextBox
			// 
			this.FrequencyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.FrequencyTextBox.Location = new System.Drawing.Point(72, 7);
			this.FrequencyTextBox.Name = "FrequencyTextBox";
			this.FrequencyTextBox.Size = new System.Drawing.Size(107, 20);
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
			this.ElementsGroupBox.Controls.Add(this.tableLayoutPanel6);
			this.ElementsGroupBox.Location = new System.Drawing.Point(3, 3);
			this.ElementsGroupBox.Name = "ElementsGroupBox";
			this.ElementsGroupBox.Size = new System.Drawing.Size(380, 216);
			this.ElementsGroupBox.TabIndex = 0;
			this.ElementsGroupBox.TabStop = false;
			this.ElementsGroupBox.Text = "Elements";
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.ColumnCount = 2;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.0442F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.9558F));
			this.tableLayoutPanel9.Controls.Add(this.TypeLabel, 0, 0);
			this.tableLayoutPanel9.Controls.Add(this.ValueLabel, 0, 2);
			this.tableLayoutPanel9.Controls.Add(this.NameLabel, 0, 1);
			this.tableLayoutPanel9.Controls.Add(this.ValueTextBox, 1, 2);
			this.tableLayoutPanel9.Controls.Add(this.NameTextBox, 1, 1);
			this.tableLayoutPanel9.Controls.Add(this.TypeComboBox, 1, 0);
			this.tableLayoutPanel9.Location = new System.Drawing.Point(6, 28);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 3;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(181, 126);
			this.tableLayoutPanel9.TabIndex = 5;
			// 
			// TypeLabel
			// 
			this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TypeLabel.AutoSize = true;
			this.TypeLabel.Location = new System.Drawing.Point(12, 14);
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
			this.ValueLabel.Location = new System.Drawing.Point(10, 98);
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
			this.NameLabel.Location = new System.Drawing.Point(10, 56);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(38, 13);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Name:";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ValueTextBox
			// 
			this.ValueTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ValueTextBox.Location = new System.Drawing.Point(61, 95);
			this.ValueTextBox.Name = "ValueTextBox";
			this.ValueTextBox.Size = new System.Drawing.Size(117, 20);
			this.ValueTextBox.TabIndex = 4;
			this.ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.NameTextBox.Location = new System.Drawing.Point(61, 53);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(117, 20);
			this.NameTextBox.TabIndex = 3;
			this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TypeComboBox
			// 
			this.TypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeComboBox.FormattingEnabled = true;
			this.TypeComboBox.Location = new System.Drawing.Point(61, 10);
			this.TypeComboBox.Name = "TypeComboBox";
			this.TypeComboBox.Size = new System.Drawing.Size(117, 21);
			this.TypeComboBox.TabIndex = 5;
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel7.Controls.Add(this.RemoveElementButton, 2, 0);
			this.tableLayoutPanel7.Controls.Add(this.EditElementButton, 1, 0);
			this.tableLayoutPanel7.Controls.Add(this.AddElementButton, 0, 0);
			this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 160);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(181, 40);
			this.tableLayoutPanel7.TabIndex = 4;
			// 
			// RemoveElementButton
			// 
			this.RemoveElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveElementButton.Location = new System.Drawing.Point(123, 3);
			this.RemoveElementButton.Name = "RemoveElementButton";
			this.RemoveElementButton.Size = new System.Drawing.Size(55, 34);
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
			this.EditElementButton.Location = new System.Drawing.Point(63, 3);
			this.EditElementButton.Name = "EditElementButton";
			this.EditElementButton.Size = new System.Drawing.Size(54, 34);
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
			this.AddElementButton.Size = new System.Drawing.Size(54, 34);
			this.AddElementButton.TabIndex = 0;
			this.AddElementButton.Text = "Add";
			this.AddElementButton.UseVisualStyleBackColor = true;
			this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel6.ColumnCount = 1;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Controls.Add(this.AddSerialElementButton, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.AddParallelElementButton, 0, 0);
			this.tableLayoutPanel6.Location = new System.Drawing.Point(190, 74);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(181, 80);
			this.tableLayoutPanel6.TabIndex = 3;
			// 
			// AddSerialElementButton
			// 
			this.AddSerialElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddSerialElementButton.Location = new System.Drawing.Point(3, 43);
			this.AddSerialElementButton.Name = "AddSerialElementButton";
			this.AddSerialElementButton.Size = new System.Drawing.Size(175, 34);
			this.AddSerialElementButton.TabIndex = 1;
			this.AddSerialElementButton.Text = "Add serial segment";
			this.AddSerialElementButton.UseVisualStyleBackColor = true;
			this.AddSerialElementButton.Click += new System.EventHandler(this.AddSerialElementButton_Click);
			// 
			// AddParallelElementButton
			// 
			this.AddParallelElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddParallelElementButton.Location = new System.Drawing.Point(3, 3);
			this.AddParallelElementButton.Name = "AddParallelElementButton";
			this.AddParallelElementButton.Size = new System.Drawing.Size(175, 34);
			this.AddParallelElementButton.TabIndex = 0;
			this.AddParallelElementButton.Text = "Add parallel segment";
			this.AddParallelElementButton.UseVisualStyleBackColor = true;
			this.AddParallelElementButton.Click += new System.EventHandler(this.AddParallelElementButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1076, 623);
			this.Controls.Add(this.tableLayoutPanel8);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.CircuitsGroupBox.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ImpedancesGroupBox.ResumeLayout(false);
			this.FrequenciesGroupBox.ResumeLayout(false);
			this.FrequencyGroupBox.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ElementsGroupBox.ResumeLayout(false);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel9.PerformLayout();
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox FrequenciesListBox;
		private System.Windows.Forms.ListBox ResultsListBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.GroupBox CircuitsGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox ImpedancesGroupBox;
		private System.Windows.Forms.GroupBox FrequenciesGroupBox;
		private System.Windows.Forms.GroupBox FrequencyGroupBox;
		private System.Windows.Forms.GroupBox ElementsGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.ComboBox CircuitSelectionComboBox;
		private System.Windows.Forms.TreeView CircuitsTreeView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label FrequencyLabel;
		private System.Windows.Forms.TextBox FrequencyTextBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Button RemoveFrequencyButton;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.Button RemoveElementButton;
		private System.Windows.Forms.Button EditElementButton;
		private System.Windows.Forms.Button AddElementButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Button AddSerialElementButton;
		private System.Windows.Forms.Button AddParallelElementButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private System.Windows.Forms.TextBox ValueTextBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label ValueLabel;
		private System.Windows.Forms.Label TypeLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.ComboBox TypeComboBox;
	}
}