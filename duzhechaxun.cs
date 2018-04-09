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
    public partial class duzhechaxun : Form
    {
        private SqlConnection sqlConnection1 = null;
        private SqlCommand sqlCommand1 = null;
        private string strSql;
        private DataSet ds;
        duzhe dz;
        public duzhechaxun()
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection(dbconnection.connection);
            sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            dz = new duzhe();
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
            this.sqlConnection1.Close();
        }

        private void duzhechaxun_Load(object sender, EventArgs e)
        {
            this.strSql = "  select Rno 读者号,Rname 读者姓名,Rsex 性别,Rdep 所在系,Rage 年龄 from Reader ";
            this.FillDataGrid(strSql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strSql = " select Rno, Rname, Rsex, Rdep,Rage from Reader where ";
            if (Rno.Text != "")
                strSql = strSql + "Rno=" + "'" + Rno.Text + "'";
            else if (Rname.Text != "")
                strSql = strSql + "Rname like" + "'%" + Rname.Text + "%'";
            else if (Rsex.Text != "")
                strSql = strSql + "Rsex=" + "'" + Rsex.Text + "'";
            else if (Rdep.Text != "")
                strSql = strSql + "Rdep=" + "'" + Rdep.Text + "'";
            else if (Rage.Text != "")
                strSql = strSql + "Rage=" + "'" + Rage.Text + "'";
            // strSql = strSql+"CustomerName like"+"'%"+textName.Text+"%'";
            else
            {
                MessageBox.Show("请选择查询条件！", "提示");
                return;
            }

            this.FillDataGrid(this.strSql);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            strSql = " select * from Reader";
            this.FillDataGrid(this.strSql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Rno.Clear();
            this.Rname.Clear();
            this.Rage.Clear();
            //this.Wr.Clear();
        }

        private void Rname_TextChanged(object sender, EventArgs e)
        {

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
            dz.dz_del(Rno);
            MessageBox.Show("删除成功！");
            this.FillDataGrid(this.strSql);
            
        }
    }
}
