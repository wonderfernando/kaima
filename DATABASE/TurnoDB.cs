using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class TurnoDB
    {
        Conection con = new Conection();
        public bool inserir(string nome, string inicio, string final)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = con.getConection();
            command.CommandText = "INSERT INTO turno(nome, inicio, final) VALUES(@nome, @inicio, @final)";
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@inicio", inicio);
            command.Parameters.AddWithValue("@final", final);
            int result = command.ExecuteNonQuery();
            con.desconect();
            return result == 1;
            
        }
        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM turno";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con.getConection());
                adapter.Fill(dt);
                con.desconect();
            }
            catch (Exception erro)
            {
                throw new Exception("deu erro ao acessar o banco de dados" + erro);
            }
            return dt;
        }
        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM turno WHERE id = @id",con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }

    }
}
