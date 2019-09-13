using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace prjSlnSelecter {
	static class Program {
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			Dictionary<string, string> dcSetting;
			Type tpSetting = typeof(Dictionary<string, string>);

			dcSetting = new Dictionary<string, string>();
			string sSetFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "setting.txt");
			if (File.Exists(sSetFile)) {
				using (StreamReader sr  = new StreamReader(sSetFile, Encoding.UTF8)) {
					while(-1 < sr.Peek()) {
						string[] sL = sr.ReadLine().Split('\t');
						if(sL.Length == 2) {
							if (!dcSetting.ContainsKey(sL[0])) { dcSetting.Add(sL[0], sL[1]); }
						}
					}
				}
			}
			else {
				MessageBox.Show("設定ファイルが見つかりません。\nファイルを作成します。\n" + sSetFile,
					"設定ファイルを作成します", MessageBoxButtons.OK, MessageBoxIcon.Information);
				using(StreamWriter sw = new StreamWriter(sSetFile, false, Encoding.UTF8)) {
					sw.WriteLine("csproj\t"); dcSetting.Add("csproj", "");
					sw.WriteLine("vfproj\t"); dcSetting.Add("vfproj", "");
				}
			}

			if (args.Length == 0) {
				SetProcessDPIAware();
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new frmMain(dcSetting));
			}
			else {
				if (!File.Exists(args[0])) { MessageBox.Show("Error", "渡されたslnファイルが見つかりません。\n" + args[0]); return; }
				using(StreamReader sr = new StreamReader(args[0], Encoding.UTF8)) {
					while(-1 < sr.Peek()) {
						string sLine = sr.ReadLine();
						foreach(string sExt in dcSetting.Keys) {
							if(Regex.IsMatch(sLine, @"\." + sExt)) {
								System.Diagnostics.ProcessStartInfo p = new System.Diagnostics.ProcessStartInfo();
								p.FileName = dcSetting[sExt];
								p.Arguments = string.Format("\"{0}\"", args[0]);
								System.Diagnostics.Process.Start(p);
								return;
							}
						}
					}
				}
			}
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}



}
