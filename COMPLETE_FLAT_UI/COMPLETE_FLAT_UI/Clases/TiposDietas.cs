using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.Clases
{
    public class TiposDietas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static List<TiposDietas> Lista()
        {
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("Select * from TablaTiposDietas", conx);
            SqlDataReader dr;
            List<TiposDietas> l = new List<TiposDietas>();
            TiposDietas c;
            conx.Open();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                c = new TiposDietas();
                c.Id = dr.GetInt32(0);
                c.Nombre = dr.GetString(1);
                l.Add(c);
            }
            dr.Close();
            conx.Close();
            return l;
        }
    }
}
