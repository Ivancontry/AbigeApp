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
    public class RepositorioDispositivos : Utilidades
    {        
        public int registrarPosicionActual(Dispositivos dispositivo)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("registrarPosicionActual",connection,transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.Add(new MySqlParameter("xlatitud", dispositivo.latitud));
                    cmd.Parameters.Add(new MySqlParameter("xlongitud", dispositivo.longitud));
                    cmd.Parameters.Add(new MySqlParameter("xestadoDispositivo", dispositivo.estadoDispositivo));
                    cmd.Parameters.Add(new MySqlParameter("xidDispositivo", dispositivo.idDispositivo));
                    cmd.Parameters.Add(new MySqlParameter("xestadoBateria", dispositivo.estadoBateria));

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
            return cargarRegistros("mostrarPosicionDispositivo");
        }

    }
}
