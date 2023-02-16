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
        public Disciplina Disciplinad { get; set; }

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

        public List<ProfessorDisciplina> listTodos()
        {
            List<ProfessorDisciplina> professorDisciplinas = new List<ProfessorDisciplina>();
            foreach (DataRow item in professorDisciplinaDB.listTodos().Rows)
            {
                professorDisciplinas.Add(new ProfessorDisciplina(int.Parse(item["id"].ToString()), int.Parse(item["professor_id"].ToString()), int.Parse(item["disciplina_id"].ToString())));
            }
            return professorDisciplinas;
        }
        public static ProfessorDisciplina findId(int id)
        {
            DataRow item = new ProfessorDisciplinaDB().findId(id);
            if (item != null)
            {
                ProfessorDisciplina professorDisciplina = new ProfessorDisciplina(int.Parse(item["id"].ToString()), int.Parse(item["professor_id"].ToString()), int.Parse(item["disciplina_id"].ToString()));
                return professorDisciplina;
            }
            return null;
        }

    }
}
