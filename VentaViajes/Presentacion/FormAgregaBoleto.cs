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
using Validaciones;
using System.Data.SqlClient;

namespace VentaViajes.Presentacion
{
    public partial class FormAgregaBoleto : Form
    {
        public FormAgregaBoleto() => InitializeComponent();

        private void FormAgregaBoleto_Load(object sender, EventArgs e)
        {
            string strC = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            Destino[] destinos = AdministraDestinos.DatosParaBoleto(strC);
            cmbDestinos.Items.AddRange(destinos);
            cmbDestinos.SelectedIndex = 0;
            CambiaPrecio();
        }

        private void rdbNormal_CheckedChanged(object sender, EventArgs e) => CambiaPrecio();

        private void cmbDestinos_SelectedIndexChanged(object sender, EventArgs e) => CambiaPrecio();

        #region Eventos Click
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            Destino destino = cmbDestinos.SelectedItem as Destino;
            string boleto = txtBoleto.Text;
            string clave = destino.Clave;
            string pasajero = txtPasajero.Text;
            int asiento = Convert.ToInt32(numAsiento.Value);
            int tipo = DeterminaTipo();
            double costo = CalculaCosto();
            if (AdministraBoletos.ValidaAsiento(cadenaConexion, clave, asiento))
            {
                Guardar(cadenaConexion, boleto, clave, pasajero, asiento, tipo, costo);
            }
            else
            {
                MessageBox.Show("Número de asiento no disponible, seleccione otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(numAsiento, "Seleccione otro número de asiento");
                if (Validar.ValidaBlanco(boleto))
                    errorProvider1.SetError(txtBoleto, "Ingrese número de boleto");
                if (Validar.ValidaBlanco(pasajero))
                    errorProvider1.SetError(txtPasajero,"Ingrese nombre de pasajero");
            }
        }
        #endregion

        #region Eventos KeyPress
        private void txtBoleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaClave(e.KeyChar))
            {
                errorProvider1.SetError(txtBoleto, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtBoleto, "Sólo se permiten números");
                e.Handled = true;
            }
        }

        private void txtPasajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaNombre(e.KeyChar))
            {
                errorProvider1.SetError(txtPasajero, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtPasajero, "Sólo se permiten letras.");
                e.Handled = true;
            }
        }
        #endregion

        #region Eventos NumericUpDown
        private void numAsiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaClave(e.KeyChar))
            {
                errorProvider1.SetError(numAsiento, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(numAsiento, "Sólo enteros");
                e.Handled = true;
            }
        }

        private void numAsiento_ValueChanged(object sender, EventArgs e) => errorProvider1.SetError(numAsiento, "");
        #endregion

        #region Eventos Validated
        private void txtBoleto_Validated(object sender, EventArgs e)
        {
            string boleto = txtBoleto.Text;
            if (Validar.ValidaBlanco(boleto))
            {
                errorProvider1.SetError(txtBoleto, "Ingrese número de boleto");
            }
            else
            {
                errorProvider1.SetError(txtBoleto, "");
            }
        }

        private void txtPasajero_Validated(object sender, EventArgs e)
        {
            string boleto = txtPasajero.Text;
            if (Validar.ValidaBlanco(boleto))
            {
                errorProvider1.SetError(txtPasajero, "Ingrese el nombre del pasajero");
            }
            else
            {
                errorProvider1.SetError(txtBoleto, "");
            }
        }
        #endregion

        #region Utilerías
        private void Guardar(string cadenaC, string boleto, string destino, string pasajero, int asiento, int tipo, double costo)
        {
            Destino dest = cmbDestinos.SelectedItem as Destino;
            string tip = "";
            if (tipo == 0)
            {
                tip = "Normal";
            }
            else
            {
                tip = "Estudiante";
            }
            bool bol = Validar.ValidaBlanco(boleto);
            bool nom = Validar.ValidaBlanco(pasajero);
            if (bol || nom)
            {
                MessageBox.Show("Campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (bol)
                    errorProvider1.SetError(txtBoleto, "Ingrese boleto");
                if (nom)
                    errorProvider1.SetError(txtPasajero, "Ingrese nombre de pasajero");
            }
            else
            {
                if(boleto.Length != 4)
                {
                    MessageBox.Show("El número de boleto debe de ser de 4 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txtBoleto, "Mínimo 4 caracteres");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Boleto:" +
                        $"\nNúmero: {boleto}" +
                        $"\nDestino: {dest.Nombre}" +
                        $"\nPasajero: {pasajero}" +
                        $"\nAsiento: {asiento}" +
                        $"\nTipo: {tip}" +
                        $"\nCosto: {txtCosto.Text}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        int bole = Convert.ToInt32(boleto);
                        if (AdministraBoletos.AgregaBoletos(cadenaC, bole, destino, pasajero, asiento, tipo, costo))
                        {
                            MessageBox.Show("Se ha agregado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            foreach(SqlError er in AdministraBoletos.errores.Errors)
                            {
                                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
        
        private void Limpiar()
        {
            txtBoleto.Clear();
            txtPasajero.Clear();
            cmbDestinos.SelectedIndex = 0;
            numAsiento.Value = 1;
            rdbNormal.Checked = true;
            CambiaPrecio();
        }
        
        private int DeterminaTipo()
        {
            if (rdbNormal.Checked)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        #endregion

        #region Costo
        private void CambiaPrecio()
        {
            txtCosto.Text = CalculaCosto().ToString("C2");
        }
        
        private double CalculaCosto()
        {
            Destino destino = cmbDestinos.SelectedItem as Destino;
            double costo = destino.Costo;
            if (rdbNormal.Checked)
            {
                return costo;
            }
            costo = costo - (costo / 100 * 20);
            return costo;
        }
        #endregion
    }
}
