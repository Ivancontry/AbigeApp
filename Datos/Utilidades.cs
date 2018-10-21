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
    public class Utilidades : Conexion
    {
        public MySqlCommand cmd;
        public DataTable llenarDataTable(MySqlCommand cmd)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable cargarRegistros(string procedimiento)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand(procedimiento, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
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
