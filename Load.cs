using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace 登陆
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Focus();
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(dbconnection.connection);
                    string str = "select * from Manage where id='" + this.textBox1.Text.Trim() + "'";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        if (textBox2.Text.Trim() == read["pwd"].ToString().Trim())
                        {
                            if (RB.Checked)
                            {
                                this.Hide();
                                MainForm1 fm = new MainForm1();
                                fm.Show();
                            }
                            else if(RB1.Checked){
                            this.Hide();
                            MainForm fm= new MainForm();
                         
                            fm.Show();}
                        }
                        else
                        {
                            MessageBox.Show("密码错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox2.Clear();
                            textBox2.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("不存在该用户");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Load_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

