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
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con.getConection()))
                {
                    adapter.Fill(dt);
                }
               
            }
            catch (Exception erro)
            {
                throw new Exception("deu erro ao acessar o banco de dados" + erro);
            }finally
            {
                con.desconect();
            }
            return dt;
        }
        
        public DataRow findId(int id)
        {
            DataRow drow;
            DataTable dt = new DataTable();
            try
            {
                 using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM curso WHERE id = @id", con.getConection()))
                     {
                       adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                       adapter.Fill(dt);
                       drow = dt.Rows[0];        
                   }
            }catch(Exception erro)
            {
                throw new Exception("Erro ao acessar o banco de dados");
            }
            finally
            {
                con.desconect();   
            }
           return drow;
        }
        public DataRow getLast()
        {
            try
            {
               DataTable dt = new DataTable();
               using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM curso order by id desc limit 1", con.getConection()))
                {
                    
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
        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM curso WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool Edit(int Id, string Nome, int IdArea, float Mensalidade)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE curso SET nome = @nome, area_id = @area, mensalidade = @mensalidade WHERE id = @id";

                command.Parameters.AddWithValue("@nome", Nome);
                command.Parameters.AddWithValue("@area", IdArea);
                command.Parameters.AddWithValue("@mensalidade", Mensalidade);
                command.Parameters.AddWithValue("@id", Id);

                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listQuery(string Nome)
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM curso WHERE  nome LIKE '%' @nome '%'", con.getConection()))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@nome", Nome);
                    adapter.Fill(dt);
                    con.desconect();
                    return dt;
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

    }
}
