using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using Entidades;

namespace Logica
{
    public class ServiciosUsuario
    {
        RepositorioUsuarios repositorioUsuarios = new RepositorioUsuarios();
        public DataTable cargarMenu(string rol)
        {
            return repositorioUsuarios.cargarMenu(rol);
        }

        public string GuardarUsuarios(Usuarios usuario)
        {
            return repositorioUsuarios.registrarOActualizarUsuario(usuario);
        }
        private Usuarios mapearUsuario(DataRow row)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.identificacion = row["IDENTIFICACION"].ToString();
            usuarios.nombres = row["NOMBRES"].ToString();
            usuarios.primerApellido = row["PRIMERAPELLIDO"].ToString();
            usuarios.segundoApellido = row["SEGUNDOAPELLIDO"].ToString();
            usuarios.telefono = row["TELEFONO"].ToString();
            usuarios.rol = row["ROL"].ToString();
            usuarios.estado =Char.Parse( row["ESTADO"].ToString());
            usuarios.idfinca = int.Parse(row["IDFINCA"].ToString());
            usuarios.clave = row["CLAVE"].ToString();
            usuarios.direccion = row["DIRECCION"].ToString();
            usuarios.email = row["EMAIL"].ToString();
            return usuarios;
        }
        public Usuarios buscarPorIdentificacion(string identificacion)
        {
            DataTable dataTable = repositorioUsuarios.cargarRegistros("cargarUsuarios");
            foreach (DataRow item in dataTable.Rows)
            {
                if (item["IDENTIFICACION"].ToString().Equals(identificacion))
                {
                    return mapearUsuario(item);
                }
            }
            return null;
        }

        public DataTable cargarRoles()
        {
            return repositorioUsuarios.cargarRegistros("cargarRoles");
        }
    }
}
