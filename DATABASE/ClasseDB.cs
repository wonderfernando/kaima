using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DATABASE
{
   public class ClasseDB
    {
        Conection con = new Conection(); 
   
        public bool Insert(string Classe)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO classe(name) VALUES(@nome)";
                command.Parameters.AddWithValue("@nome", Classe);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM classe",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
     
        public DataRow findId(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM classe WHERE id = @id", con.getConection()))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                    adapter.Fill(dt);
                    con.desconect();
                    DataRow drow = dt.Rows[0];
                    return drow;
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao acessar o banco de dados");
            }
            finally
            {
                con.desconect();
            }
          
        }
        public DataRow getLast()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                adapter.SelectCommand.Connection = con.getConection();
                adapter.SelectCommand.CommandText = "SELECT * FROM classe WHERE order by id desc";
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
    }
}
