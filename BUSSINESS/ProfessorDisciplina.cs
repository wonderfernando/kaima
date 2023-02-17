using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class ProfessorDisciplina
    {
        public ProfessorDisciplina()
        {

        }
        public int Id { get; set; }
        public int IdProfessor { get; set; }
        public int IdDisciplina { get; set; }

        public Professor Professor { get; set; }
        public Disciplina Disciplina { get; set; }

        public ProfessorDisciplina(int Id , int IdProfessor, int IdDisciplina)
        {
            this.Id = Id;
            this.IdDisciplina = IdDisciplina;
            this.IdProfessor = IdProfessor;
        }
        public ProfessorDisciplina(int IdProfessor, int IdDisciplina)
        {
           
            this.IdDisciplina = IdDisciplina;
            this.IdProfessor = IdProfessor;
        }
        ProfessorDisciplinaDB professorDisciplinaDB = new ProfessorDisciplinaDB();
        public bool inserir()
        {
            return professorDisciplinaDB.Insert(this.IdProfessor,this.IdDisciplina);
        }
        public static bool DELETE(int id)
        {
            return new ProfessorDisciplinaDB().DELETE(id);
        }

        public List<ProfessorDisciplina> listTodos()
        {
            List<ProfessorDisciplina> professorDisciplinas = new List<ProfessorDisciplina>();
            foreach (DataRow item in professorDisciplinaDB.listTodos().Rows)
            {
                ProfessorDisciplina prof = new ProfessorDisciplina(int.Parse(item["id"].ToString()), int.Parse(item["professor_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                prof.Professor = BUSSINESS.Professor.findId(int.Parse(item["professor_id"].ToString()));
                prof.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));

            }
            return professorDisciplinas;
        }
        public static List<ProfessorDisciplina> listTodosByDiscId(int idDisci)
        {
            List<ProfessorDisciplina> professorDisciplinas = new List<ProfessorDisciplina>();
            foreach (DataRow item in new ProfessorDisciplinaDB().listTodosByIdDisc(idDisci).Rows)
            {
                ProfessorDisciplina prof = new ProfessorDisciplina(int.Parse(item["id"].ToString()), int.Parse(item["professor_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                prof.Professor = BUSSINESS.Professor.findId(int.Parse(item["professor_id"].ToString()));
                prof.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));

                professorDisciplinas.Add(prof);
            }
            return professorDisciplinas;
        }
        public static List<ProfessorDisciplina> listTodosByProfId(int idProf)
        {
            List<ProfessorDisciplina> professorDisciplinas = new List<ProfessorDisciplina>();
            foreach (DataRow item in new ProfessorDisciplinaDB().listTodosByIdProf(idProf).Rows)
            {
                ProfessorDisciplina prof = new ProfessorDisciplina(int.Parse(item["id"].ToString()), int.Parse(item["professor_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                prof.Professor = BUSSINESS.Professor.findId(int.Parse(item["professor_id"].ToString()));
                prof.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));

                professorDisciplinas.Add(prof);
            }
            return professorDisciplinas;
        }
        public static ProfessorDisciplina findId(int id)
        {
            DataRow item = new ProfessorDisciplinaDB().findId(id);
            if (item != null)
            {
                ProfessorDisciplina professorDisciplina = new ProfessorDisciplina(int.Parse(item["id"].ToString()), int.Parse(item["professor_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                professorDisciplina.Professor = BUSSINESS.Professor.findId(int.Parse(item["professor_id"].ToString()));
                professorDisciplina.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));
                return professorDisciplina;
            }
            return null;
        }

    }
}
