using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Professor
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }

        public  bool Insert()
        {
            return professorDB.Insert(this.IdFuncionario);
        }
        public bool DELETE()
        {
            return professorDB.DELETE(this.Id);
        }
        public static bool DELETE(int id)
        {
            return new ProfessorDB().DELETE(id);
        }
        public Professor()
        {

        }
        public Professor(int Id, int IdFuncionario)
        {
            this.Id = Id;
            this.IdFuncionario = IdFuncionario;
        }
        public Professor( int IdFuncionario)
        {
            this.IdFuncionario = IdFuncionario;
        }
        ProfessorDB professorDB = new ProfessorDB();
        public List<Professor> listTodos()
        {
            List<Professor> professores = new List<Professor>();
            DataTable dt = professorDB.listTodos();
            foreach (DataRow item in dt.Rows)
            {
                Professor professor = new Professor(int.Parse(item["id"].ToString()), int.Parse(item["funcionaro_id"].ToString()));
                professor.Funcionario = BUSSINESS.Funcionario.findId(int.Parse(item["funcionaro_id"].ToString()));
                professores.Add(professor);
            }
            return professores;
        }
        public static Professor findId(int id)
        {
            DataRow item = new ProfessorDB().findId(id);
            if (item != null)
            {
                Professor professor = new Professor(int.Parse(item["id"].ToString()), int.Parse(item["funcionaro_id"].ToString()));
                professor.Funcionario = BUSSINESS.Funcionario.findId(int.Parse(item["funcionaro_id"].ToString()));
                return professor;
            }
            return null;
        }
        public static Professor findByFuncId(int id)
        {
            DataRow item = new ProfessorDB().findByFuncId(id);
            if (item != null)
            {
                Professor professor = new Professor(int.Parse(item["id"].ToString()), int.Parse(item["funcionaro_id"].ToString()));
                professor.Funcionario = BUSSINESS.Funcionario.findId(int.Parse(item["funcionaro_id"].ToString()));
                return professor;
            }
            return null;
        }
        public static Professor getLast()
        {
            DataRow item = new ProfessorDB().getLast();
            if (item != null)
            {
                Professor professor = new Professor(int.Parse(item["id"].ToString()), int.Parse(item["funcionaro_id"].ToString()));
                professor.Funcionario = BUSSINESS.Funcionario.findId(int.Parse(item["funcionaro_id"].ToString()));
                return professor;
            }
            return null;
        }
    }
}
