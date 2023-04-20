using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Propina
    {
        public int Id { get; set; }
        public  Matricula Matricula { get; set; }
        public string DataVencimento { get; set; }
        public string DataPago { get; set; }
        public float _Multa { get; set; }
        public float Total { get; set; }
        public float TotalPago { get; set; }
        public int Status { get; set; }
        public int idMatricula { get; set; }
        public int idAluno { get; set; }
        public int IdMulta { get; set; }
        public Multa Multa { get; set; }
        public Aluno Aluno { get; set; }

    
        public Propina()
        {

        }
        public Propina(int id , int idMatricula, int idAluno, string DataVencimento, string DataPago , float Total, float TotalPago, int Status, int IdMulta, float _Multa)
        {
            this.Id = id;
            this.idAluno = idAluno;
            this.idMatricula = idMatricula;
            this.DataVencimento = DataVencimento;
            this.DataPago = DataPago;
            this.Status = Status;
            this.IdMulta = IdMulta;
            this.Total = Total;
            this._Multa = _Multa;
        }
        public Propina(int idMatricula, int idAluno , string DataVencimento, string DataPago, float Total, float TotalPago, int Status, int IdMulta, float _Multa)
        {
            this.IdMulta = IdMulta;
            this.idAluno = idAluno;
            this.idMatricula = idMatricula;
            this.DataVencimento = DataVencimento;
            this.DataPago = DataPago;
            this.Status = Status;
            this.Total = Total;
            this._Multa = _Multa;
        }
        PropinaDB propinaDB = new PropinaDB();
        public bool Insert()
        {
           return propinaDB.Insert(this.idMatricula, this.DataVencimento, this.DataPago, this.Total, this.TotalPago, 1, 0, this.idAluno, this._Multa);
        }
      
        public static bool DELETE(int id)
        {
            return new PropinaDB().DELETE(id);

        }
        public static bool Pay(int id, float  total)
        {
            return new PropinaDB().Pay(id, total);
        }
        public static Propina findId(int id)
        {
            DataRow dt = new PropinaDB().findId(id);
            if (dt != null)
            {
                Propina propina = new Propina(int.Parse(dt["id"].ToString()), int.Parse(dt["matricula_id"].ToString()), int.Parse(dt["aluno_id"].ToString()), dt["data_vencimento"].ToString(), dt["data_pago"].ToString(), float.Parse(dt["total"].ToString()), float.Parse(dt["total_pago"].ToString()), int.Parse(dt["status"].ToString()), int.Parse(dt["multa_id"].ToString()), float.Parse(dt["multa"].ToString()));
                propina.Aluno = Aluno.findId(int.Parse(dt["aluno_id"].ToString()));
                propina.Matricula = Matricula.findId(int.Parse(dt["matricula_id"].ToString()));
                propina.Multa = Multa.findId(int.Parse(dt["multa_id"].ToString()));
                return propina;
            }
            return null;
        }
        

        public static List<Propina> listForAlunoId(int idAluno)
        {
            DataTable dt = new PropinaDB().listForAlunoId(idAluno);
            List<Propina> propinas = new List<Propina>();
            foreach (DataRow item in dt.Rows)
            {
                Propina propina = new Propina(int.Parse(item["id"].ToString()), int.Parse(item["matricula_id"].ToString()), int.Parse(item["aluno_id"].ToString()), item["data_vencimento"].ToString(), item["data_pago"].ToString(), float.Parse(item["total"].ToString()), float.Parse(item["total_pago"].ToString()), int.Parse(item["status"].ToString()), int.Parse(item["multa_id"].ToString()), float.Parse(item["multa"].ToString()));

                propina.Aluno = Aluno.findId(int.Parse(item["aluno_id"].ToString()));
                propina.Matricula = Matricula.findId(int.Parse(item["matricula_id"].ToString()));
                propina.Multa = Multa.findId(int.Parse(item["multa_id"].ToString()));
                propinas.Add(propina);
            }

            return propinas;
        }

        public static Propina getLast()
        {
            DataRow dt = new PropinaDB().getLast();
            if (dt != null)
            {
                Propina propina = new Propina(int.Parse(dt["id"].ToString()), int.Parse(dt["matricula_id"].ToString()), int.Parse(dt["aluno_id"].ToString()), dt["data_vencimento"].ToString(), dt["data_pago"].ToString(), float.Parse(dt["total"].ToString()), float.Parse(dt["total_pago"].ToString()), int.Parse(dt["status"].ToString()), int.Parse(dt["multa_id"].ToString()), float.Parse(dt["multa"].ToString()));
                propina.Aluno = Aluno.findId(int.Parse(dt["aluno_id"].ToString()));
                propina.Matricula = Matricula.findId(int.Parse(dt["matricula_id"].ToString()));
                propina.Multa = Multa.findId(int.Parse(dt["multa_id"].ToString()));
                return propina;
            }
            return null;
        }

         

        public List<Propina> listTodos()
        {
            DataTable dt = new PropinaDB().listTodos();
            List<Propina> propinas = new List<Propina>();
            foreach (DataRow item in dt.Rows)
            {
                Propina propina = new Propina(int.Parse(item["id"].ToString()), int.Parse(item["matricula_id"].ToString()), int.Parse(item["aluno_id"].ToString()), item["data_vencimento"].ToString(), item["data_pago"].ToString(), float.Parse(item["total"].ToString()), float.Parse(item["total_pago"].ToString()), int.Parse(item["status"].ToString()), int.Parse(item["multa_id"].ToString()), float.Parse(item["multa"].ToString()));

                propina.Aluno = Aluno.findId(int.Parse(item["aluno_id"].ToString()));
                propina.Matricula = Matricula.findId(int.Parse(item["matricula_id"].ToString()));
                propinas.Add(propina);
            }
            return propinas;
        }
        public List<Propina> listToPay()
        {
            DataTable dt = new PropinaDB().ToPay();
            List<Propina> propinas = new List<Propina>();
            if (dt != null)  
            foreach (DataRow item in dt.Rows)
            {
                Propina propina = new Propina(int.Parse(item["id"].ToString()), int.Parse(item["matricula_id"].ToString()), int.Parse(item["aluno_id"].ToString()), item["data_vencimento"].ToString(), item["data_pago"].ToString(), float.Parse(item["total"].ToString()), float.Parse(item["total_pago"].ToString()), int.Parse(item["status"].ToString()), int.Parse(item["multa_id"].ToString()), float.Parse(item["multa"].ToString()));
                propina.Multa = Multa.findId(1);
                propina.Aluno = Aluno.findId(int.Parse(item["aluno_id"].ToString()));
                propina.Matricula = Matricula.findId(int.Parse(item["matricula_id"].ToString()));
                propinas.Add(propina);
            }
            return propinas;
        }
    }
}
