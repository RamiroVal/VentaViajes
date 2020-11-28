using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaViajes.Persistencia;
using System.Data.SqlClient;
using Validaciones;

namespace VentaViajes.Presentacion
{
    public partial class FormConsultaIndBoletos : Form
    {
        public FormConsultaIndBoletos()
        {
            InitializeComponent();
        }

        private void FormConsultaIndBoletos_Load(object sender, EventArgs e)
        {
            CargaLista();
        }

        private void CargaLista()
        {
            string conexion = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            string[] claves = AdministraBoletos.Claves(conexion);
            if (claves == null)
            {
                foreach (SqlError er in AdministraBoletos.errores.Errors)
                {
                    MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            collection.AddRange(claves);
            txtClave.AutoCompleteCustomSource = collection;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!Consultar())
            {
                MessageBox.Show("Clave no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaClave(e.KeyChar))
            {
                errorProvider1.SetError(txtClave, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtClave, "Solo números");
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                Consultar();
                errorProvider1.SetError(txtClave, "");
            }
        }

        private bool Consultar()
        {
            Limpiar();
            string conexion = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            int clave = Convert.ToInt32(txtClave.Text);
            string[] datos = AdministraBoletos.DatosBoleto(conexion, clave);
            if (datos == null)
            {
                foreach(SqlError e in AdministraBoletos.errores.Errors)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            if (datos[0] == null)
            {
                return false;
            }
            txtDestino.Text = datos[1];
            txtPasajero.Text = datos[2];
            txtAsiento.Text = datos[3];
            if (datos[4] == "")
            {
                txtTipo.Text = "0";
            }
            else
            {
                txtTipo.Text = "1";
            }
            txtCosto.Text = datos[5];
            return true;
        }

        private void Limpiar()
        {
            txtAsiento.Clear();
            txtCosto.Clear();
            txtDestino.Clear();
            txtTipo.Clear();
            txtAsiento.Clear();
        }
    }
}
