using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class ClasseDisciplinaCurso
    {
       public int Id { get; set; }

        public int IdCurso { get; set; }
        public int IdClasse { get; set; }
        public int IdDisciplina { get; set; }
        public Disciplina Disciplina { get; set; }
        public Classe Classe { get; set; }
        public Curso Curso { get; set; }
        public ClasseDisciplinaCurso()
        {

        }
        public ClasseDisciplinaCurso(int Id , int IdCurso, int IdClasse, int IdDisciplina)
        {
            this.Id = Id;
            this.IdCurso = IdCurso;
            this.IdClasse = IdClasse;
            this.IdDisciplina = IdDisciplina;
        }
        public ClasseDisciplinaCurso( int IdCurso, int IdClasse, int IdDisciplina)
        {
            this.IdCurso = IdCurso;
            this.IdClasse = IdClasse;
            this.IdDisciplina = IdDisciplina;
        }
    
    ClasseDisciplinaCursoDB classeDisciplinaCursoDB = new ClasseDisciplinaCursoDB();
    public bool inserir()
    {
        return classeDisciplinaCursoDB.Insert(this.IdCurso, this.IdClasse, this.IdDisciplina);
    }
        public static bool DELETE(int id)
        {
            return new ClasseDisciplinaCursoDB().DELETE(id);
        }
        public bool DELETE()
        {
            return classeDisciplinaCursoDB.DELETE(this.Id);
        }

    public List<ClasseDisciplinaCurso> listTodos()
    {
        List<ClasseDisciplinaCurso> professorDisciplinaCursos = new List<ClasseDisciplinaCurso>();
        foreach (DataRow item in classeDisciplinaCursoDB.listTodos().Rows)
        {
                ClasseDisciplinaCurso cl = new ClasseDisciplinaCurso(int.Parse(item["id"].ToString()), int.Parse(item["curso_id"].ToString()), int.Parse(item["classe_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                cl.Classe = BUSSINESS.Classe.findId(int.Parse(item["classe_id"].ToString()));
                cl.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));
                cl.Curso = BUSSINESS.Curso.findId(int.Parse(item["curso_id"].ToString()));
                professorDisciplinaCursos.Add(cl);
        }
        return professorDisciplinaCursos;
    }
        public static List<ClasseDisciplinaCurso> listTodosByClasseCurso()
        {
            List<ClasseDisciplinaCurso> professorDisciplinaCursos = new List<ClasseDisciplinaCurso>();
            foreach (DataRow item in new ClasseDisciplinaCursoDB().listTodos().Rows)
            {
                ClasseDisciplinaCurso cl = new ClasseDisciplinaCurso(int.Parse(item["id"].ToString()), int.Parse(item["curso_id"].ToString()), int.Parse(item["classe_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                cl.Classe = BUSSINESS.Classe.findId(int.Parse(item["classe_id"].ToString()));
                cl.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));
                cl.Curso = BUSSINESS.Curso.findId(int.Parse(item["curso_id"].ToString()));
                professorDisciplinaCursos.Add(cl);
            }
            return professorDisciplinaCursos;
        }

        public static ClasseDisciplinaCurso findId(int id)
    {
        DataRow item = new ClasseDisciplinaCursoDB().findId(id);
        if (item != null)
        {
                ClasseDisciplinaCurso cl = new ClasseDisciplinaCurso(int.Parse(item["id"].ToString()), int.Parse(item["curso_id"].ToString()), int.Parse(item["classe_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                cl.Classe = BUSSINESS.Classe.findId(int.Parse(item["classe_id"].ToString()));
                cl.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));
                cl.Curso = BUSSINESS.Curso.findId(int.Parse(item["curso_id"].ToString()));

                return cl;
        }
        return null;
    }
    public static List<ClasseDisciplinaCurso> listForClasseCurso(int idCurso, int idClasse)
        {
            List<ClasseDisciplinaCurso> classeDisciplinaCursos = new List<ClasseDisciplinaCurso>();
            foreach (DataRow item in new ClasseDisciplinaCursoDB().listForClasseCurso(idCurso,idClasse).Rows)
            {
                ClasseDisciplinaCurso cl = new ClasseDisciplinaCurso(int.Parse(item["id"].ToString()), int.Parse(item["curso_id"].ToString()), int.Parse(item["classe_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                cl.Classe = BUSSINESS.Classe.findId(int.Parse(item["classe_id"].ToString()));
                cl.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));
                cl.Curso = BUSSINESS.Curso.findId(int.Parse(item["curso_id"].ToString()));
                classeDisciplinaCursos.Add(cl);
            }
            return classeDisciplinaCursos;
        }
        public  List<ClasseDisciplinaCurso> listForClasseCurso()
        {
            List<ClasseDisciplinaCurso> classeDisciplinaCursos = new List<ClasseDisciplinaCurso>();
            foreach (DataRow item in classeDisciplinaCursoDB.listForClasseCurso(this.IdCurso, this.IdClasse).Rows)
            {
                ClasseDisciplinaCurso cl = new ClasseDisciplinaCurso(int.Parse(item["id"].ToString()), int.Parse(item["curso_id"].ToString()), int.Parse(item["classe_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                cl.Classe = BUSSINESS.Classe.findId(int.Parse(item["classe_id"].ToString()));
                cl.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));
                cl.Curso = BUSSINESS.Curso.findId(int.Parse(item["curso_id"].ToString()));
                classeDisciplinaCursos.Add(cl);
            }
            return classeDisciplinaCursos;
        }


    }
}
