using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdCurso { get; set; }
        public int IdClasse { get; set; }
        public int IdSala { get; set; }
        public int IdTurno { get; set; }
        public int IdAnoLectivo { get; set; }
        public int IdProf { get; set; }

        public Professor Professor { get; set; }
        public Classe Classe { get; set; }
        public Sala Sala { get; set; }
        public AnoLectivo AnoLectivo { get; set; }
        public Turno Turno { get; set; }
        public Curso Curso { get; set; }

        public Turma(int Id, string Nome, int IdCurso, int IdClasse, int IdTurno, int IdProf, int IdAnoLectivo, int IdSala)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.IdClasse = IdClasse;
            this.IdCurso = IdCurso;
            this.IdSala = IdSala;
            this.IdProf = IdProf;
            this.IdAnoLectivo = IdAnoLectivo;
        }
        public Turma( string Nome, int IdCurso, int IdClasse, int IdTurno, int IdProf, int IdAnoLectivo, int IdSala)
        {
            this.Nome = Nome;
            this.IdClasse = IdClasse;
            this.IdCurso = IdCurso;
            this.IdSala = IdSala;
            this.IdProf = IdProf;
            this.IdAnoLectivo = IdAnoLectivo;
        }
        public Turma()
        {
 
        }
        public bool Insert()
        {
            return turmaDB.Insert(this.Nome,this.IdClasse,this.IdCurso, this.IdProf, this.IdTurno,this.IdAnoLectivo, this.IdSala);
        }
        TurmaDB turmaDB = new TurmaDB();
        public List<Turma> listTodos()
        {
            List<Turma> turmas = new List<Turma>();
            DataTable dt = turmaDB.listTodos();
            foreach (DataRow item in dt.Rows)
            {
                Turma turma = new Turma(int.Parse(item["id"].ToString()), item["nome"].ToString(), int.Parse(item["curso_id"].ToString()), int.Parse(item["classe_id"].ToString()), int.Parse(item["turno_id"].ToString()), int.Parse(item["prof_id"].ToString()),int.Parse(item["ano_id"].ToString()),int.Parse(item["sala_id"].ToString()));
                turma.AnoLectivo = BUSSINESS.AnoLectivo.findId(int.Parse(item["ano_id"].ToString()));
                turma.Curso = BUSSINESS.Curso.findId(int.Parse(item["curso_id"].ToString()));
                turma.Classe = BUSSINESS.Classe.findId(int.Parse(item["classe_id"].ToString()));
                turma.Sala = BUSSINESS.Sala.findId(int.Parse(item["sala_id"].ToString()));
                turma.Professor = BUSSINESS.Professor.findId(int.Parse(item["prof_id"].ToString()));
                turma.Turno = BUSSINESS.Turno.findId(int.Parse(item["turno_id"].ToString()));
                turmas.Add(turma);
            }
            return turmas;
        }
        public static Turma findId(int id)
        {
            DataRow item = new TurmaDB().findId(id);
            if (item != null)
            {
                Turma turma = new Turma(int.Parse(item["id"].ToString()), item["nome"].ToString(), int.Parse(item["curso_id"].ToString()), int.Parse(item["classe_id"].ToString()), int.Parse(item["turno_id"].ToString()), int.Parse(item["prof_id"].ToString()), int.Parse(item["ano_id"].ToString()), int.Parse(item["sala_id"].ToString()));
                turma.AnoLectivo = BUSSINESS.AnoLectivo.findId(int.Parse(item["ano_id"].ToString()));
                turma.Curso = BUSSINESS.Curso.findId(int.Parse(item["curso_id"].ToString()));
                turma.Classe = BUSSINESS.Classe.findId(int.Parse(item["classe_id"].ToString()));
                turma.Sala = BUSSINESS.Sala.findId(int.Parse(item["sala_id"].ToString()));
                turma.Professor = BUSSINESS.Professor.findId(int.Parse(item["prof_id"].ToString()));
                turma.Turno = BUSSINESS.Turno.findId(int.Parse(item["turno_id"].ToString()));
             
                return turma;
            }
            return null;
        }
        public static Turma getLast()
        {
            DataRow item = new TurmaDB().getLast();
            if (item != null)
            {
                Turma turma = new Turma(int.Parse(item["id"].ToString()), item["nome"].ToString(), int.Parse(item["curso_id"].ToString()), int.Parse(item["classe_id"].ToString()), int.Parse(item["turno_id"].ToString()), int.Parse(item["prof_id"].ToString()), int.Parse(item["ano_id"].ToString()), int.Parse(item["sala_id"].ToString()));
                turma.AnoLectivo = BUSSINESS.AnoLectivo.findId(int.Parse(item["ano_id"].ToString()));
                turma.Curso = BUSSINESS.Curso.findId(int.Parse(item["curso_id"].ToString()));
                turma.Classe = BUSSINESS.Classe.findId(int.Parse(item["classe_id"].ToString()));
                turma.Sala = BUSSINESS.Sala.findId(int.Parse(item["sala_id"].ToString()));
                turma.Professor = BUSSINESS.Professor.findId(int.Parse(item["prof_id"].ToString()));
                turma.Turno = BUSSINESS.Turno.findId(int.Parse(item["turno_id"].ToString()));
                return turma;
            }
            return null;
        }
    }
}
