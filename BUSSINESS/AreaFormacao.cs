using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
   public class AreaFormacao
    {
        AreaFormacaoDB areaDB = new AreaFormacaoDB();
        public string area { get; set; }
        public int duracao { get; set; }
        public int id { get; set; }
        public AreaFormacao()
        {

        }

        /// adicionar id 
        public static AreaFormacao findId(int id)
        {
             DataTable dt = new AreaFormacaoDB().findId(id);
            if (dt.Rows.Count > 0)
            {
                return new AreaFormacao(int.Parse(dt.Rows[0]["duracao"].ToString()), dt.Rows[0]["nome"].ToString(),int.Parse(dt.Rows[0]["duracao"].ToString()));
            }
            return null;
        }
        public AreaFormacao(string area, int duracao)
        {
            this.area = area;
            this.duracao = duracao;
        }
        public AreaFormacao(int id, string area, int duracao)
        {
            this.area = area;
            this.duracao = duracao;
            this.id = id;
        }

        public List<AreaFormacao> listTodos()
        {
            List<AreaFormacao> areaFormacaos = new List<AreaFormacao>(); 
            foreach (DataRow item in areaDB.listTodos().Rows)
            {
                areaFormacaos.Add(new AreaFormacao(item["nome"].ToString(), int.Parse(item["duracao"].ToString())));
            }
            return areaFormacaos;
        }

        public bool inserir()
        {
            return areaDB.inserir(this.area, this.duracao);

        }
    }
}
