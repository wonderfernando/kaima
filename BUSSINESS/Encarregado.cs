using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Encarregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public List<Aluno> Alunos { get; set; }
        public Encarregado(int Id, string Nome,string Telefone, string Email, string Sexo)
        {
            this.Nome = Nome;
            this.Id = Id;
            this.Telefone = Telefone;
            this.Email = Email;
            this.Sexo = Sexo;
        }
        public Encarregado( string Nome, string Telefone, string Email, string Sexo)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
            this.Sexo = Sexo;
        }
        public Encarregado()
        {

        }
        EncarregadoDB encarregadoDB = new EncarregadoDB();
        public bool Insert()
        {
            return encarregadoDB.Insert(this.Nome, this.Telefone, this.Email, this.Sexo);
        }
        public static Encarregado findId(int id)
        {
            DataRow dt = new EncarregadoDB().findId(id);
            if (dt != null)
            {
                Encarregado encarregado = new Encarregado(int.Parse(dt["id"].ToString()), dt["nome"].ToString(), dt["telefone"].ToString(), dt["email"].ToString(), dt["sexo"].ToString());
                encarregado.Alunos = Aluno.listAlunosForEncarregadoId(id);
                return encarregado;
            }
            return null;
        }
        public static Encarregado getLast()
        {
            DataRow dt = new EncarregadoDB().getLast();
            if (dt != null)
            {
                Encarregado encarregado = new Encarregado(int.Parse(dt["id"].ToString()), dt["nome"].ToString(), dt["telefone"].ToString(), dt["email"].ToString(), dt["sexo"].ToString());
                encarregado.Alunos = Aluno.listAlunosForEncarregadoId(int.Parse(dt["id"].ToString()));
                return encarregado;
            }
            return null;
        }
        public List<Encarregado> listTodos()
        {
            DataTable dt = new AlunoDB().listTodos();
            List<Encarregado> encarregados = new List<Encarregado>();
            foreach (DataRow item in dt.Rows)
            {
                Encarregado encarregado = new Encarregado(int.Parse(item["id"].ToString()), item["nome"].ToString(), item["telefone"].ToString(), item["email"].ToString(), item["sexo"].ToString());
                encarregado.Alunos = Aluno.listAlunosForEncarregadoId(int.Parse(item["id"].ToString()));
                encarregados.Add(encarregado);
            }
            return encarregados;
        }

    }
}
