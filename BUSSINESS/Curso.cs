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
        public int Id { get; set; }
        public int areaId { get; set; }
        public string Nome { get; set; }
        public float Mensalidade { get; set; }
        public AreaFormacao area {get;set;} 


        public Curso(string nome,int areaId, float mensalidade )
        {
            this.Nome = nome;
            this.areaId = areaId;
            this.Mensalidade = mensalidade;
        }
        public Curso(int id , string nome, int areaId, float mensalidade)
        {
            this.Nome = nome;
            this.areaId = areaId;
            this.Mensalidade = mensalidade;
        }
        public Curso()
        {

        }
        bool result;
        public bool inserir()
        {
            CursoDB disciplinaDB = new CursoDB();
            return disciplinaDB.inserir(this.Nome,this.areaId,this.Mensalidade);
        }

        public List<Curso> listTodo()
        {
            List<Curso> cursos = new List<Curso>();
            CursoDB cursoDB = new CursoDB();
            foreach (DataRow item in cursoDB.listTodos().Rows)
            {
                Curso c = new Curso(int.Parse(item["id"].ToString()),item["nome"].ToString(), int.Parse(item["area_id"].ToString()), float.Parse(item["mensalidade"].ToString()));
                c.area = AreaFormacao.findId(int.Parse(item["id"].ToString()));
                cursos.Add(c);
            }
            return cursos;
        }
        public static Curso findId(int id)
        {
            DataRow item = new CursoDB().findId(id);
            if (item != null)
            {
                Curso c = new Curso(int.Parse(item["id"].ToString()),item["nome"].ToString(), int.Parse(item["area_id"].ToString()), float.Parse(item["mensalidade"].ToString()));
                c.area = AreaFormacao.findId(int.Parse(item["id"].ToString()));
                return c;
            }
            return null;
        }


    }
}
