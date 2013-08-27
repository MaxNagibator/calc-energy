/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 29.05.2013
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TM_2
{
	partial class LoadHourDialog
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
			this.textBox_HourRow = new System.Windows.Forms.TextBox();
			this.textBox_HourColumn = new System.Windows.Forms.TextBox();
			this.textBox_DateRow = new System.Windows.Forms.TextBox();
			this.textBox_DateColumn = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
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
			this.dataGridView1.Location = new System.Drawing.Point(12, 132);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(992, 604);
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
			this.OKButton.Location = new System.Drawing.Point(722, 33);
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
			this.cancelButton.Location = new System.Drawing.Point(911, 33);
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
			this.panel1.Controls.Add(this.textBox_HourRow);
			this.panel1.Controls.Add(this.textBox_HourColumn);
			this.panel1.Controls.Add(this.textBox_DateRow);
			this.panel1.Controls.Add(this.textBox_DateColumn);
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
			this.panel1.Size = new System.Drawing.Size(992, 89);
			this.panel1.TabIndex = 6;
			// 
			// textBox_HourRow
			// 
			this.textBox_HourRow.Location = new System.Drawing.Point(413, 65);
			this.textBox_HourRow.Name = "textBox_HourRow";
			this.textBox_HourRow.ReadOnly = true;
			this.textBox_HourRow.Size = new System.Drawing.Size(100, 20);
			this.textBox_HourRow.TabIndex = 21;
			// 
			// textBox_HourColumn
			// 
			this.textBox_HourColumn.Location = new System.Drawing.Point(413, 36);
			this.textBox_HourColumn.Name = "textBox_HourColumn";
			this.textBox_HourColumn.ReadOnly = true;
			this.textBox_HourColumn.Size = new System.Drawing.Size(100, 20);
			this.textBox_HourColumn.TabIndex = 20;
			// 
			// textBox_DateRow
			// 
			this.textBox_DateRow.Location = new System.Drawing.Point(99, 64);
			this.textBox_DateRow.Name = "textBox_DateRow";
			this.textBox_DateRow.ReadOnly = true;
			this.textBox_DateRow.Size = new System.Drawing.Size(100, 20);
			this.textBox_DateRow.TabIndex = 19;
			// 
			// textBox_DateColumn
			// 
			this.textBox_DateColumn.Location = new System.Drawing.Point(99, 37);
			this.textBox_DateColumn.Name = "textBox_DateColumn";
			this.textBox_DateColumn.ReadOnly = true;
			this.textBox_DateColumn.Size = new System.Drawing.Size(100, 20);
			this.textBox_DateColumn.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(345, 65);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "строка";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(345, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "столбец";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(31, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(286, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "Введите адрес начальной ячейки с датой";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(345, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(306, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "Введите адрес начальной ячейки с данными";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(31, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "строка";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(31, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "столбец";
			// 
			// LoadHourDialog
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
			this.Name = "LoadHourDialog";
			this.Text = "Импорт часов максимального совокупного энергопотребления из XLS файла";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox_HourColumn;
		private System.Windows.Forms.TextBox textBox_HourRow;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_DateColumn;
		private System.Windows.Forms.TextBox textBox_DateRow;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button openXLSButton;
		private System.Windows.Forms.TextBox OpenFileStringBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
	}
}
