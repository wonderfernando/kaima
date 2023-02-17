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
        public int Id { get; set; }
        public string inicio { get; set; }
        public string final { get; set; }

        public Turno(int Id,string nome, string inicio, string final)
        {
            this.Id = Id;
            this.nome = nome;
            this.inicio = inicio;
            this.final = final;
        }
        public Turno( string nome, string inicio, string final)
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
        public static bool DELETE(int id)
        {
            return new TurnoDB().DELETE(id);
        }
        public bool Edit()
        { 
            return new TurnoDB().Edit(this.Id, this.nome, this.inicio, this.final);
        }

        public List<Turno> listTodos()
        {
            List<Turno> turnos = new List<Turno>();
            foreach (DataRow item in turno.listTodos().Rows)
            {
                turnos.Add(new Turno(int.Parse(item["id"].ToString()),item["nome"].ToString(), item["inicio"].ToString(), item["final"].ToString()));
            }
            return turnos;
        }
        public static Turno findId(int id)
        {
            DataRow item = new TurnoDB().findId(id);
            if (item != null)
            {
                Turno turno = new Turno(int.Parse(item["id"].ToString()), item["nome"].ToString(), item["inicio"].ToString(), item["final"].ToString());
                return turno;
            }
            return null;
        }


    }
}
