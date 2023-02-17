using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DATABASE
{
    public class AlunoDB
    {
        #region
        Conection con = new Conection();
        public bool Insert(string Nome, string Telefone, string Morada, string DataNascimento, string Sexo, int EncarregadoId, string Bi, string Img)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO aluno (nome, telefone, morada, data_nascimento, bi, sexo, encarregado_id, img) VALUES (@nome,@telefone,@morada,@data,@bi,@sexo,@encarregado,@img)";
                command.Parameters.AddWithValue("@nome",Nome);
                command.Parameters.AddWithValue("@telefone",Telefone);
                command.Parameters.AddWithValue("@morada",Morada);
                command.Parameters.AddWithValue("@data",DataNascimento);
                command.Parameters.AddWithValue("@bi",Bi);
                command.Parameters.AddWithValue("@sexo",Sexo);
                command.Parameters.AddWithValue("@encarregado",EncarregadoId);
                command.Parameters.AddWithValue("@img",Img);
                bool retorno = command.ExecuteNonQuery() == 1;
                return retorno;
            }
            
        }
        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using(MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM aluno",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }  
        }
        public DataTable listQuery(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM aluno WHERE LIKE %"+query+"%", con.getConection()))
            {
          
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
        public DataTable listAlunosForEncarregadoId(int idEncarregado)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM aluno WHERE encarregado_id",con.getConection()))
            {
                
                adapter.SelectCommand.Parameters.AddWithValue("@id",idEncarregado);
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM aluno WHERE id = @id", con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        public DataRow getLast()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM aluno WHERE order by id desc", con.getConection()))
            {
                adapter.SelectCommand.Connection = con.getConection();
                adapter.SelectCommand.CommandText = ;
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        #endregion
    }
}
