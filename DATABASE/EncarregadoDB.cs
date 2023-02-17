using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class EncarregadoDB
    {
        #region
        Conection con = new Conection();
        public bool Insert(string Nome, string Telefone, string Email, string Sexo)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO encarregado (nome, telefone, email, sexo) VALUES (@nome,@telefone,@email,@sexo)";
                command.Parameters.AddWithValue("@nome", Nome);
                command.Parameters.AddWithValue("@telefone", Telefone);
                command.Parameters.AddWithValue("@email", Email);
                command.Parameters.AddWithValue("@sexo", Sexo);
                bool retorno = command.ExecuteNonQuery() == 1;
                return retorno;
            }

        }

        public bool Edit(int Id, string Nome, string Telefone, string Email, string Sexo)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE encarregado SET nome = @nome, telefone = @telefone, email = @email, sexo = @sexo WHERE id = @id";
                command.Parameters.AddWithValue("@nome", Nome);
                command.Parameters.AddWithValue("@telefone", Telefone);
                command.Parameters.AddWithValue("@email", Email);
                command.Parameters.AddWithValue("@sexo", Sexo);
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }


        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM encarregado WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM encarregado",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }
        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM encarregado WHERE id = @id",con.getConection()))
            {
                adapter.SelectCommand.Connection = con.getConection();
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
            using (MySqlDataAdapter adapter = new MySqlDataAdapter( "SELECT * FROM encarregado  order by id desc",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
        #endregion
    }
}
