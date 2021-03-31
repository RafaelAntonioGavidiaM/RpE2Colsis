using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clAsistencia
    {
        public int idDocente { get; set; }
        public int idEstudiante { get; set; }
        public int idCurso { get; set; }
        public int idAsignatura { get; set; }
        public string nombreAsignatura { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string nombreCurso { get; set; }
        public DateTime fechaHora { get; set; }
        public string Asistencia { get; set; }
        public int idAsistencia { get; set; }
        public string fechaHoras2 { get; set; }


        public int idAsignaturaCurso { get; set; }

        clConexion objConexion = new clConexion();
        public List<clAsistencia> mtdListarAsistencia()
        {
            mtdConsultarIdAsignaturaCurso();

            string consulta = "select asistencia.idAsistencia,estudiante.idEstudiante,estudiante.nombres,estudiante.apellidos,curso.nombreCurso,asignatura.nombreAsignatura,asistencia.fechaHora,asistencia.asistencia from asistencia \n " +
                               "inner join asignaturacurso on asignaturacurso.idAsignaturaCurso = asistencia.idAsignaturacurso \n " +
                               "inner join estudiante on asistencia.idEstudiante = estudiante.idEstudiante \n " +
                               "inner join curso on asignaturacurso.idCurso = curso.idCurso  \n " +
                               "inner join asignatura on asignaturacurso.idAsignatura = asignatura.idAsignatura where asignaturacurso.idAsignaturaCurso = " + idAsignaturaCurso + " ";


            DataTable tblAsistencia = new DataTable();
            objConexion = new clConexion();
            tblAsistencia = objConexion.mtdDesconectado(consulta);

            List<clAsistencia> listAsistencia = new List<clAsistencia>();


            for (int i = 0; i < tblAsistencia.Rows.Count; i++)
            {

                clAsistencia objAsistencia = new clAsistencia();
                objAsistencia.idAsistencia = int.Parse(tblAsistencia.Rows[i]["idAsistencia"].ToString());
                objAsistencia.idEstudiante = int.Parse(tblAsistencia.Rows[i]["idEstudiante"].ToString());
                objAsistencia.nombres = tblAsistencia.Rows[i]["nombres"].ToString();
                objAsistencia.apellidos = tblAsistencia.Rows[i]["apellidos"].ToString();
                objAsistencia.nombreCurso = tblAsistencia.Rows[i]["nombreCurso"].ToString();
                objAsistencia.nombreAsignatura = tblAsistencia.Rows[i]["nombreAsignatura"].ToString();
                objAsistencia.fechaHora = DateTime.Parse(tblAsistencia.Rows[i]["fechaHora"].ToString());
                objAsistencia.Asistencia = tblAsistencia.Rows[i]["asistencia"].ToString();

                listAsistencia.Add(objAsistencia);
            }

            return listAsistencia;



        }


        public List<clAsistencia> mtdConsultarCursos()
        {
            string consulta = "select idCurso,nombreCurso from curso";
            DataTable resultado = new DataTable();

            resultado = objConexion.mtdDesconectado(consulta);
            List<clAsistencia> lista = new List<clAsistencia>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clAsistencia objAdd = new clAsistencia();
                objAdd.idCurso = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.nombreCurso = resultado.Rows[i][1].ToString();
                lista.Add(objAdd);

            }
            return lista;

        }

        public List<clAsistencia> mtdConsultarAsignaturasSegunCurso()
        {
            string consulta = "select  asignatura.idAsignatura,asignatura.nombreAsignatura from asignaturacurso inner join asignatura on asignaturacurso.idAsignatura=asignatura.idAsignatura where asignaturacurso.idCurso=" + idCurso + "";
            DataTable resultado = new DataTable();
            resultado = objConexion.mtdDesconectado(consulta);
            List<clAsistencia> lista = new List<clAsistencia>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clAsistencia objAdd = new clAsistencia();
                objAdd.idAsignatura = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.nombreAsignatura = resultado.Rows[i][1].ToString();
                lista.Add(objAdd);
            }
            return lista;
        }
        public void mtdConsultarIdAsignaturaCurso()
        {
            string consulta = "select idAsignaturaCurso from asignaturacurso where idCurso=" + idCurso + " and idAsignatura=" + idAsignatura + "";
            DataTable resultado = new DataTable();

            resultado = objConexion.mtdDesconectado(consulta);
            int cantidad = resultado.Rows.Count;
            idAsignaturaCurso = int.Parse(resultado.Rows[0][0].ToString());
        }

        public int mtdInsertarAsistencia()
        {
            mtdConsultarIdAsignaturaCurso();

            // consultar estudiantes del curso 

            string consultarEstudiantes = "select idEstudiante from estudiante where  idCurso=" + idCurso + "";
            DataTable resultadoEstudiantes = new DataTable();
            resultadoEstudiantes = objConexion.mtdDesconectado(consultarEstudiantes);

            //Insert tabla Asistencia

            DateTime fechaActual = DateTime.Now;
            string fecha = Convert.ToDateTime(fechaActual).ToString("yyyy-MM-dd,hh,mm,ss");
            int rows = 0;
            for (int i = 0; i < resultadoEstudiantes.Rows.Count; i++)
            {
                string estado = "Falto";
                string consultaInsertar = "insert into asistencia(idAsignaturaCurso,idEstudiante,fechaHora,asistencia) values   (" + idAsignaturaCurso + "," + resultadoEstudiantes.Rows[i][0].ToString() + ",'" + fecha + "','" + estado + "')";
                rows = objConexion.mtdConectado(consultaInsertar);
            }

            return rows;

        }

        public List<clAsistencia> mtdBuscarAsistencia()
        {
           
            string fecha = Convert.ToDateTime(fechaHora).ToString("yyyy-MM-dd hh:mm:ss");
            string consulta = "select asistencia.idAsistencia,estudiante.idEstudiante,estudiante.nombres,estudiante.apellidos,curso.nombreCurso,asignatura.nombreAsignatura,asistencia.fechaHora,asistencia.asistencia from asistencia \n " +
                               "inner join asignaturacurso on asignaturacurso.idAsignaturaCurso = asistencia.idAsignaturacurso \n " +
                               "inner join estudiante on asistencia.idEstudiante = estudiante.idEstudiante \n " +
                               "inner join curso on asignaturacurso.idCurso = curso.idCurso  \n " +
                               "inner join asignatura on asignaturacurso.idAsignatura = asignatura.idAsignatura where asignaturacurso.idAsignatura = " + idAsignatura + " and asignaturacurso.idCurso = " + idCurso + " and fechaHora= '" + fecha + "'";     
            
            DataTable tblAsistencia = new DataTable();
            objConexion = new clConexion();
            tblAsistencia = objConexion.mtdDesconectado(consulta);

            List<clAsistencia> listAsistencia = new List<clAsistencia>();


            for (int i = 0; i < tblAsistencia.Rows.Count; i++)
            {

                clAsistencia objAsistencia = new clAsistencia();
                objAsistencia.idAsistencia = int.Parse(tblAsistencia.Rows[i]["idAsistencia"].ToString());
                objAsistencia.idEstudiante = int.Parse(tblAsistencia.Rows[i]["idEstudiante"].ToString());
                objAsistencia.nombres = tblAsistencia.Rows[i]["nombres"].ToString();
                objAsistencia.apellidos = tblAsistencia.Rows[i]["apellidos"].ToString();
                objAsistencia.nombreCurso = tblAsistencia.Rows[i]["nombreCurso"].ToString();
                objAsistencia.nombreAsignatura = tblAsistencia.Rows[i]["nombreAsignatura"].ToString();
                objAsistencia.fechaHora = DateTime.Parse(tblAsistencia.Rows[i]["fechaHora"].ToString());
                objAsistencia.Asistencia = tblAsistencia.Rows[i]["asistencia"].ToString();

                listAsistencia.Add(objAsistencia);
            }

            return listAsistencia;
        }

        public List<clAsistencia> mtdConsultarFechaSegunCursoAsignatura(int curso,int asigantura)
        {
            List<clAsistencia> listFecha = new List<clAsistencia>();
            
            string consulta = "select distinct (fechaHora) idAsistencia,fechaHora from asistencia inner join asignaturacurso on asistencia.idAsignaturacurso = asignaturacurso.idAsignaturaCurso where asignaturacurso.idCurso = " + curso + " and asignaturacurso.idAsignatura = " + asigantura + " ";
            DataTable tblListaFechas = new DataTable();
            tblListaFechas = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < tblListaFechas.Rows.Count; i++)
            {
                clAsistencia objFecha = new clAsistencia();
                string fechaConsulta = tblListaFechas.Rows[i]["fechaHora"].ToString();
                objFecha.fechaHoras2 = Convert.ToDateTime(fechaConsulta).ToString("yyyy-MM-dd hh:mm:ss");
                listFecha.Add(objFecha);
            }
            return listFecha;
        }
       

        public int mtdAsistioFalto(string asistencia)
        {
            string estado = asistencia;
            string Estado = "update asistencia set asistencia = '" + estado +  "' where idAsistencia = " + idAsistencia  + " " ;
            int resultado = objConexion.mtdConectado(Estado);
            return resultado;

        }
    }
}
