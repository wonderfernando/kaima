using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Curso
    {
        public int id { get; set; }
        public int areaId { get; set; }
        public string nome { get; set; }
        public float mensalidade { get; set; }
        public AreaFormacao area {get;set;} 


        public Curso(string nome,int areaId, float mensalidade )
        {
            this.nome = nome;
            this.areaId = areaId;
            this.mensalidade = mensalidade;
        }
        public Curso()
        {

        }
        bool result;
        public bool inserir()
        {
            CursoDB disciplinaDB = new CursoDB();
            return disciplinaDB.inserir(this.nome,this.areaId,this.mensalidade);
        }

        public List<Curso> listTodo()
        {
            List<Curso> cursos = new List<Curso>();
            CursoDB cursoDB = new CursoDB();
            foreach (DataRow item in cursoDB.listTodos().Rows)
            {
                Curso c = new Curso(item["nome"].ToString(), int.Parse(item["area_id"].ToString()), this.mensalidade);
                c.area = AreaFormacao.findId(int.Parse(item["id"].ToString()));
                cursos.Add(c);
            }
            return cursos;
        }
    
     
    }
}
