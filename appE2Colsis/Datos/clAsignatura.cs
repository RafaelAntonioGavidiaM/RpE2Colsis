using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clAsignatura
    {
        
        public int idAsignatura { get; set; }
        public string nombreAsignatura { get; set; }
        public int idArea { get; set; }
        public string nombreArea { get; set; }

        // tabla asignatura (listado y metdos de registrar, eliminar y modificar)
        clConexion objConexion;
        public List<clAsignatura> mtdListarAsignatura()
        {

            string consulta = "select * from asignatura";
            DataTable tblAsignatura = new DataTable();
            objConexion = new clConexion();
            tblAsignatura = objConexion.mtdDesconectado(consulta);

            List<clAsignatura> listAsignatura = new List<clAsignatura>();

            for (int i = 0; i < tblAsignatura.Rows.Count; i++)
            {

                clAsignatura objAsignatura = new clAsignatura();

                objAsignatura.idAsignatura = int.Parse(tblAsignatura.Rows[i]["idAsignatura"].ToString());
                objAsignatura.nombreAsignatura = tblAsignatura.Rows[i]["nombreAsignatura"].ToString();
                objAsignatura.idArea = int.Parse(tblAsignatura.Rows[i]["idArea"].ToString());

                listAsignatura.Add(objAsignatura);

            }

            return listAsignatura;

        }

        public int mtdRegistrarAsignatura()
        {

            int resultado = 0;
            string consulta = "insert into asignatura (nombreAsignatura,idArea) values ('" + nombreAsignatura + "','" + idArea + "')";

            objConexion = new clConexion();        
            resultado = objConexion.mtdConectado(consulta); 
            
            return resultado;


        }


        public int mtdEliminarAsignatura(int idAsignatura)
        {


            string consulta = "delete from asignatura where idAsignatura = " + idAsignatura;
            objConexion = new clConexion();
            int eliminar = objConexion.mtdConectado(consulta);
            return eliminar;


        }


        public int mtdModificarAsignatura()
        {

            string consulta = "update asignatura set nombreAsignatura = '" + nombreAsignatura + "',idArea ='" + idArea + "' where idAsignatura='" + idAsignatura + "'" ;
            objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;

        }
        // tabla area (listado y metdos de registrar, eliminar y modificar)

        public List<clAsignatura> mtdListarArea()
        {

            string consulta = "select * from area";
            DataTable tblArea = new DataTable();
            objConexion = new clConexion();
            tblArea = objConexion.mtdDesconectado(consulta);

            List<clAsignatura> listArea = new List<clAsignatura>();

            for (int i = 0; i < tblArea.Rows.Count; i++)
            {
                clAsignatura objArea = new clAsignatura();
                objArea.idArea = int.Parse(tblArea.Rows[i]["idArea"].ToString());
                objArea.nombreArea = tblArea.Rows[i]["nombreArea"].ToString();

                listArea.Add(objArea);
            }

            return listArea;

        }



    }
}
