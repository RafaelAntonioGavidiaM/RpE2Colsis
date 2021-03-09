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
        private string server;
        private string user;
        private string port;
        private string database;
        private string password;
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
                throw;
            }
        }
        public DataTable mtdDesconectado(string consulta)
        {
            mtdIniciarConexion();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, objConexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objConexion.Close();
            return tblDatos;
        }
        public int mtdConectado(string consulta)
        {
            mtdIniciarConexion();
            MySqlCommand comando = new MySqlCommand(consulta, objConexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            objConexion.Close();
            return filasAfectadas;
        }
        public void mtdActualizarCadenaConexion()
        {
            string cadena = "server = "+server+"; user id = "+user+"; Port = "+port+"; database = "+database+"; Password = "+password;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach(XmlDocument element in xmlDoc.DocumentElement)
            {
                if(element.Name.Equals("appSettings"))
                {
                    foreach(XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "conexion")
                            node.Attributes[1].Value = cadena;
                    }
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
