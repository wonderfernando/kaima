using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Morada { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public int EncarregadoId { get; set; }
        public Encarregado Encarregado { get; set; }
        //public Matricula Matricula { get; set; }
        public string Bi { get; set; }
        public string Img { get; set; }
        public Aluno()
        {

        }
        public Aluno(int Id, string Nome, string Telefone, string Morada,string DataNascimento,string Sexo, int EncarregadoId, string Bi, string Img)
        {
            this.Nome = Nome;
            this.Id = Id;
            this.Telefone = Telefone;
            this.Morada = Morada;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.EncarregadoId = EncarregadoId;
            this.Bi = Bi;
            this.Img = Img;
        }
        public Aluno( string Nome, string Telefone, string Morada, string DataNascimento, string Sexo, int EncarregadoId, string Bi, string Img)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Morada = Morada;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.EncarregadoId = EncarregadoId;
            this.Bi = Bi;
            this.Img = Img;
        }
        AlunoDB alunoDB = new AlunoDB();
        public bool Insert()
        {
            return alunoDB.Insert(this.Nome,this.Telefone,this.Morada,this.DataNascimento,this.Sexo,this.EncarregadoId,this.Bi,this.Img);
        }
        public bool Edit()
        {
            return alunoDB.Edit(this.Id,this.Nome, this.Telefone, this.Morada, this.Bi,this.DataNascimento, this.Sexo, this.EncarregadoId,  this.Img);
        }
        public static bool DELETE(int id)
        {
            return new AlunoDB().DELETE(id);
         }
        public static Aluno findId(int id)
        {
            DataRow dt = new AlunoDB().findId(id);
            if (dt!=null)
            {
                Aluno aluno = new Aluno(int.Parse(dt["id"].ToString()), dt["nome"].ToString(), dt["telefone"].ToString(),dt["morada"].ToString(),dt["data_nascimento"].ToString(),dt["sexo"].ToString(),int.Parse(dt["encarregado_id"].ToString()),dt["bi"].ToString(),dt["img"].ToString());
                aluno.Encarregado = Encarregado.findId(int.Parse(dt["encarregado_id"].ToString()));
                return aluno;
            }
            return null;
        }
        public static Aluno getLast()
        {
            DataRow dt = new AlunoDB().getLast();
            if (dt != null)
            {
                Aluno aluno = new Aluno(int.Parse(dt["id"].ToString()), dt["nome"].ToString(), dt["telefone"].ToString(), dt["morada"].ToString(), dt["data_nascimento"].ToString(), dt["sexo"].ToString(), int.Parse(dt["encarregado_id"].ToString()), dt["bi"].ToString(), dt["img"].ToString());
                aluno.Encarregado = Encarregado.findId(int.Parse(dt["encarregado_id"].ToString()));
                return aluno;
            }
            return null;
        }

        public static List<Aluno> listAlunosForEncarregadoId(int idEncarregado)
        {
            DataTable dt = new AlunoDB().listAlunosForEncarregadoId(idEncarregado);
            List<Aluno> alunos = new List<Aluno>();
            foreach (DataRow item in dt.Rows)
                {
                    Aluno aluno = new Aluno(int.Parse(item["id"].ToString()), item["nome"].ToString(), item["telefone"].ToString(), item["morada"].ToString(), item["data_nascimento"].ToString(), item["sexo"].ToString(), int.Parse(item["encarregado_id"].ToString()), item["bi"].ToString(), item["img"].ToString());
                    aluno.Encarregado = Encarregado.findId(int.Parse(item["encarregado_id"].ToString()));
                    alunos.Add(aluno);
                }
            
            return alunos;
        }

        
        public List<Aluno> listTodos()
        {
            DataTable dt = new AlunoDB().listTodos();
            List<Aluno> alunos = new List<Aluno>();
            foreach (DataRow item in dt.Rows)
            {
                Aluno aluno = new Aluno(int.Parse(item["id"].ToString()), item["nome"].ToString(), item["telefone"].ToString(), item["morada"].ToString(), item["data_nascimento"].ToString(), item["sexo"].ToString(), int.Parse(item["encarregado_id"].ToString()), item["bi"].ToString(), item["img"].ToString());
                aluno.Encarregado = Encarregado.findId(int.Parse(item["encarregado_id"].ToString()));
                alunos.Add(aluno);
            }
            return alunos;
        }
    }
}
