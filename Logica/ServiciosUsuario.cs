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
            usuarios.Identificacion = row["IDENTIFICACION"].ToString();
            usuarios.Nombres = row["NOMBRES"].ToString();
            usuarios.PrimerApellido = row["PRIMERAPELLIDO"].ToString();
            usuarios.SegundoApellido = row["SEGUNDOAPELLIDO"].ToString();
            usuarios.Telefono = row["TELEFONO"].ToString();
            usuarios.Rol = row["ROL"].ToString();
            usuarios.Estado =Char.Parse( row["ESTADO"].ToString());
            usuarios.Idfinca = int.Parse(row["IDFINCA"].ToString());
            usuarios.Clave = row["CLAVE"].ToString();
            usuarios.Direccion = row["DIRECCION"].ToString();
            usuarios.Email = row["EMAIL"].ToString();
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
        public Usuarios buscarPorCorreo(string correo)
        {
            DataTable dataTable = repositorioUsuarios.cargarRegistros("cargarUsuarios");
            foreach (DataRow item in dataTable.Rows)
            {
                if (item["EMAIL"].ToString().Equals(correo))
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
