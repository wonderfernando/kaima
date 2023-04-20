using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class MatriculaPayment
    {
        public int Id { get; set; }
        public float Preco { get; set; }
        public string Nome { get; set; }
        public int multaId { get; set; }
        public Multa Multa;
 


        public MatriculaPayment(string nome, float Preco, int multaId)
        {
            this.Nome = nome;
            this.Preco = Preco;
            this.multaId = multaId;
        }
        public MatriculaPayment(int Id,string nome, float Preco, int multaId)
        {
            this.Id = Id;
            this.Nome = nome;
            this.Preco = Preco;
            this.multaId = multaId;
        }
 
        public MatriculaPayment()
        {

        }
        bool result;
        public bool inserir()
        {
            MatriculaPaymentDB matriculaPaymentDB = new MatriculaPaymentDB();
            return matriculaPaymentDB.inserir(this.Nome, this.Preco, this.multaId);
        }

        public List<MatriculaPayment> listTodo()
        {
            List<MatriculaPayment> matriculaPayments = new List<MatriculaPayment>();
            MatriculaPaymentDB cursoDB = new MatriculaPaymentDB();
            foreach (DataRow item in cursoDB.listTodos().Rows)
            {
                MatriculaPayment c = new MatriculaPayment(int.Parse(item["id"].ToString()), item["nome"].ToString(), float.Parse(item["preco"].ToString()), int.Parse(item["multa_id"].ToString()));
                c.Multa = Multa.findId(int.Parse(item["multa_id"].ToString()));
                matriculaPayments.Add(c);
            }
            return matriculaPayments;
        }
 
        public static MatriculaPayment findId(int id)
        {
            DataRow item = new MatriculaPaymentDB().findId(id);
            if (item != null)
            {
                MatriculaPayment c = new MatriculaPayment(int.Parse(item["id"].ToString()), item["nome"].ToString(), float.Parse(item["preco"].ToString()), int.Parse(item["multa_id"].ToString()));
                c.Multa = Multa.findId(int.Parse(item["multa_id"].ToString()));
                return c;
            }
            return null;
        }
        public static MatriculaPayment getLast()
        {
            DataRow item = new MatriculaPaymentDB().getLast();
            if (item != null)
            {
                MatriculaPayment c = new MatriculaPayment(int.Parse(item["id"].ToString()), item["nome"].ToString(), float.Parse(item["preco"].ToString()), int.Parse(item["multa_id"].ToString()));
                c.Multa = Multa.findId(int.Parse(item["multa_id"].ToString()));
                return c;
            }
            return null;
        }

        public bool Edit()
        {
            return new MatriculaPaymentDB().Edit(this.Id, this.Nome, this.Preco);
        }

        public bool Delete()
        {
            return new MatriculaPaymentDB().DELETE(this.Id);
        }
        public static bool Delete(int Id)
        {
            return new MatriculaPaymentDB().DELETE(Id);
        }

    }
}
