using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Entidades;

namespace Datos
{
    public class DatosDispositivo : Conexion
    {
        public MySqlCommand cmd;
        public int registrarPosicionActual(Posicion posicion)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("registrarPosicionActual",connection,transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.Add(new MySqlParameter("xlatitud", posicion.latitud));
                    cmd.Parameters.Add(new MySqlParameter("xlongitud", posicion.longitud));
                    cmd.Parameters.Add(new MySqlParameter("xestadoDispositivo", posicion.estadoDispositivo));
                    cmd.Parameters.Add(new MySqlParameter("xidDispositivo", posicion.idDispositivo));
                    cmd.Parameters.Add(new MySqlParameter("xestadoBateria", posicion.estadoBateria));

                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }

                }
                else
                {
                    return -1;
                }

            }
            catch (Exception e)

            {

                return -1;
            }
            finally
            {
                desConectar();
            }
        }

        public DataTable listadoPosicionDispositivo()
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand("mostrarPosicionDispositivo");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        return llenarDataTable(cmd);
                    }
                    else
                    {
                        return null;
                    }

                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                desConectar();
            }
        }

    }
}
