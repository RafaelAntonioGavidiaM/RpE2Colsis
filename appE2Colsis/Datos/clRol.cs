using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clRol : clPersona
    {
        public int idRol { get; set; }
        public string nombreRol { get; set; }
        public string nombreFormulario { get; set; }
        public int idPermiso { get; set; }
        public string nombrePermiso { get; set; }
        public int permiso { get; set; }

        public string estadoPersona { get; set; } //usado solo para filtrar

        public int idFormulario { get; set; }

       

        /// <summary>
        /// Metodo Registrar Rol con solo nombre.
        /// </summary>
       // clConexion objConexion = new clConexion();
        public int mtdRegistrarRol() //Registra en la tabla Rol
        {
            string consulta = "insert into rol(nombre) values ('" + nombreRol + "')";

            int rows = 0;
            rows = objConexion.mtdConectado(consulta);

            return rows;

        }
        /// <summary>
        /// Verifica los permisos dependiendo el formulario al que desea acceder
        /// </summary>
        /// <param name="idRolP"> rol al que pertenece la persona</param>
        /// <param name="nombreFormularioP"> formulario al que desea ingresar</param>
        
        public int mtdAccesoModulos(int idPersonal,string nombreFormularioP)
        {
            string consulta= "select count(rol_permiso.idPermiso) from personal inner join rol on personal.idRol = rol.idRol inner join rol_permiso on rol.idRol = rol_permiso.idRol inner join formulario on rol_permiso.nombreFormulario=formulario.idFormulario where personal.idPersonal ="+idPersonal+" and formulario.nombreFormulario = '"+nombreFormularioP+"' and rol_permiso.idPermiso = 1";

            DataTable resultado = new DataTable();
            resultado= objConexion.mtdDesconectado(consulta);
            int registros = 0;
            registros = int.Parse(resultado.Rows[0][0].ToString());
            return registros;

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
            string consulta = "select rol.idRol, rol.nombre,formulario.nombreFormulario,rol_permiso.idPermiso,permiso.nombrePermiso,formulario.idFormulario from rol_permiso inner join permiso on rol_permiso.idPermiso=permiso.idPermiso inner join rol on rol_permiso.idRol=rol.idRol  inner join formulario on rol_permiso.nombreFormulario=formulario.idFormulario where rol.nombre='" + nombreRol + "'";
            DataTable resultado = new DataTable();
            resultado = objConexion.mtdDesconectado(consulta);
            List<clRol> listaRol = new List<clRol>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clRol objRol = new clRol();
                objRol.idRol = int.Parse(resultado.Rows[i][0].ToString());
                objRol.nombreRol = resultado.Rows[i][1].ToString();
                objRol.nombreFormulario = resultado.Rows[i][2].ToString();
                objRol.idPermiso = int.Parse(resultado.Rows[i][3].ToString());
                objRol.nombrePermiso = resultado.Rows[i][4].ToString();
                objRol.idFormulario= int.Parse(resultado.Rows[i][5].ToString());

                listaRol.Add(objRol);
            }
            return listaRol;


        }
        /// <summary>
        /// Metodo Para registrar permisos en la tabla rol_permisos
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Int de rows Afectadas </returns>
        public int mtdRegistrarPermisos(List<clRol> lista, int idRolCrear)
        {
            string consulta = null;
            int rows = 0;

            foreach (var item in lista)
            {
                consulta = "insert into rol_permiso (idRol,nombreFormulario,idPermiso) values ('" + idRolCrear + "','" + item.idFormulario + "','" + item.idPermiso + "')";
                rows = objConexion.mtdConectado(consulta);
                rows = rows + rows;

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
            string[] consultas = new string[2];
            consultas[0] = consuta2 = "delete from rol_permiso where idRol ='" + idRol + "'";//Eliminara los permisos en la tabla rol_permiso
            consultas[1] = consulta1 = "delete from rol where idRol ='" + idRol + "'";//Eliminara el registro en la tabla rol

            for (int i = 0; i < consultas.Length; i++)
            {
                rows = objConexion.mtdConectado(consultas[i]);

                rows = rows + rows;

            }
            return rows;


        }

        /// <summary>
        /// Modifica y Actualiza la informacion de la tabla rol  y la tabla rol_permisos
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>int filas Afectadas</returns>
        public int mtdModificarRolPermisos(List<clRol> lista, int idRolM, string nombreRolM)
        {
            int rows = 0;
           string consultasTblRol = "Update  rol set nombre='" + nombreRolM + "' where idRol='" + idRolM + "'";//Actualiza nombre rol en caso de ser necesario

          rows =  objConexion.mtdConectado(consultasTblRol);

            foreach (var item in lista)
            {
             string consultaTblRolPermiso ="Update  rol_permiso set nombreFormulario='"+item.idFormulario+"',idPermiso='"+item.idPermiso+"' where nombreFormulario='"+item.idFormulario+"' and idRol="+idRolM+" ";//Actualiza la informacion de la tabla rol_permiso

                rows = objConexion.mtdConectado(consultaTblRolPermiso);
                rows = rows + rows;



            }
            return rows;



        }
        /// <summary>
        /// Metodo para Filtrar roles y mostrar las personas que estan incluidas en el rol
        /// </summary>
        /// <returns>Int con filas Afectadas</returns>

        public List<clRol> mtdFiltrar(string nombreRolFiltrar)
        {
            string consulta = "select rol.idRol,rol.nombre,personal.nombre,personal.apellido,personal.documento,personal.telefono,personal.ciudad,personal.estado from rol inner join personal on rol.idRol = personal.idRol where rol.nombre='"+nombreRolFiltrar+"'";
            DataTable resultado = new DataTable();
           resultado= objConexion.mtdDesconectado(consulta);

            List<clRol> listaRol = new List<clRol>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clRol objRol = new clRol();
                objRol.idRol =int.Parse (resultado.Rows[i][0].ToString());
                objRol.nombreRol = resultado.Rows[i][1].ToString();
                objRol.nombre = resultado.Rows[i][2].ToString();
                objRol.apellido = resultado.Rows[i][3].ToString();
                objRol.documento = resultado.Rows[i][4].ToString();
                objRol.telefono = resultado.Rows[i][5].ToString();
                objRol.ciudad = resultado.Rows[i][6].ToString();
                objRol.estadoPersona= resultado.Rows[i][7].ToString();

                listaRol.Add(objRol);
                





            }
            return listaRol;

          




        }

        public List<clRol> mtdListarFormularios()
        {
            string consulta=" select * from formulario";
            DataTable resultado = new DataTable();
           resultado= objConexion.mtdDesconectado(consulta);
            List<clRol> listaFormularios = new List<clRol>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clRol objAdd = new clRol();
                objAdd.idFormulario = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.nombreFormulario=resultado.Rows[i][1].ToString();


                listaFormularios.Add(objAdd);


            }

            return listaFormularios;



        }




    }
}
