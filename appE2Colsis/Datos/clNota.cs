using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clNota
    {
        //tabla nota
        public int idNota { get; set; } 
        public string  nombreNota { get; set; }

        public int estadoNota { get; set; }

        public int idAsignatura { get; set; }

        public int idCurso { get; set; }
        public int idDocente { get; set; }

        public int idPeriodo { get; set; }

        //tabla asignaturaNota

        public int idAsignaturaNota { get; set; }
        public float nota { get; set; }

        public int idNotaAsignaturaNota { get; set; }

        public int idEstudiante { get; set; }

        //Datos necesarios

        public string nombreCurso { get; set; }
        public string nombreAsignatura { get; set; }
        public string nombreEstudiante { get; set; }
        public string apellidoEstudiante { get; set; }

        int rows = 0;


        clConexion objConexion = new clConexion();

        /// <summary>
        /// Registro de la Nota en la tabla nota 
        /// </summary>
        /// <returns> rows afectadas</returns>
        public int mtdRegistrarNota()
        {
           DateTime fechaActual = DateTime.Now;
          String fecha=  Convert.ToDateTime(fechaActual).ToString("yyyy-MM-dd");
            string consultaPeriodo = "select idPeriodo from periodo where fechaInicio<'" + fecha + "' and fechaFin>'" + fecha + "'";
            DataTable resultadoPeriodo = new DataTable();
           resultadoPeriodo= objConexion.mtdDesconectado(consultaPeriodo);
            idPeriodo =int.Parse( resultadoPeriodo.Rows[0][0].ToString());
            






            string consulta = "insert into nota(nombreNota,estadoNota,idAsignatura,idCurso,idDocente,idPeriodo) \n" +
                  "values ('" + nombreNota + "',1," + idAsignatura + "," + idCurso + "," + idDocente + "," + idPeriodo + ") ";

            rows = objConexion.mtdConectado(consulta);
            mtdCargarNotasEstudiante();



           

            return rows;
        }

        /// <summary>
        /// Carga en todos los estudiantes segun curso y asignatura las nuevas notas con 0 , para que el docente cargue los nuevos resultados 
        /// </summary>

        public void mtdCargarNotasEstudiante()
        {

            if (rows > 0)
            {
                string consultaEstudiantes = "select estudiante.idEstudiante from estudiante inner join curso on estudiante.idCurso=curso.idCurso where estudiante.idCurso=" + idCurso + " ";
                DataTable resultadoEstudiantes = new DataTable();
                resultadoEstudiantes = objConexion.mtdDesconectado(consultaEstudiantes);
                string consultaIdNota = "select nota.idNota from nota where nombreNota='" + nombreNota + "'";
               

                DataTable resultadoidNota = new DataTable();
              resultadoidNota=  objConexion.mtdDesconectado(consultaIdNota);
                idNota = int.Parse(resultadoidNota.Rows[0][0].ToString());

                for (int i = 0; i < resultadoEstudiantes.Rows.Count; i++)
                {
                    string insertAsignatura = "insert into asignaturanota(nota,idNota,idEstudiante) values(0.0,"+idNota+"," + int.Parse(resultadoEstudiantes.Rows[i][0].ToString()) + ")";
                    int estudiantesAfectados = objConexion.mtdConectado(insertAsignatura);
                }





            }
        }

        /// <summary>
        /// Consulta los cursos que un profesor tiene disponibles segun el año actual 
        /// </summary>
        /// <returns></returns>
        public List<clNota> mtdConsultarCursos()//consultas los cursos segun año actual 
        {
            DateTime fechaActual = DateTime.Now;
            String año = Convert.ToDateTime(fechaActual).ToString("yyyy");
            string consulta = "select  distinct(curso.idCurso),curso.idCurso,curso.nombreCurso from asignaturacurso inner join curso on asignaturacurso.idCurso = curso.idCurso inner join asignatura on asignaturacurso.idAsignatura = asignatura.idAsignatura inner join personal on asignaturacurso.idDocente = personal.idPersonal where personal.idPersonal =" + idDocente+" and curso.año = "+año+"";
            DataTable resultado = new DataTable();
         resultado=   objConexion.mtdDesconectado(consulta);
            List<clNota> listaCursosDocente = new List<clNota>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clNota objNota = new clNota();
                objNota.idCurso = int.Parse(resultado.Rows[i][0].ToString());
                objNota.nombreCurso = resultado.Rows[i][2].ToString();
                //objNota.idAsignatura =int.Parse(resultado.Rows[i][2].ToString());
                //objNota.nombreAsignatura = resultado.Rows[i][3].ToString();
                listaCursosDocente.Add(objNota);

            }
            return listaCursosDocente;




        }




        /// <summary>
        /// Consulta notas segun curso y asignatura de todos los estudiantes 
        /// </summary>
        /// <returns>lista con estudiantes y notas </returns>

        int PeriodoConsulta = 0;
        public DataTable mtdConsultarNotasDeEstudiantes()
        {


            DateTime fechaActual = DateTime.Now;
            String fecha = Convert.ToDateTime(fechaActual).ToString("yyyy-MM-dd");
            string consultaPeriodo = "select idPeriodo from periodo where fechaInicio<'" + fecha + "' and fechaFin>'" + fecha + "'";
            DataTable resultadoPeriodo = new DataTable();
            resultadoPeriodo = objConexion.mtdDesconectado(consultaPeriodo);
            PeriodoConsulta = int.Parse(resultadoPeriodo.Rows[0][0].ToString());

            string consultaNombresNotas = "select  distinct nota.nombreNota \n" +
                " from asignaturanota inner join estudiante on asignaturanota.idEstudiante = estudiante.idEstudiante inner join nota on asignaturanota.idNota = nota.idNota inner join asignatura on nota.idAsignatura = asignatura.idAsignatura  inner join periodo on nota.idPeriodo = periodo.idPeriodo where \n" +
                " nota.idCurso =" + idCurso + " and asignatura.idAsignatura =" + idAsignatura + " and periodo.idPeriodo="+PeriodoConsulta+" ";

            DataTable NombresNotas = new DataTable();
            NombresNotas =objConexion.mtdDesconectado(consultaNombresNotas);
            int cantidadNotas = NombresNotas.Rows.Count;

            //string final="";
            string[] consultasSum = new string[cantidadNotas];

           

            for (int i = 0; i < cantidadNotas; i++)
            {
              string  notaCalificacion = NombresNotas.Rows[i][0].ToString();




               consultasSum[i] = "sum(case when Nnota ='"+notaCalificacion+"' then Calificacion else 0 end )as '"+notaCalificacion+"' ";



            }

            
            string cadena = string.Join(",", consultasSum.ToArray()); // concatena los string que se llenan en el vector.

            string consultaFinal = " select \n" +
                "idCursoF,idAsignaturaF,cod_Estudiante, Nombre,Apellidos, \n" +
                " " + cadena + " \n " +
                "from (select nota.idCurso as idCursoF ,asignatura.idasignatura as idAsignaturaF,estudiante.idEstudiante as cod_Estudiante, estudiante.nombres as Nombre,estudiante.apellidos as Apellidos,asignatura.nombreAsignatura as Asignatura,nota.nombreNota as Nnota,asignaturanota.nota as Calificacion \n" +
                " from asignaturanota inner join estudiante on asignaturanota.idEstudiante=estudiante.idEstudiante inner join nota on asignaturanota.idNota=nota.idNota \n " +
                "inner join asignatura on nota.idAsignatura=asignatura.idAsignatura where nota.idCurso=" + idCurso + " and asignatura.idAsignatura=" + idAsignatura + ") as tb group by Nombre ";
            DataTable resultadoaCargar = new DataTable();
            resultadoaCargar= objConexion.mtdDesconectado(consultaFinal);

            return resultadoaCargar;









        } 
        /// <summary>
        /// Muestra las notas de cada estudiante segun curso, asignatura y estudiante
        /// </summary>
        public List<clNota> mtdCargarNotas()
        {
            string consultaNotasPorEstudiante = "select nota.idNota as idNota, nota.nombreNota as Nombre,asignaturanota.nota as Calificacion  \n " +
                "from asignaturanota inner join estudiante on asignaturanota.idEstudiante = estudiante.idEstudiante  \n " +
                "inner join nota on asignaturanota.idNota = nota.idNota inner join asignatura on nota.idAsignatura = asignatura.idAsignatura inner join periodo on nota.idPeriodo=periodo.idPeriodo \n " +
                "where nota.idCurso ="+idCurso+" and asignatura.idAsignatura ="+idAsignatura+" and estudiante.idEstudiante ="+idEstudiante+"  and nota.estadoNota =1 and periodo.idPeriodo="+PeriodoConsulta+"";

            DataTable resultado = new DataTable();
            resultado= objConexion.mtdDesconectado(consultaNotasPorEstudiante);
            List<clNota> listaNotas = new List<clNota>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clNota objNota = new clNota();
                objNota.idNota= int.Parse(resultado.Rows[i][0].ToString());
                objNota.nombreNota = resultado.Rows[i][1].ToString();
                objNota.nota = float.Parse( resultado.Rows[i][2].ToString());
                listaNotas.Add(objNota);               
            }

            return listaNotas;




        }

        public int mtdActualizarNotas(List<clNota> listaActualizar )
        {
            int rows = 0;
            foreach (var item in listaActualizar)
            {
                string consulta = "Update asignaturanota set nota=" + item.nota + " where idEstudiante=" + idEstudiante + " and idNota=" + item.idNota + " ";
             rows=  objConexion.mtdConectado(consulta);
                rows = rows + rows;
                

            }

            return rows;

        }

        public List<clNota> mtdMostrarNotasSegunCursoAsignatura()
        {
            DateTime fechaActual = DateTime.Now;
            String fecha = Convert.ToDateTime(fechaActual).ToString("yyyy-MM-dd");
            string consultaPeriodo = "select idPeriodo from periodo where fechaInicio<'" + fecha + "' and fechaFin>'" + fecha + "'";
            DataTable resultadoPeriodo = new DataTable();
            resultadoPeriodo = objConexion.mtdDesconectado(consultaPeriodo);
            PeriodoConsulta = int.Parse(resultadoPeriodo.Rows[0][0].ToString());

            string consultaNotas = "select idNota,nombreNota from nota where idAsignatura ="+idAsignatura+" and idDocente ="+idDocente+"  and idPeriodo ="+PeriodoConsulta+" and idCurso ="+idCurso+"";
            DataTable resultado = new DataTable();
           resultado= objConexion.mtdDesconectado(consultaNotas);
            List<clNota> listaNombreNotas = new List<clNota>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clNota objNota = new clNota();
                objNota.idNota = int.Parse(resultado.Rows[i][0].ToString());
                objNota.nombreNota = resultado.Rows[i][1].ToString();
                listaNombreNotas.Add(objNota);


                

            }
            return listaNombreNotas;

        }
        public int mtdEliminarNota()
        {
            string[] consultas = new string[2];
            consultas[0] = "delete from asignaturanota where idNota=" + idNota + "";
            consultas[1] = "delete from nota where idNota=" + idNota + "";
            int filasModificadas=0;
            for (int i = 0; i < consultas.Length; i++)
            {
               filasModificadas= objConexion.mtdConectado(consultas[i]);
                filasModificadas = filasModificadas + filasModificadas;

            }
            return filasModificadas;

        }
        public int  mtdActualizarNota()
        {
            string consultaActualizar = "update nota  set nombreNota='"+nombreNota+"', estadoNota="+estadoNota+" where idNota="+idNota+"" ;
           int rows = objConexion.mtdConectado(consultaActualizar);
            return rows;






        }

        public List<clNota> mtdConsultarAsignaturas()
        {

            string consulta = "select asignatura.idAsignatura,asignatura.nombreAsignatura from asignaturacurso inner join asignatura on asignaturacurso.idAsignatura=asignatura.idAsignatura inner join curso on asignaturacurso.idCurso=curso.idCurso where curso.idCurso=" + idCurso + " and asignaturacurso.idDocente=" + idDocente + " ";
            DataTable resultado = new DataTable();
            resultado=objConexion.mtdDesconectado(consulta);
            List<clNota> listaAsignaturas = new List<clNota>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clNota objAdd = new clNota();
                objAdd.idAsignatura = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.nombreAsignatura = resultado.Rows[i][1].ToString();
                listaAsignaturas.Add(objAdd);
            }

            return listaAsignaturas;
        }






    }
}
