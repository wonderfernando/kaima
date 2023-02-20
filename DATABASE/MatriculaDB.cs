using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class MatriculaDB
    {

        Conection con = new Conection();

        public bool Insert(string nmatricula, int IdTurma, int Idaluno, int IdAno, string Data, string Tipo, int Status)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO matricula(nmatricula, turma_id,aluno_id,ano_id,data_matricula, tipo,status) VALUES(@nmatricula, @turma,@aluno,@ano,@data,@tipo,@status)";
                command.Parameters.AddWithValue("@nmatricula", nmatricula);
                command.Parameters.AddWithValue("@turma", IdTurma);
                command.Parameters.AddWithValue("@aluno", Idaluno);
                command.Parameters.AddWithValue("@ano", IdAno);
                command.Parameters.AddWithValue("@data", Data);
                command.Parameters.AddWithValue("@tipo", Tipo);
                command.Parameters.AddWithValue("@status", Status);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter( "SELECT * FROM matricula", con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }


        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM matricula WHERE id = @id", con.getConection()))
            {
    
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        public DataTable listForIdAlunoAno(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM matricula WHERE aluno_id = @id", con.getConection()))
            {

                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dt);
                con.desconect();
               
                return dt;
            }
        }
        public DataRow getLast()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM matricula  order by id desc  limit 1",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        public bool fecharMatricular(int Id)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand command = new MySqlCommand("UPDATE matricula SET status = 0 WHERE aluno_id = @id", con.getConection()))
            {
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1 ? true : false;
            }
        }
    }
}
