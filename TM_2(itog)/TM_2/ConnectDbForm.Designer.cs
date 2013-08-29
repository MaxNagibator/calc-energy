/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 31.05.2013
 * Time: 15:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TM_2
{
	partial class ConnectDbForm
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
			this.textBox_server = new System.Windows.Forms.TextBox();
			this.textBox_user = new System.Windows.Forms.TextBox();
			this.textBox_passvord = new System.Windows.Forms.TextBox();
			this.comboBox_DB = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.connect_to_DB_button = new System.Windows.Forms.Button();
			this.cancel_connectDB_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox_server
			// 
			this.textBox_server.Location = new System.Drawing.Point(110, 30);
			this.textBox_server.Name = "textBox_server";
			this.textBox_server.Size = new System.Drawing.Size(137, 20);
			this.textBox_server.TabIndex = 0;
			// 
			// textBox_user
			// 
			this.textBox_user.Location = new System.Drawing.Point(110, 70);
			this.textBox_user.Name = "textBox_user";
			this.textBox_user.Size = new System.Drawing.Size(137, 20);
			this.textBox_user.TabIndex = 1;
			// 
			// textBox_passvord
			// 
			this.textBox_passvord.Location = new System.Drawing.Point(110, 110);
			this.textBox_passvord.Name = "textBox_passvord";
			this.textBox_passvord.Size = new System.Drawing.Size(137, 20);
			this.textBox_passvord.PasswordChar = '*';
			this.textBox_passvord.TabIndex = 2;
			// 
			// comboBox_DB
			// 
			this.comboBox_DB.FormattingEnabled = true;
			this.comboBox_DB.Location = new System.Drawing.Point(110, 150);
			this.comboBox_DB.Name = "comboBox_DB";
			this.comboBox_DB.Size = new System.Drawing.Size(137, 21);
			this.comboBox_DB.TabIndex = 3;
			this.comboBox_DB.Click += new System.EventHandler(this.comboBox_DBClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Сервер";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Пользователь";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Пароль";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "База данных";
			// 
			// connect_to_DB_button
			// 
			this.connect_to_DB_button.Location = new System.Drawing.Point(69, 209);
			this.connect_to_DB_button.Name = "connect_to_DB_button";
			this.connect_to_DB_button.Size = new System.Drawing.Size(75, 23);
			this.connect_to_DB_button.TabIndex = 8;
			this.connect_to_DB_button.Text = "OK";
			this.connect_to_DB_button.UseVisualStyleBackColor = true;
			this.connect_to_DB_button.Click += new System.EventHandler(this.Connect_to_DB_buttonClick);
			// 
			// cancel_connectDB_button
			// 
			this.cancel_connectDB_button.Location = new System.Drawing.Point(156, 209);
			this.cancel_connectDB_button.Name = "cancel_connectDB_button";
			this.cancel_connectDB_button.Size = new System.Drawing.Size(75, 23);
			this.cancel_connectDB_button.TabIndex = 9;
			this.cancel_connectDB_button.Text = "Cancel";
			this.cancel_connectDB_button.UseVisualStyleBackColor = true;
			this.cancel_connectDB_button.Click += new System.EventHandler(this.Cancel_connectDB_buttonClick);
			// 
			// ConnectDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 244);
			this.Controls.Add(this.cancel_connectDB_button);
			this.Controls.Add(this.connect_to_DB_button);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox_DB);
			this.Controls.Add(this.textBox_passvord);
			this.Controls.Add(this.textBox_user);
			this.Controls.Add(this.textBox_server);
			this.MaximumSize = new System.Drawing.Size(300, 271);
			this.MinimumSize = new System.Drawing.Size(300, 271);
			this.Name = "ConnectDB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Подключение к БД";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cancel_connectDB_button;
		private System.Windows.Forms.Button connect_to_DB_button;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox comboBox_DB;
		private System.Windows.Forms.TextBox textBox_passvord;
		private System.Windows.Forms.TextBox textBox_user;
		private System.Windows.Forms.TextBox textBox_server;
	}
}
