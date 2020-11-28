using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaViajes.Presentacion;

namespace VentaViajes
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAgregaDestino c = new FormAgregaDestino();
            c.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultaIndDestinos c = new FormConsultaIndDestinos();
            c.ShowDialog();
        }

        private void globalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultaGlobalDestinos c = new FormConsultaGlobalDestinos();
            c.ShowDialog();
        }

        private void globalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultasBoletos c = new FormConsultasBoletos();
            c.ShowDialog();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaIndBoletos c = new FormConsultaIndBoletos();
            c.ShowDialog();
        }
    }
}
