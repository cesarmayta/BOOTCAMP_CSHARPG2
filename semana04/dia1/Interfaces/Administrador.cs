using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Administrador : IUsuario
    {
        private string username;
        private string password;

        public Administrador()
        {
            this.username = "admin";
            this.password = "1234";
        }

        public void Login(string username, string password)
        {
            if (this.username == username && this.password == password)
            {
                Console.WriteLine("Bienvenido ADMINISTRADOR!!!");
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas");
            }
        }
    }
}
