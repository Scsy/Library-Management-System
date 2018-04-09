using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace 登陆
{
    class jieyue
    {

        private SqlConnection sqlConnection1 = null;
        private SqlCommand sqlCommand1 = null;
        private string strSql = null;
        public jieyue()
        {
            this.sqlConnection1 = new SqlConnection(dbconnection.connection);
            this.sqlCommand1 = new SqlCommand();
            this.sqlCommand1.CommandType = CommandType.Text;
            this.sqlCommand1.Connection = this.sqlConnection1;

            // TODO: 在此处添加构造函数逻辑
            //
        }

        public void Jieyue_add(string Rno, string Lno)
        {
            DateTime Date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            DateTime Redate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            this.strSql = "insert into jy (Rno,Lno,Date,Redate) " +
                "values('" + Rno + "','" + Lno + "','" + Date + "','" + Redate + "')";
            this.sqlCommand1.CommandText = this.strSql;
            try
            {
                this.sqlConnection1.Open();
                this.sqlCommand1.ExecuteNonQuery();
                //Lno_add(Lno);
            }
            catch (System.Exception E)
            {
                Console.WriteLine(E.ToString());
            }
            finally
            {
                this.sqlConnection1.Close();
            }
        }

            public void jieyue_del(string Lno)
	    	{
                this.strSql = "delete from jy where Lno=" + "'" + Lno + "'";
                //this.strSql = "delete from jy where Rno= " + "'" + Rno + "'";
			this.sqlCommand1.CommandText=this.strSql;
			try
			{
				this.sqlConnection1.Open();
				this.sqlCommand1.ExecuteNonQuery();
			}
			catch(System.Exception E)
			{
				Console.WriteLine(E.ToString());
			}
			finally
			{
				this.sqlConnection1.Close();
			}
        }
    }
}
