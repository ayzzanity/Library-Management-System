using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    class DBTransactions
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        ConnectionString connString = new ConnectionString();

        public DataSet load(string sql)
        {
            DataSet ds = new DataSet();
            con.ConnectionString = connString.connString();
            da = new MySqlDataAdapter(sql, con);
            da.Fill(ds, "Data");
            con.Close();
            return ds;
        }

        public void executeSql(string sql)
        {
            con.ConnectionString = connString.connString();
            con.Open();
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
