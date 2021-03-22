using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clDocente : clPersona
    {
        public void mtdListarDocentes()
        {
            string sql = "select idPersonal, concat(nombre,' ',apellido) as NombreDocente,documento from personal"; 
            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }
        public void mtdBuscarDocentePorDocumento()
        {
            string sql = "select idPersonal,concat(nombre,' ',apellido) as NombreDocente,documento from personal where documento = '" + documento+"'";
            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }   
    }
}
