using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin
{
    public partial class Form3 : Form
    {
        Thread thread;//声明一个线程,全局变量
        delegate void DoProcess();//先声明一个调用给控件赋值的委托
        DoProcess DoWriteProcess;  //定义一个委托的全局变量
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            thread = new Thread(DoDelegate);//实例化一个线程(新开启一个线程)
            thread.Start();//启动线程
        }
        public void DoPro()
        {
            try
            {
                for (int i = 0; i < (progressBar1.Maximum / 10); i++)
                {
                    progressBar1.Value += 10;
                    Application.DoEvents();
                    List<int> times = new List<int>() { 1000, 2000, 1500, 300, 3000, 2500, 1200, 1100, 800, 4000 };
                    Thread.Sleep(times[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 用于线程调用委托的方法
        /// </summary>
        public void DoDelegate()
        {
            DoWriteProcess = DoPro;//将方法绑定给委托
            Invoke(DoWriteProcess);

        }
    }
}
