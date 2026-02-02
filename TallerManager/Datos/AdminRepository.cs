using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class AdminRepository
    {
        public Admin login(string email, string contraseña)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_Login");
                datos.agregarParametro("@Email", email);
                datos.agregarParametro("@Clave", contraseña);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    Admin admin = new Admin(
                        (int)datos.Lector["IdAdmin"],
                        (string)datos.Lector["Nombre"],
                        (string)datos.Lector["Email"],
                        (string)datos.Lector["Password"]
                    );
                    return admin;
                }
                else
                {
                    return null;
                }
            }       
            finally
            {
                datos.cerrarConexion();
            }         
        }
        public void registrarAdmin(string nombre, string email, string passHash)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_RegistrarAdmin");
                datos.agregarParametro("@Nombre", nombre);
                datos.agregarParametro("@Email", email);
                datos.agregarParametro("@Clave", passHash);
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
