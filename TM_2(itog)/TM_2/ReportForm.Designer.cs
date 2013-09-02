namespace TM_2
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.uiMainDataGridView = new System.Windows.Forms.DataGridView();
            this.uiNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiMeasureCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiMeasureNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiCostSumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiAkcizeSumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiTaxValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiTaxSumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiTotalSumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiMainDataGridView
            // 
            this.uiMainDataGridView.AllowUserToAddRows = false;
            this.uiMainDataGridView.AllowUserToDeleteRows = false;
            this.uiMainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiMainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uiMainDataGridView.ColumnHeadersHeight = 50;
            this.uiMainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uiNameColumn,
            this.uiMeasureCodeColumn,
            this.uiMeasureNameColumn,
            this.uiCountColumn,
            this.uiCostColumn,
            this.uiCostSumColumn,
            this.uiAkcizeSumColumn,
            this.uiTaxValueColumn,
            this.uiTaxSumColumn,
            this.uiTotalSumColumn});
            this.uiMainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.RowHeadersVisible = false;
            this.uiMainDataGridView.Size = new System.Drawing.Size(1064, 540);
            this.uiMainDataGridView.TabIndex = 14;
            // 
            // uiNameColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.uiNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.uiNameColumn.HeaderText = "Наименование товара";
            this.uiNameColumn.Name = "uiNameColumn";
            this.uiNameColumn.ReadOnly = true;
            this.uiNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uiNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // uiMeasureCodeColumn
            // 
            this.uiMeasureCodeColumn.HeaderText = "Еденица измерения: Код";
            this.uiMeasureCodeColumn.Name = "uiMeasureCodeColumn";
            this.uiMeasureCodeColumn.ReadOnly = true;
            this.uiMeasureCodeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // uiMeasureNameColumn
            // 
            this.uiMeasureNameColumn.HeaderText = "Еденица измерения: Условное обозначение";
            this.uiMeasureNameColumn.Name = "uiMeasureNameColumn";
            this.uiMeasureNameColumn.ReadOnly = true;
            this.uiMeasureNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // uiCountColumn
            // 
            this.uiCountColumn.HeaderText = "Количество (объем)";
            this.uiCountColumn.Name = "uiCountColumn";
            this.uiCountColumn.ReadOnly = true;
            // 
            // uiCostColumn
            // 
            this.uiCostColumn.HeaderText = "Цена (тариф)";
            this.uiCostColumn.Name = "uiCostColumn";
            this.uiCostColumn.ReadOnly = true;
            // 
            // uiCostSumColumn
            // 
            this.uiCostSumColumn.HeaderText = "Стоимость товара без налога";
            this.uiCostSumColumn.Name = "uiCostSumColumn";
            this.uiCostSumColumn.ReadOnly = true;
            // 
            // uiAkcizeSumColumn
            // 
            this.uiAkcizeSumColumn.HeaderText = "В том числе сумма акциза";
            this.uiAkcizeSumColumn.Name = "uiAkcizeSumColumn";
            this.uiAkcizeSumColumn.ReadOnly = true;
            // 
            // uiTaxValueColumn
            // 
            this.uiTaxValueColumn.HeaderText = "Налоговая ставка";
            this.uiTaxValueColumn.Name = "uiTaxValueColumn";
            this.uiTaxValueColumn.ReadOnly = true;
            // 
            // uiTaxSumColumn
            // 
            this.uiTaxSumColumn.HeaderText = "Сумма налога";
            this.uiTaxSumColumn.Name = "uiTaxSumColumn";
            this.uiTaxSumColumn.ReadOnly = true;
            // 
            // uiTotalSumColumn
            // 
            this.uiTotalSumColumn.HeaderText = "Стоимость товара с налогом";
            this.uiTotalSumColumn.Name = "uiTotalSumColumn";
            this.uiTotalSumColumn.ReadOnly = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 540);
            this.Controls.Add(this.uiMainDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiMainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiMeasureCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiMeasureNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiCostSumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiAkcizeSumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiTaxValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiTaxSumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiTotalSumColumn;
    }
}