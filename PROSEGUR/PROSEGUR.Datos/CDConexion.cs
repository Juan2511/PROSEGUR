using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace PROSEGUR.Datos
{
    public class CDConexion
    {
        public MySqlConnection Conectar()
        {
            string strConn = "server=127.0.0.1;uid=root;pwd=Clave;database=PROSEGUR";
            try
            {
                MySqlConnection cnn = new MySqlConnection(strConn);
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DesConectar()
        {
            string strConn = "server=127.0.0.1;uid=root;pwd=Clave;database=PROSEGUR";
            try
            {
                MySqlConnection cnn = new MySqlConnection(strConn);
                cnn.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
