using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 自动生成器
{
    public partial class Sc : Form
    {
        string mess = string.Empty;

        StringBuilder sb = new StringBuilder();
         
        Model M = new Model();
        /// <summary>
        /// 接收值
        /// </summary>
        /// <param name="server"></param>
        /// <param name="cbyz"></param>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        public Sc(Model m)
        {
            M = m;
            InitializeComponent();
        }

        /// <summary>
        /// 窗体一加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sc_Load(object sender, EventArgs e)
        { 
            ScF();
        }

        /// <summary>
        /// 根据数据库查询数据表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbUname_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbUnameF();
        }

        /// <summary>
        /// 根据数据表查询数据类型及名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbNameF();
        }

        /// <summary>
        /// 存储路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtLj_Click(object sender, EventArgs e)
        {
            BtLjF();
        }

        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtSc_Click(object sender, EventArgs e)
        {
            if (LbName.SelectedIndex < 0)
            {
                MessageBox.Show("请选择数据表");
                return;
            }
            if (TbUname.Text == "输入命名空间" || TbUname.Text == "")
            {
                TbUname.Focus();
                TbUname.ForeColor = Color.Black;
                MessageBox.Show("请输入命名空间！");
                return;
            }
            BtScF();
        }

        /// <summary>
        /// 生成SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtSQL_Click(object sender, EventArgs e)
        {
            if (LbName.SelectedIndex < 0)
            {
                MessageBox.Show("请选择数据表");
                return;
            }
            if (TbUname.Text == "输入命名空间" || TbUname.Text == "")
            {
                TbUname.Focus();
                TbUname.ForeColor = Color.Black;
                MessageBox.Show("请输入命名空间！");
                return;
            }
            BtSQLF();
        }

        /// <summary>
        /// 下载通用DBHelp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtXdb_Click(object sender, EventArgs e)
        {
            BtCc();
            BtXdbF();
        }

        /// <summary>
        /// 窗体一加载方法
        /// </summary>
        public void ScF()
        {
            string sql = "SELECT * FROM SYSDATABASES WHERE DBID>4 ORDER BY name";
            DataTable dt = DBHelp.Qu(M, sql,out mess);
            if (dt != null)
            {
                CbUname.DataSource = dt;
                CbUname.DisplayMember = "name";
                CbUname.ValueMember = "dbid";
                LbName.SelectedIndex = 0;
            }
            TbUname.ForeColor = Color.Gray;
        }

        /// <summary>
        /// 根据数据库查询数据表方法
        /// </summary>
        public void CbUnameF()
        {
            if (CbUname.Text != "System.Data.DataRowView")
            LbName.Items.Clear();
            string sql = "USE " + CbUname.Text + " SELECT name FROM SYSOBJECTS WHERE xtype = 'U' ORDER BY name";
            DataTable dt = DBHelp.Qu(M, sql, out mess);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string t = dt.Rows[i][0].ToString();
                    LbName.Items.Add(t);
                }
                LbName.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 根据数据表查询数据名称及类型
        /// </summary>
        public void LbNameF()
        {
            string sql = string.Format(@"USE {0}
                                        SELECT
                                        B.name AS column_name,
                                        d.name,
                                        C.value AS column_description,
                                        A.name AS table_name
                                        FROM sys.tables A
                                        INNER JOIN sys.columns B ON B.object_id = A.object_id
                                        inner join systypes d on d.xusertype = b.system_type_id
                                        LEFT JOIN sys.extended_properties C ON C.major_id = B.object_id AND C.minor_id = B.column_id
                                        WHERE A.name = '{1}'", CbUname.Text.ToString(), LbName.Text.ToString());
            DataTable dt = DBHelp.Qu(M, sql,out mess);
            if (dt != null)
                dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// 存储路径方法
        /// </summary>
        public void BtLjF()
        {
            FBD = new FolderBrowserDialog();
            FBD.ShowDialog();
            TbDz.Text = FBD.SelectedPath;
        }

        public void BtCc()
        {
            if (TbDz.Text != "")
                return;
            else
                BtLj_Click(null,null);
        }

        /// <summary>
        /// 生成实体类方法
        /// </summary>
        public void BtScF()
        {
            BtCc();
            sb.Append("using System;\r\n");
            sb.Append("using System.Collections.Generic;\r\n");
            sb.Append("using System.Linq;\r\n");
            sb.Append("using System.Text;\r\n");
            sb.Append("using System.Threading.Tasks;\r\n");
            sb.AppendFormat("namespace {0}\r\n", TbUname.Text);
            sb.Append("{\r\n");
            sb.AppendFormat("    public class Entity{0}", DataName(LbName.Text));
            sb.Append("\r\n    {\r\n");

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string type = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string DataName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                sb.Append("        /// <summary>\r\n");
                sb.AppendFormat("        ///{0}{1}", dataGridView1.Rows[i].Cells[2].Value.ToString(), "\r\n");
                sb.Append("        /// <summary>\r\n");
                sb.Append("        public " + TypeZ(type) + " " + DataName.ToLower() + ";");
                sb.Append("\r\n");
                sb.Append("        public");
                sb.Append(" ");
                sb.Append(TypeZ(type));
                sb.Append(" ");
                sb.Append(DataName);
                sb.Append("\r\n");
                sb.Append("        {");
                sb.Append("\r\n");
                sb.Append(" ");
                sb.Append("            get{return " + DataName.ToLower() + ";}");
                sb.Append("\r\n");
                sb.Append(" ");
                sb.Append("            set{" + DataName.ToLower() + "=value;}");
                sb.Append("\r\n");
                sb.Append("        }");
                sb.Append("\r\n");
            }
            sb.Append("    }");
            sb.Append("\r\n");
            sb.Append("}");
            sb.Append("\r\n");
            FileL(sb.ToString(), "Entity" + LbName.Text.ToString());
        }

        /// <summary>
        /// 生成实体类>数据名称>方法
        /// </summary>
        public string DataName(string Su)
        {
            if (Su.Length > 0)
                return Su.Substring(0, 1).ToUpper() + Su.Substring(1).ToLower();
            else
                return Su.ToUpper();
        }

        /// <summary>
        /// 生成实体类>类型转换>方法
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string TypeZ(string type)
        {
            switch (type)
            {
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                    type = "string";
                    break;
                case "int":
                    type = "int";
                    break;
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldatetime":
                    type = "DateTime";
                    break;
                case "bigint":
                    type = "long";
                    break;
                case "binary":
                case "image":
                case "varbinary":
                    type = "byte[]";
                    break;
                case "bit":
                    type = "bool";
                    break;
                case "datetimeoffset":
                    type = "DateTimeOffset";
                    break;
                case "decimal":
                case "money":
                case "numeric":
                case "smallmoney":
                    type = "decimal";
                    break;
                case "float":
                    type = "float";
                    break;
                case "real":
                    type = "double";
                    break;
                case "smallint":
                    type = "short";
                    break;
                case "time":
                    type = "TimeSpan";
                    break;
                case "tinyint":
                    type = "byte";
                    break;
                case "uniqueidentifier":
                    type = "Guid";
                    break;
                default:
                    type = type;
                    break;
            }
            return type;
        }

        /// <summary>
        /// 写入文件>方法
        /// </summary>
        public void FileL(string str, string name)
        {
            FileStream fs = null;
            try
            {
                if (TbDz.Text != "")
                {
                    fs = File.Open(TbDz.Text + @"\" + name + ".cs", FileMode.Create);
                    byte[] array = Encoding.Default.GetBytes(str);
                    fs.Write(array, 0, array.Length);
                    MessageBox.Show(CbUname.Text + "生成成功！");
                    fs.Close();
                }
                else
                    fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("生成失败,错误的原因是：" + ex.Message);
                return;
            }
            finally
            {
                sb.Clear();
            }
        } 

        /// <summary>
        /// 生成SQL方法
        /// </summary>
        public void BtSQLF()
        {
            BtCc();
            T();
            InsertF();
            FortxtF();
            DeleteF();
            UpdateF();
            SelectF();
            FileL(sb.ToString(), "SQL" + LbName.Text.ToString());
        }

        /// <summary>
        /// 生成SQL头
        /// </summary>
        public void T()
        {
            sb.Append("using System;");
            sb.Append("\r\n");
            sb.Append("using System.Collections.Generic;");
            sb.Append("\r\n");
            sb.Append("using System.Data.SqlClient;");
            sb.Append("\r\n");
            sb.Append("using System.Linq;");
            sb.Append("\r\n");
            sb.Append("using System.Text;");
            sb.Append("\r\n");
            sb.Append("using System.Threading.Tasks;");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("using System.Data;");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.AppendFormat("namespace {0}", TbUname.Text.ToLower());
            sb.Append("\r\n");
            sb.Append("{");
            sb.Append("\r\n");
            sb.AppendFormat("    public class SQL{0}", LbName.Text);
            sb.Append("\r\n");
            sb.Append("    {");
            sb.Append("\r\n");
        }

        /// <summary>
        /// 死的前缀方法
        /// </summary>
        public void SSF()
        {
            sb.Append(" ");
            sb.Append("(");
            sb.Append("" + TbUname.Text + ".Entity" + DataName(LbName.Text.ToString()) + " " + "" + TbUname.Text.ToLower() + "_" + DataName(LbName.Text.ToString().ToLower()));
            sb.Append(" ");
            sb.Append(")\r\n");
            sb.Append("        {");
            sb.Append("\r\n");
            sb.Append("            string sql=\"");
        }

        /// <summary>
        /// 添加方法
        /// </summary>
        public void InsertF()
        {
            sb.Append("        public static bool");
            sb.Append(" ");
            sb.Append(LbName.Text + "Add");
            SSF();
            sb.Append("INSERT INTO " + LbName.Text + " VALUES (");
            for (int i = 0; i < dataGridView1.RowCount -1; i++)
            {
                sb.Append("@" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "");
                if (i < dataGridView1.RowCount - 2)
                    sb.Append(",");
            }
            sb.Append(")\";");
            sb.Append("\r\n");
            sb.Append("            SqlParameter[] sqlpa={\r\n");
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        public void DeleteF()
        {
            sb.Append("\r\n");
            sb.Append("        public static bool");
            sb.Append(" ");
            sb.Append(LbName.Text + "del");
            SSF();
            sb.Append("DELETE FROM " + LbName.Text + " " + dataGridView1.Rows[0].Cells[0].Value.ToString() +"=@"+ dataGridView1.Rows[0].Cells[0].Value.ToString() + "\";");
            sb.Append("\r\n");
            sb.Append("            SqlParameter[] sqlpa={\r\n");
            sb.Append("                new SqlParameter(\"@" + dataGridView1.Rows[0].Cells[0].Value.ToString() + "\"," + TbUname.Text.ToLower() + "_" + DataName(LbName.Text.ToString()).ToLower() + "." + dataGridView1.Rows[0].Cells[0].Value.ToString() + ")};");
            sb.Append("\r\n");
            sb.Append("            return DBHelp.ExecuteCommand(sql,sqlpa);");
            sb.Append("\r\n");
            sb.Append("        }");
            sb.Append("\r\n");
        }

        /// <summary>
        /// 修改方法
        /// </summary>
        public void UpdateF()
        {
            sb.Append("\r\n");
            sb.Append("        public static bool");
            sb.Append(" ");
            sb.Append(LbName.Text + "upd");
            SSF();
            sb.Append("UPDATE "+LbName.Text+" SET ");
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                sb.Append("" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "=@" + dataGridView1.Rows[i].Cells[0].Value.ToString() + " ");
                if (i < dataGridView1.RowCount - 2)
                    sb.Append(", ");
            }
            sb.Append("WHERE " + dataGridView1.Rows[0].Cells[0].Value.ToString() + "=@" + dataGridView1.Rows[0].Cells[0].Value.ToString() + "\";");
            sb.Append("\r\n");
            sb.Append("            SqlParameter[] sqlpa={");
            sb.Append("\r\n");
            FortxtF();
        }

        /// <summary>
        /// 查询方法
        /// </summary>
        public void SelectF()
        {
            sb.Append("\r\n");
            sb.Append("        public static DataTable");
            sb.Append(" ");
            sb.Append(LbName.Text + "sel");
            SSF();
            sb.Append("SELECT ");
            for (int i = 0; i < dataGridView1.RowCount -1; i++)
            {
                sb.Append(""+dataGridView1.Rows[i].Cells[0].Value.ToString() +"");
                if (i < dataGridView1.RowCount - 2)
                    sb.Append(",");
            }
            sb.Append(" FROM " + LbName.Text + " WHERE ");
            for (int i = 0; i < dataGridView1.RowCount -1; i++)
            {
                sb.Append("" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "=@" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "");
                if (i < dataGridView1.RowCount - 2)
                    sb.Append(" and ");
            }
            sb.Append(" \";");
            sb.Append("\r\n");
            sb.Append("            SqlParameter[] sqlpa={\r\n");
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                sb.Append("                new SqlParameter");
                sb.Append("(");
                sb.Append("\"@" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "\"," + TbUname.Text.ToLower() + "_" + DataName(LbName.Text.ToString()).ToLower() + "." + dataGridView1.Rows[i].Cells[0].Value.ToString() + ")");
                if (i == dataGridView1.RowCount - 2)
                    sb.Append("};\r\n");
                else
                    sb.Append(",\r\n");
            }
            sb.Append("            return DBHelp.ExcuteQuery(sql,sqlpa);\r\n");
            sb.Append("        }");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("    }");
            sb.Append("\r\n");
            sb.Append("}");
        }

        /// <summary>
        /// 内容方法
        /// </summary>
        public void FortxtF()
        {
            for (int i = 0; i < dataGridView1.RowCount -1; i++)
            {
                sb.Append("                new SqlParameter");
                sb.Append("(");
                sb.Append("\"@" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "\"," + TbUname.Text.ToLower() + "_" + DataName(LbName.Text.ToString()).ToLower() + "." + dataGridView1.Rows[i].Cells[0].Value.ToString() + ")");
                if (i == dataGridView1.RowCount - 2)
                    sb.Append("};\r\n");
                else
                    sb.Append(",\r\n");
            }
            sb.Append("            return DBHelp.ExecuteCommand(sql,sqlpa);\r\n");
            sb.Append("        }");
            sb.Append("\r\n");
            sb.Append("\r\n");
        }

        private void TbUname_MouseEnter(object sender, EventArgs e)
        {
            if (TbUname.Text == "输入命名空间")
            {
                TbUname.Text = "";
                TbUname.Focus();
                TbUname.ForeColor = Color.Black;
            }
            else
                return;
        }

        private void TbUname_MouseLeave(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 关闭确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出系统吗？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
            else
                e.Cancel = true;
        }

        /// <summary>
        /// 下载通用DBHelp方法
        /// </summary>
        public void BtXdbF()
        {

        }
    }
}
