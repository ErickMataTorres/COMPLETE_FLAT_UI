using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace COMPLETE_FLAT_UI.Clases
{
    public class ReservarCita
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Edad { get; set; }
        public string Fecha { get; set; }
        public string Enfermedad { get; set; }
        public string Antecedentes_Familiares { get; set; }
        public string Medicamento { get; set; }
        public string Diagnostico { get; set; }
        public string Actividad_Fisica { get; set; }
        public DateTime Cita { get; set; }
        public string Hora { get; set; }

        public string MetodoReservarCita()
        {
            string respuesta = "ok";
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spReservarCita", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@Telefono", Telefono);
            //command.Parameters.AddWithValue("@Fecha_Nacimiento", Fecha_Nacimiento);
            //command.Parameters.AddWithValue("@Edad", Edad);
            //command.Parameters.AddWithValue("@Enfermedad", Enfermedad);
            //command.Parameters.AddWithValue("@Antecedentes_Familiares", Antecedentes_Familiares);
            //command.Parameters.AddWithValue("@Medicamento", Medicamento);
            //command.Parameters.AddWithValue("@Diagnostico", Diagnostico);
            //command.Parameters.AddWithValue("@Actividad_Fisica", Actividad_Fisica);
            command.Parameters.AddWithValue("@Cita", Cita);
            command.Parameters.AddWithValue("@Hora", Hora);
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
        public static ReservarCita Cargar(int id)
        {
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spCargarCita", conx);
            command.CommandType=CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            ReservarCita c = new ReservarCita();
            SqlDataReader dr;
            conx.Open();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                c.Id = id;
                c.Nombre = dr.GetString(1);
                c.Telefono = dr.GetString(2);
                //c.Fecha_Nacimiento = dr.GetDateTime(3);
                //c.Edad = dr.GetInt32(4);
                //c.Fecha = dr.GetString(5);
                //c.Enfermedad = dr.GetString(6);
                //c.Antecedentes_Familiares = dr.GetString(7);
                //c.Medicamento = dr.GetString(8);
                //c.Diagnostico = dr.GetString(9);
                //c.Actividad_Fisica = dr.GetString(10);
                c.Cita = dr.GetDateTime(3);
                c.Hora = dr.GetString(4);
            }
            dr.Close();
            conx.Close();
            return c;
        }
        public string EliminarCita(int id)
        {
            string respuesta = "ok";
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spEliminarCita", conx);
            command.Parameters.AddWithValue("@Id", id);
            command.CommandType = CommandType.StoredProcedure;
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
        public static int ValidaCita(DateTime cita, string hora)
        {
            int respuesta = 0;
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spValidaCita", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cita", cita);
            command.Parameters.AddWithValue("@Hora", hora);
            conx.Open();
            DataTable t = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(t);
            if (t.Rows.Count > 0)
            {
                respuesta = 1;
            }
            else
            {
                respuesta = 0;
            }
            conx.Close();
            return respuesta;
        }
        public static int MaximoId()
        {
            int maximoId = 0;
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(Id+1),1) FROM TablaReservarCita", conx);
            conx.Open();
            maximoId = int.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return maximoId;
        }
        public static DataTable Citas(string texto)
        {
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("SELECT * FROM TablaCitas WHERE Nombre COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI LIKE '%" + texto + "%'", conx);
            DataTable t = new DataTable();
            conx.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(t);
            conx.Close();
            return t;
        }
    }
}