using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace appE2Colsis.Datos
{
    class clPeriodo
    {

        public int idPeriodo { get; set; }
        public string nombrePeriodo { get; set; }

        public string fechaI { get; set; }

        public string fechaFin { get; set; }

        public string año { get; set; }


        clConexion objConexion = new clConexion();

        public void mtdConsultarAño()
        {
            DateTime fechaActual = DateTime.Now;
             año = Convert.ToDateTime(fechaActual).ToString("yyyy");



        }

        public int  mtdInsertarPeriodo()
        {
            mtdConsultarAño();
            string consulta = "insert into periodo(nombrePeriodo,fechaInicio,fechaFin,año) values ('" + nombrePeriodo + "','" + fechaI + "','" + fechaFin + "','" + año + "')";
          int  rows = objConexion.mtdConectado(consulta);
            return rows;

        }

        public int  mtdActualizar()
        {

            string consulta = "update periodo set nombrePeriodo='" + nombrePeriodo + "', fechaInicio='" + fechaI + "', fechaFin='" + fechaFin + "' where idPeriodo="+idPeriodo+" ";
           int rows = objConexion.mtdConectado(consulta);
            return rows;

        }

        public List<clPeriodo> mtdconsultarPeridos()
        {
            string consulta = "select * from periodo";
            DataTable resultado = new DataTable();
           resultado= objConexion.mtdDesconectado(consulta);
            List<clPeriodo> listaPeriodo = new List<clPeriodo>();
            for (int i = 0; i < resultado.Rows.Count; i++)

            {
                clPeriodo objP = new clPeriodo();
                objP.idPeriodo = int.Parse(resultado.Rows[i][0].ToString());
                objP.nombrePeriodo = resultado.Rows[i][1].ToString();
                objP.fechaI = resultado.Rows[i][2].ToString();
                objP.fechaFin = resultado.Rows[i][3].ToString();

                listaPeriodo.Add(objP);




                






            }
            return listaPeriodo;


        }


        public int  mtdEliminar()
        {
            string consulta = "delete from periodo where idPeriodo=" + idPeriodo + "";
           int rows = objConexion.mtdConectado(consulta);
            return rows;



        }

    }
}
