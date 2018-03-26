namespace MeiboResister
{
    partial class settingform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.password = new System.Windows.Forms.TextBox();
            this.RBAll = new System.Windows.Forms.RadioButton();
            this.Items = new System.Windows.Forms.GroupBox();
            this.RBOther = new System.Windows.Forms.RadioButton();
            this.RBName = new System.Windows.Forms.RadioButton();
            this.RBAddress = new System.Windows.Forms.RadioButton();
            this.RBWithoutDept = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBisFulScr = new System.Windows.Forms.CheckBox();
            this.Items.SuspendLayout();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 66);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(280, 19);
            this.password.TabIndex = 0;
            // 
            // RBAll
            // 
            this.RBAll.AutoSize = true;
            this.RBAll.Checked = true;
            this.RBAll.Location = new System.Drawing.Point(9, 13);
            this.RBAll.Name = "RBAll";
            this.RBAll.Size = new System.Drawing.Size(41, 16);
            this.RBAll.TabIndex = 2;
            this.RBAll.TabStop = true;
            this.RBAll.Text = "フル";
            this.RBAll.UseVisualStyleBackColor = true;
            this.RBAll.CheckedChanged += new System.EventHandler(this.RBAll_CheckedChanged);
            // 
            // Items
            // 
            this.Items.Controls.Add(this.RBOther);
            this.Items.Controls.Add(this.RBName);
            this.Items.Controls.Add(this.RBAddress);
            this.Items.Controls.Add(this.RBWithoutDept);
            this.Items.Controls.Add(this.RBAll);
            this.Items.Location = new System.Drawing.Point(12, 12);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(329, 35);
            this.Items.TabIndex = 6;
            this.Items.TabStop = false;
            this.Items.Text = "入力項目";
            // 
            // RBOther
            // 
            this.RBOther.AutoSize = true;
            this.RBOther.Enabled = false;
            this.RBOther.Location = new System.Drawing.Point(269, 13);
            this.RBOther.Name = "RBOther";
            this.RBOther.Size = new System.Drawing.Size(54, 16);
            this.RBOther.TabIndex = 6;
            this.RBOther.Text = "その他";
            this.RBOther.UseVisualStyleBackColor = true;
            // 
            // RBName
            // 
            this.RBName.AutoSize = true;
            this.RBName.Location = new System.Drawing.Point(203, 13);
            this.RBName.Name = "RBName";
            this.RBName.Size = new System.Drawing.Size(68, 16);
            this.RBName.TabIndex = 5;
            this.RBName.TabStop = true;
            this.RBName.Text = "名前のみ";
            this.RBName.UseVisualStyleBackColor = true;
            this.RBName.CheckedChanged += new System.EventHandler(this.RBName_CheckedChanged);
            // 
            // RBAddress
            // 
            this.RBAddress.AutoSize = true;
            this.RBAddress.Location = new System.Drawing.Point(125, 13);
            this.RBAddress.Name = "RBAddress";
            this.RBAddress.Size = new System.Drawing.Size(72, 16);
            this.RBAddress.TabIndex = 4;
            this.RBAddress.TabStop = true;
            this.RBAddress.Text = "メールのみ";
            this.RBAddress.UseVisualStyleBackColor = true;
            this.RBAddress.CheckedChanged += new System.EventHandler(this.RBAddress_CheckedChanged);
            // 
            // RBWithoutDept
            // 
            this.RBWithoutDept.AutoSize = true;
            this.RBWithoutDept.Location = new System.Drawing.Point(53, 13);
            this.RBWithoutDept.Name = "RBWithoutDept";
            this.RBWithoutDept.Size = new System.Drawing.Size(66, 16);
            this.RBWithoutDept.TabIndex = 3;
            this.RBWithoutDept.TabStop = true;
            this.RBWithoutDept.Text = "学部なし";
            this.RBWithoutDept.UseVisualStyleBackColor = true;
            this.RBWithoutDept.CheckedChanged += new System.EventHandler(this.RBWithoutDept_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(222, 92);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(70, 30);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButtonCliked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "新入生いたずら防止用パスワード(入力推奨):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "【重要】 パスワードを忘れた場合は\r\nPause/Breakキーを押してください";
            // 
            // CBisFulScr
            // 
            this.CBisFulScr.AutoSize = true;
            this.CBisFulScr.Location = new System.Drawing.Point(237, 49);
            this.CBisFulScr.Name = "CBisFulScr";
            this.CBisFulScr.Size = new System.Drawing.Size(88, 16);
            this.CBisFulScr.TabIndex = 9;
            this.CBisFulScr.Text = "全画面モード";
            this.CBisFulScr.UseVisualStyleBackColor = true;
            // 
            // settingform
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 131);
            this.Controls.Add(this.CBisFulScr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "settingform";
            this.Text = "設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingCancel);
            this.Items.ResumeLayout(false);
            this.Items.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.RadioButton RBAll;
        private System.Windows.Forms.GroupBox Items;
        private System.Windows.Forms.RadioButton RBName;
        private System.Windows.Forms.RadioButton RBAddress;
        private System.Windows.Forms.RadioButton RBWithoutDept;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBOther;
        private System.Windows.Forms.CheckBox CBisFulScr;
    }
}