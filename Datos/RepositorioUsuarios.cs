using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class RepositorioUsuarios : Utilidades
    {
        public String registrarOActualizarCliente(Usuarios usuario)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarOActualizarCliente", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xidentificacion", usuario.identificacion));
                    cmd.Parameters.Add(new MySqlParameter("xnombres", usuario.nombres));
                    cmd.Parameters.Add(new MySqlParameter("xprimerApellido", usuario.primerApellido));
                    cmd.Parameters.Add(new MySqlParameter("xsegundoApellido", usuario.segundoApellido));
                    cmd.Parameters.Add(new MySqlParameter("xrol", usuario.rol));
                    cmd.Parameters.Add(new MySqlParameter("xemail", usuario.email));
                    cmd.Parameters.Add(new MySqlParameter("xtelefono", usuario.telefono));
                    cmd.Parameters.Add(new MySqlParameter("xdireccion", usuario.direccion));
                    cmd.Parameters.Add(new MySqlParameter("xestado", usuario.estado));
                    cmd.Parameters.Add(new MySqlParameter("ximagen", usuario.imagen));
                    cmd.Parameters.Add(new MySqlParameter("xclave", usuario.clave));                    

                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return "exito";
                    }
                    else
                    {
                        return "Error";
                    }
                }
                else
                {
                    return "Error Conectar Base Datos";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                desConectar();
            }
        }
        public DataTable cargarMenu(string rol)
        {
            DataTable menus =  cargarRegistros("cargarMenu");
            DataTable menuRol = new DataTable();
            foreach (DataRow item in menus.Rows)
            {
                if (item["rol"].ToString().Equals(rol))
                {
                    menuRol.Rows.Add(item);
                }
            }
            return menuRol;
        }
    }
}
