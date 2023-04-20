using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class AnoLetivoDB
    {
        Conection con = new Conection();


        public bool Insert(string Ano,string DataInicio,string DataFinal, int Status)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO ano_letivo(ano_lectivo, data_inicio, data_final,status) VALUES(@ano,@dataInicio,@dataFinal,@status)";
                command.Parameters.AddWithValue("@ano", Ano);
                command.Parameters.AddWithValue("@dataInicio", DataInicio);
                command.Parameters.AddWithValue("@dataFinal", DataFinal);
                command.Parameters.AddWithValue("@status", Status);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM ano_letivo WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool Edit(int Id, string Nome, string inicio, string fim, int Status)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE ano_letivo SET ano_lectivo = @ano , data_inicio = @inicio, data_final = @fim, status = @status WHERE id = @id";

                command.Parameters.AddWithValue("@status", Status);
                command.Parameters.AddWithValue("@ano", Nome);
                command.Parameters.AddWithValue("@inicio", inicio);
                command.Parameters.AddWithValue("@fim", fim);
                command.Parameters.AddWithValue("@id", Id);

                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool FecharAnoLetivo()
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE ano_letivo SET status = 0 WHERE 1=1 ";
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ano_letivo", con.getConection()))
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
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ano_letivo WHERE id = @id",con.getConection()))
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
                throw new Exception(erro.Message);
            }
            finally
            {

            }
          
        }
        public DataRow getLast()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ano_letivo order by id desc",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                if(dt.Rows.Count>0)
                 return dt.Rows[0];
                return null;
            }
        }
    }
}
