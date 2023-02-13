using DATABASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Usuario
    {
        public string username { get; set; }
        public string senha { set; get; }
        public Usuario()
        {

        }
        public Usuario(string username, string senha)
        {
            this.username = username;
            this.senha = senha;
        }
        UsuarioDB usuario = new UsuarioDB();
        public static bool login(string username, string senha)
        {
            return new UsuarioDB().login(username, senha); 
        }
    }
}
