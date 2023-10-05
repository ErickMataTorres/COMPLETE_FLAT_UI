using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.Conexion
{
    public class ClaseConexion
    {
        static public SqlConnection Conectar()
        {
            string s = @"Data Source=A; Initial Catalog=BDNutricion; Integrated Security=Yes";
            var conx = new SqlConnection(s);
            return conx;
        }
    }
}
