using MySql.Data.MySqlClient;
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
        public DataRow login(string username, string senha)
        {
           // DataTable dt = new DataTable();
            string sql = "SELECT * FROM users WHERE (username = @username) AND (senha = @senha)";
            
            MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sql, con.getConection());
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            adapter.SelectCommand.Parameters.AddWithValue("@senha", senha);
            adapter.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            return dt.Rows.Count > 0 ? dt.Rows[0]: null ;
           
        }
        public bool Insert(string Username, string Senha)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO users(username, senha) VALUES(@nome,@senha)";
                command.Parameters.AddWithValue("@nome", Username);
                command.Parameters.AddWithValue("@senha", Senha);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM users WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool Edit(int Id, string Nome, string senha)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE users SET username = @username , senha = @senha WHERE id = @id";
                command.Parameters.AddWithValue("@username", Nome);
                command.Parameters.AddWithValue("@senha", senha);
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM users", con.getConection());
            adapter.Fill(dt);
            con.desconect();
            return dt;
        }

    }
}
