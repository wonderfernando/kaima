using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class CursoDB
    {
        Conection con = new Conection();
        public bool inserir(string nome, int areaId, float mensalidade)
        {
            bool result = false;
            using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand())
            {
                string sql = "INSERT INTO curso (nome,area_id, mensalidade) VALUES(@nome,@area_id,@mensalidade)";
                command.Connection = con.getConection();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@area_id", areaId);
                command.Parameters.AddWithValue("@mensalidade", mensalidade);
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
                string sql = "SELECT * FROM curso";
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
        public DataTable listTodoDataGrid()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT curso.nome as nome, curso.mensalidade as mensalidade,area_formacao.duracao as duracao FROM curso inner join area_formacao on curso.area_id = area_formacao_id";
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
    }
}
