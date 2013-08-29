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
            this.uiCalcButton = new System.Windows.Forms.Button();
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Energy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tariff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiCalcButton
            // 
            this.uiCalcButton.Location = new System.Drawing.Point(12, 12);
            this.uiCalcButton.Name = "uiCalcButton";
            this.uiCalcButton.Size = new System.Drawing.Size(75, 23);
            this.uiCalcButton.TabIndex = 0;
            this.uiCalcButton.Text = "расчитать";
            this.uiCalcButton.UseVisualStyleBackColor = true;
            // 
            // uiImportCostButton
            // 
            this.uiImportCostButton.Location = new System.Drawing.Point(346, 12);
            this.uiImportCostButton.Name = "uiImportCostButton";
            this.uiImportCostButton.Size = new System.Drawing.Size(171, 23);
            this.uiImportCostButton.TabIndex = 1;
            this.uiImportCostButton.Text = "импортировать ценник";
            this.uiImportCostButton.UseVisualStyleBackColor = true;
            this.uiImportCostButton.Click += new System.EventHandler(this.uiImportCostButton_Click);
            // 
            // uiOldMainFormButton
            // 
            this.uiOldMainFormButton.Location = new System.Drawing.Point(262, 269);
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
            this.uiObjectRegistrationTreeView.Location = new System.Drawing.Point(12, 73);
            this.uiObjectRegistrationTreeView.Name = "uiObjectRegistrationTreeView";
            this.uiObjectRegistrationTreeView.Size = new System.Drawing.Size(366, 84);
            this.uiObjectRegistrationTreeView.TabIndex = 12;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 31;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Points,
            this.Energy,
            this.Tariff,
            this.Summa});
            this.dataGridView.Location = new System.Drawing.Point(568, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(478, 314);
            this.dataGridView.TabIndex = 13;
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
            this.Energy.HeaderText = "А+, кВт/ч.";
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
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 353);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.uiObjectRegistrationTreeView);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.uiOldMainFormButton);
            this.Controls.Add(this.uiImportCostButton);
            this.Controls.Add(this.uiCalcButton);
            this.Name = "CalculateForm";
            this.Text = "CalculateForm";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiCalcButton;
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn Energy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tariff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summa;
    }
}