using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeiboResister
{
    public partial class passconfform : Form
    {
        public passconfform()
        {
            InitializeComponent();
        }
        private string lockpass; //パスワード
        private bool canclose = false; //パスワード一致フラグ(false: キャンセル)
        //パスワード受け渡し用プロパティ
        public string gotpass
        {
            get {return lockpass;}
            set {lockpass = value;}
        }
        //パスワード一致プロパティ
        public bool authok
        {
            get {return canclose;}
            set {canclose = value;}
        }
        public void ShowD(IWin32Window owner, string pass)
        {
            lockpass = pass;
            base.ShowDialog(owner);
        }
        public void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (password.Text == lockpass) //パスワードが一致した時
                {
                    canclose = true;
                    this.Close();
                }
                else //パスワードが違うとき
                {
                    if(passdiff.Visible) disptimer.Stop();
                    else passdiff.Visible = true;
                    disptimer.Start();
                }
            } else if(e.KeyCode == System.Windows.Forms.Keys.Pause){ //非常用ショートカット
                canclose = true;
                this.Close();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }

        public void labledisappear(object sender, EventArgs e)
        { //タイマー
            passdiff.Visible = false;
            disptimer.Stop();
        }


    }
}
