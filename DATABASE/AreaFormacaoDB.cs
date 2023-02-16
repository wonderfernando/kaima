using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class AreaFormacaoDB
    { Conection con = new Conection();
        public bool inserir(string area,int duracao)
        {
            bool result = false;
            using(MySqlCommand command = new MySqlCommand())
            {
                string sql = "INSERT INTO area_formacao (nome,duracao) VALUES(@nome,@duracao)";
                command.Connection = con.getConection();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@nome", area);
                command.Parameters.AddWithValue("@duracao", duracao);
                result = command.ExecuteNonQuery() == 1;
                con.desconect();
            };
            return result;
            
        }
        public bool Edit(int Id, string Nome, int Duracao)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE area_formacao SET nome = @nome, duracao = @duracao WHERE id = @id";
                command.Parameters.AddWithValue("@nome", Nome);
                command.Parameters.AddWithValue("@duracao", Duracao);
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM area_formacao WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public DataTable listQuery(string Nome)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM area_formacao WHERE  nome LIKE '%' @nome '%'", con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@nome", Nome);
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
        public DataTable listTodos()
        {
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM area_formacao",con.getConection()))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.desconect();
                return dt;                           
            }
        }
        public DataTable findId(int id)
        {
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM area_formacao  WHERE id = @id", con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@id",id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
    }
}
