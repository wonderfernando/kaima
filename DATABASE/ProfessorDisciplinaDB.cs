using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
   public class ProfessorDisciplinaDB
    {
        Conection con = new Conection();

        public bool Insert(int IdProfessor, int IdDisciplina)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO professor_disciplina(professor_id, disciplina_id) VALUES(@prof, @disci)";
                command.Parameters.AddWithValue("@prof", IdProfessor);
                command.Parameters.AddWithValue("@disci", IdDisciplina);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM professor_disciplina",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
        public DataTable listTodosByIdDisc(int idDisc)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM professor_disciplina WHERE disciplina_id = @disci", con.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("disci", idDisc);
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }

        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM professor_disciplina WHERE id = @id",con.getConection()))
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
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM professor_disciplina WHERE order by id desc",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
    }
}
