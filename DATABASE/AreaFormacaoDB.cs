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
            using(MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand())
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
        public DataTable listTodos()
        {
            using (MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM area_formacao",con.getConection()))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.desconect();
                return dt;                           
            }
        }
        public DataTable findId(int id)
        {
            using (MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM area_formacao  WHERE id = @id", con.getConection()))
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
