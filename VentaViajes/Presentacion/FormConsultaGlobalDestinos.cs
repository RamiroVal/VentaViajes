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

namespace VentaViajes.Presentacion
{
    public partial class FormConsultaGlobalDestinos : Form
    {
        public FormConsultaGlobalDestinos()
        {
            InitializeComponent();
        }

        private void FormConsultaGlobalDestinos_Load(object sender, EventArgs e)
        {
            string cadenaC = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            dtgDestinos.DataSource = AdministraDestinos.Destinos(cadenaC);
        }
    }
}
