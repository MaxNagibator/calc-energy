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
    partial class ImportHourPowerForm
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
            this.openXLSButton = new System.Windows.Forms.Button();
            this.uiLoadToDataBaseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiHourRowTextBox = new System.Windows.Forms.TextBox();
            this.uiHourColumnTextBox = new System.Windows.Forms.TextBox();
            this.uiDateRowTextBox = new System.Windows.Forms.TextBox();
            this.uiDateColumnTextBox = new System.Windows.Forms.TextBox();
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
            this.uiMainDataGridView.Location = new System.Drawing.Point(12, 132);
            this.uiMainDataGridView.MultiSelect = false;
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.ReadOnly = true;
            this.uiMainDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.uiMainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.uiMainDataGridView.Size = new System.Drawing.Size(992, 604);
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
            // uiLoadToDataBaseButton
            // 
            this.uiLoadToDataBaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLoadToDataBaseButton.AutoSize = true;
            this.uiLoadToDataBaseButton.Enabled = false;
            this.uiLoadToDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiLoadToDataBaseButton.Location = new System.Drawing.Point(722, 33);
            this.uiLoadToDataBaseButton.Name = "uiLoadToDataBaseButton";
            this.uiLoadToDataBaseButton.Size = new System.Drawing.Size(183, 27);
            this.uiLoadToDataBaseButton.TabIndex = 4;
            this.uiLoadToDataBaseButton.Text = "Загрузить данные в базу";
            this.uiLoadToDataBaseButton.UseVisualStyleBackColor = true;
            this.uiLoadToDataBaseButton.Click += new System.EventHandler(this.uiLoadToDataBaseButton_Click);
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
            this.panel1.Controls.Add(this.uiHourRowTextBox);
            this.panel1.Controls.Add(this.uiHourColumnTextBox);
            this.panel1.Controls.Add(this.uiDateRowTextBox);
            this.panel1.Controls.Add(this.uiDateColumnTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.uiLoadToDataBaseButton);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 89);
            this.panel1.TabIndex = 6;
            // 
            // uiHourRowTextBox
            // 
            this.uiHourRowTextBox.Location = new System.Drawing.Point(413, 65);
            this.uiHourRowTextBox.Name = "uiHourRowTextBox";
            this.uiHourRowTextBox.ReadOnly = true;
            this.uiHourRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiHourRowTextBox.TabIndex = 21;
            // 
            // uiHourColumnTextBox
            // 
            this.uiHourColumnTextBox.Location = new System.Drawing.Point(413, 36);
            this.uiHourColumnTextBox.Name = "uiHourColumnTextBox";
            this.uiHourColumnTextBox.ReadOnly = true;
            this.uiHourColumnTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiHourColumnTextBox.TabIndex = 20;
            // 
            // uiDateRowTextBox
            // 
            this.uiDateRowTextBox.Location = new System.Drawing.Point(99, 64);
            this.uiDateRowTextBox.Name = "uiDateRowTextBox";
            this.uiDateRowTextBox.ReadOnly = true;
            this.uiDateRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiDateRowTextBox.TabIndex = 19;
            // 
            // uiDateColumnTextBox
            // 
            this.uiDateColumnTextBox.Location = new System.Drawing.Point(99, 37);
            this.uiDateColumnTextBox.Name = "uiDateColumnTextBox";
            this.uiDateColumnTextBox.ReadOnly = true;
            this.uiDateColumnTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiDateColumnTextBox.TabIndex = 18;
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
            this.Controls.Add(this.uiMainDataGridView);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "LoadHourDialog";
            this.Text = "Импорт часов максимального совокупного энергопотребления из XLS файла";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.TextBox uiHourColumnTextBox;
        private System.Windows.Forms.TextBox uiHourRowTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiDateColumnTextBox;
        private System.Windows.Forms.TextBox uiDateRowTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button uiLoadToDataBaseButton;
        private System.Windows.Forms.Button openXLSButton;
        private System.Windows.Forms.TextBox OpenFileStringBox;
        private System.Windows.Forms.DataGridView uiMainDataGridView;
        private System.Windows.Forms.Label label1;
    }
}
