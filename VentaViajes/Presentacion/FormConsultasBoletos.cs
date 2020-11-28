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
    public partial class FormConsultasBoletos : Form
    {
        public FormConsultasBoletos()
        {
            InitializeComponent();
        }

        private void FormConsultasBoletos_Load(object sender, EventArgs e)
        {
            string cadenaC = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            Boleto[] boletos = AdministraBoletos.Boletos(cadenaC);
            dataGridView1.DataSource = boletos;
            dataGridView1.AutoResizeColumns();
        }
    }
}
