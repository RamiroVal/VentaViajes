using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaViajes.Persistencia;

namespace VentaViajes.Presentacion
{
    public partial class FormConsultaIndDestinos : Form
    {
        public FormConsultaIndDestinos() => InitializeComponent();

        private void cmbDestinos_SelectionChangeCommitted(object sender, EventArgs e) => MuestraDatos();

        private void FormConsultaIndDestinos_Load(object sender, EventArgs e) => CargarDestinos();

        private void CargarDestinos()
        {
            //string cadenaConexion = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            //Destino[] destinos = AdministraDestinos.Destinos(cadenaConexion);
            //if (destinos == null)
            //{
            //    foreach(SqlError er in AdministraBoletos.errores.Errors)
            //    {
            //        MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    return;
            //}
            //cmbDestinos.Items.AddRange(destinos);
            string cadenaConexion = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            string[] destinos = AdministraDestinos.ClavesDestinos(cadenaConexion);
            if (destinos == null)
            {
                foreach(SqlError er in AdministraBoletos.errores.Errors)
                {
                    MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            cmbDestinos.Items.AddRange(destinos);

        }

        private void MuestraDatos()
        {
            string cadenaConexion = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            string clave = cmbDestinos.SelectedItem.ToString();
            string[] datos = AdministraDestinos.DatosDestino(cadenaConexion, clave);
            txtNombre.Text = datos[0];
            txtCosto.Text = datos[1];
            txtDuracion.Text = datos[2]+"Hr";

            //Destino destino = cmbDestinos.SelectedItem as Destino;

            //txtNombre.Text = destino.Nombre;
            //txtCosto.Text = destino.Costo.ToString("C2");
            //txtDuracion.Text = destino.Duracion.ToString() + "hr";
        }
    }
}
