using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DatosDispositivo : Conexion
    {
        public MySqlCommand cmd;
        public int registrarPosicionActual(string[] posicion)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand("registrarPosicionActual");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.Add(new MySqlParameter("xlatitud", Double.Parse(posicion[1])));
                    cmd.Parameters.Add(new MySqlParameter("xlongitud", Double.Parse(posicion[2])));
                    cmd.Parameters.Add(new MySqlParameter("xestadoDispositivo", "Dentro"));
                    cmd.Parameters.Add(new MySqlParameter("xidDispositivo", posicion[0]));
                    cmd.Parameters.Add(new MySqlParameter("xestadoBateria", posicion[3]));
                    return cmd.ExecuteNonQuery();

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
    }
}
