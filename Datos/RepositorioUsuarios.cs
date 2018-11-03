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
        public String registrarOActualizarUsuario(Usuarios usuario)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarOActulizarUsuario", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("XIDENTIFICACION", usuario.identificacion));
                    cmd.Parameters.Add(new MySqlParameter("XNOMBRES", usuario.nombres));
                    cmd.Parameters.Add(new MySqlParameter("XPRIMER_APELLIDO", usuario.primerApellido));
                    cmd.Parameters.Add(new MySqlParameter("XSEGUNDO_APELLIDO", usuario.segundoApellido));
                    cmd.Parameters.Add(new MySqlParameter("XROL", usuario.rol));
                    cmd.Parameters.Add(new MySqlParameter("XID_FINCA", usuario.idfinca));
                    cmd.Parameters.Add(new MySqlParameter("XEMAIL", usuario.email));
                    cmd.Parameters.Add(new MySqlParameter("XTELEFONO", usuario.telefono));
                    cmd.Parameters.Add(new MySqlParameter("XDIRECCION", usuario.direccion));
                    cmd.Parameters.Add(new MySqlParameter("XESTADO", usuario.estado));                    
                    cmd.Parameters.Add(new MySqlParameter("XCLAVE", usuario.clave));                    

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
