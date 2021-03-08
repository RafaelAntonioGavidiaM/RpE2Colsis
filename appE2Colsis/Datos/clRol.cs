using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appE2Colsis.Datos
{
    class clRol
    {
        public int idRol { get; set; }
        public string nombreRol { get; set; }
        /// <summary>
        /// Metodo Registrar Rol con solo nombre.
        /// </summary>
        public int mtdRegistrarRol()
        {
            string consulta = "insert into rol(nombre) values ('" + nombreRol + "')";
            clConexion objConexion = new clConexion();
            int rows=0;
            rows=objConexion.mtdConectado(consulta);
            return rows;





        }
    }
}
