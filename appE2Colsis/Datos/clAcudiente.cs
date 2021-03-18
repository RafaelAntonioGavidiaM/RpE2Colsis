using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appE2Colsis.Datos
{
    class clAcudiente:clPersona
    {
        public int idAcudiente { get; set; }

        public int mtdBuscar()
        {
            string sql = "select * from acudiente where documento = '" + documento + "'";
            tblPersona = new System.Data.DataTable();
            tblPersona = objConexion.mtdDesconectado(sql);

            for (int i = 0; i < tblPersona.Rows.Count; i++)
            {
                idAcudiente = int.Parse(tblPersona.Rows[i]["idAcudiente"].ToString());
            }

            return tblPersona.Rows.Count;
        }
    }
}
