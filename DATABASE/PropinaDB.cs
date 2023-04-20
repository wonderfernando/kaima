using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
   public class PropinaDB
    {

        Conection con = new Conection();

        public bool Insert(int idMatricula,string DataVencimento, string DataPago, float Total,float TotalPago, int idMulta,int Status,int IdAluno, float Multa)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO propina(matricula_id,data_vencimento,total,total_pago,multa_id,data_pago, status,aluno_id,multa) VALUES(@matricula,@data,@total,@totalp,@multaid,@datap,@status,@aluno,@multa)";
                command.Parameters.AddWithValue("@matricula", idMatricula);
                command.Parameters.AddWithValue("@data", DataVencimento);
                command.Parameters.AddWithValue("@total", Total);
                command.Parameters.AddWithValue("@multaid", idMulta);
                command.Parameters.AddWithValue("@multa", Multa);
                command.Parameters.AddWithValue("@status", Status);
                command.Parameters.AddWithValue("@datap", DataPago);
                command.Parameters.AddWithValue("@totalp", TotalPago);
                command.Parameters.AddWithValue("@aluno", IdAluno);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM propina WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool Edit(int Id, string Nome, int IdClasse, int IdCurso, int idProf, int IdTurno, int IdSala)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE propina SET nome = @nome, classe_id = @classe , curso_id = @curso, turno_id = @turno, sala_id = @sala , prof_id = @res WHERE id = @id";
                command.Parameters.AddWithValue("@nome", Nome);
                command.Parameters.AddWithValue("@classe", IdClasse);
                command.Parameters.AddWithValue("@curso", IdCurso);
                command.Parameters.AddWithValue("@turno", IdTurno);
                command.Parameters.AddWithValue("@res", idProf);
                command.Parameters.AddWithValue("@sala", IdSala);
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool Pay(int Id, float Pay)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE propina SET total_pago = @totalp , status = 1 WHERE id = @id";
                command.Parameters.AddWithValue("@totalp", Pay);
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool PayD(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE propina SET status = 1 WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM propina", con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
        public DataTable listForAlunoId(int idAluno)
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM propina Where aluno_id = @alunoId order by id asc", con.getConection()))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@alunoId", idAluno);
                    adapter.Fill(dt);
                 
                    return dt;
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

        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM propina WHERE id = @id", con.getConection()))
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
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM propina order by id desc", con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        public DataTable ToPay()
        {
            
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * from propina where status = 0", con.getConection()))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.desconect();
                if (dt.Rows.Count > 0)
                {
                     return dt;
                }
               
                return null;
            }
        }
        public DataRow PayD()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * propina from where status = 1", con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }

    }
}

 