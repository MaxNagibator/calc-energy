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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.uiPowerAverageCostLabel = new System.Windows.Forms.Label();
            this.uiPowerHourButton = new System.Windows.Forms.Button();
            this.uiPowerAverageCostSumLabel = new System.Windows.Forms.Label();
            this.uiPowerAverageCostSumValueLabel = new System.Windows.Forms.Label();
            this.uiPowerSalesSurchargeCostSumValueLabel = new System.Windows.Forms.Label();
            this.uiPowerSalesSurchargeCostSumLabel = new System.Windows.Forms.Label();
            this.uiPowerSalesSurchargeCostValueTextBox = new System.Windows.Forms.TextBox();
            this.uiPowerSalesSurchargeCostLabel = new System.Windows.Forms.Label();
            this.uiPowerTotalCostLabel = new System.Windows.Forms.Label();
            this.uiPowerTotalCostValueLabel = new System.Windows.Forms.Label();
            this.uiPowerTotalLabel = new System.Windows.Forms.Label();
            this.uiPowerTotalValueLabel = new System.Windows.Forms.Label();
            this.uiTotalCostLabel = new System.Windows.Forms.Label();
            this.uiTotalCostValueLabel = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiImportCostButton
            // 
            this.uiImportCostButton.Location = new System.Drawing.Point(179, 12);
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
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.uiMonthComboBox);
            this.panel9.Controls.Add(this.uiYearsComboBox);
            this.panel9.Controls.Add(this.button_Excel_Save);
            this.panel9.Controls.Add(this.button_Word_Save);
            this.panel9.Controls.Add(this.uiCalculateButton);
            this.panel9.Location = new System.Drawing.Point(12, 178);
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
            // 
            // uiYearsComboBox
            // 
            this.uiYearsComboBox.FormattingEnabled = true;
            this.uiYearsComboBox.Location = new System.Drawing.Point(34, 24);
            this.uiYearsComboBox.Name = "uiYearsComboBox";
            this.uiYearsComboBox.Size = new System.Drawing.Size(71, 21);
            this.uiYearsComboBox.TabIndex = 9;
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
            this.uiObjectRegistrationTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiObjectRegistrationTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiObjectRegistrationTreeView.Location = new System.Drawing.Point(12, 70);
            this.uiObjectRegistrationTreeView.Name = "uiObjectRegistrationTreeView";
            this.uiObjectRegistrationTreeView.Size = new System.Drawing.Size(386, 99);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiMainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.uiMainDataGridView.ColumnHeadersHeight = 31;
            this.uiMainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Points,
            this.Energy,
            this.Tariff,
            this.Summa});
            this.uiMainDataGridView.Location = new System.Drawing.Point(404, 12);
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.RowHeadersVisible = false;
            this.uiMainDataGridView.Size = new System.Drawing.Size(524, 238);
            this.uiMainDataGridView.TabIndex = 13;
            // 
            // Points
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Points.DefaultCellStyle = dataGridViewCellStyle12;
            this.Points.FillWeight = 120F;
            this.Points.HeaderText = "Интервал";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Points.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Energy
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Energy.DefaultCellStyle = dataGridViewCellStyle13;
            this.Energy.HeaderText = "А+, Вт/ч.";
            this.Energy.Name = "Energy";
            this.Energy.ReadOnly = true;
            this.Energy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Energy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tariff
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tariff.DefaultCellStyle = dataGridViewCellStyle14;
            this.Tariff.HeaderText = "Тариф, руб./кВт.ч.";
            this.Tariff.Name = "Tariff";
            this.Tariff.ReadOnly = true;
            this.Tariff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tariff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Summa
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Summa.DefaultCellStyle = dataGridViewCellStyle15;
            this.Summa.HeaderText = "Сумма, руб.";
            this.Summa.Name = "Summa";
            this.Summa.ReadOnly = true;
            this.Summa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Summa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // uiEnergyAverageCostSumLabel
            // 
            this.uiEnergyAverageCostSumLabel.AutoSize = true;
            this.uiEnergyAverageCostSumLabel.Location = new System.Drawing.Point(45, 347);
            this.uiEnergyAverageCostSumLabel.Name = "uiEnergyAverageCostSumLabel";
            this.uiEnergyAverageCostSumLabel.Size = new System.Drawing.Size(210, 13);
            this.uiEnergyAverageCostSumLabel.TabIndex = 14;
            this.uiEnergyAverageCostSumLabel.Text = "Средневзвешенная стоимость энергии:";
            // 
            // uiEnergyAverageCostValueLabel
            // 
            this.uiEnergyAverageCostValueLabel.AutoSize = true;
            this.uiEnergyAverageCostValueLabel.Location = new System.Drawing.Point(319, 347);
            this.uiEnergyAverageCostValueLabel.Name = "uiEnergyAverageCostValueLabel";
            this.uiEnergyAverageCostValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyAverageCostValueLabel.TabIndex = 15;
            this.uiEnergyAverageCostValueLabel.Text = "0";
            // 
            // uiEnergyTotalValueLabel
            // 
            this.uiEnergyTotalValueLabel.AutoSize = true;
            this.uiEnergyTotalValueLabel.Location = new System.Drawing.Point(318, 253);
            this.uiEnergyTotalValueLabel.Name = "uiEnergyTotalValueLabel";
            this.uiEnergyTotalValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyTotalValueLabel.TabIndex = 17;
            this.uiEnergyTotalValueLabel.Text = "0";
            // 
            // uiEnergyTotalLabel
            // 
            this.uiEnergyTotalLabel.AutoSize = true;
            this.uiEnergyTotalLabel.Location = new System.Drawing.Point(12, 253);
            this.uiEnergyTotalLabel.Name = "uiEnergyTotalLabel";
            this.uiEnergyTotalLabel.Size = new System.Drawing.Size(102, 13);
            this.uiEnergyTotalLabel.TabIndex = 16;
            this.uiEnergyTotalLabel.Text = "Всего энергии, Вт:";
            // 
            // uiEnergyTransferCostLabel
            // 
            this.uiEnergyTransferCostLabel.AutoSize = true;
            this.uiEnergyTransferCostLabel.Location = new System.Drawing.Point(398, 267);
            this.uiEnergyTransferCostLabel.Name = "uiEnergyTransferCostLabel";
            this.uiEnergyTransferCostLabel.Size = new System.Drawing.Size(211, 13);
            this.uiEnergyTransferCostLabel.TabIndex = 18;
            this.uiEnergyTransferCostLabel.Text = "Тариф на услуги по передаче э/энергии";
            // 
            // uiEnergyTransferCostTextBox
            // 
            this.uiEnergyTransferCostTextBox.Location = new System.Drawing.Point(829, 267);
            this.uiEnergyTransferCostTextBox.Name = "uiEnergyTransferCostTextBox";
            this.uiEnergyTransferCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiEnergyTransferCostTextBox.TabIndex = 19;
            this.uiEnergyTransferCostTextBox.Text = "1,36671";
            // 
            // uiEnergyTransferCostSumLabel
            // 
            this.uiEnergyTransferCostSumLabel.AutoSize = true;
            this.uiEnergyTransferCostSumLabel.Location = new System.Drawing.Point(45, 376);
            this.uiEnergyTransferCostSumLabel.Name = "uiEnergyTransferCostSumLabel";
            this.uiEnergyTransferCostSumLabel.Size = new System.Drawing.Size(196, 13);
            this.uiEnergyTransferCostSumLabel.TabIndex = 20;
            this.uiEnergyTransferCostSumLabel.Text = "Сумма филки по передаче э/энергии";
            // 
            // uiEnergyTransferCostSumValueLabel
            // 
            this.uiEnergyTransferCostSumValueLabel.AutoSize = true;
            this.uiEnergyTransferCostSumValueLabel.Location = new System.Drawing.Point(319, 376);
            this.uiEnergyTransferCostSumValueLabel.Name = "uiEnergyTransferCostSumValueLabel";
            this.uiEnergyTransferCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyTransferCostSumValueLabel.TabIndex = 21;
            this.uiEnergyTransferCostSumValueLabel.Text = "0";
            // 
            // uiEnergyOtherCostSumValueLabel
            // 
            this.uiEnergyOtherCostSumValueLabel.AutoSize = true;
            this.uiEnergyOtherCostSumValueLabel.Location = new System.Drawing.Point(319, 405);
            this.uiEnergyOtherCostSumValueLabel.Name = "uiEnergyOtherCostSumValueLabel";
            this.uiEnergyOtherCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyOtherCostSumValueLabel.TabIndex = 23;
            this.uiEnergyOtherCostSumValueLabel.Text = "0";
            // 
            // uiEnergyOtherCostSumLabel
            // 
            this.uiEnergyOtherCostSumLabel.AutoSize = true;
            this.uiEnergyOtherCostSumLabel.Location = new System.Drawing.Point(45, 405);
            this.uiEnergyOtherCostSumLabel.Name = "uiEnergyOtherCostSumLabel";
            this.uiEnergyOtherCostSumLabel.Size = new System.Drawing.Size(118, 13);
            this.uiEnergyOtherCostSumLabel.TabIndex = 22;
            this.uiEnergyOtherCostSumLabel.Text = "Плата за иные услуги";
            // 
            // uiEnergyOtherCostValueTextBox
            // 
            this.uiEnergyOtherCostValueTextBox.Location = new System.Drawing.Point(829, 293);
            this.uiEnergyOtherCostValueTextBox.Name = "uiEnergyOtherCostValueTextBox";
            this.uiEnergyOtherCostValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiEnergyOtherCostValueTextBox.TabIndex = 35;
            this.uiEnergyOtherCostValueTextBox.Text = "0,00092";
            // 
            // uiEnergyOtherCostLabel
            // 
            this.uiEnergyOtherCostLabel.AutoSize = true;
            this.uiEnergyOtherCostLabel.Location = new System.Drawing.Point(401, 296);
            this.uiEnergyOtherCostLabel.Name = "uiEnergyOtherCostLabel";
            this.uiEnergyOtherCostLabel.Size = new System.Drawing.Size(120, 13);
            this.uiEnergyOtherCostLabel.TabIndex = 34;
            this.uiEnergyOtherCostLabel.Text = "Тариф на иные услуги";
            // 
            // uiEnergySalesSurchargeCostValueTextBox
            // 
            this.uiEnergySalesSurchargeCostValueTextBox.Location = new System.Drawing.Point(828, 319);
            this.uiEnergySalesSurchargeCostValueTextBox.Name = "uiEnergySalesSurchargeCostValueTextBox";
            this.uiEnergySalesSurchargeCostValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiEnergySalesSurchargeCostValueTextBox.TabIndex = 41;
            this.uiEnergySalesSurchargeCostValueTextBox.Text = "0,83586";
            // 
            // uiEnergySalesSurchargeCostLabel
            // 
            this.uiEnergySalesSurchargeCostLabel.AutoSize = true;
            this.uiEnergySalesSurchargeCostLabel.Location = new System.Drawing.Point(397, 319);
            this.uiEnergySalesSurchargeCostLabel.Name = "uiEnergySalesSurchargeCostLabel";
            this.uiEnergySalesSurchargeCostLabel.Size = new System.Drawing.Size(102, 13);
            this.uiEnergySalesSurchargeCostLabel.TabIndex = 40;
            this.uiEnergySalesSurchargeCostLabel.Text = "СНЭот670до10Мвт";
            // 
            // uiEnergySalesSurchargeCostSumValueLabel
            // 
            this.uiEnergySalesSurchargeCostSumValueLabel.AutoSize = true;
            this.uiEnergySalesSurchargeCostSumValueLabel.Location = new System.Drawing.Point(318, 427);
            this.uiEnergySalesSurchargeCostSumValueLabel.Name = "uiEnergySalesSurchargeCostSumValueLabel";
            this.uiEnergySalesSurchargeCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergySalesSurchargeCostSumValueLabel.TabIndex = 43;
            this.uiEnergySalesSurchargeCostSumValueLabel.Text = "0";
            // 
            // uiEnergySalesSurchargeCostSumLabel
            // 
            this.uiEnergySalesSurchargeCostSumLabel.AutoSize = true;
            this.uiEnergySalesSurchargeCostSumLabel.Location = new System.Drawing.Point(44, 427);
            this.uiEnergySalesSurchargeCostSumLabel.Name = "uiEnergySalesSurchargeCostSumLabel";
            this.uiEnergySalesSurchargeCostSumLabel.Size = new System.Drawing.Size(169, 13);
            this.uiEnergySalesSurchargeCostSumLabel.TabIndex = 42;
            this.uiEnergySalesSurchargeCostSumLabel.Text = "Сбытовая надбавка на енергию";
            // 
            // uiEnergyTotalCostValueLabel
            // 
            this.uiEnergyTotalCostValueLabel.AutoSize = true;
            this.uiEnergyTotalCostValueLabel.Location = new System.Drawing.Point(319, 315);
            this.uiEnergyTotalCostValueLabel.Name = "uiEnergyTotalCostValueLabel";
            this.uiEnergyTotalCostValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiEnergyTotalCostValueLabel.TabIndex = 45;
            this.uiEnergyTotalCostValueLabel.Text = "0";
            // 
            // uiEnergyTotalCostLabel
            // 
            this.uiEnergyTotalCostLabel.AutoSize = true;
            this.uiEnergyTotalCostLabel.Location = new System.Drawing.Point(12, 315);
            this.uiEnergyTotalCostLabel.Name = "uiEnergyTotalCostLabel";
            this.uiEnergyTotalCostLabel.Size = new System.Drawing.Size(257, 13);
            this.uiEnergyTotalCostLabel.TabIndex = 44;
            this.uiEnergyTotalCostLabel.Text = "Ставка на электроэнергию по тарифу(цене) в т.ч.";
            // 
            // uiPowerAverageCostTextBox
            // 
            this.uiPowerAverageCostTextBox.Location = new System.Drawing.Point(828, 342);
            this.uiPowerAverageCostTextBox.Name = "uiPowerAverageCostTextBox";
            this.uiPowerAverageCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiPowerAverageCostTextBox.TabIndex = 47;
            this.uiPowerAverageCostTextBox.Text = "0,18894623";
            // 
            // uiPowerAverageCostLabel
            // 
            this.uiPowerAverageCostLabel.AutoSize = true;
            this.uiPowerAverageCostLabel.Location = new System.Drawing.Point(397, 345);
            this.uiPowerAverageCostLabel.Name = "uiPowerAverageCostLabel";
            this.uiPowerAverageCostLabel.Size = new System.Drawing.Size(425, 13);
            this.uiPowerAverageCostLabel.TabIndex = 46;
            this.uiPowerAverageCostLabel.Text = "Средневзвешенная нерегулируемая цена на мощность на оптовом рынке. руб/Вт";
            // 
            // uiPowerHourButton
            // 
            this.uiPowerHourButton.Location = new System.Drawing.Point(179, 41);
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
            this.uiPowerAverageCostSumLabel.Location = new System.Drawing.Point(46, 496);
            this.uiPowerAverageCostSumLabel.Name = "uiPowerAverageCostSumLabel";
            this.uiPowerAverageCostSumLabel.Size = new System.Drawing.Size(161, 13);
            this.uiPowerAverageCostSumLabel.TabIndex = 49;
            this.uiPowerAverageCostSumLabel.Text = "Средневзвешанная мощность";
            // 
            // uiPowerAverageCostSumValueLabel
            // 
            this.uiPowerAverageCostSumValueLabel.AutoSize = true;
            this.uiPowerAverageCostSumValueLabel.Location = new System.Drawing.Point(318, 496);
            this.uiPowerAverageCostSumValueLabel.Name = "uiPowerAverageCostSumValueLabel";
            this.uiPowerAverageCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiPowerAverageCostSumValueLabel.TabIndex = 50;
            this.uiPowerAverageCostSumValueLabel.Text = "0";
            // 
            // uiPowerSalesSurchargeCostSumValueLabel
            // 
            this.uiPowerSalesSurchargeCostSumValueLabel.AutoSize = true;
            this.uiPowerSalesSurchargeCostSumValueLabel.Location = new System.Drawing.Point(318, 519);
            this.uiPowerSalesSurchargeCostSumValueLabel.Name = "uiPowerSalesSurchargeCostSumValueLabel";
            this.uiPowerSalesSurchargeCostSumValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiPowerSalesSurchargeCostSumValueLabel.TabIndex = 52;
            this.uiPowerSalesSurchargeCostSumValueLabel.Text = "0";
            // 
            // uiPowerSalesSurchargeCostSumLabel
            // 
            this.uiPowerSalesSurchargeCostSumLabel.AutoSize = true;
            this.uiPowerSalesSurchargeCostSumLabel.Location = new System.Drawing.Point(46, 519);
            this.uiPowerSalesSurchargeCostSumLabel.Name = "uiPowerSalesSurchargeCostSumLabel";
            this.uiPowerSalesSurchargeCostSumLabel.Size = new System.Drawing.Size(177, 13);
            this.uiPowerSalesSurchargeCostSumLabel.TabIndex = 51;
            this.uiPowerSalesSurchargeCostSumLabel.Text = "Сбытовая надбавка на можность";
            // 
            // uiPowerSalesSurchargeCostValueTextBox
            // 
            this.uiPowerSalesSurchargeCostValueTextBox.Location = new System.Drawing.Point(828, 368);
            this.uiPowerSalesSurchargeCostValueTextBox.Name = "uiPowerSalesSurchargeCostValueTextBox";
            this.uiPowerSalesSurchargeCostValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiPowerSalesSurchargeCostValueTextBox.TabIndex = 54;
            this.uiPowerSalesSurchargeCostValueTextBox.Text = "0,18894623";
            // 
            // uiPowerSalesSurchargeCostLabel
            // 
            this.uiPowerSalesSurchargeCostLabel.AutoSize = true;
            this.uiPowerSalesSurchargeCostLabel.Location = new System.Drawing.Point(397, 368);
            this.uiPowerSalesSurchargeCostLabel.Name = "uiPowerSalesSurchargeCostLabel";
            this.uiPowerSalesSurchargeCostLabel.Size = new System.Drawing.Size(104, 13);
            this.uiPowerSalesSurchargeCostLabel.TabIndex = 53;
            this.uiPowerSalesSurchargeCostLabel.Text = "СНМот670до10Мвт";
            // 
            // uiPowerTotalCostLabel
            // 
            this.uiPowerTotalCostLabel.AutoSize = true;
            this.uiPowerTotalCostLabel.Location = new System.Drawing.Point(15, 470);
            this.uiPowerTotalCostLabel.Name = "uiPowerTotalCostLabel";
            this.uiPowerTotalCostLabel.Size = new System.Drawing.Size(296, 13);
            this.uiPowerTotalCostLabel.TabIndex = 55;
            this.uiPowerTotalCostLabel.Text = "Ставка за мощность, приобретаемую покупателем в т.ч.";
            // 
            // uiPowerTotalCostValueLabel
            // 
            this.uiPowerTotalCostValueLabel.AutoSize = true;
            this.uiPowerTotalCostValueLabel.Location = new System.Drawing.Point(317, 470);
            this.uiPowerTotalCostValueLabel.Name = "uiPowerTotalCostValueLabel";
            this.uiPowerTotalCostValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiPowerTotalCostValueLabel.TabIndex = 50;
            this.uiPowerTotalCostValueLabel.Text = "0";
            // 
            // uiPowerTotalLabel
            // 
            this.uiPowerTotalLabel.AutoSize = true;
            this.uiPowerTotalLabel.Location = new System.Drawing.Point(12, 274);
            this.uiPowerTotalLabel.Name = "uiPowerTotalLabel";
            this.uiPowerTotalLabel.Size = new System.Drawing.Size(113, 13);
            this.uiPowerTotalLabel.TabIndex = 16;
            this.uiPowerTotalLabel.Text = "Всего мощности, Вт:";
            // 
            // uiPowerTotalValueLabel
            // 
            this.uiPowerTotalValueLabel.AutoSize = true;
            this.uiPowerTotalValueLabel.Location = new System.Drawing.Point(318, 274);
            this.uiPowerTotalValueLabel.Name = "uiPowerTotalValueLabel";
            this.uiPowerTotalValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiPowerTotalValueLabel.TabIndex = 17;
            this.uiPowerTotalValueLabel.Text = "0";
            // 
            // uiTotalCostLabel
            // 
            this.uiTotalCostLabel.AutoSize = true;
            this.uiTotalCostLabel.Location = new System.Drawing.Point(9, 292);
            this.uiTotalCostLabel.Name = "uiTotalCostLabel";
            this.uiTotalCostLabel.Size = new System.Drawing.Size(91, 13);
            this.uiTotalCostLabel.TabIndex = 56;
            this.uiTotalCostLabel.Text = "Всего по тарифу";
            // 
            // uiTotalCostValueLabel
            // 
            this.uiTotalCostValueLabel.AutoSize = true;
            this.uiTotalCostValueLabel.Location = new System.Drawing.Point(319, 292);
            this.uiTotalCostValueLabel.Name = "uiTotalCostValueLabel";
            this.uiTotalCostValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uiTotalCostValueLabel.TabIndex = 57;
            this.uiTotalCostValueLabel.Text = "0";
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 667);
            this.Controls.Add(this.uiTotalCostValueLabel);
            this.Controls.Add(this.uiTotalCostLabel);
            this.Controls.Add(this.uiPowerTotalCostLabel);
            this.Controls.Add(this.uiPowerSalesSurchargeCostValueTextBox);
            this.Controls.Add(this.uiPowerSalesSurchargeCostLabel);
            this.Controls.Add(this.uiPowerSalesSurchargeCostSumValueLabel);
            this.Controls.Add(this.uiPowerSalesSurchargeCostSumLabel);
            this.Controls.Add(this.uiPowerTotalCostValueLabel);
            this.Controls.Add(this.uiPowerAverageCostSumValueLabel);
            this.Controls.Add(this.uiPowerAverageCostSumLabel);
            this.Controls.Add(this.uiPowerHourButton);
            this.Controls.Add(this.uiPowerAverageCostTextBox);
            this.Controls.Add(this.uiPowerAverageCostLabel);
            this.Controls.Add(this.uiEnergyTotalCostValueLabel);
            this.Controls.Add(this.uiEnergyTotalCostLabel);
            this.Controls.Add(this.uiEnergySalesSurchargeCostSumValueLabel);
            this.Controls.Add(this.uiEnergySalesSurchargeCostSumLabel);
            this.Controls.Add(this.uiEnergySalesSurchargeCostValueTextBox);
            this.Controls.Add(this.uiEnergySalesSurchargeCostLabel);
            this.Controls.Add(this.uiEnergyOtherCostValueTextBox);
            this.Controls.Add(this.uiEnergyOtherCostLabel);
            this.Controls.Add(this.uiEnergyOtherCostSumValueLabel);
            this.Controls.Add(this.uiEnergyOtherCostSumLabel);
            this.Controls.Add(this.uiEnergyTransferCostSumValueLabel);
            this.Controls.Add(this.uiEnergyTransferCostSumLabel);
            this.Controls.Add(this.uiEnergyTransferCostTextBox);
            this.Controls.Add(this.uiEnergyTransferCostLabel);
            this.Controls.Add(this.uiPowerTotalValueLabel);
            this.Controls.Add(this.uiEnergyTotalValueLabel);
            this.Controls.Add(this.uiPowerTotalLabel);
            this.Controls.Add(this.uiEnergyTotalLabel);
            this.Controls.Add(this.uiEnergyAverageCostValueLabel);
            this.Controls.Add(this.uiEnergyAverageCostSumLabel);
            this.Controls.Add(this.uiMainDataGridView);
            this.Controls.Add(this.uiObjectRegistrationTreeView);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.uiOldMainFormButton);
            this.Controls.Add(this.uiImportCostButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculateForm";
            this.Text = "Расчёт стоимости";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
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
        private System.Windows.Forms.Label uiPowerAverageCostLabel;
        private System.Windows.Forms.Button uiPowerHourButton;
        private System.Windows.Forms.Label uiPowerAverageCostSumLabel;
        private System.Windows.Forms.Label uiPowerAverageCostSumValueLabel;
        private System.Windows.Forms.Label uiPowerSalesSurchargeCostSumValueLabel;
        private System.Windows.Forms.Label uiPowerSalesSurchargeCostSumLabel;
        private System.Windows.Forms.TextBox uiPowerSalesSurchargeCostValueTextBox;
        private System.Windows.Forms.Label uiPowerSalesSurchargeCostLabel;
        private System.Windows.Forms.Label uiPowerTotalCostLabel;
        private System.Windows.Forms.Label uiPowerTotalCostValueLabel;
        private System.Windows.Forms.Label uiPowerTotalLabel;
        private System.Windows.Forms.Label uiPowerTotalValueLabel;
        private System.Windows.Forms.Label uiTotalCostLabel;
        private System.Windows.Forms.Label uiTotalCostValueLabel;
    }
}