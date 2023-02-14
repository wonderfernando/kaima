using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class ProfessorDB
    {
        Conection con = new Conection();

        public bool Insert(int IdFuncionario)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO professor(funcionario_id) VALUES(@idFuncionario)";
                command.Parameters.AddWithValue("@idFuncionario", IdFuncionario);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                adapter.SelectCommand.Connection = con.getConection();
                adapter.SelectCommand.CommandText = "SELECT * FROM professor";
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }

        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                adapter.SelectCommand.Connection = con.getConection();
                adapter.SelectCommand.CommandText = "SELECT * FROM professor WHERE id = @id";
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        public DataRow getLast()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                adapter.SelectCommand.Connection = con.getConection();
                adapter.SelectCommand.CommandText = "SELECT * FROM professor WHERE order by id desc";
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
    }
}
