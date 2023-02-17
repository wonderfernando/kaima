using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATABASE;
using System.Data;

namespace BUSSINESS
{
    public class Disciplina
    {
        public int id { get; set; }
        public string disciplina { get; set; }
      
       
        public Disciplina(string disciplina)
        {
            this.disciplina = disciplina;
        }
        public Disciplina(int id , string disciplina)
        {
            this.disciplina = disciplina;
            this.id = id;
        }
        public Disciplina()
        {
            
        }
    
        public bool inserir()
        {
            DisciplinaDB disciplinaDB = new DisciplinaDB();
            return disciplinaDB.inserir(this.disciplina);
        }

        public static bool DELETE(int id)
        {
         
            return new DisciplinaDB().DELETE(id);
        }
        public bool Edit()
        {
            return new DisciplinaDB().Edit(this.id, this.disciplina);
        }

        public List<Disciplina> listTodo()
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            DisciplinaDB disciplinasDB = new DisciplinaDB();
            foreach (DataRow item in disciplinasDB.listTodos().Rows)
            {
                disciplinas.Add(new Disciplina(int.Parse(item["id"].ToString()),item["disciplina"].ToString()));
            }
            return disciplinas;
        }
        public DataTable listTodos()
        {
            DisciplinaDB disciplinasDB = new DisciplinaDB();
            return disciplinasDB.listTodos(); ;
        }
        public static Disciplina findId(int id)
        {
            DataRow item = new DisciplinaDB().findId(id);
            if (item != null)
            {
                Disciplina disc = new Disciplina(int.Parse(item["id"].ToString()), item["disciplina"].ToString());
                return disc;
            }
            return null;
        }
    }
}
