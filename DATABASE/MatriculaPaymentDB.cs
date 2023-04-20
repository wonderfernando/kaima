using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class MatriculaPaymentDB
    {
        Conection con = new Conection();
        public bool inserir(string nome, float preco, int multaId)
        {
            bool result = false;
            using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand())
            {
                string sql = "INSERT INTO matricula_preco (nome,preco,multa_id) VALUES(@nome,@preco,@multa)";
                command.Connection = con.getConection();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@preco", preco);
                command.Parameters.AddWithValue("@multa", multaId);
                result = command.ExecuteNonQuery() == 1;
                con.desconect();
            };
            return result;

        }
        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM matricula_preco";
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
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM matricula_preco WHERE id = @id", con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        public bool mudarPreco(int id, float preco)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand command = new MySqlCommand("UPDATE matricula_preco SET preco = @preco WHERE id = @id", con.getConection()))
            {
                command.Parameters.AddWithValue("@preco",preco);
                command.Parameters.AddWithValue("@id",id);
                return command.ExecuteNonQuery() == 1 ? true : false;
            }
        }
        public DataRow getLast()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM matricula_preco order by id desc limit 1", con.getConection()))
            {

                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM matricula_preco WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool Edit(int Id, string Nome, float Preco)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE matricula_preco SET nome = @nome, preco = @preco WHERE id = @id";

                command.Parameters.AddWithValue("@nome", Nome);
                command.Parameters.AddWithValue("@preco", Preco);
                
                command.Parameters.AddWithValue("@id", Id);

                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listQuery(string Nome)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM matricula_preco WHERE  nome LIKE '%' @nome '%'", con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@nome", Nome);
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }

    }
}
