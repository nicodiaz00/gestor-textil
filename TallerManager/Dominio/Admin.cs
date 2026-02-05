using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Admin
    {
        public int IdAdmin { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public Admin(int id, string nombre, string email)
        {
            this.IdAdmin = id;
            this.Nombre = nombre;
            this.Email = email;
            
        }

    }
}
