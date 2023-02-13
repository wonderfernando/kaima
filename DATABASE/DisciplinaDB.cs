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
}
}
