using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class MultaDB
    {
        Conection con = new Conection();
        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM multa", con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM multa WHERE id = @id", con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        public bool Edit(int Id, float multa, int unica, int intervalo)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE multa SET multa = @multa, unica = @unica, intervalo = @intervalo WHERE id = @id";

                command.Parameters.AddWithValue("@multa", multa);
                command.Parameters.AddWithValue("@unica", unica);
                command.Parameters.AddWithValue("@intervalo", intervalo);
                command.Parameters.AddWithValue("@id", Id);

                return command.ExecuteNonQuery() == 1;
            }
        }

    }
}
