using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibreriaBD;
using System.Data;

namespace VentaViajes.Persistencia
{
    class AdministraDestinos
    {
        // Sirve para guardar los errores que se presenten con la conexión SQL.
        public static SqlException errores;

        /// <summary>
        /// Método para insertar nuevos destinos.
        /// </summary>
        /// <param name="cadenaC">Cadena de Conexión.</param>
        /// <param name="clave">ID del destino.</param>
        /// <param name="nombre">Nombre del destino.</param>
        /// <param name="costo">Costo del destino.</param>
        /// <param name="duracion">Duración del destino.</param>
        /// <param name="habilitado">Estadi habilitado o no.</param>
        /// <returns>true = inserción exitosa.</returns>
        public static bool AgregaDestino(string cadenaC, string clave, string nombre, double costo, double duracion, string habilitado)
        {
            SqlConnection conexion = UsoBD.ConectaBD(cadenaC);
            if (conexion == null)
            {
                errores = UsoBD.ESalida;
                return false;
            }
            string proc = "IsertarDestino";
            SqlCommand command = new SqlCommand(proc, conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idDestino", clave);
            command.Parameters.AddWithValue("@nomDestino", nombre);
            command.Parameters.AddWithValue("@costoDestino", costo);
            command.Parameters.AddWithValue("@durDestino", duracion);
            command.Parameters.AddWithValue("@habilDestino", habilitado);

            try
            {
                command.ExecuteNonQuery();
            }catch(SqlException ex)
            {
                errores = ex;
                conexion.Close();
                return false;
            }

            conexion.Close();
            return true;
        }

        /// <summary>
        /// Método que devuelve una lista con las claves de los destinos.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <returns>Lista con claves de destino.</returns>
        public static Destino[] Destinos(string cadenaC)
        {
            SqlConnection sqlConnection = UsoBD.ConectaBD(cadenaC);
            if (sqlConnection == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader reader = null;
            List<Destino> claves = new List<Destino>();
            string proc = "DatosDestinos";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = proc;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                reader = sqlCommand.ExecuteReader();
            }catch(SqlException e)
            {
                errores = e;
                sqlConnection.Close();
                return null;
            }
            while (reader.Read())
            {
                string clave = reader.GetValue(0).ToString();
                string nombre = reader.GetValue(1).ToString();
                double costo = Convert.ToDouble(reader.GetValue(2));
                double duracion = Convert.ToDouble(reader.GetValue(3));
                string habilitado = reader.GetValue(4).ToString();
                claves.Add(new Destino(clave, nombre, costo, duracion, habilitado));
            }
            Destino[] c = new Destino[claves.Count];
            claves.CopyTo(c);
            sqlConnection.Close();
            return c;
        }

        /// <summary>
        /// Método que devuelve las claves de los destinos.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <returns>Arreglo string con las claves de destino.</returns>
        public static string[] ClavesDestinos(string cadenaC)
        {
            SqlConnection sqlConnection = UsoBD.ConectaBD(cadenaC);
            if (sqlConnection == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader reader = null;
            List<string> claves = new List<string>();
            string proc = "IdDestinos";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = proc;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                reader = sqlCommand.ExecuteReader();
            }
            catch (SqlException e)
            {
                errores = e;
                sqlConnection.Close();
                return null;
            }
            while (reader.Read())
            {
                claves.Add(reader.GetValue(0).ToString());
            }
            string[] c = new string[claves.Count];
            claves.CopyTo(c);
            sqlConnection.Close();
            return c;
        }

        /// <summary>
        /// Método que consulta todos los atributos de un destino dado por su clave.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <returns>DataTable con los datos de la consulta.</returns>
        public static string[] DatosDestino(string cadenaC, string clave)
        {
            string[] datos = new string[3];
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            SqlDataReader reader = UsoBD.Consulta("select nombre_dest, costo_dest, duracion_dest from DESTINOS where clave_dest=" + clave, connection);
            if (reader == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            while (reader.Read())
            {
                datos[0] = reader.GetValue(0).ToString();
                datos[1] = Convert.ToDouble(reader.GetValue(1)).ToString("C2");
                datos[2] = reader.GetValue(2).ToString();

                // Convierte double a formato hora.
                string[] d = datos[2].Split('.');
                double dec = Convert.ToDouble(d[1]);
                dec = dec / 100 * 60;
                if (dec < 10)
                {
                    datos[2] = d[0] + ":" + dec+"0";
                }
                else
                {
                    datos[2] = d[0] + ":" + dec;
                }
            }
            connection.Close();
            return datos; ;
        }
    }
}
