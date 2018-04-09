using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 登陆
{
    class LibraryManage
    {
        private SqlConnection sqlConnection1 = null;
        private SqlCommand sqlCommand1 = null;
        private string strSql = null;
        public LibraryManage()
        {
            this.sqlConnection1 = new SqlConnection(dbconnection.connection);
            this.sqlCommand1 = new SqlCommand();
            this.sqlCommand1.CommandType = CommandType.Text;
            this.sqlCommand1.Connection = this.sqlConnection1;

            // TODO: 在此处添加构造函数逻辑
            //
        }

        public void Library_add(string Lno, string Lname, string Wr, string Lpress, string Lbz)
        {
            DateTime Ldate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            this.strSql = "insert into Library (Lno,Lname,Wr,Ldate,Lpress,Lbz) " +
                "values('" + Lno + "','" + Lname + "','" + Wr + "','" + Ldate + "','" + Lpress + "','" + Lbz + "')";
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
        public void ts_del(string Lno)
        {
            this.strSql = "delete from Library where Lno= " + "'" + Lno + "'";
            this.sqlCommand1.CommandText = this.strSql;
            try
            {
                this.sqlConnection1.Open();
                this.sqlCommand1.ExecuteNonQuery();
            }
            catch (System.Exception E)
            {
                Console.WriteLine(E.ToString());
            }
            finally
            {
                this.sqlConnection1.Close();
            }
            //    public void trueNum_add(int Lno)
            //    {
            //        strSql = "Update Library Set Lno=Lno+1 Where Lno=" + "'" + Lno + "'";
            //        sqlCommand2.CommandText = strSql;

            //        try
            //        {
            //            if (sqlConnection1.State == ConnectionState.Closed)
            //                sqlConnection1.Open();
            //            sqlCommand2.ExecuteNonQuery();
            //        }
            //        catch (System.Exception e)
            //        {
            //            Console.WriteLine(e.ToString());
            //        }
            //        finally
            //        {
            //            sqlConnection1.Close();
            //        }
            //    }s
        }
    }
}