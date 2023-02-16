using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Funcionario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdCargo { get; set; }
        public Cargo Cargo { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(int Id, string Nome, string Telefone, string Morada, string Sexo, int IdCargo, string Email)
        {
            this.Email = Email;
            this.Id = Id;
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Morada = Morada;
            this.Sexo = Sexo;
            this.IdCargo = Id;
        }
        public Funcionario(string Nome, string Telefone, string Morada, string Sexo, int IdCargo,string Email)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Morada = Morada;
            this.Sexo = Sexo;
            this.IdCargo = IdCargo;
            this.Email = Email;
        }
        public bool Insert()
        {
            return funcionarioDB.Insert(this.Nome,this.Telefone,this.Morada,this.Sexo, this.IdCargo, this.Email);
        }
        public bool DELETE()
        {
            return funcionarioDB.DELETE(this.Id);
        }
        public bool Edit()
        {
            return funcionarioDB.Edit(this.Id,this.Nome,this.Email,this.Morada,this.Telefone,this.IdCargo,this.Sexo);
        }
        public static bool DELETE(int id)
        {
            return new FuncionarioDB().DELETE(id);
        }
        FuncionarioDB funcionarioDB = new FuncionarioDB();
        public List<Funcionario> listTodos()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            DataTable dt = funcionarioDB.listTodos();
            foreach (DataRow item in dt.Rows)
            {
                Funcionario funcionario = new Funcionario(int.Parse(item["id"].ToString()), item["nome"].ToString(), item["tel"].ToString(), item["morada"].ToString(), item["sexo"].ToString(), int.Parse(item["cargo_id"].ToString()),item["email"].ToString());
                funcionario.Cargo = BUSSINESS.Cargo.findId(int.Parse(item["cargo_id"].ToString()));
                funcionarios.Add(funcionario);
            }
            return funcionarios;
        }
        public static Funcionario findId(int id)
        {
            DataRow item = new FuncionarioDB().findId(id);
            if (item != null)
            {
                Funcionario funcionario = new Funcionario(int.Parse(item["id"].ToString()), item["nome"].ToString(), item["tel"].ToString(), item["morada"].ToString(), item["sexo"].ToString(), int.Parse(item["cargo_id"].ToString()),item["email"].ToString());
                funcionario.Cargo = BUSSINESS.Cargo.findId(int.Parse(item["cargo_id"].ToString()));
                return funcionario;
            }
            return null;
        }
        public static Funcionario getLast()
        {
            DataRow item = new FuncionarioDB().getLast();
            if (item != null)
            {
                Funcionario funcionario = new Funcionario(int.Parse(item["id"].ToString()), item["nome"].ToString(), item["tel"].ToString(), item["morada"].ToString(), item["sexo"].ToString(), int.Parse(item["cargo_id"].ToString()),item["email"].ToString());
                funcionario.Cargo = BUSSINESS.Cargo.findId(int.Parse(item["cargo_id"].ToString()));
                return funcionario;
            }
            return null;
        }
    }
}
