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

        /// <summary>
        /// Método que obtiene los atributos de BOLETOS
        /// </summary>
        /// <param name="strConexion">Cadena de conexión.</param>
        /// <returns>Arreglo de Boleto con los atributos.</returns>
        public static Boleto[] Boletos(string strConexion)
        {
            SqlConnection connection = UsoBD.ConectaBD(strConexion);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            SqlCommand command = new SqlCommand();
            SqlDataReader reader = null;
            List<Boleto> boletos = new List<Boleto>();
            string proc = "ConsultaBoletos";
            command.Connection = connection;
            command.CommandText = proc;
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                reader = command.ExecuteReader();
            }catch(SqlException e)
            {
                errores = e;
                connection.Close();
                return null;
            }
            while (reader.Read())
            {
                int clave = Convert.ToInt32(reader.GetValue(0));
                string nomDestino = reader.GetValue(1).ToString();
                string nomPasajero = reader.GetValue(2).ToString();
                int numAsiento = Convert.ToInt32(reader.GetValue(3));
                int tipoBoleto;
                if (reader.GetValue(4).ToString() == "")
                {
                    tipoBoleto = 0;
                }
                else
                {
                    tipoBoleto = Convert.ToInt32(reader.GetValue(4));
                }
                double costo = Convert.ToDouble(reader.GetValue(5));
                boletos.Add(new Boleto(clave, nomDestino, nomPasajero, numAsiento, tipoBoleto, costo));
            }
            Boleto[] bol = new Boleto[boletos.Count];
            boletos.CopyTo(bol);
            connection.Close();
            return bol;
        }
    }
}
