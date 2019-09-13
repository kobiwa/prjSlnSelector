using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

namespace prjSlnSelecter {
	public partial class frmMain : Form {
		private Dictionary<string, string> _dcSetting;

		public frmMain(Dictionary<string, string> dcSetting) {
			InitializeComponent();
			_dcSetting = dcSetting;
		}

		private void frmMain_Load(object sender, EventArgs e) {
			foreach(string sExt in _dcSetting.Keys) {
				cboExt.Items.Add(sExt);
			}
		}

		private void cmdFile_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();

			//初期ディレクトリ
			string sInit = txtExeFile.Text;
			if (File.Exists(sInit)) { ofd.InitialDirectory = Path.GetDirectoryName(sInit); }
			else if (Directory.Exists(sInit)) { ofd.InitialDirectory = sInit; }

			//フィルタ
			ofd.Filter = "実行ファイル(*.exe)|*.exe|すべてのファイル(*.*)|*.*";

			//ダイアログ→OK
			if(ofd.ShowDialog() == DialogResult.OK) {
				if (_dcSetting.ContainsKey(cboExt.Text)) {
					if (MessageBox.Show("設定を上書きしますか？", "設定上書き確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
						_dcSetting[cboExt.Text] = ofd.FileName; txtExeFile.Text = ofd.FileName;
					}
				}
				else {
					_dcSetting.Add(cboExt.Text, ofd.FileName);
					txtExeFile.Text = ofd.FileName;
				}
			}
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
			string sSetFile = Path.Combine(Directory.GetCurrentDirectory(), "setting.txt");
			using(StreamWriter sw = new StreamWriter(sSetFile, false, Encoding.UTF8)) {
				foreach(string sExt in _dcSetting.Keys) {
					sw.WriteLine("{0}\t{1}", sExt, _dcSetting[sExt]);
				}
			}
		}

		private void cboExt_SelectedIndexChanged(object sender, EventArgs e) {
			if (_dcSetting.ContainsKey(cboExt.SelectedItem.ToString())) {
				txtExeFile.Text = _dcSetting[cboExt.SelectedItem.ToString()];
			}
		}
	}
}
