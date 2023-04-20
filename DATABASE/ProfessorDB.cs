using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class ProfessorDB
    {
        Conection con = new Conection();

        public bool Insert(int IdFuncionario)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO professor(funcionaro_id) VALUES(@idFuncionario)";
                command.Parameters.AddWithValue("@idFuncionario", IdFuncionario);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM professor", con.getConection()))
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
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM professor WHERE id = @id", con.getConection()))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                    adapter.Fill(dt);
                   
                    if(dt.Rows.Count>0)
                    return dt.Rows[0];
                    return null;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                 con.desconect();
            }
            
        }
        public DataRow findByFuncId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM professor WHERE funcionaro_id = @id", con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dt);
                con.desconect();
                if(dt.Rows.Count >0)
                  return dt.Rows[0];
                else
                  return null;
            }
        }
        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM professor WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public DataRow getLast()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM professor order by id desc", con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
    }
}
