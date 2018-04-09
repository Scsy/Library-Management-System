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
    public partial class MainForm : Form
    {
     
       
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void 系统帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Help = new Help();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            Help.MdiParent = this;
            // Help.MdiParent = this;
            Help.WindowState = FormWindowState.Maximized;
            Help.Show();
        }

        private void 图书代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form Tushuxinxi = new Tushuxinxi();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            Tushuxinxi.MdiParent = this;
            // Help.MdiParent = this;
            Tushuxinxi.WindowState = FormWindowState.Maximized;
            Tushuxinxi.Show();
        }
        private void 出版时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yiyoutushu = new yiyoutushu();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            yiyoutushu.MdiParent = this;
            // Help.MdiParent = this;
            yiyoutushu.WindowState = FormWindowState.Maximized;
            yiyoutushu.Show();
        }

        private void 系统退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 图书作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yiyoutushu = new yiyoutushu();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            yiyoutushu.MdiParent = this;
            // Help.MdiParent = this;
            yiyoutushu.WindowState = FormWindowState.Maximized;
            yiyoutushu.Show();
        }

        private void 借阅时间ToolStripMenuItem_Click(object sender, EventArgs e)
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

      
        private void 归还时间ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form jieyuechaxun = new jieyuechaxun();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            jieyuechaxun.MdiParent = this;
            //Help.MdiParent = this;
            jieyuechaxun.WindowState = FormWindowState.Maximized;
            jieyuechaxun.Show();
        }

        private void 学生情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form duzhexinxi = new duzhexinxi();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            duzhexinxi.MdiParent = this;
            //Help.MdiParent = this;
            duzhexinxi.WindowState = FormWindowState.Maximized;
            duzhexinxi.Show();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form duzhechaxun = new duzhechaxun();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            duzhechaxun.MdiParent = this;
            //Help.MdiParent = this;
            duzhechaxun.WindowState = FormWindowState.Maximized;
            duzhechaxun.Show();
        }

        }

    }

