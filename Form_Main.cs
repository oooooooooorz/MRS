using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRS {
	public partial class Form_Main : Form {

		#region Struct

		public struct ONE_DATA {
			public string sFeederName;
			public string sPetName;
			public string sBreed;
			public string nAge;
			public string sSex;
			public string sPhone;
			public string sAddress;
			public string sLastDoctor;
			public DateTime dtLastTime;
			public List<string> lsRecord;
		}
		#endregion

		public Form_Main () {
			InitializeComponent();
			button_EditRecord.Enabled = false;
		}	


		#region AccessDataFromDB
		public int SearchData ( ONE_DATA Data ) {
			return 0;
		}

		public void AddData ( ONE_DATA Data ) {
		}

		public void UpdateData ( ONE_DATA Data ) {
		}

		public void DeleteData ( ONE_DATA Data ) {
		}

		#endregion

		private void button_EditRecord_Click ( object sender, EventArgs e ) {
			Form_EditRecord Form_EditRecord = new Form_EditRecord();
			Form_EditRecord.Show();

		}

		private void button_Register_Click ( object sender, EventArgs e ) {
			ONE_DATA Data = new ONE_DATA();
			Data.sFeederName = textBox_FeederName.Text;
			Data.sPetName = textBox_PetName.Text;
			Data.sBreed = textBox_Breed.Text;
			Data.nAge = textBox_Age.Text;
			Data.sSex = textBox_Sex.Text;
			Data.sPhone = textBox_Phone.Text;
			Data.sAddress = textBox_Address.Text;

			int nNum = SearchData(Data);

			if (nNum == 0) {
				label_Monitor.Text = "狀態 : 資料庫無符合資料";
				label_Monitor.ForeColor = Color.Red;
			}
			if (nNum > 1) {
				label_Monitor.Text = "狀態 : 資料庫搜尋到多筆資料，請增加關鍵字";
				label_Monitor.ForeColor = Color.Red;
			}
				




			//private System.Windows.Forms.TextBox textBox_FeederName;
			//private System.Windows.Forms.TextBox textBox_PetName;
			//private System.Windows.Forms.TextBox textBox_Breed;
			//private System.Windows.Forms.TextBox textBox_Age;
			//private System.Windows.Forms.TextBox textBox_Sex;
			//private System.Windows.Forms.TextBox textBox_Phone;
			//private System.Windows.Forms.TextBox textBox_Address;
			//private System.Windows.Forms.TextBox textBox_LastDoctor;
			//private System.Windows.Forms.TextBox textBox_LastTime;



		}

	}
}
