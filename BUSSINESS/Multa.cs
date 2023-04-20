using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Multa
    {
        public float multa { get; set; }
        public int unica { get; set; }
        public int intervalo { get; set; }
        public string nome { get; set; }
        public int Id { get; set; }

    

        public Multa()
        {

        }
        MultaDB mult = new MultaDB();
        public Multa(int Id, float multa, int unica, int intervalo, string nome)
        {
            this.nome = nome;
            this.Id = Id;
            this.multa = multa;
            this.unica = unica;
            this.intervalo = intervalo;
        }
        public Multa(float multa, int unica, int intervalo, string nome)
        {
            this.nome = nome;
            this.multa = multa;
            this.unica = unica;
            this.intervalo = intervalo;
        }

        public List<Multa> listMulta()
        {
            List<Multa> multas = new List<Multa>();
            foreach (DataRow item in mult.listTodos().Rows)
            {
                multas.Add(new Multa(int.Parse(item["id"].ToString()), float.Parse(item["multa"].ToString()), int.Parse(item["unica"].ToString()), int.Parse(item["intervalo"].ToString()), item["nome"].ToString()));
            }
            return multas;
        }
        public bool Edit()
        {
            return new MultaDB().Edit(this.Id, this.multa, this.unica, this.intervalo);
        }
        public static Multa findId(int id)
        {
            DataRow item = new MultaDB().findId(id);
            if (item != null)
            {
                Multa multa = new Multa(int.Parse(item["id"].ToString()), float.Parse(item["multa"].ToString()), int.Parse(item["unica"].ToString()), int.Parse(item["intervalo"].ToString()), item["nome"].ToString());
                return multa;
            }
            return null;
        }

    }
}
