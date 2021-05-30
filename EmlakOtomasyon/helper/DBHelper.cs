using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace EmlakOtomasyon.helper
{
    class DBHelper
    {
        private static DBHelper instance = null;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private DataTable dt;

        private DBHelper()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            cmd = new SqlCommand("", con);
            dt = new DataTable();
        }

        public static DBHelper getInstance()
        {
            if (instance == null)
            {
                instance = new DBHelper();
            }

            return instance;
        }

        public bool isLogin(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            bool login = cmd.ExecuteReader().Read();
            con.Close();

            return login;
        }

        // bağlantı kapandığı için geriye ExecuteReader döndüremiyor
        public SqlDataReader executeReader(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            con.Close();

            return dr;
        }

        public int executeNonQuery(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            int result = cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }

        public object executeScalar(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            object obj = cmd.ExecuteScalar();
            con.Close();

            return obj;
        }

        public DataTable executeDataTable(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            dt.Clear();
            dt.Load(cmd.ExecuteReader());
            con.Close();

            return dt.Copy();
        }
    }
}
