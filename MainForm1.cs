using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace 登陆
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
             
        }
        private void 已有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Tushuxinxi = new Tushuxinxi();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            Tushuxinxi.MdiParent = this;
            Tushuxinxi.WindowState = FormWindowState.Maximized;
            Tushuxinxi.Show();
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form duzhexinxi = new duzhexinxi();
            for (int x = 0;x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            duzhexinxi.MdiParent = this;
            //duzhexinxi.MdiParent = this;
            duzhexinxi.WindowState = FormWindowState.Maximized;
           // duzhexinxi.WindowState = FormWindowState.Maximized;
           // duzhexinxi.Show();
            duzhexinxi.Show();
        }

        private void 借阅信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form jieyuexinxi = new jieyuexinxi();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            jieyuexinxi.MdiParent = this;
            // Help.MdiParent = this;
            jieyuexinxi.WindowState = FormWindowState.Maximized;
            jieyuexinxi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Load fm = new Load();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
