using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace appE2Colsis.Datos
{
    class clAsignaturaCurso
    {
        public int idCurso { get; set; }
        public string nombreCurso { get; set; }
        public int idPersonal { get; set; }
        public string nombrePersonal { get; set; }
        public string apellido { get; set; }

        public int idAsignatura { get; set; }

        public string nombreAsignatura { get; set; }
        public string nombreCompleto { get; set; }
        public int idAsignaturaCurso { get; set; }

        public string año { get; set; }





        clConexion objConexion = new clConexion();
        public void mtdConsultarAño()
        {
            DateTime fechaActual = DateTime.Now;
            año = Convert.ToDateTime(fechaActual).ToString("yyyy");
        }

        public List<clAsignaturaCurso> mtdConsultaCursos()
        {
            mtdConsultarAño(); 
           string consulta = "select idCurso,nombreCurso from curso where año='"+año+"' ";
            DataTable resultado = new  DataTable();
           resultado= objConexion.mtdDesconectado(consulta);
            List<clAsignaturaCurso> lista = new List<clAsignaturaCurso>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clAsignaturaCurso objAdd = new clAsignaturaCurso();
                objAdd.idCurso = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.nombreCurso = resultado.Rows[i][1].ToString();
                lista.Add(objAdd);

            }
            return lista;

        }
        public List<clAsignaturaCurso> mtdConsultaAsignatura()
        {
            string consulta = "select idAsignatura,nombreAsignatura from asignatura";
            DataTable resultado = new DataTable();
            resultado = objConexion.mtdDesconectado(consulta);
            List<clAsignaturaCurso> lista = new List<clAsignaturaCurso>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clAsignaturaCurso objAdd = new clAsignaturaCurso();
                objAdd.idAsignatura = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.nombreAsignatura = resultado.Rows[i][1].ToString();
                lista.Add(objAdd);



            }
            return lista;

        }

        public List<clAsignaturaCurso> mtdConsultarPersonal()
        {
            string consulta= "select personal.idPersonal,personal.nombre,personal.apellido from personal";
            DataTable resultado = new DataTable();
         resultado=   objConexion.mtdDesconectado(consulta);
            List<clAsignaturaCurso> lista = new List<clAsignaturaCurso>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clAsignaturaCurso objAdd = new clAsignaturaCurso();
                objAdd.idPersonal = int.Parse(resultado.Rows[i][0].ToString());
                string allname = resultado.Rows[i][1].ToString() + " " + resultado.Rows[i][2].ToString();
                objAdd.nombreCompleto = allname;

                lista.Add(objAdd);
               
            }
            return lista;
        }
        
        public List<clAsignaturaCurso> mtdBuscarAsignaturasCurso()
        {
            mtdConsultarAño();
            string consulta= "select   asignaturacurso.idDocente , asignaturacurso.idAsignatura ,asignatura.nombreAsignatura as Nombre_Asignatura,personal.nombre as Nombre,personal.apellido as Apellido, asignaturacurso.idAsignaturaCurso, asignaturacurso.idCurso from asignaturacurso inner join asignatura on asignaturacurso.idAsignatura = asignatura.idAsignatura \n " +
                "inner join personal on asignaturacurso.idDocente = personal.idPersonal inner join curso on asignaturacurso.idCurso = curso.idCurso where curso.idCurso ="+idCurso+" and curso.año='"+año+"'";
            DataTable resultado = new DataTable();
           resultado= objConexion.mtdDesconectado(consulta);
            List<clAsignaturaCurso> lista = new List<clAsignaturaCurso>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clAsignaturaCurso objAdd = new clAsignaturaCurso();
                objAdd.idPersonal = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.idAsignatura= int.Parse(resultado.Rows[i][1].ToString());
                objAdd.nombreAsignatura = resultado.Rows[i][2].ToString();
                objAdd.nombrePersonal= resultado.Rows[i][3].ToString();
                objAdd.apellido= resultado.Rows[i][4].ToString();
                objAdd.idAsignaturaCurso= int.Parse(resultado.Rows[i][5].ToString());
                objAdd.idCurso= int.Parse(resultado.Rows[i][6].ToString());
                lista.Add(objAdd);

            }

            return lista;
        }
        public int  mtdInsertar()
        {
            string consulta = "insert into asignaturacurso(idAsignatura,idCurso,idDocente) values (" + idAsignatura + "," + idCurso + "," + idPersonal + ")";
           int rows = objConexion.mtdConectado(consulta);
            return rows;

        }

       
        public int mtdActualizarCurso()
        {
           
            string consultaActualiza = "update asignaturacurso set idAsignatura=" + idAsignatura + ", idCurso=" + idCurso + ", idDocente=" + idPersonal + " where idAsignaturaCurso="+idAsignaturaCurso+"";
          int rows= objConexion.mtdConectado(consultaActualiza);
            return rows;

        }

        /// <summary>
        /// Elimina la asignacion si no tiene referencias a las tablas asistencia y horario
        /// </summary>
        /// <returns></returns>

        public int  mtdEliminarAsignacionCurso()
        {
            string consulta = "delete from asignaturacurso where idAsignaturaCurso=" + idAsignaturaCurso + "";
           int rows= objConexion.mtdConectado(consulta);
            return rows;

        }








    }
}
