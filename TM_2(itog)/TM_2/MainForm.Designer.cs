/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 28.05.2013
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TM_2
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox_Month = new System.Windows.Forms.ComboBox();
			this.comboBox_Year = new System.Windows.Forms.ComboBox();
			this.button_Excel_Save = new System.Windows.Forms.Button();
			this.button_Word_Save = new System.Windows.Forms.Button();
			this.button_Calc = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.button_Price_Hours = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.button_Enrgy_Hours = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.View_Obj_Registration = new System.Windows.Forms.TreeView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Energi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Coast = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Energy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tariff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Controls.Add(this.panel8);
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.View_Obj_Registration);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(790, 158);
			this.panel1.TabIndex = 0;
			// 
			// panel9
			// 
			this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel9.Controls.Add(this.label6);
			this.panel9.Controls.Add(this.comboBox_Month);
			this.panel9.Controls.Add(this.comboBox_Year);
			this.panel9.Controls.Add(this.button_Excel_Save);
			this.panel9.Controls.Add(this.button_Word_Save);
			this.panel9.Controls.Add(this.button_Calc);
			this.panel9.Location = new System.Drawing.Point(385, 80);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(386, 72);
			this.panel9.TabIndex = 3;
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
			// comboBox_Month
			// 
			this.comboBox_Month.FormattingEnabled = true;
			this.comboBox_Month.Items.AddRange(new object[] {
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
			this.comboBox_Month.Location = new System.Drawing.Point(120, 24);
			this.comboBox_Month.Name = "comboBox_Month";
			this.comboBox_Month.Size = new System.Drawing.Size(105, 21);
			this.comboBox_Month.TabIndex = 10;
			// 
			// comboBox_Year
			// 
			this.comboBox_Year.FormattingEnabled = true;
			this.comboBox_Year.Location = new System.Drawing.Point(34, 24);
			this.comboBox_Year.Name = "comboBox_Year";
			this.comboBox_Year.Size = new System.Drawing.Size(71, 21);
			this.comboBox_Year.TabIndex = 9;
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
			this.toolTip3.SetToolTip(this.button_Excel_Save, "Сохранить в Excel");
			this.button_Excel_Save.UseVisualStyleBackColor = true;
			this.button_Excel_Save.Click += new System.EventHandler(this.Button_Excel_SaveClick);
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
			this.toolTip2.SetToolTip(this.button_Word_Save, "Сохранить в Word");
			this.button_Word_Save.UseVisualStyleBackColor = true;
			this.button_Word_Save.Visible = false;
			this.button_Word_Save.Click += new System.EventHandler(this.Button_Word_SaveClick);
			// 
			// button_Calc
			// 
			this.button_Calc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Calc.BackgroundImage")));
			this.button_Calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button_Calc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Calc.Location = new System.Drawing.Point(246, 13);
			this.button_Calc.Name = "button_Calc";
			this.button_Calc.Size = new System.Drawing.Size(40, 40);
			this.button_Calc.TabIndex = 6;
			this.toolTip1.SetToolTip(this.button_Calc, "Расчитать");
			this.button_Calc.UseVisualStyleBackColor = true;
			this.button_Calc.Click += new System.EventHandler(this.Button_CalcClick);
			// 
			// panel8
			// 
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel8.Controls.Add(this.button_Price_Hours);
			this.panel8.Controls.Add(this.label5);
			this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel8.Location = new System.Drawing.Point(549, 2);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(222, 72);
			this.panel8.TabIndex = 2;
			// 
			// button_Price_Hours
			// 
			this.button_Price_Hours.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Price_Hours.ForeColor = System.Drawing.Color.Red;
			this.button_Price_Hours.Location = new System.Drawing.Point(71, 44);
			this.button_Price_Hours.Name = "button_Price_Hours";
			this.button_Price_Hours.Size = new System.Drawing.Size(75, 23);
			this.button_Price_Hours.TabIndex = 1;
			this.button_Price_Hours.Text = "Загрузить";
			this.button_Price_Hours.UseVisualStyleBackColor = true;
			this.button_Price_Hours.Click += new System.EventHandler(this.Button_Price_HoursClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(4, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(213, 40);
			this.label5.TabIndex = 0;
			this.label5.Text = "Дифференцированная по часам расчетного периода нерегулируемая цена на электроэнер" +
			"гию, руб/МВт*ч.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Controls.Add(this.label4);
			this.panel7.Controls.Add(this.button_Enrgy_Hours);
			this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel7.Location = new System.Drawing.Point(385, 2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(143, 72);
			this.panel7.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 43);
			this.label4.TabIndex = 1;
			this.label4.Text = "Часы максимального совокупного потребления электроэнергии";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_Enrgy_Hours
			// 
			this.button_Enrgy_Hours.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Enrgy_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Enrgy_Hours.ForeColor = System.Drawing.Color.Red;
			this.button_Enrgy_Hours.Location = new System.Drawing.Point(31, 44);
			this.button_Enrgy_Hours.Name = "button_Enrgy_Hours";
			this.button_Enrgy_Hours.Size = new System.Drawing.Size(75, 23);
			this.button_Enrgy_Hours.TabIndex = 0;
			this.button_Enrgy_Hours.Text = "Загрузить";
			this.button_Enrgy_Hours.UseVisualStyleBackColor = true;
			this.button_Enrgy_Hours.Click += new System.EventHandler(this.Button_Enrgy_HoursClick);
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new System.Drawing.Point(3, 4);
			this.panel4.Margin = new System.Windows.Forms.Padding(1);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(1);
			this.panel4.Size = new System.Drawing.Size(366, 26);
			this.panel4.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Объекты учета";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// View_Obj_Registration
			// 
			this.View_Obj_Registration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.View_Obj_Registration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.View_Obj_Registration.Location = new System.Drawing.Point(3, 30);
			this.View_Obj_Registration.Name = "View_Obj_Registration";
			this.View_Obj_Registration.Size = new System.Drawing.Size(366, 123);
			this.View_Obj_Registration.TabIndex = 1;
			this.View_Obj_Registration.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.View_Obj_RegistrationAfterSelect);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.panel10);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.dataGridView);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(1, 159);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(790, 413);
			this.panel2.TabIndex = 1;
			// 
			// panel10
			// 
			this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel10.Controls.Add(this.label7);
			this.panel10.Location = new System.Drawing.Point(3, 3);
			this.panel10.Name = "panel10";
			this.panel10.Padding = new System.Windows.Forms.Padding(1);
			this.panel10.Size = new System.Drawing.Size(366, 26);
			this.panel10.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(91, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(154, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Расчет стоимости мощности";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeight = 31;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Date,
									this.Hour,
									this.Energi,
									this.Coast});
			this.dataGridView1.Location = new System.Drawing.Point(3, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(366, 314);
			this.dataGridView1.TabIndex = 4;
			// 
			// Date
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Date.DefaultCellStyle = dataGridViewCellStyle2;
			this.Date.FillWeight = 55F;
			this.Date.HeaderText = "Дата";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Hour
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Hour.DefaultCellStyle = dataGridViewCellStyle3;
			this.Hour.FillWeight = 40F;
			this.Hour.HeaderText = "Час";
			this.Hour.Name = "Hour";
			this.Hour.ReadOnly = true;
			this.Hour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Energi
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Energi.DefaultCellStyle = dataGridViewCellStyle4;
			this.Energi.FillWeight = 79.18781F;
			this.Energi.HeaderText = "А+, кВт/ч.";
			this.Energi.Name = "Energi";
			this.Energi.ReadOnly = true;
			this.Energi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Coast
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Coast.DefaultCellStyle = dataGridViewCellStyle5;
			this.Coast.FillWeight = 79.18781F;
			this.Coast.HeaderText = "Сумма, руб.";
			this.Coast.Name = "Coast";
			this.Coast.ReadOnly = true;
			this.Coast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.label3);
			this.panel5.Location = new System.Drawing.Point(381, 3);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(1);
			this.panel5.Size = new System.Drawing.Size(404, 26);
			this.panel5.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(346, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Расчет затрат на электроэнергию по факту часового потребления";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView.ColumnHeadersHeight = 31;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Points,
									this.Energy,
									this.Tariff,
									this.Summa});
			this.dataGridView.Location = new System.Drawing.Point(381, 28);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.Size = new System.Drawing.Size(404, 314);
			this.dataGridView.TabIndex = 0;
			// 
			// Points
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Points.DefaultCellStyle = dataGridViewCellStyle7;
			this.Points.FillWeight = 120F;
			this.Points.HeaderText = "Интервал";
			this.Points.Name = "Points";
			this.Points.ReadOnly = true;
			this.Points.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Points.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Energy
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Energy.DefaultCellStyle = dataGridViewCellStyle8;
			this.Energy.HeaderText = "А+, кВт/ч.";
			this.Energy.Name = "Energy";
			this.Energy.ReadOnly = true;
			this.Energy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Energy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Tariff
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Tariff.DefaultCellStyle = dataGridViewCellStyle9;
			this.Tariff.HeaderText = "Тариф, руб./кВт.ч.";
			this.Tariff.Name = "Tariff";
			this.Tariff.ReadOnly = true;
			this.Tariff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Tariff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Summa
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Summa.DefaultCellStyle = dataGridViewCellStyle10;
			this.Summa.HeaderText = "Сумма, руб.";
			this.Summa.Name = "Summa";
			this.Summa.ReadOnly = true;
			this.Summa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Summa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(1, 504);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(790, 68);
			this.panel3.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(3, 44);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(782, 17);
			this.label10.TabIndex = 3;
			this.label10.Text = "label10";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label10.Visible = false;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(323, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(351, 17);
			this.label9.TabIndex = 2;
			this.label9.Text = "стоимость электроэнергии + стоимость мощности =";
			this.label9.Visible = false;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(105, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(220, 17);
			this.label8.TabIndex = 1;
			this.label8.Text = "Стоимость потребления всего =";
			this.label8.Visible = false;
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.Controls.Add(this.label1);
			this.panel6.Location = new System.Drawing.Point(3, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(782, 22);
			this.panel6.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(304, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Результаты расчетов";
			// 
			// toolTip1
			// 
			this.toolTip1.ShowAlways = true;
			// 
			// toolTip2
			// 
			this.toolTip2.ShowAlways = true;
			// 
			// toolTip3
			// 
			this.toolTip3.ShowAlways = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TM_2";
			this.panel1.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn Coast;
		private System.Windows.Forms.DataGridViewTextBoxColumn Energi;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.ComboBox comboBox_Year;
		private System.Windows.Forms.ComboBox comboBox_Month;
		private System.Windows.Forms.ToolTip toolTip3;
		private System.Windows.Forms.Button button_Excel_Save;
		private System.Windows.Forms.ToolTip toolTip2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button_Calc;
		private System.Windows.Forms.Button button_Word_Save;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button_Price_Hours;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button_Enrgy_Hours;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Summa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tariff;
		private System.Windows.Forms.DataGridViewTextBoxColumn Energy;
		private System.Windows.Forms.DataGridViewTextBoxColumn Points;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.TreeView View_Obj_Registration;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		
	}
}
