using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Datos;

namespace Negocio
{
    public class AdminNegocio
    {
        private readonly AdminRepository _adminRepo;

        public AdminNegocio()
        {
            _adminRepo = new AdminRepository();
        }   

        public Admin Login(string email, string contraseña)
        {
            
            return _adminRepo.login(email, contraseña);
        }
        public void RegistrarAdmin(string nombre, string email, string passHash)
        {
            _adminRepo.registrarAdmin(nombre, email, passHash);
        }
    }
}
