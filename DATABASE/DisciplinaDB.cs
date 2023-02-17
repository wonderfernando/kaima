using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DATABASE
{
    public class DisciplinaDB
    {
        Conection conection = new Conection();
       
        public DisciplinaDB()
        {

        }
        public  bool inserir(string disciplina)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                int result = 0;
                try
                {              
                   string sql = "INSERT INTO disciplinas (disciplina) VALUES(@disciplina)"; 
                   command.Connection = conection.getConection();
                   command.CommandText = sql;
                   command.Parameters.AddWithValue("@disciplina", disciplina);
                   
                   result = command.ExecuteNonQuery();
                   conection.desconect();
                  
                }
                catch (MySqlException erro)
                {
                    throw new Exception("deu erro ao acessar o banco de dados"+ erro);
                }
                return result == 1 ? true : false;
            }

        }
        public bool Edit(int Id, string Nome)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = conection.getConection();
                command.CommandText = "UPDATE disciplinas SET disciplina = @disc WHERE id = @id";
                command.Parameters.AddWithValue("@disc", Nome);
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }


        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = conection.getConection();
                command.CommandText = "DELETE FROM disciplinas WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            try
            { 
                string sql = "SELECT * FROM disciplinas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql,conection.getConection());
                adapter.Fill(dt);
                conection.desconect();
            }
            catch (Exception erro)
            {
                throw new Exception("deu erro ao acessar o banco de dados" + erro);
            }
            return dt;
        }

        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM disciplinas WHERE id = @id",conection.getConection()))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dt);
                conection.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
    }
}
