﻿namespace TM_2
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
            this.uiEnergyTransferCostLabel = new System.Windows.Forms.Label();
            this.uiEnergyTransferCostTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergyOtherCostValueTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergyOtherCostLabel = new System.Windows.Forms.Label();
            this.uiEnergySalesSurchargeCostValueTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergySalesSurchargeCostLabel = new System.Windows.Forms.Label();
            this.uiPowerAverageCostTextBox = new System.Windows.Forms.TextBox();
            this.uiPowerAverageCostPart1Label = new System.Windows.Forms.Label();
            this.uiPowerHourButton = new System.Windows.Forms.Button();
            this.uiEnergySalesSurchargeCost2ValueTextBox = new System.Windows.Forms.TextBox();
            this.uiEnergySalesSurchargeCost2Label = new System.Windows.Forms.Label();
            this.uiPowerAverageCostPart2Label = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
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
            this.panel9.Size = new System.Drawing.Size(391, 72);
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
            this.uiObjectRegistrationTreeView.Size = new System.Drawing.Size(391, 65);
            this.uiObjectRegistrationTreeView.TabIndex = 12;
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
            this.ClientSize = new System.Drawing.Size(424, 399);
            this.Controls.Add(this.uiPowerAverageCostPart2Label);
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
        private System.Windows.Forms.Label uiEnergyTransferCostLabel;
        private System.Windows.Forms.TextBox uiEnergyTransferCostTextBox;
        private System.Windows.Forms.TextBox uiEnergyOtherCostValueTextBox;
        private System.Windows.Forms.Label uiEnergyOtherCostLabel;
        private System.Windows.Forms.TextBox uiEnergySalesSurchargeCostValueTextBox;
        private System.Windows.Forms.Label uiEnergySalesSurchargeCostLabel;
        private System.Windows.Forms.TextBox uiPowerAverageCostTextBox;
        private System.Windows.Forms.Label uiPowerAverageCostPart1Label;
        private System.Windows.Forms.Button uiPowerHourButton;
        private System.Windows.Forms.TextBox uiEnergySalesSurchargeCost2ValueTextBox;
        private System.Windows.Forms.Label uiEnergySalesSurchargeCost2Label;
        private System.Windows.Forms.Label uiPowerAverageCostPart2Label;
    }
}