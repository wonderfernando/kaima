using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Turno
    {
        public Turno()
        {

        }
        public string nome { get; set; }
        public string inicio { get; set; }
        public string final { get; set; }

        public Turno(string nome, string inicio, string final)
        {
            this.nome = nome;
            this.inicio = inicio;
            this.final = final;
        }
        TurnoDB turno = new TurnoDB();
        public bool inserir()
        {
           return turno.inserir(this.nome,this.inicio, this.final);
        }

        public List<Turno> listTodos()
        {
            List<Turno> turnos = new List<Turno>();
            foreach (DataRow item in turno.listTodos().Rows)
            {
                turnos.Add(new Turno(item["nome"].ToString(), item["inicio"].ToString(), item["final"].ToString()));
            }
            return turnos;
        }


    }
}
