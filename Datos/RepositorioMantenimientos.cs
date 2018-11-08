using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class RepositorioMantenimientos : Utilidades
    {
        public int registrarMantenimientos(Mantenimientos mantenimientos)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("registrarMantenimientos", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.Add(new MySqlParameter("xidDispositivo", mantenimientos.idDispositivo));
                    cmd.Parameters.Add(new MySqlParameter("xfecha", mantenimientos.fecha));
                    cmd.Parameters.Add(new MySqlParameter("xdescripcion", mantenimientos.descripcion));
                    cmd.Parameters.Add(new MySqlParameter("xestadoMantenimiento", mantenimientos.estadoMantenimiento));
                    cmd.Parameters.Add(new MySqlParameter("xestadoDispositivo", mantenimientos.estadoDispositivo));

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
        public int actualizarMantenimientos(Mantenimientos mantenimientos)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("actualizarMantenimientos", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.Add(new MySqlParameter("xidDispositivo", mantenimientos.idDispositivo));
                    cmd.Parameters.Add(new MySqlParameter("xfecha", mantenimientos.fecha));
                    cmd.Parameters.Add(new MySqlParameter("xdescripcion", mantenimientos.descripcion));
                    cmd.Parameters.Add(new MySqlParameter("xestadoMantenimiento", mantenimientos.estadoMantenimiento));
                    cmd.Parameters.Add(new MySqlParameter("xestadoDispositivo", mantenimientos.estadoDispositivo));

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
        public DataTable buscarDispoitivoMantenimiento(String idDispositivo)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("buscarDispositivoMantenimientos", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xidDispositivo", idDispositivo));
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


        public DataTable buscarDispoitivo(String idDispositivo)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("buscarDispositivo", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xidDispositivo", idDispositivo));
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

        public DataTable mostrarMantenimientos()
        {
            return cargarRegistros("mostrarMantenimientos");
        }
    }
}
