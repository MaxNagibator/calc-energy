/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 17.06.2013
 * Time: 6:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TM_2
{
    partial class ImportCostForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.uiMainDataGridView = new System.Windows.Forms.DataGridView();
            this.OpenFileStringBox = new System.Windows.Forms.TextBox();
            this.uiOpenXlsButton = new System.Windows.Forms.Button();
            this.uiLoadToDataBaseButton = new System.Windows.Forms.Button();
            this.uiCancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uiCoastColumnTextBox = new System.Windows.Forms.TextBox();
            this.uiCoastRowTextBox = new System.Windows.Forms.TextBox();
            this.uiDateColumnTextBox = new System.Windows.Forms.TextBox();
            this.uiDateRowTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл";
            // 
            // uiMainDataGridView
            // 
            this.uiMainDataGridView.AllowUserToAddRows = false;
            this.uiMainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiMainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiMainDataGridView.Location = new System.Drawing.Point(12, 159);
            this.uiMainDataGridView.MultiSelect = false;
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.ReadOnly = true;
            this.uiMainDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.uiMainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.uiMainDataGridView.Size = new System.Drawing.Size(992, 577);
            this.uiMainDataGridView.TabIndex = 1;
            // 
            // OpenFileStringBox
            // 
            this.OpenFileStringBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileStringBox.Location = new System.Drawing.Point(55, 9);
            this.OpenFileStringBox.Name = "OpenFileStringBox";
            this.OpenFileStringBox.Size = new System.Drawing.Size(862, 20);
            this.OpenFileStringBox.TabIndex = 2;
            // 
            // uiOpenXlsButton
            // 
            this.uiOpenXlsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOpenXlsButton.AutoSize = true;
            this.uiOpenXlsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiOpenXlsButton.Location = new System.Drawing.Point(923, 7);
            this.uiOpenXlsButton.Name = "uiOpenXlsButton";
            this.uiOpenXlsButton.Size = new System.Drawing.Size(75, 27);
            this.uiOpenXlsButton.TabIndex = 3;
            this.uiOpenXlsButton.Text = "Открыть";
            this.uiOpenXlsButton.UseVisualStyleBackColor = true;
            this.uiOpenXlsButton.Click += new System.EventHandler(this.uiOpenXlsButton_Click);
            // 
            // uiLoadToDataBaseButton
            // 
            this.uiLoadToDataBaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLoadToDataBaseButton.AutoSize = true;
            this.uiLoadToDataBaseButton.Enabled = false;
            this.uiLoadToDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiLoadToDataBaseButton.Location = new System.Drawing.Point(722, 35);
            this.uiLoadToDataBaseButton.Name = "uiLoadToDataBaseButton";
            this.uiLoadToDataBaseButton.Size = new System.Drawing.Size(183, 27);
            this.uiLoadToDataBaseButton.TabIndex = 4;
            this.uiLoadToDataBaseButton.Text = "Загрузить данные в базу";
            this.uiLoadToDataBaseButton.UseVisualStyleBackColor = true;
            this.uiLoadToDataBaseButton.Click += new System.EventHandler(this.uiLoadToDataBaseButton_Click);
            // 
            // uiCancelButton
            // 
            this.uiCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCancelButton.AutoSize = true;
            this.uiCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiCancelButton.Location = new System.Drawing.Point(911, 35);
            this.uiCancelButton.Name = "uiCancelButton";
            this.uiCancelButton.Size = new System.Drawing.Size(75, 27);
            this.uiCancelButton.TabIndex = 5;
            this.uiCancelButton.Text = "Отмена";
            this.uiCancelButton.UseVisualStyleBackColor = true;
            this.uiCancelButton.Click += new System.EventHandler(this.uiCancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.uiCoastColumnTextBox);
            this.panel1.Controls.Add(this.uiCoastRowTextBox);
            this.panel1.Controls.Add(this.uiDateColumnTextBox);
            this.panel1.Controls.Add(this.uiDateRowTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.uiCancelButton);
            this.panel1.Controls.Add(this.uiLoadToDataBaseButton);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 116);
            this.panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ведите цену на мощность";
            // 
            // uiCoastColumnTextBox
            // 
            this.uiCoastColumnTextBox.Location = new System.Drawing.Point(395, 37);
            this.uiCoastColumnTextBox.Name = "uiCoastColumnTextBox";
            this.uiCoastColumnTextBox.ReadOnly = true;
            this.uiCoastColumnTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiCoastColumnTextBox.TabIndex = 21;
            // 
            // uiCoastRowTextBox
            // 
            this.uiCoastRowTextBox.Location = new System.Drawing.Point(395, 61);
            this.uiCoastRowTextBox.Name = "uiCoastRowTextBox";
            this.uiCoastRowTextBox.ReadOnly = true;
            this.uiCoastRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiCoastRowTextBox.TabIndex = 20;
            // 
            // uiDateColumnTextBox
            // 
            this.uiDateColumnTextBox.Location = new System.Drawing.Point(88, 37);
            this.uiDateColumnTextBox.Name = "uiDateColumnTextBox";
            this.uiDateColumnTextBox.ReadOnly = true;
            this.uiDateColumnTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiDateColumnTextBox.TabIndex = 19;
            // 
            // uiDateRowTextBox
            // 
            this.uiDateRowTextBox.Location = new System.Drawing.Point(88, 61);
            this.uiDateRowTextBox.Name = "uiDateRowTextBox";
            this.uiDateRowTextBox.ReadOnly = true;
            this.uiDateRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiDateRowTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(327, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "столбец";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(327, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "строка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите адрес начальной ячейки с датой";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(327, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите адрес начальной ячейки с ценами";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "столбец";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "строка";
            // 
            // ImportCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiOpenXlsButton);
            this.Controls.Add(this.OpenFileStringBox);
            this.Controls.Add(this.uiMainDataGridView);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "ImportCostForm";
            this.Text = "Импорт цен из XLS файла";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox uiCoastRowTextBox;
		private System.Windows.Forms.TextBox uiCoastColumnTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox uiDateRowTextBox;
		private System.Windows.Forms.TextBox uiDateColumnTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button uiCancelButton;
		private System.Windows.Forms.Button uiLoadToDataBaseButton;
		private System.Windows.Forms.Button uiOpenXlsButton;
		private System.Windows.Forms.TextBox OpenFileStringBox;
		private System.Windows.Forms.DataGridView uiMainDataGridView;
		private System.Windows.Forms.Label label1;
	}
}
