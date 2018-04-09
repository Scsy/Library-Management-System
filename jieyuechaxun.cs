using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 登陆
{
    public partial class jieyuechaxun : Form
    {
        private SqlConnection sqlConnection1 = null;
        private SqlCommand sqlCommand1 = null;
        private string strSql;
        private DataSet ds;
        jieyue jy;
        public jieyuechaxun()
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection(dbconnection.connection);
            sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            jy = new jieyue();
        }
        private void FillDataGrid(string sql)
        {
            if (this.sqlConnection1.State == ConnectionState.Closed)
                this.sqlConnection1.Open();
            Console.WriteLine(sql);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
            ds = new DataSet("jy");
            adapter.Fill(ds, "jy");
            this.dataGrid1.SetDataBinding(ds, "jy");
            this.sqlConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strSql = " select Rno,Lno,Date,Redate from jy  where ";
            if (Rno.Text != "")
                strSql = strSql + "Rno=" + "'" + Rno.Text + "'";
            else if (Lno.Text != "")
                strSql = strSql + "Lno=" + "'" + Lno.Text + "'";
               // strSql = strSql+"CustomerName like"+"'%"+textName.Text+"%'";
            else
            {
                MessageBox.Show("请选择查询条件！", "提示");
                return;
            }

            this.FillDataGrid(this.strSql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            strSql = " select Rno 读者号,Lno  图书代码,Date 借出日期,Redate 归还日期 from jy";
            this.FillDataGrid(this.strSql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Rno.Clear();
            this.Lno.Clear();
           // this.Date.Clear();
           // this.Redate.Clear();
           //// this.Lpress.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.Rno.Text == "")
            {
                MessageBox.Show("请输入完整信息！", "提示");
                return;
            }
            //int Rage = Convert.ToInt32(this.Rage.Text);
            string Rno = this.Rno.Text;
            //string Lno = this.Lno.Text;
            jy.jieyue_del(Rno);
            MessageBox.Show("删除成功！");
            this.FillDataGrid(this.strSql);
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            strSql = " select * from jy";
            this.FillDataGrid(this.strSql);
        }

        private void jieyuechaxun_Load_1(object sender, EventArgs e)
        {
            this.strSql = " select Rno 读者号,Lno  图书代码,Date 借出日期,Redate 归还日期 from jy ";
            this.FillDataGrid(strSql);
        }
        }

    }


