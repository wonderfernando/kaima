using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Classe
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Classe()
        {

        }
        public Classe(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
        ClasseDB classeDB = new ClasseDB();
        public List<Classe> listTodos()
        {
            List<Classe> classes = new List<Classe>();
            DataTable dt = classeDB.listTodos();
            foreach (DataRow item in dt.Rows)
            {
                Classe classe = new Classe(int.Parse(item["id"].ToString()), item["name"].ToString());
                classes.Add(classe);
            }
            return classes;
        }
        public static Classe findId(int id)
        {
            DataRow dt = new ClasseDB().findId(id);
            if (dt != null)
            {
                Classe classe = new Classe(int.Parse(dt["id"].ToString()), dt["name"].ToString());
                return classe;
            }
            return null;
        }
        public static Classe getLast()
        {
            DataRow dt = new ClasseDB().getLast();
            if (dt != null)
            {
                Classe classe = new Classe(int.Parse(dt["id"].ToString()), dt["name"].ToString());
                return classe;
            }
            return null;
        }


    }
}
