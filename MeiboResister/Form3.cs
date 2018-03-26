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
    public partial class settingform : Form
    {
        private string lockpass; //パスワード
        private bool canclose = false; //設定完了フラグ(false: 設定せずに閉じられる)
        //データの形式(各ラジオボタンに対応)
        private enum DataFormat { All, WithoutDept, OnlyAddress, OnlyName, Other, Undefined, Error };
        private DataFormat formattype = DataFormat.All;
        private bool FormatChangeable = true; //既存ファイルを開くなどして形式が決まってるかどうかを示すフラグ
        //パスワード受け渡し用プロパティ
        public string gotpass
        {
            get { return lockpass; }
            set { lockpass = value; }
        }
        //パスワード一致プロパティ
        public bool settingok
        {
            get { return canclose; }
            set { canclose = value; }
        }
        //データの形式(順番情報も含む)
        public List<DataItems> ItemOrder
        {
            get;
            set;
        }
        //全画面モード
        public bool isFullScreenMode
        {
            get { return CBisFulScr.Checked; }
        }
        //フォーマットチェック
        private DataFormat CheckFormat(List<DataItems> Items)
        {
            if (Items == null || Items.Count == 0 || Items.Count > 4) return DataFormat.Error; //数のチェック
            int formatnum = 0;
            foreach (var eachitem in Items)
            {
                formatnum |= 1 << (int)eachitem;
            }
            switch (formatnum)
            {
                case (int)ItemFormat.All:
                    return DataFormat.All;
                case (int)ItemFormat.OnlyAddress:
                    return DataFormat.OnlyAddress;
                case (int)ItemFormat.OnlyName:
                    return DataFormat.OnlyName;
                case (int)ItemFormat.WithoutDept:
                    return DataFormat.WithoutDept;
                default:
                    return DataFormat.Other;
            }
        }
        //////////////////////////コンストラクタ//////////////////////////////
        public settingform()
        {
            InitializeComponent();
        }
        public settingform(List<DataItems> Items)
        {
            InitializeComponent();
            formattype = CheckFormat(Items);
            if (formattype != DataFormat.Error)
            { //既存データ
                RBWithoutDept.Enabled = RBAll.Enabled = RBName.Enabled = RBAddress.Enabled = false; //ラジオボタンロック
                var Alternative = new Dictionary<DataFormat, RadioButton>()
                {
                { DataFormat.All, RBAll },
                { DataFormat.OnlyAddress, RBAddress }, 
                { DataFormat.OnlyName, RBName }, 
                { DataFormat.WithoutDept, RBWithoutDept }, 
                { DataFormat.Other, RBOther }
                };
                Alternative[formattype].Checked = true;
                ItemOrder = Items;
            }
            else
            {
                formattype = DataFormat.All;
            }
        }
        public void ShowD(IWin32Window owner)
        {
            base.ShowDialog(owner);
        }

        private void OKButtonCliked(object sender, EventArgs e)
        {
            canclose = true;
            this.Close();
        }

        private void RBAll_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAll.Checked) formattype = DataFormat.All;
        }

        private void RBWithoutDept_CheckedChanged(object sender, EventArgs e)
        {
            if (RBWithoutDept.Checked) formattype = DataFormat.WithoutDept;
        }

        private void RBAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (RBWithoutDept.Checked) formattype = DataFormat.OnlyAddress;
        }

        private void RBName_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAddress.Checked) formattype = DataFormat.OnlyName;
        }

        //フォームが閉じられる
        private void SettingCancel(object sender, FormClosingEventArgs e)
        {
            lockpass = password.Text;
            if (FormatChangeable)
            { //
                ItemOrder = new List<DataItems>();
                switch (formattype)
                { //学部→名前→メアド　の順番が原則
                    case DataFormat.All:
                        ItemOrder.Add(DataItems.Dept);
                        goto case DataFormat.WithoutDept;
                    case DataFormat.WithoutDept:
                        ItemOrder.Add(DataItems.Name);
                        goto case DataFormat.OnlyAddress;
                    case DataFormat.OnlyAddress:
                        ItemOrder.Add(DataItems.Address);
                        break;
                    case DataFormat.OnlyName:
                        ItemOrder.Add(DataItems.Name);
                        break;

                }
            }
        }

    }
}
