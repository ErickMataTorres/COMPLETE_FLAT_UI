using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.Clases
{
    public class Consultar
    {
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string ActividadFisica { get; set; }
        public string Diagnostico { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
        public string Brazo { get; set; }
        public string Cintura { get; set; }
        public string Cadera { get; set; }
        public string Busto { get; set; }
        public string Estomago { get; set; }
        public string Complexion { get; set; }
        public int Dieta { get; set; }
        public DateTime Fecha { get; set; }
        public string Tratamiento { get; set; }
        public string IMC { get; set; }

        public string Guardar()
        {
            string respuesta = "ok";
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spGuardarConsulta", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdPaciente", IdPaciente);
            command.Parameters.AddWithValue("@Nombre_Paciente", NombrePaciente);
            command.Parameters.AddWithValue("@Fecha_Nacimiento", FechaNacimiento);
            command.Parameters.AddWithValue("@Edad", Edad);
            command.Parameters.AddWithValue("@Actividad_Fisica", ActividadFisica);
            command.Parameters.AddWithValue("@Diagnostico", Diagnostico);
            command.Parameters.AddWithValue("@Estatura", Estatura);
            command.Parameters.AddWithValue("@Peso", Peso);
            command.Parameters.AddWithValue("@Brazo", Brazo);
            command.Parameters.AddWithValue("@Cintura", Cintura);
            command.Parameters.AddWithValue("@Cadera", Cadera);
            command.Parameters.AddWithValue("@Busto", Busto);
            command.Parameters.AddWithValue("@Estomago", Estomago);
            command.Parameters.AddWithValue("@Complexion", Complexion);
            command.Parameters.AddWithValue("@Dieta", Dieta);
            //command.Parameters.AddWithValue("@Fecha", Fecha);
            command.Parameters.AddWithValue("@Tratamiento", Tratamiento);
            command.Parameters.AddWithValue("@IMC", IMC);
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
        public static Consultar Cargar(int idPaciente)
        {
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spSelectParaConsulta", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdPaciente", idPaciente);
            Consultar c = new Consultar();
            SqlDataReader dr;
            conx.Open();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                c.IdPaciente = idPaciente;
                c.NombrePaciente = dr.GetString(1);
                c.FechaNacimiento = dr.GetDateTime(2);
                c.Edad = dr.GetInt32(3);
                c.ActividadFisica = dr.GetString(4);
                c.Diagnostico = dr.GetString(5);
                c.Estatura = dr.GetString(6);
                c.Peso = dr.GetString(7);
                c.Brazo = dr.GetString(8);
                c.Cintura = dr.GetString(9);
                c.Cadera = dr.GetString(10);
                c.Busto = dr.GetString(11);
                c.Estomago = dr.GetString(12);
                c.Complexion = dr.GetString(13);
                c.Dieta = dr.GetInt32(14);
                c.Tratamiento = dr.GetString(16);
                c.IMC = dr.GetString(17);
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
        public static DataTable TablaConsultar(string texto)
        {
            DataTable t = new DataTable();
            SqlConnection conx = Conexion.ClaseConexion.Conectar();

            SqlCommand command = new SqlCommand("SELECT * FROM TablaConsultar WHERE Nombre_Paciente COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI LIKE '%" + texto + "%'", conx);

            //SqlCommand command = new SqlCommand("SELECT IdPaciente as 'ID PACIENTE', Nombre_Paciente as ' NOMBRE DEL PACIENTE', Fecha_Nacimiento as 'FECHA CITA', Edad as 'EDAD', Actividad_Fisica as 'ACTIVIDAD FISICA', Diagnostico as 'DIAGNOSTICO', Estatura as 'ESTATURA', Peso as 'PESO', Brazo as 'BRAZO', Cintura as 'CINTURA', Cadera as 'CADERA', Busto as 'BUSTO', Estomago as 'ESTOMAGO', Complexion as 'COMPLEXION', Dieta as 'DIETA', Fecha as 'FECHA', Tratamiento as 'TRATAMIENTO', IMC as 'IMC' FROM TablaConsultar WHERE Nombre_Paciente COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI LIKE '%" + texto + "%'", conx);

            conx.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(t);
            conx.Close();
            return t;
        }
        public static DataTable TablaHistorial(string id, DateTime desde, DateTime hasta, int opcion)
        {
            DataTable t = new DataTable();
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spConsultaHistorialTexto", conx);

            SqlParameter ParametroId = new SqlParameter();
            ParametroId.ParameterName = "@Texto";
            ParametroId.SqlDbType = SqlDbType.VarChar;
            ParametroId.Size = 100;
            ParametroId.Value = id;
            command.Parameters.Add(ParametroId);

            SqlParameter ParametroDesde = new SqlParameter();
            ParametroDesde.ParameterName = "@Desde";
            ParametroDesde.SqlDbType = SqlDbType.Date;
            ParametroDesde.Value = desde;
            command.Parameters.Add(ParametroDesde);

            SqlParameter ParametroHasta = new SqlParameter();
            ParametroHasta.ParameterName = "@Hasta";
            ParametroHasta.SqlDbType = SqlDbType.Date;
            ParametroHasta.Value = hasta;
            command.Parameters.Add(ParametroHasta);

            command.Parameters.AddWithValue("@Opcion", opcion);

            command.CommandType = CommandType.StoredProcedure;
            conx.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(t);
            conx.Close();
            return t;
        }
        public static DataTable TablaHistorialTexto(string texto, DateTime desde, DateTime hasta, int opcion)
        {
            DataTable t = new DataTable();
            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spConsultaHistorialTexto", conx);

            SqlParameter ParametroTexto = new SqlParameter();
            ParametroTexto.ParameterName = "@Texto";
            ParametroTexto.SqlDbType = SqlDbType.VarChar;
            ParametroTexto.Size = 100;
            ParametroTexto.Value = texto;
            command.Parameters.Add(ParametroTexto);

            SqlParameter ParametroDesde = new SqlParameter();
            ParametroDesde.ParameterName = "@Desde";
            ParametroDesde.SqlDbType = SqlDbType.Date;
            ParametroDesde.Value = desde;
            command.Parameters.Add(ParametroDesde);

            SqlParameter ParametroHasta = new SqlParameter();
            ParametroHasta.ParameterName = "@Hasta";
            ParametroHasta.SqlDbType = SqlDbType.Date;
            ParametroHasta.Value = hasta;
            command.Parameters.Add(ParametroHasta);

            command.Parameters.AddWithValue("@Opcion", opcion);

            command.CommandType = CommandType.StoredProcedure;
            conx.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(t);
            conx.Close();
            return t;
        }
    }
}