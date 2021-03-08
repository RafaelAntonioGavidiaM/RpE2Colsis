using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace appE2Colsis.Datos
{
    class clConexion
    {
        MySqlConnection objConexion;
        public clConexion()
        {
            string cadena = ConfigurationManager.AppSettings["conexion"];
            objConexion = new MySqlConnection(cadena);
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
    }
}
