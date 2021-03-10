using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clRol
    {
        public int idRol { get; set; }
        public string nombreRol { get; set; }
        public string nombreFormulario { get; set; }
        public int idPermiso { get; set; }
        public string nombrePermiso { get; set; }
        public int permiso { get; set; }

        /// <summary>
        /// Metodo Registrar Rol con solo nombre.
        /// </summary>
        clConexion objConexion = new clConexion();
        public int mtdRegistrarRol() //Registra en la tabla Rol
        {
            string consulta = "insert into rol(nombre) values ('" + nombreRol + "')";

            int rows = 0;
            rows = objConexion.mtdConectado(consulta);

            return rows;

        }
        /// <summary>
        /// consultar datos en la tabla rol
        /// </summary>
        /// <returns>lista datos</returns>
        public List<clRol> mtdConsultarRol() // consultar datos en la tabla rol
        {
            string consulta = "select * from rol";
            DataTable infoRol = new DataTable();
            infoRol = objConexion.mtdDesconectado(consulta);
            List<clRol> listaRol = new List<clRol>();
            for (int i = 0; i < infoRol.Rows.Count; i++)
            {
                clRol objRol = new clRol();
                objRol.idRol = int.Parse(infoRol.Rows[i][0].ToString());
                objRol.nombreRol = infoRol.Rows[i][1].ToString();
                listaRol.Add(objRol);

            }
            return listaRol;

        }
        /// <summary>
        /// Metodo para consultar permisos en la tabla permisos
        /// </summary>
        /// <returns></returns>
        public List<clRol> mtdPermisos()
        {
            string consulta = "select * from permiso";
            DataTable datos = new DataTable();
            datos = objConexion.mtdDesconectado(consulta);
            List<clRol> listaPermisos = new List<clRol>();
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                clRol objRol = new clRol();
                objRol.idPermiso = int.Parse(datos.Rows[i][0].ToString());
                objRol.nombrePermiso = datos.Rows[i][1].ToString();
                objRol.permiso = int.Parse(datos.Rows[i][2].ToString());


                listaPermisos.Add(objRol);
            }
            return listaPermisos;


        }
        /// <summary>
        /// Consulta Permisos Segun el rol a buscar
        /// </summary>
        public List<clRol> mtdColsutarPermisosRoles()
        {
            string consulta = "select rol.idRol, rol.nombre,rol_permiso.nombreFormulario,permiso.nombrePermiso from rol_permiso inner join permiso on rol_permiso.idPermiso=permiso.idPermiso inner join rol on rol_permiso.idRol=rol.idRol where rol.nombre='" + nombreRol + "'";
            DataTable resultado = new DataTable();
            resultado = objConexion.mtdDesconectado(consulta);
            List<clRol> listaRol = new List<clRol>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clRol objRol = new clRol();
                objRol.idRol = int.Parse(resultado.Rows[i][0].ToString());
                objRol.nombreRol = resultado.Rows[i][1].ToString();
                objRol.nombreFormulario = resultado.Rows[i][2].ToString();
                objRol.nombrePermiso = resultado.Rows[i][3].ToString();

                listaRol.Add(objRol);
            }
            return listaRol;


        }
        /// <summary>
        /// Metodo Para registrar permisos en la tabla rol_permisos
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Int de rows Afectadas </returns>
        public int mtdRegistrarPermisos(List<clRol> lista)
        {
            string consulta = null;
            int rows = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                foreach (var item in lista)
                {
                    consulta = "insert into rol_permiso (idRol,nombreFormulario,idPermiso) values ('"+item.idRol+"','"+item.nombreFormulario+"','"+item.idPermiso+"')";
                   rows= objConexion.mtdConectado(consulta);
                    rows = rows + rows;

                }
                
                

            }
            return rows;

        }
        /// <summary>
        /// Metodo para eliminar rol y permisos en la base de datos
        /// </summary>
        public int mtdEliminarRolYPermisos()
        {
            string consulta1 = null;
            string consuta2 = null;
            int rows = 0;
            string[] consultas = new  string[2];
            consultas[0] = consuta2 = "delete from rol_permiso where idRol ='" + idRol + "'";//Eliminara los permisos en la tabla rol_permiso
            consultas[1]= consulta1 = "delete from rol where idRol ='"+idRol+"'";//Eliminara el registro en la tabla rol
           
            for (int i = 0; i < consultas.Length; i++)
            { 
                rows =objConexion.mtdConectado(consultas[i]);

                rows = rows + rows;

            }
            return rows;


        }
    }
}
