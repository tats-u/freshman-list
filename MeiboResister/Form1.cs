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
//↓Excel出力用↓
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace MeiboResister
{
    public partial class mainform : Form
    {
        private string[] cellphonemail = {"docomo.ne.jp", "mopera.net",
			 "softbank.ne.jp", "vodafone.ne.jp", "disney.ne.jp",
			 "i.softbank.jp",
			 "ezweb.ne.jp", "ido.ne.jp",
			 "emnet.ne.jp", "emobile.ne.jp", "emobile-s.ne.jp",
			 "pdx.ne.jp", "willcom.com", "wcm.ne.jp"}; //携帯アドレス一覧
        private string datafile; //データファイル名
        private string lockpass; //画面ロック用パスワード
        private bool settingok = false; //設定完了フラグ
        private List<DataItems> itemorder = new List<DataItems>(); //入力要求項目
        private SaveDataObject DataObj;
        //コンストラクタ
        public mainform()
        {
            InitializeComponent();
            this.FormClosing +=
new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ファイルダイアログを開いてデータファイル設定
            if (datafiledialog.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                this.Activate();
                datafile = datafiledialog.FileName; //ファイル名設定
                string fileext = Path.GetExtension(datafile).ToLower(); //拡張子抜き取り
                switch (fileext) //拡張子によって分岐
                {
                    case ".csv":
                        DataObj = new SaveDataObjectTSV(datafile);
                        break;
                    case ".xlsx":
                        DataObj = new SaveDataObjectXLS(datafile);
                        break;
                    default:
                        MessageBox.Show("未対応のファイル形式です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                }
                try
                {
                    itemorder = DataObj.ReadHeader(); //ヘッダを読み込む
                }
                catch (Exception ex)
                {
                    MessageBox.Show("エラー発生\r\n" + ex.Message, "読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                settingform passset;
                bool isnewdata = itemorder == null;
                //設定用フォームを開く
                passset = new settingform(itemorder);
                passset.ShowD(this);
                lockpass = passset.gotpass; //パスワード設定
                if(isnewdata) itemorder = passset.ItemOrder; //入力要求項目設定
                bool FullS = passset.isFullScreenMode;
                if (!passset.settingok) //設定キャンセル
                {
                    this.Close();
                    return;
                }
                if (isnewdata)
                {
                    //見出しをデータファイルに書き込む
                    try
                    {
                        DataObj.WriteHeader(itemorder);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("エラー発生\r\n" + ex.Message, "書き込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                }
                if (FullS)
                { //全画面にする
                    FullScreen();
                }
                //入力しない項目は隠す
                var visibleflg = new bool[] { false, false, false };
                foreach (int it in itemorder)
                {
                    visibleflg[it] = true;
                }
                schoollabel.Visible = dept.Visible = visibleflg[(int)DataItems.Dept];
                namelabel.Visible = name.Visible = visibleflg[(int)DataItems.Name];
                maillabel.Visible = address.Visible = visibleflg[(int)DataItems.Address];
                settingok = true; //設定完了

            }
        }

        //フルスクリーンにする
        private void FullScreen()
        {
            int height = this.Height;
            int width = this.Width;
            double present_aspect = (double)width / (double)height; //全画面前の縦横比
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            double new_aspect = (double)this.Width / (double)this.Height; //全画面後の縦横比
            double magnification //拡大倍率
                = new_aspect >= present_aspect ?
                 (double)this.Height / (double)height : (double)this.Width / (double)width;
            double oldcenterX = width / 2.0;
            double oldcenterY = height / 2.0;
            double newcenterX = this.Width / 2.0;
            double newcenterY = this.Height / 2.0;
            var Controls = new System.Windows.Forms.Control[] { 
            name,dept,address,resetbutton,registerbutton,namelabel,schoollabel,maillabel,noname,nodept,nomail};
            foreach (var Com in Controls) //1つずつ座標・大きさを変える
            {
                Com.Location = new System.Drawing.Point((int)(magnification * (Com.Location.X - oldcenterX) + newcenterX),
                    (int)(magnification * (Com.Location.Y - oldcenterY) + newcenterY));
                Com.Width = (int)(Com.Width * magnification);
                Com.Height = (int)(Com.Height * magnification);
                Com.Font = new System.Drawing.Font(Com.Font.Name, (float)(Com.Font.Size * magnification));
            }
            CloseButton.Width = (int)(CloseButton.Width * magnification);
            CloseButton.Height = (int)(CloseButton.Height * magnification);
            CloseButton.Location = new System.Drawing.Point(this.Width - CloseButton.Width, 0);
            CloseButton.Font = new System.Drawing.Font(CloseButton.Font.Name, (float)(CloseButton.Font.Size * magnification));

            MinimizeButton.Width = CloseButton.Width;
            MinimizeButton.Height = CloseButton.Height;
            MinimizeButton.Location = new System.Drawing.Point(CloseButton.Location.X - CloseButton.Width,0);
            MinimizeButton.Font = new System.Drawing.Font(MinimizeButton.Font.Name, (float)(MinimizeButton.Font.Size * magnification));

            TitleLabel.Location = new System.Drawing.Point(0, 0);
            TitleLabel.Width = this.Width;
            TitleLabel.Height = CloseButton.Height;
            TitleLabel.Font = new System.Drawing.Font(TitleLabel.Font.Name, (float)(TitleLabel.Font.Size * magnification));



            this.Click += new System.EventHandler(this.mainform_Click);
        }



        //プログラムを終了しようとするとき
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (settingok)
            { //設定が終わっている時
                if (lockpass.Length > 0)
                { //パスワードが設定されている時
                    var passauth = new passconfform();
                    passauth.ShowD(this, lockpass);
                    passauth.gotpass = lockpass;


                    if (!passauth.authok)  // [いいえ] の場合
                    {
                        e.Cancel = true;  // 終了処理を中止
                        passauth.Dispose();
                        return;
                    }
                    passauth.Dispose();
                }
                if (MessageBox.Show("名簿ファイルがあるフォルダを開きますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    System.Diagnostics.Process.Start(System.IO.Path.GetDirectoryName(@datafile));
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            datafile = datafiledialog.FileName;
            MessageBox.Show(datafile);
        }

        private void warnform(int set, string mes)
        {
            if ((set & 4) == 4)
            {
                noname.Text = mes + "してください";
                noname.Visible = true;
                name.BackColor = System.Drawing.Color.Red;
            } if ((set & 2) == 2)
            {
                nodept.Text = "選択してください";
                nodept.Visible = true;
                //dept.BackColor = System.Drawing.Color.Red;
            } if ((set & 1) == 1)
            {
                nomail.Text = mes + "してください";
                nomail.Visible = true;
                address.BackColor = System.Drawing.Color.Red;
            }
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            //入力漏れのチェック
            string noinp = "";
            int check = 0;
            if (name.Visible && name.Text.Length == 0)
            {
                noinp += "\n・名前";
                name.Focus();
                check += 4;
            }
            if (dept.Visible && dept.SelectedIndex == -1)
            {
                if (noinp.Length == 0) dept.Focus();
                noinp += "\n・学部";
                check += 2;
            }
            if (address.Visible && address.Text.Length == 0)
            {
                if (noinp.Length == 0) address.Focus();
                noinp += "\n・メールアドレス";
                check += 1;
            }
            //何らかの入力漏れがあればメッセージ表示
            if (check != 0)
            {
                warnform(check, "入力");
                MessageBox.Show("以下の項目が空欄になっています" + noinp, "入力漏れ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //タブのチェック
            //noinp使い回し
            if (name.Visible && name.Text.IndexOf('\t') != -1)
            {
                name.Focus();
                noinp += "\n・名前";
                check += 4;

            }
            if (address.Visible && address.Text.IndexOf('\t') != -1)
            {
                if (noinp.Length == 0) address.Focus();
                noinp += "\n・メールアドレス";
                check += 1;

            }
            if (check != 0)
            {
                warnform(check, "修正");
                MessageBox.Show("以下の項目内にタブ文字が入っています。\n取り除いて下さい。" + noinp, "「\"」の混入", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (address.Visible)
            {
                //不正なメアドチェック
                int atpoint = address.Text.IndexOf('@');
                int dotpoint = address.Text.LastIndexOf('.');
                if (atpoint < 1 || dotpoint - atpoint < 3 || address.Text.Length - dotpoint < 3)
                {

                    address.ResetText();
                    warnform(1, "入力");
                    address.Focus();
                    MessageBox.Show("メールアドレスの形式がおかしいです。\nきちんとしたメールアドレスを入力してください。", "不正なメールアドレス", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //携帯アドレスのチェック
                bool iscellmail = false;
                for (int i = 0; i < cellphonemail.Length; i++)
                {
                    if (address.Text.IndexOf(cellphonemail[i]) != -1)
                    {
                        iscellmail = true; //比較
                        break;
                    }
                }
                if (iscellmail)
                {
                    if (MessageBox.Show("携帯メールのアドレスが入力されました。\nメーリングリストからのメールは携帯メールのフィルタリングに引っかかる可能性があります。\nこのメールアドレスを登録してよろしいでしょうか？\nPCからのメールを受信する設定になっている場合のみ「はい」を押してください。", "携帯アドレスを登録しようとしています", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        address.ResetText();
                        warnform(1, "入力");
                        address.Focus();
                        return;
                    }
                }
            }
            string confmsg = "";
            if (dept.Visible)
            {
                confmsg += dept.Text;
                if (name.Visible) confmsg += "の";
            }
            if (name.Visible) confmsg += name.Text + "さん、";
            if (confmsg.Length != 0) confmsg += "\r\n";
            confmsg += "本当に";
            if (address.Visible) confmsg += "このメールアドレス(" + address.Text + ")\r\nを";
            if (MessageBox.Show(confmsg + "登録してもよろしいでしょうか？", "最終確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var Record = new List<string>();
                    var strs = new Dictionary<DataItems, string>()
                    {
                        {DataItems.Dept, dept.Text},{DataItems.Name,name.Text},{DataItems.Address,address.Text}
                    }; //項目・データの組を一旦生成
                    foreach (var item in itemorder)
                    { //データを整列
                        Record.Add(strs[item]);
                    }
                    DataObj.AddRecord(Record); //書き込み
                }
                catch (Exception ex)
                {

                    MessageBox.Show("エラー発生\r\n\r\nエラー内容: " + ex.Message, "書き込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    registerbutton.Focus();
                    return;
                }
                string accmsg = "メーリングリストの受付が完了しました。";
                if (address.Visible) accmsg += "(アドレス: " + address.Text + ")";
                MessageBox.Show(accmsg + "\r\n登録ありがとう！", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formclear();
            }
        }
        private void formclear()
        {
            name.ResetText();
            dept.SelectedIndex = -1;
            address.ResetText();
            name.Focus();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("入力内容をリセットしてもよろしいでしょうか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                formclear();
            name_input(this, null);
            dept_changed(this, null);
            mail_input(this, null);
        }

        private void mainform_Shown(object sender, EventArgs e)
        {
            this.Activate();
            name.Focus();
        }

        private void name_input(object sender, EventArgs e)
        {
            if (noname.Visible)
            {
                noname.Visible = false;
                name.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void dept_changed(object sender, EventArgs e)
        {
            if (nodept.Visible)
            {
                nodept.Visible = false;
                //dept.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void mail_input(object sender, EventArgs e)
        {
            if (nomail.Visible)
            {
                nomail.Visible = false;
                address.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainform_Click(object sender, EventArgs e)
        {
            if(!(!CloseButton.Visible && System.Windows.Forms.Cursor.Position.Y > 5)) {
                MinimizeButton.Visible = !MinimizeButton.Visible;
                CloseButton.Visible = !CloseButton.Visible;
                TitleLabel.Visible = !TitleLabel.Visible;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
