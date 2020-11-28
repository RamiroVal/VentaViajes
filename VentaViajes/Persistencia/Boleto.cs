using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaViajes.Persistencia
{
    public class Boleto
    {
        private int clave;
        private string nomDestino;
        private string nomPasajero;
        private int numAsiento;
        private int tipoBol;
        private double costo;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="clave">Número del Boleto.</param>
        /// <param name="nomDestino">Nombre del destino.</param>
        /// <param name="nomPasajero">Nombre del pasajero.</param>
        /// <param name="numAsiento">Número de asiento.</param>
        /// <param name="tipoBol">Tipo de boleto.</param>
        /// <param name="costo">Costo del boleto.</param>
        public Boleto(int clave, string nomDestino, string nomPasajero, int numAsiento, int tipoBol, double costo)
        {
            this.clave = clave;
            this.nomDestino = nomDestino;
            this.nomPasajero = nomPasajero;
            this.numAsiento = numAsiento;
            this.tipoBol = tipoBol;
            this.costo = costo;
        }

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve clave.
        /// </summary>
        public int Clave => clave;
        /// <summary>
        /// Propiedad que devuelve el Destino.
        /// </summary>
        public string NombreDestino => nomDestino;
        /// <summary>
        /// Propiedad que devuelve el Nombre del pasajero.
        /// </summary>
        public string NombrePasajero => nomPasajero;
        /// <summary>
        /// Propiedad que devuelve el número del asiento.
        /// </summary>
        public int NumeroAsiento => numAsiento;
        /// <summary>
        /// Propiedad que devuelve el tipo de boleto.
        /// </summary>
        public int TipoBol => tipoBol;
        /// <summary>
        /// Propiedad que devuelve el costo del boleto.
        /// </summary>
        public double Costo => costo;
        #endregion
    }
}
