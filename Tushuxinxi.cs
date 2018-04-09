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
    public partial class Tushuxinxi : Form
    {

        private SqlConnection sqlConnection1;
        private SqlCommand sqlCommand1 = null;
        private DataSet ds = null;
        // private bool add;
        private string strSql;
        LibraryManage libraryManage;
        // private System.ComponentModel.Container components = null;
        public Tushuxinxi()
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection(dbconnection.connection);
            sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            //add = false;
            libraryManage = new LibraryManage();
            //MessageBox.Show("没有写图书编号！", "警告");
        }
       
        private void Tushuxinxi_Load(object sender, EventArgs e)
        {

            this.strSql = " select Lno 图书代码,Lname 图书名称,Wr 作者,Lpress 出版社 from Library ";
            this.FillDataGrid(strSql);
        }

        
        private void FillDataGrid(string sql)
        {
            if (this.sqlConnection1.State == ConnectionState.Closed)
                this.sqlConnection1.Open();
            Console.WriteLine(sql);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
            ds = new DataSet("Library");
            adapter.Fill(ds, "Library");
            this.dataGrid2.SetDataBinding(ds, "Library");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.Lno.Text == "" || this.Lname.Text == "" || this.Wr.Text == "")
            {
                MessageBox.Show("请输入完整信息！", "提示");
                return;
            }
            string  Lno =this.Lno.Text;
            string Lname = this.Lname.Text;
            string Wr = this.Wr.Text;
            string Lpress = this.Lpress.Text;
            string Lbz = this.Lbz.Text;


            libraryManage.Library_add(Lno, Lname, Wr, Lpress,Lbz);
            MessageBox.Show("保存成功！");
            this.FillDataGrid(this.strSql);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lno.Clear();
            Lname.Clear();
            Wr.Clear();
            // Lpress.Clear();
            Lbz.Clear();
            Ldate.Clear();

        }    

    }
}
