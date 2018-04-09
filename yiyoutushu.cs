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
    public partial class yiyoutushu : Form
    {
       // private System.Windows.Forms.DataGrid dataGrid1;
        private SqlConnection sqlConnection1 = null;
        private SqlCommand sqlCommand1 = null;
        private string strSql;
        private DataSet ds;
        LibraryManage ts;
       // private System.ComponentModel.Container components = null;
        public yiyoutushu()
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection(dbconnection.connection);
            sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            ts = new LibraryManage();

        }

        private void FillDataGrid(string sql)
        {
            if (this.sqlConnection1.State == ConnectionState.Closed)
                this.sqlConnection1.Open();
            Console.WriteLine(sql);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
            ds = new DataSet("Library");
            adapter.Fill(ds, "Library");
            this.dataGrid1.SetDataBinding(ds, "Library");
            this.sqlConnection1.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            strSql = " select Lno,Lname,Wr,Ldate,Lpress,Lbz  from Library  where ";
            if (Lno.Text != "")
                strSql = strSql + "Lno=" + "'" + Lno.Text + "'";
            else if (Lname.Text != "")
                strSql = strSql + "Lname like" + "'%" +Lname.Text + "%'";
            else if (Wr.Text != "")
                strSql = strSql + "Wr like" + "'%" + Wr.Text + "%'";
            else if (Ldate.Text != "")
                strSql = strSql + "Ldate=" + "'" + Ldate.Text + "'";
            else if (Lpress.Text != "")
                strSql = strSql + "Lpress=" + "'" + Lpress.Text + "'";
               // strSql = strSql+"CustomerName like"+"'%"+textName.Text+"%'";
            else
            {
                MessageBox.Show("请选择查询条件！", "提示");
                return;
            }

            this.FillDataGrid(this.strSql);
        }

        //private void yiyoutushu_Load(object sender, EventArgs e)
        //{
        //    strSql = " select Lno,Lname,Wr,Ldate,Lpress,Lbz  from Library";
        //         this.FillDataGrid(this.strSql);
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            strSql = " select Lno,Lname,Wr,Ldate,Lpress,Lbz  from Library";
            this.FillDataGrid(this.strSql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Lno.Clear();
            this.Lname.Clear();
            this.Ldate.Clear();
            this.Wr.Clear();
            //this.Lpress.Clear();
        }

        private void yiyoutushu_Load(object sender, EventArgs e)
        {
            this.strSql = " select Lno 图书代码,Lname 图书名称,Wr 作者,Lpress 出版社 from Library  ";
            this.FillDataGrid(strSql);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            strSql = " select * from Library";
            this.FillDataGrid(this.strSql);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.Lno.Text == "")
            {
                MessageBox.Show("请输入完整信息！", "提示");
                return;
            }
            //int Rage = Convert.ToInt32(this.Rage.Text);
            string Lno = this.Lno.Text;

            ts.ts_del(Lno);
            MessageBox.Show("删除成功！");
            this.FillDataGrid(this.strSql);
        }

   

       
  
    }
}
