using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clReporte : clPersona
    {
        public int idCurso { set; get; }
        public string nombreCurso { set; get; }
        public int idEstudiante { set; get; }
        public int idPeriodo { set; get; }

        public void mtdListarCursos()
        {
            string sql = "select idCurso, nombreCurso from curso";
            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }
        public void mtdListarEstudiantes()
        {
            string sql = "select idEstudiante, concat (nombres,' ',apellidos) as nombreCompleto " +
                         "from estudiante where idCurso = " + idCurso;
            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }
        public void mtdListarPeriodos()
        {
            int añoInicio = int.Parse(DateTime.Now.ToString("yyyy"));
            int añoFinal = añoInicio + 1;
            string sql = "select idPeriodo, nombrePeriodo " +
                         "from periodo where año between '" + añoInicio + "-01-01' and '" + añoFinal + "-01-01'";
            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }
        public void mtdListarReporte()
        {
            string sql = "select es.documento, es.tipoDocumento, es.nombres as nombre_Estudiante, es.apellidos as apellido_Estudiante, " +
                         "cu.nombreCurso as curso, pe.nombrePeriodo as periodo, asi.nombreAsignatura as asignatura, nota.nombreNota as nota, " +
                         "doc.nombre as nombre_Docente, doc.apellido as apellio_Docente, asn.nota " +
                         "from estudiante es " +
                         "inner join curso cu on es.idCurso = cu.idCurso " +
                         "inner join nota on nota.idCurso = cu.idCurso " +
                         "inner join periodo pe on nota.idPeriodo = pe.idPeriodo " +
                         "inner join asignatura asi on nota.idAsignatura = asi.idAsignatura " +
                         "inner join personal doc on nota.idDocente = doc.idPersonal " +
                         "inner join asignaturaNota asn on asn.idNota = nota.idNota and asn.idEstudiante = es.idEstudiante " +
                         "where es.idEstudiante = " + idEstudiante + " and nota.idPeriodo = " + idPeriodo;


            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }
        public DataTable mtdListarEstudiantesPeriodo(int idCursoP,int idPeriodoP)
        {
            String consulta = "select es.documento, es.tipoDocumento, es.nombres as nombre_Estudiante, es.apellidos as apellido_Estudiante, " +
                         "cu.nombreCurso as curso, pe.nombrePeriodo as periodo, asi.nombreAsignatura as asignatura, nota.nombreNota as nota, " +
                         "doc.nombre as nombre_Docente, doc.apellido as apellio_Docente, asn.nota " +
                         "from estudiante es " +
                         "inner join curso cu on es.idCurso = cu.idCurso " +
                         "inner join nota on nota.idCurso = cu.idCurso " +
                         "inner join periodo pe on nota.idPeriodo = pe.idPeriodo " +
                         "inner join asignatura asi on nota.idAsignatura = asi.idAsignatura " +
                         "inner join personal doc on nota.idDocente = doc.idPersonal " +
                         "inner join asignaturaNota asn on asn.idNota = nota.idNota and asn.idEstudiante = es.idEstudiante " +
                         "where cu.idCurso = " + idCursoP + " and nota.idPeriodo = " +idPeriodoP+"";

            DataTable resultado = new DataTable();
            resultado = objConexion.mtdDesconectado(consulta);
            return resultado;
        }
    }    
}
