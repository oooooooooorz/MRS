namespace MRS {
	partial class Form_Main {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.textBox_FeederName = new System.Windows.Forms.TextBox();
			this.textBox_PetName = new System.Windows.Forms.TextBox();
			this.textBox_Breed = new System.Windows.Forms.TextBox();
			this.textBox_Age = new System.Windows.Forms.TextBox();
			this.button_Register = new System.Windows.Forms.Button();
			this.textBox_Sex = new System.Windows.Forms.TextBox();
			this.textBox_Phone = new System.Windows.Forms.TextBox();
			this.textBox_Address = new System.Windows.Forms.TextBox();
			this.button_Search = new System.Windows.Forms.Button();
			this.textBox_LastDoctor = new System.Windows.Forms.TextBox();
			this.button_EditRecord = new System.Windows.Forms.Button();
			this.textBox_LastTime = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label_Monitor = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox_FeederName
			// 
			this.textBox_FeederName.Location = new System.Drawing.Point( 89, 21 );
			this.textBox_FeederName.Name = "textBox_FeederName";
			this.textBox_FeederName.Size = new System.Drawing.Size( 100, 22 );
			this.textBox_FeederName.TabIndex = 0;
			// 
			// textBox_PetName
			// 
			this.textBox_PetName.Location = new System.Drawing.Point( 89, 49 );
			this.textBox_PetName.Name = "textBox_PetName";
			this.textBox_PetName.Size = new System.Drawing.Size( 100, 22 );
			this.textBox_PetName.TabIndex = 1;
			// 
			// textBox_Breed
			// 
			this.textBox_Breed.Location = new System.Drawing.Point( 89, 77 );
			this.textBox_Breed.Name = "textBox_Breed";
			this.textBox_Breed.Size = new System.Drawing.Size( 100, 22 );
			this.textBox_Breed.TabIndex = 2;
			// 
			// textBox_Age
			// 
			this.textBox_Age.Location = new System.Drawing.Point( 89, 105 );
			this.textBox_Age.Name = "textBox_Age";
			this.textBox_Age.Size = new System.Drawing.Size( 100, 22 );
			this.textBox_Age.TabIndex = 3;
			// 
			// button_Register
			// 
			this.button_Register.Location = new System.Drawing.Point( 299, 18 );
			this.button_Register.Name = "button_Register";
			this.button_Register.Size = new System.Drawing.Size( 70, 63 );
			this.button_Register.TabIndex = 3;
			this.button_Register.Text = "掛號(F1)";
			this.button_Register.UseVisualStyleBackColor = true;
			this.button_Register.Click += new System.EventHandler( this.button_Register_Click );
			// 
			// textBox_Sex
			// 
			this.textBox_Sex.Location = new System.Drawing.Point( 89, 133 );
			this.textBox_Sex.Name = "textBox_Sex";
			this.textBox_Sex.Size = new System.Drawing.Size( 100, 22 );
			this.textBox_Sex.TabIndex = 4;
			// 
			// textBox_Phone
			// 
			this.textBox_Phone.Location = new System.Drawing.Point( 89, 161 );
			this.textBox_Phone.Name = "textBox_Phone";
			this.textBox_Phone.Size = new System.Drawing.Size( 100, 22 );
			this.textBox_Phone.TabIndex = 5;
			// 
			// textBox_Address
			// 
			this.textBox_Address.Location = new System.Drawing.Point( 89, 189 );
			this.textBox_Address.Name = "textBox_Address";
			this.textBox_Address.Size = new System.Drawing.Size( 100, 22 );
			this.textBox_Address.TabIndex = 6;
			// 
			// button_Search
			// 
			this.button_Search.Location = new System.Drawing.Point( 299, 87 );
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size( 70, 63 );
			this.button_Search.TabIndex = 6;
			this.button_Search.Text = "搜尋(F3)";
			this.button_Search.UseVisualStyleBackColor = true;
			// 
			// textBox_LastDoctor
			// 
			this.textBox_LastDoctor.Location = new System.Drawing.Point( 89, 217 );
			this.textBox_LastDoctor.Name = "textBox_LastDoctor";
			this.textBox_LastDoctor.ReadOnly = true;
			this.textBox_LastDoctor.Size = new System.Drawing.Size( 100, 22 );
			this.textBox_LastDoctor.TabIndex = 7;
			// 
			// button_EditRecord
			// 
			this.button_EditRecord.Location = new System.Drawing.Point( 299, 156 );
			this.button_EditRecord.Name = "button_EditRecord";
			this.button_EditRecord.Size = new System.Drawing.Size( 70, 63 );
			this.button_EditRecord.TabIndex = 7;
			this.button_EditRecord.Text = "病歷編輯";
			this.button_EditRecord.UseVisualStyleBackColor = true;
			this.button_EditRecord.Click += new System.EventHandler( this.button_EditRecord_Click );
			// 
			// textBox_LastTime
			// 
			this.textBox_LastTime.Location = new System.Drawing.Point( 89, 245 );
			this.textBox_LastTime.Name = "textBox_LastTime";
			this.textBox_LastTime.ReadOnly = true;
			this.textBox_LastTime.Size = new System.Drawing.Size( 100, 22 );
			this.textBox_LastTime.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 6, 26 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 41, 12 );
			this.label1.TabIndex = 9;
			this.label1.Text = "畜主名";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 6, 54 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 41, 12 );
			this.label2.TabIndex = 10;
			this.label2.Text = "動物名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 6, 82 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 29, 12 );
			this.label3.TabIndex = 11;
			this.label3.Text = "品種";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point( 6, 110 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 29, 12 );
			this.label4.TabIndex = 12;
			this.label4.Text = "年齡";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point( 6, 138 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 29, 12 );
			this.label5.TabIndex = 13;
			this.label5.Text = "性別";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point( 6, 166 );
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size( 29, 12 );
			this.label6.TabIndex = 14;
			this.label6.Text = "電話";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point( 6, 194 );
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size( 29, 12 );
			this.label7.TabIndex = 15;
			this.label7.Text = "住址";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point( 6, 222 );
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size( 77, 12 );
			this.label8.TabIndex = 16;
			this.label8.Text = "上次就診醫師";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point( 6, 250 );
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size( 77, 12 );
			this.label9.TabIndex = 17;
			this.label9.Text = "上次就診日期";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add( this.label9 );
			this.groupBox1.Controls.Add( this.label8 );
			this.groupBox1.Controls.Add( this.label7 );
			this.groupBox1.Controls.Add( this.label6 );
			this.groupBox1.Controls.Add( this.label5 );
			this.groupBox1.Controls.Add( this.label4 );
			this.groupBox1.Controls.Add( this.label3 );
			this.groupBox1.Controls.Add( this.label2 );
			this.groupBox1.Controls.Add( this.label1 );
			this.groupBox1.Controls.Add( this.textBox_LastTime );
			this.groupBox1.Controls.Add( this.button_EditRecord );
			this.groupBox1.Controls.Add( this.textBox_LastDoctor );
			this.groupBox1.Controls.Add( this.button_Search );
			this.groupBox1.Controls.Add( this.textBox_Address );
			this.groupBox1.Controls.Add( this.textBox_Phone );
			this.groupBox1.Controls.Add( this.textBox_Sex );
			this.groupBox1.Controls.Add( this.button_Register );
			this.groupBox1.Controls.Add( this.textBox_Age );
			this.groupBox1.Controls.Add( this.textBox_Breed );
			this.groupBox1.Controls.Add( this.textBox_PetName );
			this.groupBox1.Controls.Add( this.textBox_FeederName );
			this.groupBox1.Location = new System.Drawing.Point( 12, 12 );
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size( 379, 290 );
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point( 12, 342 );
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size( 710, 112 );
			this.listBox1.TabIndex = 1;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point( 601, 304 );
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size( 121, 20 );
			this.comboBox1.TabIndex = 2;
			// 
			// label_Monitor
			// 
			this.label_Monitor.AutoSize = true;
			this.label_Monitor.Location = new System.Drawing.Point( 10, 461 );
			this.label_Monitor.Name = "label_Monitor";
			this.label_Monitor.Size = new System.Drawing.Size( 0, 12 );
			this.label_Monitor.TabIndex = 3;
			// 
			// Form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 734, 482 );
			this.Controls.Add( this.label_Monitor );
			this.Controls.Add( this.comboBox1 );
			this.Controls.Add( this.listBox1 );
			this.Controls.Add( this.groupBox1 );
			this.Name = "Form_Main";
			this.Text = "Form_Main";
			this.groupBox1.ResumeLayout( false );
			this.groupBox1.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_FeederName;
		private System.Windows.Forms.TextBox textBox_PetName;
		private System.Windows.Forms.TextBox textBox_Breed;
		private System.Windows.Forms.TextBox textBox_Age;
		private System.Windows.Forms.TextBox textBox_LastDoctor;
		private System.Windows.Forms.TextBox textBox_LastTime;
		private System.Windows.Forms.TextBox textBox_Sex;
		private System.Windows.Forms.TextBox textBox_Phone;
		private System.Windows.Forms.TextBox textBox_Address;
		private System.Windows.Forms.Button button_EditRecord;
		private System.Windows.Forms.Button button_Register;
		private System.Windows.Forms.Button button_Search;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label_Monitor;

	}
}

