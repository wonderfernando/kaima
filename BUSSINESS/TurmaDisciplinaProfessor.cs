using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class TurmaDisciplinaProfessor
    {
        public int Id { get; set; }
        public int IdProfessor { get; set; }
        public int IdTurma { get; set; }
        public int IdDisciplina { get; set; }
        public Disciplina Disciplina { get; set; }
        public Professor Professor { get; set; }
        public Turma Turma { get; set; }

        public TurmaDisciplinaProfessor(int Id, int IdProfessor, int IdTurma, int IdDisciplina)
        {
            this.Id = Id;
            this.IdDisciplina = IdDisciplina;
            this.IdProfessor = IdProfessor;
            this.IdTurma = IdTurma;
        }
        public TurmaDisciplinaProfessor( int IdProfessor, int IdTurma, int IdDisciplina)
        {
    
            this.IdDisciplina = IdDisciplina;
            this.IdProfessor = IdProfessor;
            this.IdTurma = IdTurma;
        }
        public TurmaDisciplinaProfessor()
        {

        }
        bool result;
        public bool inserir()
        {
            return turmaDisciplinaProfessorDB.Insert(this.IdProfessor, this.IdDisciplina, this.IdTurma);
        }
        TurmaDisciplinaProfessorDB turmaDisciplinaProfessorDB = new TurmaDisciplinaProfessorDB();
        public List<TurmaDisciplinaProfessor> listTodo()
        {
            List<TurmaDisciplinaProfessor> turmaDisciplinaProfessores = new List<TurmaDisciplinaProfessor>();
        
            foreach (DataRow item in turmaDisciplinaProfessorDB.listTodos().Rows)
            {
                TurmaDisciplinaProfessor turmasDisc = new TurmaDisciplinaProfessor(int.Parse(item["id"].ToString()),int.Parse(item["professor_id"].ToString()),int.Parse(item["disciplina_id"].ToString()), int.Parse(item["turma_id"].ToString()));
                turmasDisc.Turma = BUSSINESS.Turma.findId(int.Parse(item["turma_id"].ToString()));
                turmasDisc.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));
                turmasDisc.Professor = BUSSINESS.Professor.findId(int.Parse(item["professor_id"].ToString()));

                turmaDisciplinaProfessores.Add(turmasDisc);
            }
            return turmaDisciplinaProfessores;
        }
      
        public static TurmaDisciplinaProfessor findId(int id)
        {
            DataRow item = new TurmaDisciplinaProfessorDB().findId(id);
            if (item != null)
            {
                TurmaDisciplinaProfessor turmasDisc = new TurmaDisciplinaProfessor(int.Parse(item["id"].ToString()), int.Parse(item["professor_id"].ToString()), int.Parse(item["disciplina_id"].ToString()), int.Parse(item["turma_id"].ToString()));
                turmasDisc.Turma = BUSSINESS.Turma.findId(int.Parse(item["turma_id"].ToString()));
                turmasDisc.Disciplina = BUSSINESS.Disciplina.findId(int.Parse(item["disciplina_id"].ToString()));
                turmasDisc.Professor = BUSSINESS.Professor.findId(int.Parse(item["professor_id"].ToString()));

                return turmasDisc;
            }
            return null;
        }

    }
}
