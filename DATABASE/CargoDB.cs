using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class CargoDB
    {
        Conection con = new Conection();

        public bool Insert(string Cargo)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO cargo(cargo) VALUES(@nome)";
                command.Parameters.AddWithValue("@nome", Cargo);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public bool Edit(int Id, string Cargo)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE cargo SET cargo = @cargo WHERE id = @id";
                command.Parameters.AddWithValue("@cargo", Cargo);
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM cargo WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM cargo", con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
        public DataTable listQuery(string Nome)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM cargo WHERE  cargo LIKE '%' @cargo '%'", con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@cargo", Nome);
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
                adapter.SelectCommand.CommandText = "SELECT * FROM cargo WHERE id = @id";
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
                adapter.SelectCommand.CommandText = "SELECT * FROM cargo WHERE order by id desc limit 1";
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
    }
}
