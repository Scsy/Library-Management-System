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
    public partial class jieyuexinxi : Form
    {
             private SqlConnection sqlConnection1;
             private SqlCommand sqlCommand1 = null;
             private DataSet ds = null;
       // private bool add;
             private string strSql;
             jieyue jy;
       public jieyuexinxi()
       {
            InitializeComponent();
            sqlConnection1 = new SqlConnection(dbconnection.connection);
            sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            //add = false;
            jy = new jieyue();
             //MessageBox.Show("没有写图书编号！", "警告");
       }
        //public jieyuexinxi(string Rno)
        //{
        //    InitializeComponent();
        //   // this.Rno.Text = Rno;
        //    //this.Lno.Text = Lno;
        //    sqlConnection1 = new SqlConnection(dbconnection.connection);
        //    sqlCommand1 = new SqlCommand();
        //    sqlCommand1.Connection = sqlConnection1;

        //    jy = new jieyue();
           
        //}
        private void jieyuexinxi_Load(object sender, EventArgs e)
        {

            this.strSql = "select Rno 读者号,Lno 图书号,Date 借出日期,Redate 归还日期 from jy ";
            this.FillDataGrid(strSql);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.Rno.Text == "" || this.Lno.Text == "")
            {
                MessageBox.Show("请输入完整信息！", "提示");
                return;
            }

            string Rno = this.Rno.Text;
            string Lno = this.Lno.Text;
            string Date = this.Date.Text;
            string Redate = this.Redate.Text;
            //string Lbz = this.Lbz.Text;

           jy.Jieyue_add(Rno, Lno);
            MessageBox.Show("保存成功！");
            this.FillDataGrid(this.strSql);
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Rno.Clear();
            Lno.Clear();
            Date.Clear();
            Redate.Clear();
            
            
        }
        //private void FillDataGrid(string sql)
        //{
        //    if (this.sqlConnection1.State == ConnectionState.Closed)
        //        this.sqlConnection1.Open();
        //    Console.WriteLine(sql);
        //    SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
        //    ds = new DataSet("jy");
        //    adapter.Fill(ds, "jy");
        //    this.dataGrid1.SetDataBinding(ds, "jy");
        //    this.sqlConnection1.Close();
        //}
        
    }
}
