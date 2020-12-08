using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin
{
    public partial class MakeSHA1WithRSA : Form
    {
        public MakeSHA1WithRSA()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 私钥
        /// </summary>
        public string PrivateKey { get; set; }
        /// <summary>
        /// 公钥
        /// </summary>
        public string PublicKey { get; set; }

        private void MakeSHA1WithRSA_Load(object sender, EventArgs e)
        {
            txt_PrivateKey.Text = PrivateKey = "";
        }

        private void btn_Sign_Click(object sender, EventArgs e)
        {
           txt_Result.Text= SHA1WithRSA.Sign(txt_WaitSignStr.Text,PrivateKey,"UTF-8");
        }
    }
}
