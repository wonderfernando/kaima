using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class UsuarioDB
    {
        Conection con = new Conection();
        public bool login(string username, string senha)
        {
            
            string sql = "SELECT * FROM users WHERE (username = @username) AND (senha = @senha)";
            
            MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sql, con.getConection());
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            adapter.SelectCommand.Parameters.AddWithValue("@senha", senha);
            adapter.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            return dt.Rows.Count > 0 ? true : false;
           
        }
    }
}
