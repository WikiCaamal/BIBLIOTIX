using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace CapaDatos
{
    public class Usuario
    {
        BibliotecaEntities db;

        public Usuario()
        {
           db = new BibliotecaEntities();
        }

        public List<Usuarios> GetUsuarios()
        {
            return db.Usuarios.ToList();
        }
    }
}
