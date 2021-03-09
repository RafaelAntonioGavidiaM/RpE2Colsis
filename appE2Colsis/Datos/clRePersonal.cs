using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clRePersonal : clPersona
    {
        public int idPersonal { get; set; }
        public int idRol { get; set; }

        public List<clRePersonal> mtdListar()
        {

            string consulta = "select * from personal";

            tblPersona = new DataTable();
            objConexion = new clConexion();
            objConexion.mtdConectado(consulta);

            List<clRePersonal> listRePersonal = new List<clRePersonal>();

            for (int i = 0; i < tblPersona.Rows.Count; i++)
            {
                clRePersonal objRePersonal = new clRePersonal();

                objRePersonal.nombre = tblPersona.Rows[i]["nombre"].ToString();
                objRePersonal.apellido = tblPersona.Rows[i]["apellido"].ToString();
                objRePersonal.documento = tblPersona.Rows[i]["documnento"].ToString();
                objRePersonal.telefono = tblPersona.Rows[i]["telefono"].ToString();
                objRePersonal.ciudad = tblPersona.Rows[i]["ciudad"].ToString();
                objRePersonal.correoYemail = tblPersona.Rows[i]["correo"].ToString();
                objRePersonal.estado = byte.Parse(tblPersona.Rows[i]["estado"].ToString());
                objRePersonal.idRol = int.Parse(tblPersona.Rows[i]["idRol"].ToString());

                listRePersonal.Add(objRePersonal);

            }

            return listRePersonal;

        }


        public int mtdRegistrar()
        {
            String consulta = "insert into empleado(nombre, apellido, documento, telefono, ciudad, correo, estado, idRol) values('" + nombre + "', '" + apellido + "', '" + documento + "', '" + telefono + "', '" + ciudad + "', '" + correoYemail + "', '" + estado + "', '" + idRol + "')";

            objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);

            return resultado;
        }
    }
}
