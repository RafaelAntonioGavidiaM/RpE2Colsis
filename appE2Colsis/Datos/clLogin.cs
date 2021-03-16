using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace appE2Colsis.Datos
{
    class clLogin : clPersona
    {
        public string password { get; set; }
        public int idRol { get; set; }

        /// <summary>
        /// Permite el logueo del usuario en la aplicacion
        /// </summary>
        /// 
        public void mtdLogin()
        {
            string consulta = "select * from personal where documento='"+documento+"' and password='"+password+"'";
            DataTable resultado = new DataTable();
            resultado =objConexion.mtdDesconectado(consulta);
            try
            {
                nombre = resultado.Rows[0][1].ToString();
                apellido = resultado.Rows[0][2].ToString();
                idRol = int.Parse(resultado.Rows[0]["idRol"].ToString());
            }
            catch (Exception)
            {
                nombre = "";
                apellido = "";
                idRol = 0;

            }
            

        }
        /// <summary>
        /// Consulta los permisos que tiene el usuario al ingresar 
        /// </summary>

        public List<clRol> mtdConsultarPermisos()
        {
            string consulta = "select rol_permiso.nombreFormulario,rol_permiso.idPermiso from rol_permiso where idRol='" + idRol + "'";
            DataTable resultado = new DataTable();
           resultado= objConexion.mtdDesconectado(consulta);

            List<clRol> listaLogin = new List<clRol>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clRol objRol = new clRol();
                objRol.nombreFormulario = resultado.Rows[i][0].ToString();
                objRol.idPermiso = int.Parse(resultado.Rows[i][1].ToString());
                listaLogin.Add(objRol);
                


            }
            return listaLogin;
            

            


        }

    }
}
