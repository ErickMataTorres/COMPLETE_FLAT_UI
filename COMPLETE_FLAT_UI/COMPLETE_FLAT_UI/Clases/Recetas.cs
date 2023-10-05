using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.Clases
{
    public class Recetas
    {
        public int IdReceta { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Contenido { get; set; }
        public string Guardar()
        {
            string respuesta = "ok";
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spGuardarReceta", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdReceta", IdReceta);
            command.Parameters.AddWithValue("@Tipo", Tipo);
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@Contenido", Contenido);
            try
            {
                conx.Open();
                command.ExecuteNonQuery();
                conx.Close();
            }
            catch (Exception error)
            {
                respuesta = "Ha ocurrido un error: " + error.Message;
                if (conx.State == ConnectionState.Open)
                {
                    conx.Close();
                }
            }
            return respuesta;
        }
    }
}
