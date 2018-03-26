namespace MeiboResister
{
    partial class passconfform
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
            this.components = new System.ComponentModel.Container();
            this.password = new System.Windows.Forms.TextBox();
            this.passconflabel = new System.Windows.Forms.Label();
            this.disptimer = new System.Windows.Forms.Timer(this.components);
            this.passdiff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(14, 76);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(333, 23);
            this.password.TabIndex = 1;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // passconflabel
            // 
            this.passconflabel.AutoEllipsis = true;
            this.passconflabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passconflabel.Location = new System.Drawing.Point(14, 11);
            this.passconflabel.Name = "passconflabel";
            this.passconflabel.Size = new System.Drawing.Size(334, 61);
            this.passconflabel.TabIndex = 2;
            this.passconflabel.Text = "このプログラムを終了するには、いたずら・誤操作防止のためにパスワードが必要です。\r\nパスワードを入力してEnterキーを押してください。";
            // 
            // disptimer
            // 
            this.disptimer.Interval = 500;
            this.disptimer.Tick += new System.EventHandler(this.labledisappear);
            // 
            // passdiff
            // 
            this.passdiff.AutoSize = true;
            this.passdiff.ForeColor = System.Drawing.Color.Red;
            this.passdiff.Location = new System.Drawing.Point(14, 104);
            this.passdiff.Name = "passdiff";
            this.passdiff.Size = new System.Drawing.Size(104, 15);
            this.passdiff.TabIndex = 3;
            this.passdiff.Text = "パスワードが違います";
            this.passdiff.Visible = false;
            // 
            // passconfform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 130);
            this.Controls.Add(this.passdiff);
            this.Controls.Add(this.passconflabel);
            this.Controls.Add(this.password);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "passconfform";
            this.Text = "パスワード入力";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passconflabel;
        private System.Windows.Forms.Timer disptimer;
        private System.Windows.Forms.Label passdiff;
    }
}