using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.Clases
{
    public class Buscar
    { 
        static public DataTable Consulta(string tabla, string campos, string orden, string filtro)
        {
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            DataTable t = new DataTable();
            conx.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select  " + campos + " from " + tabla + " where " + orden + " COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI LIKE '%" + filtro + "%' order by " + orden, conx);
            da.Fill(t);
            conx.Close();
            return t;
        }
    }
}
