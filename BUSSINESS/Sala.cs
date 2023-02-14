using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Sala
    {
        public string nome  { get { return _nome; } set { _nome = value; } }
        public int capacidade { get { return _capacidade; } set { _capacidade = value; } }
        public string tipo { get { return _tipo; } set { _tipo = value; } }
        public int Id { get; set; }

        private string _nome;
        private int _capacidade;
        private string _tipo;
        
        public Sala()
        {
             
        }
        SalaDB sala = new SalaDB();
        public Sala(int Id, string nome, int capacidade, string tipo)
        {
            this.Id = Id;
            this.nome = nome;
            this.capacidade = capacidade;
            this.tipo = tipo;           
        }
        public Sala(string nome, int capacidade, string tipo)
        {
      
            this.nome = nome;
            this.capacidade = capacidade;
            this.tipo = tipo;
        }

        public bool inserir()
        {
           return sala.inserir(this.nome, this.capacidade, this.tipo);            
        }
        public List<Sala> listTodos()
        {
           List<Sala> salas =new List<Sala>();
            foreach (DataRow item in sala.listTodos().Rows)
            {
                salas.Add(new Sala(int.Parse(item["id"].ToString()), item["nome"].ToString(), int.Parse(item["capacidade"].ToString()), item["tipo"].ToString()));
            }
            return salas;
        }
        public static Sala findId(int id)
        {
            DataRow item = new ClasseDB().findId(id);
            if (item != null)
            {
                Sala sala = new Sala(int.Parse(item["id"].ToString()), item["nome"].ToString(), int.Parse(item["capacidade"].ToString()), item["tipo"].ToString());
                return sala;
            }
            return null;
        }
    }
}
