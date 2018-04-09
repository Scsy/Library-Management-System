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
    public partial class duzhexinxi : Form
    {
        private SqlConnection sqlConnection1;
        private SqlCommand sqlCommand1 = null;
        private DataSet ds = null;
        // private bool add;
        private string strSql;
        duzhe dz;
        public duzhexinxi()
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection(dbconnection.connection);
            sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            //add = false;
            dz = new duzhe();
        }

       
        private void duzhexinxi_Load(object sender, EventArgs e)
        {

            this.strSql = " select Rno 读者号,Rname 读者姓名,Rsex 性别,Rdep 所在系,Rage 年龄 from Reader ";
            this.FillDataGrid(strSql);
        }
        private void FillDataGrid(string sql)
        {
            if (this.sqlConnection1.State == ConnectionState.Closed)
                this.sqlConnection1.Open();
            Console.WriteLine(sql);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
            ds = new DataSet("Reader");
            adapter.Fill(ds, "Reader");
            this.dataGrid1.SetDataBinding(ds, "Reader");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Rno.Text == "" || this.Rname.Text == "" || this.Rsex.Text == "")
            {
                MessageBox.Show("请输入完整信息！", "提示");
                return;
            }
            int Rage = Convert.ToInt32(this.Rage.Text);
            string Rno = this.Rno.Text;
            string Rname = this.Rname.Text;
            string Rsex = this.Rsex.Text;
            string Rdep = this.Rdep.Text;
          //  int Rage= this.Rage.Text;
            //int Rage = Convert.ToInt32(this.Rage.Text);

            dz.dz_add(Rno, Rname, Rsex, Rdep,Rage);
            MessageBox.Show("保存成功！");
            this.FillDataGrid(this.strSql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rno.Clear();
            Rname.Clear();
            //Rsex.Clear();
            //Rdep.Clear();
            //Rage.Clear();
            //Ldate.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
