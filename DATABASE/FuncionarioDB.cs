using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class FuncionarioDB
    {
        Conection con = new Conection();

        public bool Insert(string Nome, string Telefone, string Morada, string Sexo, int idCargo, string Email)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "INSERT INTO funcionario(nome,tel,morada,sexo,cargo_id,email) VALUES(@nome,@tel,@morada,@sexo,@cargo,@email)";
                command.Parameters.AddWithValue("@nome", Nome);
                command.Parameters.AddWithValue("@tel", Telefone);
                command.Parameters.AddWithValue("@morada", Morada);
                command.Parameters.AddWithValue("@sexo", Sexo);
                command.Parameters.AddWithValue("@email", Email);
                command.Parameters.AddWithValue("@cargo", idCargo);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool DELETE(int Id)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "DELETE FROM funcionario WHERE id = @id";
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool Edit(int Id, string Nome, string Email, string Morada, string Telefone, int IdCargo, string Sexo)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = con.getConection();
                command.CommandText = "UPDATE funcionario SET nome = @nome , email = @email, morada = @morada, tel = @telefone, cargo_id = @cargo , sexo = @sexo WHERE id = @id";
                command.Parameters.AddWithValue("@nome", Nome);
                command.Parameters.AddWithValue("@email", Email);
                command.Parameters.AddWithValue("@morada", Morada);
                command.Parameters.AddWithValue("@telefone", Telefone);
                command.Parameters.AddWithValue("@sexo", Sexo);
                command.Parameters.AddWithValue("@cargo", IdCargo); ;
                command.Parameters.AddWithValue("@id", Id);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable listTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM funcionario", con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                return dt;
            }
        }

        public DataRow findId(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM funcionario WHERE id = @id",con.getConection()))
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
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM funcionario order by id desc",con.getConection()))
            {
                adapter.Fill(dt);
                con.desconect();
                DataRow drow = dt.Rows[0];
                return drow;
            }
        }
    }
}
