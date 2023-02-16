using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class TurmaDB
    {

        Conection con = new Conection();

        public bool Insert(string Nome, int IdClasse, int IdCurso,int intProf, int IdTurno, int IdAno, int IdSala)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO turma(nome,classe_id,curso_id, prof_id, turno_id, ano_id, sala_id) VALUES(@nome,@classe,@curso,@res,@turno,@ano,@sala)";
                command.Parameters.AddWithValue("@nome", Nome);
                command.Parameters.AddWithValue("@classe", IdClasse);
                command.Parameters.AddWithValue("@curso", IdCurso);
                command.Parameters.AddWithValue("@res", intProf);
                command.Parameters.AddWithValue("@turno", IdTurno);
                command.Parameters.AddWithValue("@ano", IdAno);
                command.Parameters.AddWithValue("@sala", IdSala);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter( "SELECT * FROM turma",con.getConection()))
            {
                 adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }

        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM turma WHERE id = @id",con.getConection()))
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
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM turma WHERE order by id desc",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
    }
}
