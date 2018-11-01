using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class ServiciosUsuario
    {
        RepositorioUsuarios repositorioUsuarios = new RepositorioUsuarios();
        public DataTable cargarMenu(string rol)
        {
            return repositorioUsuarios.cargarMenu(rol);
        }
    }
}
