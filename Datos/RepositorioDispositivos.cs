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
        public int registrarDispositivo(Dispositivo dispositivo)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("registrarDispositivo", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.Add(new MySqlParameter("xidDispositivo", dispositivo.idDispositivo));
                    cmd.Parameters.Add(new MySqlParameter("xidPerimetro", dispositivo.idPerimetro));
                    cmd.Parameters.Add(new MySqlParameter("xestado", dispositivo.estado));
                    cmd.Parameters.Add(new MySqlParameter("xidAnimal", dispositivo.idAnimal));
                    cmd.Parameters.Add(new MySqlParameter("xbateria", dispositivo.bateria));
                    cmd.Parameters.Add(new MySqlParameter("xfecha", dispositivo.fecha));
                   

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
        public int actualizarDispositivo(Dispositivo dispositivo)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("actulizarDispositivo", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.Add(new MySqlParameter("xidDispositivo", dispositivo.idDispositivo));
                    cmd.Parameters.Add(new MySqlParameter("xidPerimetro", dispositivo.idPerimetro));
                    cmd.Parameters.Add(new MySqlParameter("xestado", dispositivo.estado));
                    cmd.Parameters.Add(new MySqlParameter("xidAnimal", dispositivo.idAnimal));
                    cmd.Parameters.Add(new MySqlParameter("xbateria", dispositivo.bateria));
                    cmd.Parameters.Add(new MySqlParameter("xfecha", dispositivo.fecha));


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
        public int registrarPosicionActual(Posicion dispositivo)
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

        public DataTable listadoPerimetros()
        {
            return cargarRegistros("mostrarPerimetros");
        }

        public DataTable listadoCoordenadasPerimetro(int idPerimetro)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("buscarCoordenadasPerimetro", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xidPerimetro", idPerimetro));
                    string c = cmd.ExecuteNonQuery().ToString();
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

        public DataTable cargarPerimetros()
        {
            return cargarRegistros("cargarPerimetros");
        }


    }
}
