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
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                adapter.SelectCommand.Connection = con.getConection();
                adapter.SelectCommand.CommandText = "SELECT * FROM matricula";
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }

        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                adapter.SelectCommand.Connection = con.getConection();
                adapter.SelectCommand.CommandText = "SELECT * FROM matricula WHERE id = @id";
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
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                adapter.SelectCommand.Connection = con.getConection();
                adapter.SelectCommand.CommandText = "SELECT * FROM matricula WHERE order by id desc";
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
    }
}
