namespace MeiboResister
{
    partial class mainform
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.schoollabel = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.ComboBox();
            this.maillabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.registerbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.noname = new System.Windows.Forms.Label();
            this.nodept = new System.Windows.Forms.Label();
            this.nomail = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.datafiledialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.name.Location = new System.Drawing.Point(96, 15);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(209, 23);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_input);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(54, 18);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(36, 15);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "名前:";
            // 
            // schoollabel
            // 
            this.schoollabel.AutoSize = true;
            this.schoollabel.Location = new System.Drawing.Point(54, 49);
            this.schoollabel.Name = "schoollabel";
            this.schoollabel.Size = new System.Drawing.Size(36, 15);
            this.schoollabel.TabIndex = 2;
            this.schoollabel.Text = "学部:";
            // 
            // dept
            // 
            this.dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            "文学部",
            "教育学部",
            "法学部",
            "経済学部",
            "情報文化学部",
            "理学部",
            "医学部(医学科)",
            "医学部(保健学科)",
            "工学部",
            "農学部"});
            this.dept.Location = new System.Drawing.Point(96, 46);
            this.dept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(208, 23);
            this.dept.TabIndex = 3;
            this.dept.SelectionChangeCommitted += new System.EventHandler(this.dept_changed);
            // 
            // maillabel
            // 
            this.maillabel.AutoSize = true;
            this.maillabel.Location = new System.Drawing.Point(15, 82);
            this.maillabel.Name = "maillabel";
            this.maillabel.Size = new System.Drawing.Size(75, 15);
            this.maillabel.TabIndex = 4;
            this.maillabel.Text = "メールアドレス:";
            // 
            // address
            // 
            this.address.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.address.Location = new System.Drawing.Point(96, 79);
            this.address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(367, 23);
            this.address.TabIndex = 5;
            this.address.TextChanged += new System.EventHandler(this.mail_input);
            // 
            // registerbutton
            // 
            this.registerbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.registerbutton.Location = new System.Drawing.Point(96, 110);
            this.registerbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(119, 29);
            this.registerbutton.TabIndex = 6;
            this.registerbutton.Text = "登録";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetbutton.Location = new System.Drawing.Point(222, 110);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(119, 29);
            this.resetbutton.TabIndex = 7;
            this.resetbutton.Text = "リセット";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // noname
            // 
            this.noname.AutoSize = true;
            this.noname.ForeColor = System.Drawing.Color.Red;
            this.noname.Location = new System.Drawing.Point(311, 18);
            this.noname.Name = "noname";
            this.noname.Size = new System.Drawing.Size(82, 15);
            this.noname.TabIndex = 8;
            this.noname.Text = "入力してください";
            this.noname.Visible = false;
            // 
            // nodept
            // 
            this.nodept.AutoSize = true;
            this.nodept.ForeColor = System.Drawing.Color.Red;
            this.nodept.Location = new System.Drawing.Point(310, 49);
            this.nodept.Name = "nodept";
            this.nodept.Size = new System.Drawing.Size(82, 15);
            this.nodept.TabIndex = 9;
            this.nodept.Text = "入力してください";
            this.nodept.Visible = false;
            // 
            // nomail
            // 
            this.nomail.AutoSize = true;
            this.nomail.ForeColor = System.Drawing.Color.Red;
            this.nomail.Location = new System.Drawing.Point(381, 106);
            this.nomail.Name = "nomail";
            this.nomail.Size = new System.Drawing.Size(82, 15);
            this.nomail.TabIndex = 10;
            this.nomail.Text = "入力してください";
            this.nomail.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(438, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "r";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Font = new System.Drawing.Font("Meiryo UI", 8F);
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TitleLabel.Location = new System.Drawing.Point(309, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 12);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "名簿作成システム";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Visible = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Blue;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(410, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(22, 22);
            this.MinimizeButton.TabIndex = 13;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = "0";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Visible = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // datafiledialog
            // 
            this.datafiledialog.DefaultExt = "xlsx";
            this.datafiledialog.Filter = "全ての対応ファイル|*.xlsx; *.csv|Excelファイル|*.xlsx|CSVファイル|*.csv";
            this.datafiledialog.OverwritePrompt = false;
            this.datafiledialog.Title = "名簿ファイルを開く・新規作成";
            // 
            // mainform
            // 
            this.AcceptButton = this.registerbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetbutton;
            this.ClientSize = new System.Drawing.Size(475, 152);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.nomail);
            this.Controls.Add(this.nodept);
            this.Controls.Add(this.noname);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.address);
            this.Controls.Add(this.maillabel);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.schoollabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainform";
            this.Text = "名簿作成システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.mainform_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label schoollabel;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Label maillabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label noname;
        private System.Windows.Forms.Label nodept;
        private System.Windows.Forms.Label nomail;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.SaveFileDialog datafiledialog;

    }
}

