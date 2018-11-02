using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace 自动生成器
{
    public class DBHelp
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="Server">服务器名称</param>
        /// <param name="CbYz">验证方式</param>
        /// <param name="User">账号</param>
        /// <param name="Pwd">密码</param>
        /// <param name="sql">查询语句</param>
        /// <returns></returns>
        public static DataTable Qu(Model m, string sql,out string mess)
        {
            mess = string.Empty;
            DataTable dt = new DataTable();
            string sqlcon = string.Empty;
            if (m.CbYz == "Windows身份验证")
                sqlcon = string.Format("Data Source={0};Integrated Security=True", m.Server);
            else
                sqlcon = string.Format("Server={0};Database=master;Uid={1};Pwd={2}", m.Server, m.User, m.Pwd);
            SqlConnection con = new SqlConnection(sqlcon);
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, sqlcon);
                con.Open();
                adp.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                mess = ex.ToString();
                return null;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
