namespace prjSlnSelecter {
	partial class frmMain {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.cboExt = new System.Windows.Forms.ComboBox();
			this.txtExeFile = new System.Windows.Forms.TextBox();
			this.cmdFile = new System.Windows.Forms.Button();
			this.lavel1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cboExt
			// 
			this.cboExt.Font = new System.Drawing.Font("Meiryo UI", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cboExt.FormattingEnabled = true;
			this.cboExt.Location = new System.Drawing.Point(16, 34);
			this.cboExt.Name = "cboExt";
			this.cboExt.Size = new System.Drawing.Size(146, 30);
			this.cboExt.TabIndex = 0;
			this.cboExt.SelectedIndexChanged += new System.EventHandler(this.cboExt_SelectedIndexChanged);
			// 
			// txtExeFile
			// 
			this.txtExeFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtExeFile.Font = new System.Drawing.Font("Meiryo UI", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtExeFile.Location = new System.Drawing.Point(184, 35);
			this.txtExeFile.Name = "txtExeFile";
			this.txtExeFile.Size = new System.Drawing.Size(352, 29);
			this.txtExeFile.TabIndex = 1;
			// 
			// cmdFile
			// 
			this.cmdFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdFile.Font = new System.Drawing.Font("Meiryo UI", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cmdFile.Location = new System.Drawing.Point(542, 28);
			this.cmdFile.Name = "cmdFile";
			this.cmdFile.Size = new System.Drawing.Size(64, 40);
			this.cmdFile.TabIndex = 2;
			this.cmdFile.Text = "参照";
			this.cmdFile.UseVisualStyleBackColor = true;
			this.cmdFile.Click += new System.EventHandler(this.cmdFile_Click);
			// 
			// lavel1
			// 
			this.lavel1.AutoSize = true;
			this.lavel1.Font = new System.Drawing.Font("Meiryo UI", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lavel1.Location = new System.Drawing.Point(12, 9);
			this.lavel1.Name = "lavel1";
			this.lavel1.Size = new System.Drawing.Size(134, 22);
			this.lavel1.TabIndex = 3;
			this.lavel1.Text = "プロジェクト拡張子";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Meiryo UI", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(180, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "起動するファイル";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(618, 86);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lavel1);
			this.Controls.Add(this.cmdFile);
			this.Controls.Add(this.txtExeFile);
			this.Controls.Add(this.cboExt);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "VisualStudioSelector";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboExt;
		private System.Windows.Forms.TextBox txtExeFile;
		private System.Windows.Forms.Button cmdFile;
		private System.Windows.Forms.Label lavel1;
		private System.Windows.Forms.Label label1;
	}
}

