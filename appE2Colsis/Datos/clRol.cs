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
        public void mtdRegistrarRol()
        {
            string consulta = "insert into rol(nombre) values ('" + nombreRol + "')";





        }
    }
}
