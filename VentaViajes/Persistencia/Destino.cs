using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaViajes.Persistencia
{
    public class Destino
    {
        // Atributos.
        private string clave;
        private string nombre;
        private double duracion;
        private double costo;
        private string habilitado;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="clave">Clave del destino.</param>
        /// <param name="nombre">Nombre del destino.</param>
        /// <param name="costo">Costo del destino.</param>
        /// <param name="duracion">Duración dell viaje.</param>
        /// <param name="habilitado">Habilitado "S" "N"</param>
        public Destino(string clave, string nombre, double costo, double duracion, string habilitado)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.costo = costo;
            this.duracion = duracion;
            this.habilitado = habilitado;
        }

        public override string ToString() => clave;

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve la clave del destino.
        /// </summary>
        public string Clave => clave;
        /// <summary>
        /// Propiedad que devuelve el nombre del destino.
        /// </summary>
        public string Nombre => nombre;
        /// <summary>
        /// Propiedad que devuelve el costo del destino.
        /// </summary>
        public double Costo => costo;
        /// <summary>
        /// Propiedad que devuelve la duración del viaje.
        /// </summary>
        public double Duracion => duracion;
        /// <summary>
        /// Propiedad que devuelve si esta habilitado o no.
        /// </summary>
        public string Habilitado => habilitado;
        #endregion
    }
}
