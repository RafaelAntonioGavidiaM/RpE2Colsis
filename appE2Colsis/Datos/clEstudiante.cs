using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace appE2Colsis.Datos
{
    class clEstudiante:clPersona
    {
        public int idEstudiante { set; get; }
        public int idAcudiente { set; get; }
        public int idCurso { set; get; }

        private string añoActual = DateTime.Now.ToString("yyyy");
        public void mtdListarNivelEducativo()
        {
            string sql = "select curso from curso where año = '"+añoActual+"' group by curso;";
            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }
        public void mtdListarCurso(string curso)
        {
            string sql = "select idCurso, nombreCurso from curso where curso = '"+curso+"' and año = '"+añoActual+"'";
            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }
        public int mtdCrearEstudiante()
        {
            string fechaNacimiento = this.fechaNacimiento.ToString("yyyy-MM-dd");

            string sql = "insert into estudiante (nombres,apellidos,documento,tipoDocumento, " +
                         "fechaNacimiento,tipoSangre,seguroEstudiantil,telefono,idAcudiente,idCurso) " +
                         "select " +
                         "'"+nombre+"','"+apellido+"',"+documento+",'"+tipoDocumento+"','"+fechaNacimiento+"', " +
                         "'"+tipoSangre+"','"+seguroEstudiantil+"','"+telefono+"',"+idAcudiente+","+idCurso+" " +
                         "from dual where not exists (select * from estudiante where documento = '" + documento + "')";
            return objConexion.mtdConectado(sql);
        }
        public void mtdBuscarEstudiantesPorCurso()
        {
            string sql = "select es.idEstudiante, es.nombres, es.apellidos, es.documento, es.tipoDocumento, es.fechaNacimiento, es.tipoSangre, " +
                         "es.seguroEstudiantil, es.telefono, es.idAcudiente, es.idCurso, ac.documento as CC_Acudiente, cu.curso as nivelEducativo, cu.nombreCurso as curso " +
                         "from estudiante es inner join acudiente ac " +
                         "on es.idAcudiente = ac.idAcudiente " +
                         "inner join curso cu " +
                         "on es.idCurso = cu.idCurso " +
                         "where es.idCurso = "+idCurso;
            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }
        public void mtdBuscarEstudiantePorDocumento()
        {
            string sql = "select es.idEstudiante, es.nombres, es.apellidos, es.documento, es.tipoDocumento, es.fechaNacimiento, es.tipoSangre, " +
                         "es.seguroEstudiantil, es.telefono, es.idAcudiente, es.idCurso, ac.documento as CC_Acudiente, cu.curso as nivelEducativo, cu.nombreCurso as curso " +
                         "from estudiante es inner join acudiente ac " +
                         "on es.idAcudiente = ac.idAcudiente " +
                         "inner join curso cu " +
                         "on es.idCurso = cu.idCurso " +
                         "where es.documento = '"+documento+"'";
            tblPersona = new DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);
        }
        public int mtdActualizarEstudiante()
        {
            string fechaNacimiento = this.fechaNacimiento.ToString("yyyy-MM-dd");

            string sql = "update estudiante set " +
                         "nombres = '"+nombre+"', apellidos = '"+apellido+"', documento = '"+documento+"',tipoDocumento = '"+tipoDocumento+"',fechaNacimiento = '"+fechaNacimiento+"', " +
                         "tipoSangre = '"+tipoSangre+"',seguroEstudiantil = '"+seguroEstudiantil+"',telefono = '"+telefono+"',idAcudiente = "+idAcudiente+",idCurso = "+idCurso+" " +
                         "where idEstudiante = "+idEstudiante;
            return objConexion.mtdConectado(sql);
        }
        public int mtdEliminarEstudiante()
        {
            string sql = "delete from estudiante where idEstudiante = "+idEstudiante;
            try
            { return objConexion.mtdConectado(sql); }
            catch (Exception)
            {
                MessageBox.Show("Hay mas datos asociados a este Estudiante\n" + 
                                "Eliminelos primero");
                return 0;
            }
        }
    }
}
