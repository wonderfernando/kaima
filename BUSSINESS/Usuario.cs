using DATABASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS
{
    public class Usuario
    {
        public string username { get; set; }
        public int Id { get; set; }
        public string senha { set; get; }
        public Usuario()
        {

        }
        public Usuario(string username, string senha)
        {
            this.username = username;
            this.senha = senha;
        }
        public Usuario(int Id ,string username, string senha)
        {
            this.Id = Id;
            this.username = username;
            this.senha = senha;
        }
        UsuarioDB usuario = new UsuarioDB();
        public static Usuario login(string username, string senha)
        {
            DataRow dt = new UsuarioDB().login(username, senha);
            if(dt!=null)
            {
                Usuario usuario = new Usuario(int.Parse(dt["id"].ToString()), dt["username"].ToString(), dt["senha"].ToString());
                return usuario;
            }
            else
            {
                return null;
            }
           
        }
        public  bool EDIT()
        {
            return new UsuarioDB().Edit(this.Id,this.username, this.senha);
        }
        public bool insert()
        {
            return new UsuarioDB().Insert(this.username, this.senha);

        }
        public static bool DELETE(int id)
        {
            return new UsuarioDB().DELETE(id);
        }


        public List<Usuario> listTodos()
        {
            List<Usuario> users = new List<Usuario>();
            foreach (DataRow item in usuario.listTodos().Rows)
            {
                users.Add(new Usuario(int.Parse(item["id"].ToString()), item["username"].ToString(), item["senha"].ToString()));
            }
            return users;
        }



    }
}
