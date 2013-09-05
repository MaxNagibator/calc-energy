namespace TM_2
{
    partial class CalculateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiImportCostButton = new System.Windows.Forms.Button();
            this.uiOldMainFormButton = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.uiMonthComboBox = new System.Windows.Forms.ComboBox();
            this.uiYearsComboBox = new System.Windows.Forms.ComboBox();
            this.button_Excel_Save = new System.Windows.Forms.Button();
            this.button_Word_Save = new System.Windows.Forms.Button();
            this.uiCalculateButton = new System.Windows.Forms.Button();
            this.uiObjectRegistrationTreeView = new System.Windows.Forms.TreeView();
            this.uiMainDataGridView = new System.Windows.Forms.DataGridView();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Energy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tariff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiEnergyAverageCostSumLabel = new System.Windows.Forms.Label();
            this.uiEnergyAverageCostValueLabel = new System.Windows.Forms.Label();
            this.uiEnergyTotalValueLabel = new System.Windows.Forms.Label();
            this.uiEnergyTotalLabel = new System.Windows.Forms.Label();
            this.uiEnergyTransferCostLabel = new System.Windows.Forms.Label();
            this.uiEnergyTransferCostTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergyTransferCostSumLabel = new System.Windows.Forms.Label();
            this.uiEnergyTransferCostSumValueLabel = new System.Windows.Forms.Label();
            this.uiEnergyOtherCostSumValueLabel = new System.Windows.Forms.Label();
            this.uiEnergyOtherCostSumLabel = new System.Windows.Forms.Label();
            this.uiEnergyOtherCostValueTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergyOtherCostLabel = new System.Windows.Forms.Label();
            this.uiEnergySalesSurchargeCostValueTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergySalesSurchargeCostLabel = new System.Windows.Forms.Label();
            this.uiEnergySalesSurchargeCostSumValueLabel = new System.Windows.Forms.Label();
            this.uiEnergySalesSurchargeCostSumLabel = new System.Windows.Forms.Label();
            this.uiEnergyTotalCostValueLabel = new System.Windows.Forms.Label();
            this.uiEnergyTotalCostLabel = new System.Windows.Forms.Label();
            this.uiPowerAverageCostTextBox = new System.Windows.Forms.TextBox();
            this.uiPowerAverageCostPart1Label = new System.Windows.Forms.Label();
            this.uiPowerHourButton = new System.Windows.Forms.Button();
            this.uiPowerAverageCostSumLabel = new System.Windows.Forms.Label();
            this.uiPowerAverageCostSumValueLabel = new System.Windows.Forms.Label();
            this.uiPowerSalesSurchargeCostSumValueLabel = new System.Windows.Forms.Label();
            this.uiPowerSalesSurchargeCostSumLabel = new System.Windows.Forms.Label();
            this.uiPowerTotalCostLabel = new System.Windows.Forms.Label();
            this.uiPowerTotalCostValueLabel = new System.Windows.Forms.Label();
            this.uiPowerTotalLabel = new System.Windows.Forms.Label();
            this.uiPowerTotalValueLabel = new System.Windows.Forms.Label();
            this.uiTotalCostLabel = new System.Windows.Forms.Label();
            this.uiTotalCostValueLabel = new System.Windows.Forms.Label();
            this.uiEnergySalesSurchargeCost2ValueTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergySalesSurchargeCost2Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPowerAverageCostPart2Label = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiImportCostButton
            // 
            this.uiImportCostButton.Location = new System.Drawing.Point(227, 8);
            this.uiImportCostButton.Name = "uiImportCostButton";
            this.uiImportCostButton.Size = new System.Drawing.Size(171, 23);
            this.uiImportCostButton.TabIndex = 1;
            this.uiImportCostButton.Text = "импортировать ценник";
            this.uiImportCostButton.UseVisualStyleBackColor = true;
            this.uiImportCostButton.Click += new System.EventHandler(this.uiImportCostButton_Click);
            // 
            // uiOldMainFormButton
            // 
            this.uiOldMainFormButton.Location = new System.Drawing.Point(12, 12);
            this.uiOldMainFormButton.Name = "uiOldMainFormButton";
            this.uiOldMainFormButton.Size = new System.Drawing.Size(161, 23);
            this.uiOldMainFormButton.TabIndex = 2;
            this.uiOldMainFormButton.Text = "старая форма";
            this.uiOldMainFormButton.UseVisualStyleBackColor = true;
            this.uiOldMainFormButton.Click += new System.EventHandler(this.uiOldMainFormButton_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.uiMonthComboBox);
            this.panel9.Controls.Add(this.uiYearsComboBox);
            this.panel9.Controls.Add(this.button_Excel_Save);
            this.panel9.Controls.Add(this.button_Word_Save);
            this.panel9.Controls.Add(this.uiCalculateButton);
            this.panel9.Location = new System.Drawing.Point(12, 144);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(386, 72);
            this.panel9.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выберите год и месяц для рассчета";
            // 
            // uiMonthComboBox
            // 
            this.uiMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiMonthComboBox.FormattingEnabled = true;
            this.uiMonthComboBox.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.uiMonthComboBox.Location = new System.Drawing.Point(120, 24);
            this.uiMonthComboBox.Name = "uiMonthComboBox";
            this.uiMonthComboBox.Size = new System.Drawing.Size(105, 21);
            this.uiMonthComboBox.TabIndex = 10;
            this.uiMonthComboBox.SelectedValueChanged += new System.EventHandler(this.uiDatesComboBox_SelectedValueChanged);
            // 
            // uiYearsComboBox
            // 
            this.uiYearsComboBox.FormattingEnabled = true;
            this.uiYearsComboBox.Location = new System.Drawing.Point(34, 24);
            this.uiYearsComboBox.Name = "uiYearsComboBox";
            this.uiYearsComboBox.Size = new System.Drawing.Size(71, 21);
            this.uiYearsComboBox.TabIndex = 9;
            this.uiYearsComboBox.SelectedValueChanged += new System.EventHandler(this.uiDatesComboBox_SelectedValueChanged);
            // 
            // button_Excel_Save
            // 
            this.button_Excel_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Excel_Save.BackgroundImage")));
            this.button_Excel_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Excel_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Excel_Save.Location = new System.Drawing.Point(336, 13);
            this.button_Excel_Save.Name = "button_Excel_Save";
            this.button_Excel_Save.Size = new System.Drawing.Size(40, 40);
            this.button_Excel_Save.TabIndex = 8;
            this.button_Excel_Save.UseVisualStyleBackColor = true;
            this.button_Excel_Save.Visible = false;
            // 
            // button_Word_Save
            // 
            this.button_Word_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Word_Save.BackgroundImage")));
            this.button_Word_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Word_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Word_Save.Location = new System.Drawing.Point(292, 13);
            this.button_Word_Save.Name = "button_Word_Save";
            this.button_Word_Save.Size = new System.Drawing.Size(40, 40);
            this.button_Word_Save.TabIndex = 7;
            this.button_Word_Save.UseVisualStyleBackColor = true;
            this.button_Word_Save.Visible = false;
            // 
            // uiCalculateButton
            // 
            this.uiCalculateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiCalculateButton.BackgroundImage")));
            this.uiCalculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiCalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCalculateButton.Location = new System.Drawing.Point(246, 13);
            this.uiCalculateButton.Name = "uiCalculateButton";
            this.uiCalculateButton.Size = new System.Drawing.Size(40, 40);
            this.uiCalculateButton.TabIndex = 6;
            this.uiCalculateButton.UseVisualStyleBackColor = true;
            this.uiCalculateButton.Click += new System.EventHandler(this.uiCalculateButton_Click);
            // 
            // uiObjectRegistrationTreeView
            // 
            this.uiObjectRegistrationTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiObjectRegistrationTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiObjectRegistrationTreeView.Location = new System.Drawing.Point(12, 70);
            this.uiObjectRegistrationTreeView.Name = "uiObjectRegistrationTreeView";
            this.uiObjectRegistrationTreeView.Size = new System.Drawing.Size(386, 65);
            this.uiObjectRegistrationTreeView.TabIndex = 12;
            // 
            // uiMainDataGridView
            // 
            this.uiMainDataGridView.AllowUserToAddRows = false;
            this.uiMainDataGridView.AllowUserToDeleteRows = false;
            this.uiMainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiMainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiMainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uiMainDataGridView.ColumnHeadersHeight = 31;
            this.uiMainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Points,
            this.Energy,
            this.Tariff,
            this.Summa});
            this.uiMainDataGridView.Location = new System.Drawing.Point(-237, -95);
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.RowHeadersVisible = false;
            this.uiMainDataGridView.Size = new System.Drawing.Size(524, 238);
            this.uiMainDataGridView.TabIndex = 13;
            // 
            // Points
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Points.DefaultCellStyle = dataGridViewCellStyle2;
            this.Points.FillWeight = 120F;
            this.Points.HeaderText = "Интервал";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Points.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Energy
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Energy.DefaultCellStyle = dataGridViewCellStyle3;
            this.Energy.HeaderText = "А+, Вт/ч.";
            this.Energy.Name = "Energy";
            this.Energy.ReadOnly = true;
            this.Energy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Energy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tariff
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tariff.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tariff.HeaderText = "Тариф, руб./кВт.ч.";
            this.Tariff.Name = "Tariff";
            this.Tariff.ReadOnly = true;
            this.Tariff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tariff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Summa
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Summa.DefaultCellStyle = dataGridViewCellStyle5;
            this.Summa.HeaderText = "Сумма, руб.";
            this.Summa.Name = "Summa";
            this.Summa.ReadOnly = true;
            this.Summa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Summa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // uiEnergyAverageCostSumLabel
            // 
            this.uiEnergyAverageCostSumLabel.AutoSize = true;
            this.uiEnergyAverageCostSumLabel.Location = new System.Drawing.Point(43, 103);
            this.uiEnergyAverageCostSumLabel.Name = "uiEnergyAverageCostSumLabel";
            this.uiEnergyAverageCostSumLabel.Size = new System.Drawing.Size(210, 13);
            this.uiEnergyAverageCostSumLabel.TabIndex = 14;
            this.uiEnergyAverageCostSumLabel.Text = "Средневзвешенная стоимость энергии:";
            // 
            // uiEnergyAverageCostValueLabel
            // 
            this.uiEnergyAverageCostValueLabel.AutoSize = true;
            this.uiEnergyAverageCostValueLabel.Location = new System.Drawing.Point(317, 103);
            this.uiEnergyAverageCostValueLabel.Name = "uiEnergyAverageCostValueLabel";
            this.uiEnergyAverageCostValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyAverageCostValueLabel.TabIndex = 15;
            this.uiEnergyAverageCostValueLabel.Text = "0";
            // 
            // uiEnergyTotalValueLabel
            // 
            this.uiEnergyTotalValueLabel.AutoSize = true;
            this.uiEnergyTotalValueLabel.Location = new System.Drawing.Point(316, 9);
            this.uiEnergyTotalValueLabel.Name = "uiEnergyTotalValueLabel";
            this.uiEnergyTotalValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyTotalValueLabel.TabIndex = 17;
            this.uiEnergyTotalValueLabel.Text = "0";
            // 
            // uiEnergyTotalLabel
            // 
            this.uiEnergyTotalLabel.AutoSize = true;
            this.uiEnergyTotalLabel.Location = new System.Drawing.Point(10, 9);
            this.uiEnergyTotalLabel.Name = "uiEnergyTotalLabel";
            this.uiEnergyTotalLabel.Size = new System.Drawing.Size(102, 13);
            this.uiEnergyTotalLabel.TabIndex = 16;
            this.uiEnergyTotalLabel.Text = "Всего энергии, Вт:";
            // 
            // uiEnergyTransferCostLabel
            // 
            this.uiEnergyTransferCostLabel.AutoSize = true;
            this.uiEnergyTransferCostLabel.Location = new System.Drawing.Point(12, 230);
            this.uiEnergyTransferCostLabel.Name = "uiEnergyTransferCostLabel";
            this.uiEnergyTransferCostLabel.Size = new System.Drawing.Size(211, 13);
            this.uiEnergyTransferCostLabel.TabIndex = 18;
            this.uiEnergyTransferCostLabel.Text = "Тариф на услуги по передаче э/энергии";
            // 
            // uiEnergyTransferCostTextBox
            // 
            this.uiEnergyTransferCostTextBox.Location = new System.Drawing.Point(298, 227);
            this.uiEnergyTransferCostTextBox.Name = "uiEnergyTransferCostTextBox";
            this.uiEnergyTransferCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiEnergyTransferCostTextBox.TabIndex = 19;
            this.uiEnergyTransferCostTextBox.Text = "1,36671";
            this.uiEnergyTransferCostTextBox.Leave += new System.EventHandler(this.uiPowerAverageCostTextBox_Leave);
            // 
            // uiEnergyTransferCostSumLabel
            // 
            this.uiEnergyTransferCostSumLabel.AutoSize = true;
            this.uiEnergyTransferCostSumLabel.Location = new System.Drawing.Point(43, 132);
            this.uiEnergyTransferCostSumLabel.Name = "uiEnergyTransferCostSumLabel";
            this.uiEnergyTransferCostSumLabel.Size = new System.Drawing.Size(196, 13);
            this.uiEnergyTransferCostSumLabel.TabIndex = 20;
            this.uiEnergyTransferCostSumLabel.Text = "Сумма филки по передаче э/энергии";
            // 
            // uiEnergyTransferCostSumValueLabel
            // 
            this.uiEnergyTransferCostSumValueLabel.AutoSize = true;
            this.uiEnergyTransferCostSumValueLabel.Location = new System.Drawing.Point(317, 132);
            this.uiEnergyTransferCostSumValueLabel.Name = "uiEnergyTransferCostSumValueLabel";
            this.uiEnergyTransferCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyTransferCostSumValueLabel.TabIndex = 21;
            this.uiEnergyTransferCostSumValueLabel.Text = "0";
            // 
            // uiEnergyOtherCostSumValueLabel
            // 
            this.uiEnergyOtherCostSumValueLabel.AutoSize = true;
            this.uiEnergyOtherCostSumValueLabel.Location = new System.Drawing.Point(317, 161);
            this.uiEnergyOtherCostSumValueLabel.Name = "uiEnergyOtherCostSumValueLabel";
            this.uiEnergyOtherCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyOtherCostSumValueLabel.TabIndex = 23;
            this.uiEnergyOtherCostSumValueLabel.Text = "0";
            // 
            // uiEnergyOtherCostSumLabel
            // 
            this.uiEnergyOtherCostSumLabel.AutoSize = true;
            this.uiEnergyOtherCostSumLabel.Location = new System.Drawing.Point(43, 161);
            this.uiEnergyOtherCostSumLabel.Name = "uiEnergyOtherCostSumLabel";
            this.uiEnergyOtherCostSumLabel.Size = new System.Drawing.Size(118, 13);
            this.uiEnergyOtherCostSumLabel.TabIndex = 22;
            this.uiEnergyOtherCostSumLabel.Text = "Плата за иные услуги";
            // 
            // uiEnergyOtherCostValueTextBox
            // 
            this.uiEnergyOtherCostValueTextBox.Location = new System.Drawing.Point(298, 253);
            this.uiEnergyOtherCostValueTextBox.Name = "uiEnergyOtherCostValueTextBox";
            this.uiEnergyOtherCostValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiEnergyOtherCostValueTextBox.TabIndex = 35;
            this.uiEnergyOtherCostValueTextBox.Text = "0,00092";
            this.uiEnergyOtherCostValueTextBox.Leave += new System.EventHandler(this.uiPowerAverageCostTextBox_Leave);
            // 
            // uiEnergyOtherCostLabel
            // 
            this.uiEnergyOtherCostLabel.AutoSize = true;
            this.uiEnergyOtherCostLabel.Location = new System.Drawing.Point(12, 256);
            this.uiEnergyOtherCostLabel.Name = "uiEnergyOtherCostLabel";
            this.uiEnergyOtherCostLabel.Size = new System.Drawing.Size(120, 13);
            this.uiEnergyOtherCostLabel.TabIndex = 34;
            this.uiEnergyOtherCostLabel.Text = "Тариф на иные услуги";
            // 
            // uiEnergySalesSurchargeCostValueTextBox
            // 
            this.uiEnergySalesSurchargeCostValueTextBox.Location = new System.Drawing.Point(298, 308);
            this.uiEnergySalesSurchargeCostValueTextBox.Name = "uiEnergySalesSurchargeCostValueTextBox";
            this.uiEnergySalesSurchargeCostValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiEnergySalesSurchargeCostValueTextBox.TabIndex = 41;
            this.uiEnergySalesSurchargeCostValueTextBox.Text = "1,83";
            this.uiEnergySalesSurchargeCostValueTextBox.Leave += new System.EventHandler(this.uiPowerAverageCostTextBox_Leave);
            // 
            // uiEnergySalesSurchargeCostLabel
            // 
            this.uiEnergySalesSurchargeCostLabel.AutoSize = true;
            this.uiEnergySalesSurchargeCostLabel.Location = new System.Drawing.Point(12, 308);
            this.uiEnergySalesSurchargeCostLabel.Name = "uiEnergySalesSurchargeCostLabel";
            this.uiEnergySalesSurchargeCostLabel.Size = new System.Drawing.Size(189, 13);
            this.uiEnergySalesSurchargeCostLabel.TabIndex = 40;
            this.uiEnergySalesSurchargeCostLabel.Text = "Сбытовая надбавка коэффициент 2";
            // 
            // uiEnergySalesSurchargeCostSumValueLabel
            // 
            this.uiEnergySalesSurchargeCostSumValueLabel.AutoSize = true;
            this.uiEnergySalesSurchargeCostSumValueLabel.Location = new System.Drawing.Point(316, 183);
            this.uiEnergySalesSurchargeCostSumValueLabel.Name = "uiEnergySalesSurchargeCostSumValueLabel";
            this.uiEnergySalesSurchargeCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergySalesSurchargeCostSumValueLabel.TabIndex = 43;
            this.uiEnergySalesSurchargeCostSumValueLabel.Text = "0";
            // 
            // uiEnergySalesSurchargeCostSumLabel
            // 
            this.uiEnergySalesSurchargeCostSumLabel.AutoSize = true;
            this.uiEnergySalesSurchargeCostSumLabel.Location = new System.Drawing.Point(42, 183);
            this.uiEnergySalesSurchargeCostSumLabel.Name = "uiEnergySalesSurchargeCostSumLabel";
            this.uiEnergySalesSurchargeCostSumLabel.Size = new System.Drawing.Size(169, 13);
            this.uiEnergySalesSurchargeCostSumLabel.TabIndex = 42;
            this.uiEnergySalesSurchargeCostSumLabel.Text = "Сбытовая надбавка на енергию";
            // 
            // uiEnergyTotalCostValueLabel
            // 
            this.uiEnergyTotalCostValueLabel.AutoSize = true;
            this.uiEnergyTotalCostValueLabel.Location = new System.Drawing.Point(317, 71);
            this.uiEnergyTotalCostValueLabel.Name = "uiEnergyTotalCostValueLabel";
            this.uiEnergyTotalCostValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyTotalCostValueLabel.TabIndex = 45;
            this.uiEnergyTotalCostValueLabel.Text = "0";
            // 
            // uiEnergyTotalCostLabel
            // 
            this.uiEnergyTotalCostLabel.AutoSize = true;
            this.uiEnergyTotalCostLabel.Location = new System.Drawing.Point(10, 71);
            this.uiEnergyTotalCostLabel.Name = "uiEnergyTotalCostLabel";
            this.uiEnergyTotalCostLabel.Size = new System.Drawing.Size(257, 13);
            this.uiEnergyTotalCostLabel.TabIndex = 44;
            this.uiEnergyTotalCostLabel.Text = "Ставка на электроэнергию по тарифу(цене) в т.ч.";
            // 
            // uiPowerAverageCostTextBox
            // 
            this.uiPowerAverageCostTextBox.Location = new System.Drawing.Point(298, 357);
            this.uiPowerAverageCostTextBox.Name = "uiPowerAverageCostTextBox";
            this.uiPowerAverageCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiPowerAverageCostTextBox.TabIndex = 47;
            this.uiPowerAverageCostTextBox.Text = "188,94623";
            this.uiPowerAverageCostTextBox.Leave += new System.EventHandler(this.uiPowerAverageCostTextBox_Leave);
            // 
            // uiPowerAverageCostPart1Label
            // 
            this.uiPowerAverageCostPart1Label.AutoSize = true;
            this.uiPowerAverageCostPart1Label.Location = new System.Drawing.Point(12, 334);
            this.uiPowerAverageCostPart1Label.Name = "uiPowerAverageCostPart1Label";
            this.uiPowerAverageCostPart1Label.Size = new System.Drawing.Size(219, 13);
            this.uiPowerAverageCostPart1Label.TabIndex = 46;
            this.uiPowerAverageCostPart1Label.Text = "Средневзвешенная нерегулируемая цена\r\n";
            // 
            // uiPowerHourButton
            // 
            this.uiPowerHourButton.Location = new System.Drawing.Point(227, 37);
            this.uiPowerHourButton.Name = "uiPowerHourButton";
            this.uiPowerHourButton.Size = new System.Drawing.Size(171, 23);
            this.uiPowerHourButton.TabIndex = 48;
            this.uiPowerHourButton.Text = "импортировать часики";
            this.uiPowerHourButton.UseVisualStyleBackColor = true;
            this.uiPowerHourButton.Click += new System.EventHandler(this.uiPowerHourButton_Click);
            // 
            // uiPowerAverageCostSumLabel
            // 
            this.uiPowerAverageCostSumLabel.AutoSize = true;
            this.uiPowerAverageCostSumLabel.Location = new System.Drawing.Point(44, 252);
            this.uiPowerAverageCostSumLabel.Name = "uiPowerAverageCostSumLabel";
            this.uiPowerAverageCostSumLabel.Size = new System.Drawing.Size(161, 13);
            this.uiPowerAverageCostSumLabel.TabIndex = 49;
            this.uiPowerAverageCostSumLabel.Text = "Средневзвешанная мощность";
            // 
            // uiPowerAverageCostSumValueLabel
            // 
            this.uiPowerAverageCostSumValueLabel.AutoSize = true;
            this.uiPowerAverageCostSumValueLabel.Location = new System.Drawing.Point(316, 252);
            this.uiPowerAverageCostSumValueLabel.Name = "uiPowerAverageCostSumValueLabel";
            this.uiPowerAverageCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiPowerAverageCostSumValueLabel.TabIndex = 50;
            this.uiPowerAverageCostSumValueLabel.Text = "0";
            // 
            // uiPowerSalesSurchargeCostSumValueLabel
            // 
            this.uiPowerSalesSurchargeCostSumValueLabel.AutoSize = true;
            this.uiPowerSalesSurchargeCostSumValueLabel.Location = new System.Drawing.Point(316, 275);
            this.uiPowerSalesSurchargeCostSumValueLabel.Name = "uiPowerSalesSurchargeCostSumValueLabel";
            this.uiPowerSalesSurchargeCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiPowerSalesSurchargeCostSumValueLabel.TabIndex = 52;
            this.uiPowerSalesSurchargeCostSumValueLabel.Text = "0";
            // 
            // uiPowerSalesSurchargeCostSumLabel
            // 
            this.uiPowerSalesSurchargeCostSumLabel.AutoSize = true;
            this.uiPowerSalesSurchargeCostSumLabel.Location = new System.Drawing.Point(44, 275);
            this.uiPowerSalesSurchargeCostSumLabel.Name = "uiPowerSalesSurchargeCostSumLabel";
            this.uiPowerSalesSurchargeCostSumLabel.Size = new System.Drawing.Size(177, 13);
            this.uiPowerSalesSurchargeCostSumLabel.TabIndex = 51;
            this.uiPowerSalesSurchargeCostSumLabel.Text = "Сбытовая надбавка на можность";
            // 
            // uiPowerTotalCostLabel
            // 
            this.uiPowerTotalCostLabel.AutoSize = true;
            this.uiPowerTotalCostLabel.Location = new System.Drawing.Point(13, 226);
            this.uiPowerTotalCostLabel.Name = "uiPowerTotalCostLabel";
            this.uiPowerTotalCostLabel.Size = new System.Drawing.Size(296, 13);
            this.uiPowerTotalCostLabel.TabIndex = 55;
            this.uiPowerTotalCostLabel.Text = "Ставка за мощность, приобретаемую покупателем в т.ч.";
            // 
            // uiPowerTotalCostValueLabel
            // 
            this.uiPowerTotalCostValueLabel.AutoSize = true;
            this.uiPowerTotalCostValueLabel.Location = new System.Drawing.Point(315, 226);
            this.uiPowerTotalCostValueLabel.Name = "uiPowerTotalCostValueLabel";
            this.uiPowerTotalCostValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiPowerTotalCostValueLabel.TabIndex = 50;
            this.uiPowerTotalCostValueLabel.Text = "0";
            // 
            // uiPowerTotalLabel
            // 
            this.uiPowerTotalLabel.AutoSize = true;
            this.uiPowerTotalLabel.Location = new System.Drawing.Point(10, 30);
            this.uiPowerTotalLabel.Name = "uiPowerTotalLabel";
            this.uiPowerTotalLabel.Size = new System.Drawing.Size(113, 13);
            this.uiPowerTotalLabel.TabIndex = 16;
            this.uiPowerTotalLabel.Text = "Всего мощности, Вт:";
            // 
            // uiPowerTotalValueLabel
            // 
            this.uiPowerTotalValueLabel.AutoSize = true;
            this.uiPowerTotalValueLabel.Location = new System.Drawing.Point(316, 30);
            this.uiPowerTotalValueLabel.Name = "uiPowerTotalValueLabel";
            this.uiPowerTotalValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiPowerTotalValueLabel.TabIndex = 17;
            this.uiPowerTotalValueLabel.Text = "0";
            // 
            // uiTotalCostLabel
            // 
            this.uiTotalCostLabel.AutoSize = true;
            this.uiTotalCostLabel.Location = new System.Drawing.Point(7, 48);
            this.uiTotalCostLabel.Name = "uiTotalCostLabel";
            this.uiTotalCostLabel.Size = new System.Drawing.Size(91, 13);
            this.uiTotalCostLabel.TabIndex = 56;
            this.uiTotalCostLabel.Text = "Всего по тарифу";
            // 
            // uiTotalCostValueLabel
            // 
            this.uiTotalCostValueLabel.AutoSize = true;
            this.uiTotalCostValueLabel.Location = new System.Drawing.Point(317, 48);
            this.uiTotalCostValueLabel.Name = "uiTotalCostValueLabel";
            this.uiTotalCostValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiTotalCostValueLabel.TabIndex = 57;
            this.uiTotalCostValueLabel.Text = "0";
            // 
            // uiEnergySalesSurchargeCost2ValueTextBox
            // 
            this.uiEnergySalesSurchargeCost2ValueTextBox.Location = new System.Drawing.Point(298, 279);
            this.uiEnergySalesSurchargeCost2ValueTextBox.Name = "uiEnergySalesSurchargeCost2ValueTextBox";
            this.uiEnergySalesSurchargeCost2ValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiEnergySalesSurchargeCost2ValueTextBox.TabIndex = 59;
            this.uiEnergySalesSurchargeCost2ValueTextBox.Text = "0,1315";
            this.uiEnergySalesSurchargeCost2ValueTextBox.Leave += new System.EventHandler(this.uiPowerAverageCostTextBox_Leave);
            // 
            // uiEnergySalesSurchargeCost2Label
            // 
            this.uiEnergySalesSurchargeCost2Label.AutoSize = true;
            this.uiEnergySalesSurchargeCost2Label.Location = new System.Drawing.Point(12, 282);
            this.uiEnergySalesSurchargeCost2Label.Name = "uiEnergySalesSurchargeCost2Label";
            this.uiEnergySalesSurchargeCost2Label.Size = new System.Drawing.Size(189, 13);
            this.uiEnergySalesSurchargeCost2Label.TabIndex = 58;
            this.uiEnergySalesSurchargeCost2Label.Text = "Сбытовая надбавка коэффициент 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiEnergyTotalLabel);
            this.panel1.Controls.Add(this.uiEnergyAverageCostSumLabel);
            this.panel1.Controls.Add(this.uiEnergyAverageCostValueLabel);
            this.panel1.Controls.Add(this.uiTotalCostValueLabel);
            this.panel1.Controls.Add(this.uiPowerTotalLabel);
            this.panel1.Controls.Add(this.uiTotalCostLabel);
            this.panel1.Controls.Add(this.uiEnergyTotalValueLabel);
            this.panel1.Controls.Add(this.uiPowerTotalCostLabel);
            this.panel1.Controls.Add(this.uiPowerTotalValueLabel);
            this.panel1.Controls.Add(this.uiPowerSalesSurchargeCostSumValueLabel);
            this.panel1.Controls.Add(this.uiEnergyTransferCostSumLabel);
            this.panel1.Controls.Add(this.uiPowerSalesSurchargeCostSumLabel);
            this.panel1.Controls.Add(this.uiMainDataGridView);
            this.panel1.Controls.Add(this.uiEnergyTransferCostSumValueLabel);
            this.panel1.Controls.Add(this.uiPowerTotalCostValueLabel);
            this.panel1.Controls.Add(this.uiEnergyOtherCostSumLabel);
            this.panel1.Controls.Add(this.uiPowerAverageCostSumValueLabel);
            this.panel1.Controls.Add(this.uiEnergyOtherCostSumValueLabel);
            this.panel1.Controls.Add(this.uiPowerAverageCostSumLabel);
            this.panel1.Controls.Add(this.uiEnergySalesSurchargeCostSumLabel);
            this.panel1.Controls.Add(this.uiEnergySalesSurchargeCostSumValueLabel);
            this.panel1.Controls.Add(this.uiEnergyTotalCostLabel);
            this.panel1.Controls.Add(this.uiEnergyTotalCostValueLabel);
            this.panel1.Location = new System.Drawing.Point(419, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 53);
            this.panel1.TabIndex = 60;
            this.panel1.Visible = false;
            // 
            // uiPowerAverageCostPart2Label
            // 
            this.uiPowerAverageCostPart2Label.AutoSize = true;
            this.uiPowerAverageCostPart2Label.Location = new System.Drawing.Point(82, 347);
            this.uiPowerAverageCostPart2Label.Name = "uiPowerAverageCostPart2Label";
            this.uiPowerAverageCostPart2Label.Size = new System.Drawing.Size(210, 26);
            this.uiPowerAverageCostPart2Label.TabIndex = 61;
            this.uiPowerAverageCostPart2Label.Text = "\r\nна мощность на оптовом рынке. руб/Вт";
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 399);
            this.Controls.Add(this.uiPowerAverageCostPart2Label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiEnergySalesSurchargeCost2ValueTextBox);
            this.Controls.Add(this.uiEnergySalesSurchargeCost2Label);
            this.Controls.Add(this.uiPowerHourButton);
            this.Controls.Add(this.uiPowerAverageCostTextBox);
            this.Controls.Add(this.uiPowerAverageCostPart1Label);
            this.Controls.Add(this.uiEnergySalesSurchargeCostValueTextBox);
            this.Controls.Add(this.uiEnergySalesSurchargeCostLabel);
            this.Controls.Add(this.uiEnergyOtherCostValueTextBox);
            this.Controls.Add(this.uiEnergyOtherCostLabel);
            this.Controls.Add(this.uiEnergyTransferCostTextBox);
            this.Controls.Add(this.uiEnergyTransferCostLabel);
            this.Controls.Add(this.uiObjectRegistrationTreeView);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.uiOldMainFormButton);
            this.Controls.Add(this.uiImportCostButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculateForm";
            this.Text = "Расчёт стоимости";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiImportCostButton;
        private System.Windows.Forms.Button uiOldMainFormButton;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox uiMonthComboBox;
        private System.Windows.Forms.ComboBox uiYearsComboBox;
        private System.Windows.Forms.Button button_Excel_Save;
        private System.Windows.Forms.Button button_Word_Save;
        private System.Windows.Forms.Button uiCalculateButton;
        private System.Windows.Forms.TreeView uiObjectRegistrationTreeView;
        private System.Windows.Forms.DataGridView uiMainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn Energy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tariff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summa;
        private System.Windows.Forms.Label uiEnergyAverageCostSumLabel;
        private System.Windows.Forms.Label uiEnergyAverageCostValueLabel;
        private System.Windows.Forms.Label uiEnergyTotalValueLabel;
        private System.Windows.Forms.Label uiEnergyTotalLabel;
        private System.Windows.Forms.Label uiEnergyTransferCostLabel;
        private System.Windows.Forms.TextBox uiEnergyTransferCostTextBox;
        private System.Windows.Forms.Label uiEnergyTransferCostSumLabel;
        private System.Windows.Forms.Label uiEnergyTransferCostSumValueLabel;
        private System.Windows.Forms.Label uiEnergyOtherCostSumValueLabel;
        private System.Windows.Forms.Label uiEnergyOtherCostSumLabel;
        private System.Windows.Forms.TextBox uiEnergyOtherCostValueTextBox;
        private System.Windows.Forms.Label uiEnergyOtherCostLabel;
        private System.Windows.Forms.TextBox uiEnergySalesSurchargeCostValueTextBox;
        private System.Windows.Forms.Label uiEnergySalesSurchargeCostLabel;
        private System.Windows.Forms.Label uiEnergySalesSurchargeCostSumValueLabel;
        private System.Windows.Forms.Label uiEnergySalesSurchargeCostSumLabel;
        private System.Windows.Forms.Label uiEnergyTotalCostValueLabel;
        private System.Windows.Forms.Label uiEnergyTotalCostLabel;
        private System.Windows.Forms.TextBox uiPowerAverageCostTextBox;
        private System.Windows.Forms.Label uiPowerAverageCostPart1Label;
        private System.Windows.Forms.Button uiPowerHourButton;
        private System.Windows.Forms.Label uiPowerAverageCostSumLabel;
        private System.Windows.Forms.Label uiPowerAverageCostSumValueLabel;
        private System.Windows.Forms.Label uiPowerSalesSurchargeCostSumValueLabel;
        private System.Windows.Forms.Label uiPowerSalesSurchargeCostSumLabel;
        private System.Windows.Forms.Label uiPowerTotalCostLabel;
        private System.Windows.Forms.Label uiPowerTotalCostValueLabel;
        private System.Windows.Forms.Label uiPowerTotalLabel;
        private System.Windows.Forms.Label uiPowerTotalValueLabel;
        private System.Windows.Forms.Label uiTotalCostLabel;
        private System.Windows.Forms.Label uiTotalCostValueLabel;
        private System.Windows.Forms.TextBox uiEnergySalesSurchargeCost2ValueTextBox;
        private System.Windows.Forms.Label uiEnergySalesSurchargeCost2Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uiPowerAverageCostPart2Label;
    }
}