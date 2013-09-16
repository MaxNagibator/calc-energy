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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateForm));
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.uiMonthComboBox = new System.Windows.Forms.ComboBox();
            this.uiYearsComboBox = new System.Windows.Forms.ComboBox();
            this.uiCalculateButton = new System.Windows.Forms.Button();
            this.uiObjectRegistrationTreeView = new System.Windows.Forms.TreeView();
            this.uiEnergyTransferCostLabel = new System.Windows.Forms.Label();
            this.uiEnergyTransferCostTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergyOtherCostValueTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergyOtherCostLabel = new System.Windows.Forms.Label();
            this.uiEnergySalesSurchargeCostValueTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergySalesSurchargeCostLabel = new System.Windows.Forms.Label();
            this.uiPowerAverageCostTextBox = new System.Windows.Forms.TextBox();
            this.uiPowerAverageCostPart1Label = new System.Windows.Forms.Label();
            this.uiEnergySalesSurchargeCost2ValueTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergySalesSurchargeCost2Label = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.uiImportCostToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiImportPowerHourToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel9.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.uiMonthComboBox);
            this.panel9.Controls.Add(this.uiYearsComboBox);
            this.panel9.Controls.Add(this.uiCalculateButton);
            this.panel9.Location = new System.Drawing.Point(12, 177);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(557, 72);
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
            this.uiMonthComboBox.TabIndex = 216;
            this.uiMonthComboBox.SelectedValueChanged += new System.EventHandler(this.uiDatesComboBox_SelectedValueChanged);
            // 
            // uiYearsComboBox
            // 
            this.uiYearsComboBox.FormattingEnabled = true;
            this.uiYearsComboBox.Location = new System.Drawing.Point(34, 24);
            this.uiYearsComboBox.Name = "uiYearsComboBox";
            this.uiYearsComboBox.Size = new System.Drawing.Size(71, 21);
            this.uiYearsComboBox.TabIndex = 215;
            this.uiYearsComboBox.SelectedValueChanged += new System.EventHandler(this.uiDatesComboBox_SelectedValueChanged);
            // 
            // uiCalculateButton
            // 
            this.uiCalculateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiCalculateButton.BackgroundImage")));
            this.uiCalculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiCalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCalculateButton.Location = new System.Drawing.Point(239, 13);
            this.uiCalculateButton.Name = "uiCalculateButton";
            this.uiCalculateButton.Size = new System.Drawing.Size(40, 40);
            this.uiCalculateButton.TabIndex = 222;
            this.toolTip1.SetToolTip(this.uiCalculateButton, "посчитать стоимость электроенергии за выбранный месяц");
            this.uiCalculateButton.UseVisualStyleBackColor = true;
            this.uiCalculateButton.Click += new System.EventHandler(this.uiCalculateButton_Click);
            // 
            // uiObjectRegistrationTreeView
            // 
            this.uiObjectRegistrationTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiObjectRegistrationTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiObjectRegistrationTreeView.Location = new System.Drawing.Point(12, 74);
            this.uiObjectRegistrationTreeView.Name = "uiObjectRegistrationTreeView";
            this.uiObjectRegistrationTreeView.Size = new System.Drawing.Size(557, 94);
            this.uiObjectRegistrationTreeView.TabIndex = 12;
            this.uiObjectRegistrationTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.uiObjectRegistrationTreeView_AfterSelect);
            // 
            // uiEnergyTransferCostLabel
            // 
            this.uiEnergyTransferCostLabel.AutoSize = true;
            this.uiEnergyTransferCostLabel.Location = new System.Drawing.Point(12, 263);
            this.uiEnergyTransferCostLabel.Name = "uiEnergyTransferCostLabel";
            this.uiEnergyTransferCostLabel.Size = new System.Drawing.Size(254, 13);
            this.uiEnergyTransferCostLabel.TabIndex = 18;
            this.uiEnergyTransferCostLabel.Text = "Тариф на услуги по передаче э/энергии руб/кВт";
            // 
            // uiEnergyTransferCostTextBox
            // 
            this.uiEnergyTransferCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiEnergyTransferCostTextBox.Location = new System.Drawing.Point(457, 260);
            this.uiEnergyTransferCostTextBox.Name = "uiEnergyTransferCostTextBox";
            this.uiEnergyTransferCostTextBox.Size = new System.Drawing.Size(112, 20);
            this.uiEnergyTransferCostTextBox.TabIndex = 217;
            this.uiEnergyTransferCostTextBox.Text = "1,36671";
            this.uiEnergyTransferCostTextBox.Leave += new System.EventHandler(this.uiCoefficientTextBox_Leave);
            // 
            // uiEnergyOtherCostValueTextBox
            // 
            this.uiEnergyOtherCostValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiEnergyOtherCostValueTextBox.Location = new System.Drawing.Point(457, 286);
            this.uiEnergyOtherCostValueTextBox.Name = "uiEnergyOtherCostValueTextBox";
            this.uiEnergyOtherCostValueTextBox.Size = new System.Drawing.Size(112, 20);
            this.uiEnergyOtherCostValueTextBox.TabIndex = 218;
            this.uiEnergyOtherCostValueTextBox.Text = "0,00092";
            this.uiEnergyOtherCostValueTextBox.Leave += new System.EventHandler(this.uiCoefficientTextBox_Leave);
            // 
            // uiEnergyOtherCostLabel
            // 
            this.uiEnergyOtherCostLabel.AutoSize = true;
            this.uiEnergyOtherCostLabel.Location = new System.Drawing.Point(12, 289);
            this.uiEnergyOtherCostLabel.Name = "uiEnergyOtherCostLabel";
            this.uiEnergyOtherCostLabel.Size = new System.Drawing.Size(163, 13);
            this.uiEnergyOtherCostLabel.TabIndex = 34;
            this.uiEnergyOtherCostLabel.Text = "Тариф на иные услуги руб/кВт";
            // 
            // uiEnergySalesSurchargeCostValueTextBox
            // 
            this.uiEnergySalesSurchargeCostValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiEnergySalesSurchargeCostValueTextBox.Location = new System.Drawing.Point(457, 341);
            this.uiEnergySalesSurchargeCostValueTextBox.Name = "uiEnergySalesSurchargeCostValueTextBox";
            this.uiEnergySalesSurchargeCostValueTextBox.Size = new System.Drawing.Size(112, 20);
            this.uiEnergySalesSurchargeCostValueTextBox.TabIndex = 220;
            this.uiEnergySalesSurchargeCostValueTextBox.Text = "1,83";
            this.uiEnergySalesSurchargeCostValueTextBox.Leave += new System.EventHandler(this.uiCoefficientTextBox_Leave);
            // 
            // uiEnergySalesSurchargeCostLabel
            // 
            this.uiEnergySalesSurchargeCostLabel.AutoSize = true;
            this.uiEnergySalesSurchargeCostLabel.Location = new System.Drawing.Point(12, 341);
            this.uiEnergySalesSurchargeCostLabel.Name = "uiEnergySalesSurchargeCostLabel";
            this.uiEnergySalesSurchargeCostLabel.Size = new System.Drawing.Size(232, 13);
            this.uiEnergySalesSurchargeCostLabel.TabIndex = 40;
            this.uiEnergySalesSurchargeCostLabel.Text = "Сбытовая надбавка коэффициент 2 руб/кВт";
            // 
            // uiPowerAverageCostTextBox
            // 
            this.uiPowerAverageCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPowerAverageCostTextBox.Location = new System.Drawing.Point(457, 367);
            this.uiPowerAverageCostTextBox.Name = "uiPowerAverageCostTextBox";
            this.uiPowerAverageCostTextBox.Size = new System.Drawing.Size(112, 20);
            this.uiPowerAverageCostTextBox.TabIndex = 221;
            this.uiPowerAverageCostTextBox.Text = "188,94623";
            this.uiPowerAverageCostTextBox.Leave += new System.EventHandler(this.uiCoefficientTextBox_Leave);
            // 
            // uiPowerAverageCostPart1Label
            // 
            this.uiPowerAverageCostPart1Label.AutoSize = true;
            this.uiPowerAverageCostPart1Label.Location = new System.Drawing.Point(12, 367);
            this.uiPowerAverageCostPart1Label.Name = "uiPowerAverageCostPart1Label";
            this.uiPowerAverageCostPart1Label.Size = new System.Drawing.Size(431, 13);
            this.uiPowerAverageCostPart1Label.TabIndex = 46;
            this.uiPowerAverageCostPart1Label.Text = "Средневзвешенная нерегулируемая цена на мощность на оптовом рынке. руб/кВт";
            // 
            // uiEnergySalesSurchargeCost2ValueTextBox
            // 
            this.uiEnergySalesSurchargeCost2ValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiEnergySalesSurchargeCost2ValueTextBox.Location = new System.Drawing.Point(457, 312);
            this.uiEnergySalesSurchargeCost2ValueTextBox.Name = "uiEnergySalesSurchargeCost2ValueTextBox";
            this.uiEnergySalesSurchargeCost2ValueTextBox.Size = new System.Drawing.Size(112, 20);
            this.uiEnergySalesSurchargeCost2ValueTextBox.TabIndex = 219;
            this.uiEnergySalesSurchargeCost2ValueTextBox.Text = "0,1315";
            this.uiEnergySalesSurchargeCost2ValueTextBox.Leave += new System.EventHandler(this.uiCoefficientTextBox_Leave);
            // 
            // uiEnergySalesSurchargeCost2Label
            // 
            this.uiEnergySalesSurchargeCost2Label.AutoSize = true;
            this.uiEnergySalesSurchargeCost2Label.Location = new System.Drawing.Point(12, 315);
            this.uiEnergySalesSurchargeCost2Label.Name = "uiEnergySalesSurchargeCost2Label";
            this.uiEnergySalesSurchargeCost2Label.Size = new System.Drawing.Size(232, 13);
            this.uiEnergySalesSurchargeCost2Label.TabIndex = 58;
            this.uiEnergySalesSurchargeCost2Label.Text = "Сбытовая надбавка коэффициент 1 руб/кВт";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiImportCostToolStripButton,
            this.uiImportPowerHourToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(590, 71);
            this.toolStrip1.TabIndex = 62;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uiImportCostToolStripButton
            // 
            this.uiImportCostToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiImportCostToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiImportCostToolStripButton.Image")));
            this.uiImportCostToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiImportCostToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiImportCostToolStripButton.Name = "uiImportCostToolStripButton";
            this.uiImportCostToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.uiImportCostToolStripButton.Text = resources.GetString("uiImportCostToolStripButton.Text");
            this.uiImportCostToolStripButton.ToolTipText = resources.GetString("uiImportCostToolStripButton.ToolTipText");
            this.uiImportCostToolStripButton.Click += new System.EventHandler(this.uiImportCostToolStripButton_Click);
            // 
            // uiImportPowerHourToolStripButton
            // 
            this.uiImportPowerHourToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiImportPowerHourToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiImportPowerHourToolStripButton.Image")));
            this.uiImportPowerHourToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiImportPowerHourToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiImportPowerHourToolStripButton.Name = "uiImportPowerHourToolStripButton";
            this.uiImportPowerHourToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.uiImportPowerHourToolStripButton.Text = "импортировать час максимального совокупного потребления электроэнергии в субъекте" +
    " Российской Федерации";
            this.uiImportPowerHourToolStripButton.ToolTipText = "импортировать час максимального совокупного потребления \r\nэлектроэнергии в субъек" +
    "те Российской Федерации";
            this.uiImportPowerHourToolStripButton.Click += new System.EventHandler(this.uiImportPowerHourToolStripButton_Click);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 401);
            this.Controls.Add(this.uiEnergySalesSurchargeCost2ValueTextBox);
            this.Controls.Add(this.uiEnergySalesSurchargeCost2Label);
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
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculateForm";
            this.Text = "Расчёт стоимости электроэнергии";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox uiMonthComboBox;
        private System.Windows.Forms.ComboBox uiYearsComboBox;
        private System.Windows.Forms.Button uiCalculateButton;
        private System.Windows.Forms.TreeView uiObjectRegistrationTreeView;
        private System.Windows.Forms.Label uiEnergyTransferCostLabel;
        private System.Windows.Forms.TextBox uiEnergyTransferCostTextBox;
        private System.Windows.Forms.TextBox uiEnergyOtherCostValueTextBox;
        private System.Windows.Forms.Label uiEnergyOtherCostLabel;
        private System.Windows.Forms.TextBox uiEnergySalesSurchargeCostValueTextBox;
        private System.Windows.Forms.Label uiEnergySalesSurchargeCostLabel;
        private System.Windows.Forms.TextBox uiPowerAverageCostTextBox;
        private System.Windows.Forms.Label uiPowerAverageCostPart1Label;
        private System.Windows.Forms.TextBox uiEnergySalesSurchargeCost2ValueTextBox;
        private System.Windows.Forms.Label uiEnergySalesSurchargeCost2Label;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton uiImportCostToolStripButton;
        private System.Windows.Forms.ToolStripButton uiImportPowerHourToolStripButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}