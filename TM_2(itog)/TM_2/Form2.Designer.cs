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
	partial class Form2
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.OpenFileStringBox = new System.Windows.Forms.TextBox();
			this.openXLSButton = new System.Windows.Forms.Button();
			this.OKButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox_CoastColumn = new System.Windows.Forms.TextBox();
			this.textBox_CoastRow = new System.Windows.Forms.TextBox();
			this.textBox_DateColumn = new System.Windows.Forms.TextBox();
			this.textBox_DateRow = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(12, 159);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(992, 577);
			this.dataGridView1.TabIndex = 1;
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
			// openXLSButton
			// 
			this.openXLSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.openXLSButton.AutoSize = true;
			this.openXLSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.openXLSButton.Location = new System.Drawing.Point(923, 7);
			this.openXLSButton.Name = "openXLSButton";
			this.openXLSButton.Size = new System.Drawing.Size(75, 27);
			this.openXLSButton.TabIndex = 3;
			this.openXLSButton.Text = "Открыть";
			this.openXLSButton.UseVisualStyleBackColor = true;
			this.openXLSButton.Click += new System.EventHandler(this.OpenXLSButtonClick);
			// 
			// OKButton
			// 
			this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OKButton.AutoSize = true;
			this.OKButton.Enabled = false;
			this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OKButton.Location = new System.Drawing.Point(722, 35);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(183, 27);
			this.OKButton.TabIndex = 4;
			this.OKButton.Text = "Загрузить данные в базу";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.AutoSize = true;
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cancelButton.Location = new System.Drawing.Point(911, 35);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 27);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.textBox_CoastColumn);
			this.panel1.Controls.Add(this.textBox_CoastRow);
			this.panel1.Controls.Add(this.textBox_DateColumn);
			this.panel1.Controls.Add(this.textBox_DateRow);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cancelButton);
			this.panel1.Controls.Add(this.OKButton);
			this.panel1.Location = new System.Drawing.Point(12, 37);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(992, 116);
			this.panel1.TabIndex = 6;
			// 
			// textBox_CoastColumn
			// 
			this.textBox_CoastColumn.Location = new System.Drawing.Point(395, 37);
			this.textBox_CoastColumn.Name = "textBox_CoastColumn";
			this.textBox_CoastColumn.ReadOnly = true;
			this.textBox_CoastColumn.Size = new System.Drawing.Size(100, 20);
			this.textBox_CoastColumn.TabIndex = 21;
			// 
			// textBox_CoastRow
			// 
			this.textBox_CoastRow.Location = new System.Drawing.Point(395, 61);
			this.textBox_CoastRow.Name = "textBox_CoastRow";
			this.textBox_CoastRow.ReadOnly = true;
			this.textBox_CoastRow.Size = new System.Drawing.Size(100, 20);
			this.textBox_CoastRow.TabIndex = 20;
			// 
			// textBox_DateColumn
			// 
			this.textBox_DateColumn.Location = new System.Drawing.Point(88, 37);
			this.textBox_DateColumn.Name = "textBox_DateColumn";
			this.textBox_DateColumn.ReadOnly = true;
			this.textBox_DateColumn.Size = new System.Drawing.Size(100, 20);
			this.textBox_DateColumn.TabIndex = 19;
			// 
			// textBox_DateRow
			// 
			this.textBox_DateRow.Location = new System.Drawing.Point(88, 61);
			this.textBox_DateRow.Name = "textBox_DateRow";
			this.textBox_DateRow.ReadOnly = true;
			this.textBox_DateRow.Size = new System.Drawing.Size(100, 20);
			this.textBox_DateRow.TabIndex = 18;
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(206, 90);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 23;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.openXLSButton);
			this.Controls.Add(this.OpenFileStringBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(1024, 768);
			this.Name = "Form2";
			this.Text = "Импорт цен из XLS файла";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox_CoastRow;
		private System.Windows.Forms.TextBox textBox_CoastColumn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_DateRow;
		private System.Windows.Forms.TextBox textBox_DateColumn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button openXLSButton;
		private System.Windows.Forms.TextBox OpenFileStringBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
	}
}
