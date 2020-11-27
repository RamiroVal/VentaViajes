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
        public FormConsultaIndDestinos()
        {
            InitializeComponent();
        }

        private void FormConsultaIndDestinos_Load(object sender, EventArgs e)
        {
            CargarDestinos();
        }

        private void CargarDestinos()
        {
            string cadenaConexion = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            DataTable table = AdministraDestinos.ListarDestinos(cadenaConexion);
            if (table == null)
            {
                foreach(SqlError er in AdministraBoletos.errores.Errors)
                {
                    MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            cmbDestinos.DataSource = table;
            cmbDestinos.DisplayMember = "nombre_dest";
            cmbDestinos.ValueMember = "clave_dest";
            cmbDestinos.Text = "Seleccione destino";
        }

        private void MuestraDatos()
        {
            string cadenaConexion = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            string clave = cmbDestinos.SelectedValue.ToString();
            string[] datos = AdministraDestinos.DatosDestino(cadenaConexion, clave);
            txtNombre.Text = datos[0];
            txtCosto.Text = datos[1];
            txtDuracion.Text = datos[2];

        }

        private void cmbDestinos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MuestraDatos();
        }
    }
}
