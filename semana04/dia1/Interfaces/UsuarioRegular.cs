using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class UsuarioRegular : IUsuario
    {
        private string username;
        private string password;

        public UsuarioRegular(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void Login(string username, string password)
        {
            if (this.username == username && this.password == password)
            {
                Console.WriteLine("Bienvenido Usuario");
            }
            else
            {
                Console.WriteLine("Credenciales invalidas");
            }
        }
    }
}
