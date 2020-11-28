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
            LlenaDataGrid();
        }

        private void LlenaDataGrid()
        {
            string cadenaC = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=VENTABOLETOS;Integrated Security=True";
            Boleto[] boletos = AdministraBoletos.Boletos(cadenaC);
            dataGridView1.DataSource = boletos;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Columns[0].HeaderText = "Número de Boleto";
            dataGridView1.Columns[1].HeaderText = "Nombre de Destino";
            dataGridView1.Columns[2].HeaderText = "Nombre de Pasajero";
            dataGridView1.Columns[3].HeaderText = "Número de Asiento";
            dataGridView1.Columns[4].HeaderText = "Tipo de Boleto";
            dataGridView1.Columns[5].HeaderText = "Costo";
        }
    }
}
