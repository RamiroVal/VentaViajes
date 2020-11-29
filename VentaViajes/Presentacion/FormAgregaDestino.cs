using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using System.Data.SqlClient;

namespace VentaViajes.Presentacion
{
    public partial class FormAgregaDestino : Form
    {
        public FormAgregaDestino() => InitializeComponent();

        #region Eventos Validated
        private void txtClave_Validated(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            if (Validar.ValidaBlanco(clave))
            {
                errorProvider1.SetError(txtClave, "Agregue clave");
            }
            else
            {
                errorProvider1.SetError(txtClave, "");
                if (clave.Length == 3)
                {
                    errorProvider1.SetError(txtClave, "");
                }
                else
                {
                    errorProvider1.SetError(txtClave, "Clave de 3 caracteres");
                }
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (Validar.ValidaBlanco(nombre))
            {
                errorProvider1.SetError(txtNombre, "Agregue nombre");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
                if (nombre.Length <= 30)
                {
                    errorProvider1.SetError(txtNombre, "");
                }
                else
                {
                    errorProvider1.SetError(txtNombre, "Nombre de máximo 30 caracteres");
                }
            }
        }

        private void txtCosto_Validated(object sender, EventArgs e)
        {
            string costo = txtCosto.Text;
            if (Validar.ValidaBlanco(costo))
            {
                errorProvider1.SetError(txtCosto, "Agregue clave");
            }
            else
            {
                errorProvider1.SetError(txtCosto, "");
            }
        }
        #endregion

        #region Eventos KeyPress
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
                Guardar();
                errorProvider1.SetError(txtClave, "");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaNombre(e.KeyChar))
            {
                errorProvider1.SetError(txtNombre, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "Solo letras");
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                Guardar();
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')
            {
                errorProvider1.SetError(txtCosto, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtCosto, "Íngrese costo válido");
            }
        }

        private void numDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Guardar();
            }
        }
        #endregion

        #region Eventos Click
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion

        #region Utilidades
        private void Guardar()
        {
            try
            {
                string clave = txtClave.Text;
                string nombre = txtNombre.Text.ToUpper();
                double costo = Convert.ToDouble(txtCosto.Text);
                double duracion = Convert.ToDouble(numDuracion.Value);
                string habilitado = "";
                if (chbHabilitado.Checked)
                {
                    habilitado = "S";
                }
                else
                {
                    habilitado = "N";
                }
                if (Validar.ValidaBlanco(clave) || Validar.ValidaBlanco(nombre) || Validar.ValidaBlanco(txtCosto.Text))
                {
                    MessageBox.Show("Campos en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (Validar.ValidaBlanco(clave)) errorProvider1.SetError(txtClave, "Agregue clave");
                    if (Validar.ValidaBlanco(nombre)) errorProvider1.SetError(txtNombre, "Agregue nombre");
                    if (Validar.ValidaBlanco(txtCosto.Text)) errorProvider1.SetError(txtCosto, "Agregue costo");
                }
                else
                {
                    DialogResult confirmacion = MessageBox.Show("Se agregará el siguiente destino:" +
                        $"\nClave: {clave}" +
                        $"\nNombre: {nombre}" +
                        $"\nCosto: {costo.ToString("C2")}" +
                        $"\nDuracion: {duracion.ToString("F").Replace('.', ':')}" +
                        $"\nHabilitado: {habilitado}", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmacion == DialogResult.Yes)
                    {
                        string cadenaConexion = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
                        if (Persistencia.AdministraDestinos.AgregaDestino(cadenaConexion, clave, nombre, costo, duracion, habilitado))
                        {
                            MessageBox.Show($"El destino {nombre}, ha sido agregado con éxito");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show($"No se ha podido agregar el destino {nombre}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            foreach (SqlError er in Persistencia.AdministraDestinos.errores.Errors)
                            {
                                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            return;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese clave o costo correctos.");
            }
        }

        private void Limpiar()
        {
            txtClave.Clear();
            txtNombre.Clear();
            txtCosto.Clear();
            numDuracion.Value = 0;
            chbHabilitado.Checked = true;
        }
        #endregion
    }
}
