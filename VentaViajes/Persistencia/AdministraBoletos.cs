using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LibreriaBD;

namespace VentaViajes.Persistencia
{
    class AdministraBoletos
    {
        // Sirve para guardar los errores que se presenten con la conexión SQL.
        public static SqlException errores;

        /// <summary>
        /// Método para insertar nuevo boleto.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <param name="numBoleto">ID de Boleto.</param>
        /// <param name="claveDestino">ID de clave destino.</param>
        /// <param name="nombrePasajero">Nombre del pasajero.</param>
        /// <param name="nAsiento">Número de asiento.</param>
        /// <param name="tipo">Tipo de boleto.</param>
        /// <param name="costo">Costo del boleto.</param>
        /// <returns>true = inserción exitosa.</returns>
        public static bool AgregaBoletos(string cadenaC, int numBoleto, string claveDestino, string nombrePasajero, int nAsiento, int tipo, double costo)
        {
            SqlConnection conexion = UsoBD.ConectaBD(cadenaC);
            if (conexion == null)
            {
                errores = UsoBD.ESalida;
                return false;
            }
            string proc = "InsertarBoleto";
            SqlCommand command = new SqlCommand(proc, conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@noBoleto", numBoleto);
            command.Parameters.AddWithValue("@idDestino", claveDestino);
            command.Parameters.AddWithValue("@nomPasajero", nombrePasajero);
            command.Parameters.AddWithValue("@noAsiento", nAsiento);
            command.Parameters.AddWithValue("@tipo", tipo);
            command.Parameters.AddWithValue("@costo", costo);

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
    }
}
