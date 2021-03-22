using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clPersona
    {
        //Atributos compartidos
        public int idPersona  { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string documento { set; get; }
        public string tipoDocumento { set; get; }
        public DateTime fechaNacimiento { set; get; }
        public string tipoSangre { set; get; }
        public string tipoSeguroYseguroMedico { set; get; }
        public string seguroEstudiantil { set; get; }
        public string telefono { set; get; }
        public string direccion { set; get; }
        public string ciudad { set; get; }
        public string correoYemail { set; get; }
        public string estado { set; get; }
        public string clave { set; get; }



        //Objetos compartidos
        protected clConexion objConexion = new clConexion();

        //Datos de solo lectura
        public DataTable tblPersona;
    }
}
