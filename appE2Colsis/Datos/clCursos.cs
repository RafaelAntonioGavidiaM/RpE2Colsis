using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace appE2Colsis.Datos
{
    class clCursos
    {
        public int idCurso { get; set; }
        public string curso { get; set; }
        public string nombreCurso { get; set; }
        public string año { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int idPersonal { get; set; }

        public DataTable dtCursos;

        public List<clCursos> mtdListarCursos()
        {
            string consulta = "select curso.idCurso,curso.curso,curso.nombreCurso,curso.año,personal.nombre,personal.apellido from curso inner join personal on curso.idDocente = personal.idPersonal;";
            clConexion objConexion = new clConexion();
            DataTable tblCursos = new DataTable();
            tblCursos = objConexion.mtdDesconectado(consulta);

            List<clCursos> ListarCursos = new List<clCursos>();

            for (int i = 0; i < tblCursos.Rows.Count; i++)
            {
                clCursos objpCurso = new clCursos();

                objpCurso.idCurso = int.Parse(tblCursos.Rows[i]["idCurso"].ToString());
                objpCurso.curso = tblCursos.Rows[i]["curso"].ToString();
                objpCurso.nombreCurso = tblCursos.Rows[i]["nombreCurso"].ToString();
                objpCurso.nombre = tblCursos.Rows[i]["nombre"].ToString();
                objpCurso.apellido = tblCursos.Rows[i]["apellido"].ToString();
                objpCurso.año = tblCursos.Rows[i]["año"].ToString();

                ListarCursos.Add(objpCurso);
            }
            return ListarCursos;


        }
        public int mtdRegistrar()
        {
            string consulta = "insert into curso (curso,nombreCurso,año,idDocente) " +
                              "select '" + curso + "','" + nombreCurso + "','" + año + "', " + idPersonal + " " +
                              "from dual where not exists (select * from curso where nombreCurso = '"+nombreCurso+"' and año = '"+año+"')";
            clConexion objConexion = new clConexion();
            int RegistrosAfectado = objConexion.mtdConectado(consulta);
            return RegistrosAfectado;

        }

        public void mtdFiltrarCursos(string nivelEducativo)
        {
            string consulta = "select cu.idCurso, cu.curso,cu.nombreCurso,cu.año,cu.idDocente, concat(pr.nombre,' ',pr.apellido)as NombreDocente  " +
                "from curso cu inner join personal pr on cu.idDocente = pr.idPersonal where cu.curso = '" + nivelEducativo + "'"; 
            clConexion objConexion = new clConexion();
            dtCursos = new DataTable();
            dtCursos = objConexion.mtdDesconectado(consulta);
        }
        public void mtdCargarCursos()
        {
            string consulta = "select curso from curso group by curso";
            clConexion objConexion = new clConexion();
            dtCursos = new DataTable();
            dtCursos = objConexion.mtdDesconectado(consulta);
        }
        public int mtdActualizarCurso()
        {
            string consulta = "update curso " +
                              "set curso = '" + curso + "', nombreCurso = '" + nombreCurso + "', año = '" + año + "', idDocente = " + idPersonal + " " +
                              "where not exists (select * from curso where nombreCurso = '" + nombreCurso + "' and año = '" + año + "') and idCurso = "+idCurso;
            clConexion objConexion = new clConexion();
            return objConexion.mtdConectado(consulta);
        }
        public int mtdEliminarCurso()
        {
            string consulta ="delete from curso where idCurso = "+idCurso;
            clConexion objConexion = new clConexion();
            return objConexion.mtdConectado(consulta);
        }
        public void mtdRefrescarGrilla()
        {
            string consulta = "select cu.idCurso, cu.curso,cu.nombreCurso,cu.año,cu.idDocente, concat(pr.nombre,' ',pr.apellido)as NombreDocente  " +
               "from curso cu inner join personal pr on cu.idDocente = pr.idPersonal where cu.curso = '" + curso + "' and cu.nombreCurso = '"+nombreCurso+"'";
            clConexion objConexion = new clConexion();
            dtCursos = new DataTable();
            dtCursos = objConexion.mtdDesconectado(consulta);
        }
    }
}
