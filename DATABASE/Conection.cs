using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DATABASE
{
    public class Conection
    {
        MySqlConnection stringConection ;
        public Conection()
        {
            stringConection = new MySqlConnection("Persist Security Info = False; server = localhost; database = db_kaima; uid = root; pwd = ");
        }

        public MySqlConnection getConection()
        {
            if(stringConection.State == System.Data.ConnectionState.Closed)
                stringConection.Open();
            return stringConection;
        }
        public void desconect()
        {
            
            if(stringConection.State == System.Data.ConnectionState.Open)
            {
                stringConection.Clone();
            }
        }
    }
}
