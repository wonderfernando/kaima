using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
   public class Matricula
    {
       
        public int IdAluno { get; set; }
        public int IdTurma { get; set; }
        public int IdAno { get; set; }
        public string Data { get; set; }
        public string Nmatricula { get; set; }
        public int Status { get; set; }
        public string Tipo { get; set; }
    


        public Matricula(int Id, int IdAluno, int IdTurma, int IdAno, string Data, string Nmatricula, int Status, string Tipo)
        {
        
            this.IdAluno = IdAluno;
            this.IdAno = IdAno;
            this.IdTurma = IdTurma;
            this.Data = Data;
            this.Nmatricula = Nmatricula;
            this.Status = Status;
            this.Tipo = Tipo;
            this.Id = Id;
        }
        public string nome { get; set; }
        public int Id { get; set; }
        public string inicio { get; set; }
        public string final { get; set; }

        public Matricula( int IdAluno, int IdTurma, int IdAno, string Data, string Nmatricula, int Status, string Tipo)
        {

            this.IdAluno = IdAluno;
            this.IdAno = IdAno;
            this.IdTurma = IdTurma;
            this.Data = Data;
            this.Nmatricula = Nmatricula;
            this.Status = Status;
            this.Tipo = Tipo;
        }
        public Matricula()
        {
 
        }
        MatriculaDB matriculaDB = new MatriculaDB();
        public bool inserir()
        {
            return matriculaDB.Insert(this.Nmatricula, this.IdTurma, this.IdAluno, this.IdAno, this.Data, this.Tipo, this.Status);
        }

        public List<Matricula> listTodos()
        {
            List<Matricula> matriculas = new List<Matricula>();
            foreach (DataRow item in matriculaDB.listTodos().Rows)
            {
                matriculas.Add(new Matricula(int.Parse(item["id"].ToString()), int.Parse(item["aluno_id"].ToString()),  int.Parse(item["turma_id"].ToString()), item["data"].ToString(), item["nmatricula"].ToString(),int.Parse(item["status"].ToString()), item["tipo"].ToString()));
            }
            return matriculas;
        }
        public static Matricula findId(int id)
        {
            DataRow item = new MatriculaDB().findId(id);
            if (item != null)
            {
                Matricula matricula = new Matricula(int.Parse(item["id"].ToString()), int.Parse(item["aluno_id"].ToString()), int.Parse(item["turma_id"].ToString()), item["data"].ToString(), item["nmatricula"].ToString(), int.Parse(item["status"].ToString()), item["tipo"].ToString());
                return matricula;
            }
            return null;
        }

    }
}
