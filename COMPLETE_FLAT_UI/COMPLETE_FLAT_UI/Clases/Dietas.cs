using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.Clases
{
    public class Dietas
    {
        public string Tipo { get; set; }
        public int IdDieta { get; set; }
        public string Dia { get; set; }
        public string TipoDeComida { get; set; }
        public string Contenido { get; set; }
        
        public static DataTable TablaDietas(int idDieta)
        {
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("ConsultaPivot", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdDieta", idDieta);
            conx.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            da.Fill(t);
            conx.Close();
            return t;
        }
        public static List<Dietas> Lista()
        {
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("SELECT IdDieta FROM TablaDietaPivot GROUP BY IdDieta", conx);
            SqlDataReader dr;
            List<Dietas> l = new List<Dietas>();
            Dietas c;
            conx.Open();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                c = new Dietas();
                c.IdDieta = dr.GetInt32(0);
                l.Add(c);
            }
            dr.Close();
            conx.Close();
            return l;
        }
    }
}
