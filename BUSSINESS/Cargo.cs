using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Cargo
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public Cargo()
        {

        }
        public Cargo(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
        public bool Insert()
        {
            return cargoDb.Insert(this.Nome);
        }
        CargoDB cargoDb = new CargoDB();
        public List<Cargo> listTodos()
        {
            List<Cargo> cargos = new List<Cargo>();
            DataTable dt = cargoDb.listTodos();
            foreach (DataRow item in dt.Rows)
            {
                Cargo cargo = new Cargo(int.Parse(item["id"].ToString()), item["cargo"].ToString());
                cargos.Add(cargo);
            }
            return cargos;
        }
        public static Cargo findId(int id)
        {
            DataRow item = new CargoDB().findId(id);
            if (item != null)
            {
                Cargo cargo = new Cargo(int.Parse(item["id"].ToString()), item["cargo"].ToString());
                return cargo;
            }
            return null;
        }
        public static Cargo getLast()
        {
            DataRow item = new CargoDB().getLast();
            if (item != null)
            {
                Cargo cargo = new Cargo(int.Parse(item["id"].ToString()), item["cargo"].ToString());
                return cargo;
            }
            return null;
        }
    }
}
