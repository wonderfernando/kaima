using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DATABASE
{
    public class SalaDB
    {
        Conection con = new Conection();

        public bool inserir(string nome, int capacidade, string tipo)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = con.getConection() ;
            command.CommandText = "INSERT INTO sala(nome, capacidade, tipo) VALUES(@nome, @capacidade, @tipo)";
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@capacidade", capacidade);
            command.Parameters.AddWithValue("@tipo", tipo);
             int result = command.ExecuteNonQuery();
            if (result==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM sala",con.getConection());
            adapter.Fill(dt);
            con.desconect();
            return dt;
        }
        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter( "SELECT * FROM sala WHERE id = @id", con.getConection()))
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
