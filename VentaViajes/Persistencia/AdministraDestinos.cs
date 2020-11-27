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
        public static SqlException errores;

        /// <summary>
        /// Método para insertar nuevos destinos.
        /// </summary>
        /// <param name="cadenaC">Cadena de Conexión.</param>
        /// <param name="clave">Id del destino.</param>
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
        /// Propiedad Errores de Sql.
        /// </summary>
        public SqlException Errores => errores;
    }
}
