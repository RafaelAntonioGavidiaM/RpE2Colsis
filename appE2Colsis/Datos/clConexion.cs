using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace appE2Colsis.Datos
{
    class clConexion
    {
        private string cadenaConexion;
        private MySqlConnection objConexion;
        public clConexion()
        {
            mtdCrearCadenaConexion();
            objConexion = new MySqlConnection(cadenaConexion);
        }
        private void mtdCrearCadenaConexion()
        {
            string server = ConfigurationManager.AppSettings["server"];
            string user = ConfigurationManager.AppSettings["user"];
            string port = ConfigurationManager.AppSettings["port"];
            string database = ConfigurationManager.AppSettings["database"];
            string password = ConfigurationManager.AppSettings["password"];
            cadenaConexion = "server = " + server + "; user id = " + user + "; Port = " + port + "; database = " + database + "; Password = " + password;
        }
        public void mtdIniciarConexion()
        {
            
           try
            {
                objConexion.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public DataTable mtdDesconectado(string consulta)
        {
           
            mtdIniciarConexion();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, objConexion);
            DataTable tblDatos = new DataTable();
            try
            {
                adaptador.Fill(tblDatos);

            }
            catch (Exception)
            {


                
            }
            
            objConexion.Close();
            return tblDatos;
        }
        public int mtdConectado(string consulta)
        {
            int filasAfectadas = 0;
            mtdIniciarConexion();
            MySqlCommand comando = new MySqlCommand(consulta, objConexion);
            try
            {
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                filasAfectadas = 0;
            }
            objConexion.Close();
            return filasAfectadas;
        }
    }
}
