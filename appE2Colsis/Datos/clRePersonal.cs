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

            string consulta = ("select * from personal");

            DataTable tblPersona = new DataTable();
            objConexion = new clConexion();
            tblPersona = objConexion.mtdDesconectado(consulta);


            List<clRePersonal> listRePersonal = new List<clRePersonal>();

            for (int i = 0; i < tblPersona.Rows.Count; i++)
            {
                clRePersonal objRePersonal = new clRePersonal();
                objRePersonal.idPersonal = int.Parse(tblPersona.Rows[i]["idPersonal"].ToString());
                objRePersonal.nombre = tblPersona.Rows[i]["nombre"].ToString();
                objRePersonal.apellido = tblPersona.Rows[i]["apellido"].ToString();
                objRePersonal.documento = tblPersona.Rows[i]["documento"].ToString();
                objRePersonal.telefono = tblPersona.Rows[i]["telefono"].ToString();
                objRePersonal.direccion = tblPersona.Rows[i]["direccion"].ToString();
                objRePersonal.ciudad = tblPersona.Rows[i]["ciudad"].ToString();
                objRePersonal.correoYemail = tblPersona.Rows[i]["correo"].ToString();
                objRePersonal.estado = tblPersona.Rows[i]["estado"].ToString();
              
                objRePersonal.idRol = int.Parse(tblPersona.Rows[i]["idRol"].ToString());
                objRePersonal.clave = tblPersona.Rows[i]["password"].ToString();
                listRePersonal.Add(objRePersonal);

            }

            return listRePersonal;

        }


        public int mtdRegistrar(List<clRePersonal> listRePersonal)
        {

            int resultado = 0;
            foreach (var item in listRePersonal)
            {
                String consulta = "insert into personal(nombre, apellido, documento, telefono, direccion, ciudad, correo, password, estado, idRol) values('" + item.nombre + "', '" + item.apellido + "', '" + item.documento + "', '" + item.telefono + "', '" + item.direccion + "', '" + item.ciudad + "','" + item.correoYemail + "', '" + item.clave + "','" + item.estado + "', '" + item.idRol + "')";


                objConexion = new clConexion();
                resultado = objConexion.mtdConectado(consulta);


            }
            return resultado;


        }


        public int mtdEliminarPersonal(int idPersonal)
        {

            string consulta = "delete from personal where idPersonal = " + idPersonal;
            objConexion = new clConexion();
            int eliminar = objConexion.mtdConectado(consulta);
            return eliminar;

        }

        public int mtdActualizar()
        {


            string consulta = "update personal set nombre='" + nombre + "',apellido= '" + apellido + "', documento='" + documento + "',telefono='" + telefono + "', direccion= '" + direccion + "',ciudad='" + ciudad + "',correo='" + correoYemail + "',password='" + clave + "',estado='" + estado + "',idRol='" + idRol + " ' where idPersonal='"+idPersonal+"'";
            objConexion = new clConexion();
            int Resultado = objConexion.mtdConectado(consulta);
            return Resultado;

        }


        public List<clRePersonal> mtdBuscar()
        {


            string consulta = "select * from personal where nombre ='" + nombre + "' or documento='" + documento + "'";
            tblPersona = new DataTable();
            objConexion = new clConexion();

            tblPersona = objConexion.mtdDesconectado(consulta);

            List<clRePersonal> listBuscar = new List<clRePersonal>();

            for (int i = 0; i < tblPersona.Rows.Count; i++)
            {
                clRePersonal objRePersonal = new clRePersonal();
                objRePersonal.idPersonal = int.Parse(tblPersona.Rows[i]["idPersonal"].ToString());
                objRePersonal.nombre = tblPersona.Rows[i]["nombre"].ToString();
                objRePersonal.apellido = tblPersona.Rows[i]["apellido"].ToString();
                objRePersonal.documento = tblPersona.Rows[i]["documento"].ToString();
                objRePersonal.telefono = tblPersona.Rows[i]["telefono"].ToString();
                objRePersonal.direccion = tblPersona.Rows[i]["direccion"].ToString();
                objRePersonal.ciudad = tblPersona.Rows[i]["ciudad"].ToString();
                objRePersonal.correoYemail = tblPersona.Rows[i]["correo"].ToString();
                objRePersonal.clave = tblPersona.Rows[i]["password"].ToString();
                objRePersonal.estado = tblPersona.Rows[i]["estado"].ToString();
                objRePersonal.idRol = int.Parse(tblPersona.Rows[i]["idRol"].ToString());

                listBuscar.Add(objRePersonal);


            }

            return listBuscar;
            


        }
    }
}
