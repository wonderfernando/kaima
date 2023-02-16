using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class AnoLectivo
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string Ano { get; set; }
        public string DataInicio { get; set; }
        public string DataFinal { get; set; }
        public AnoLectivo()
        {

        }
        public AnoLectivo(int Id, string Ano,string DataInicio, string DataFinal, int Status)
        {
            this.Ano = Ano;
            this.DataInicio = DataInicio;
            this.DataFinal = DataFinal;
            this.Status = Status;
            this.Id = Id;
        }
        public AnoLectivo( string Ano, string DataInicio, string DataFinal, int Status)
        {
            this.Ano = Ano;
            this.DataInicio = DataInicio;
            this.DataFinal = DataFinal;
            this.Status = Status;
        }
        AnoLetivoDB anoLetivoDB = new AnoLetivoDB();
        public bool Insert()
        {
            return anoLetivoDB.Insert(this.Ano,this.DataInicio, this.DataFinal, this.Status);
        }
        public List<AnoLectivo> listTodos()
        {
            List<AnoLectivo> anoLetivos = new List<AnoLectivo>();
            DataTable dt = anoLetivoDB.listTodos();
            foreach (DataRow item in dt.Rows)
            {
                AnoLectivo anoLetivo = new AnoLectivo(int.Parse(item["id"].ToString()), item["ano_lectivo"].ToString(),item["data_inicio"].ToString(), item["data_final"].ToString(),int.Parse(item["status"].ToString()));
                anoLetivos.Add(anoLetivo);
            }
            return anoLetivos;
        }
        public static AnoLectivo findId(int id)
        {
            DataRow item = new AnoLetivoDB().findId(id);
            if (item != null)
            {
                AnoLectivo anoLetivo = new AnoLectivo(int.Parse(item["id"].ToString()), item["ano_lectivo"].ToString(), item["data_inicio"].ToString(), item["data_final"].ToString(), int.Parse(item["status"].ToString()));
                return anoLetivo;
            }
            return null;
        }
        public static AnoLectivo getLast()
        {
            DataRow item = new AnoLetivoDB().getLast();
            if (item != null)
            {
                AnoLectivo anoLetivo = new AnoLectivo(int.Parse(item["id"].ToString()), item["ano_lectivo"].ToString(), item["data_inicio"].ToString(), item["data_final"].ToString(), int.Parse(item["status"].ToString()));
                return anoLetivo;
            }
            return null;
        }

    }
}
