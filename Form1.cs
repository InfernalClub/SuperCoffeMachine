using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCoffeMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void botonProductos_Click(object sender, EventArgs e)
        {

        }

        private void botonVentas_Click(object sender, EventArgs e)
        {

        }

        private void botonClientes_Click(object sender, EventArgs e)
        {
            IngresoClientecs ingresoClientescs = new IngresoClientecs();
            ingresoClientescs.Show();

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente eliminarCliente = new EliminarCliente();
            eliminarCliente.Show();
        }
    }
}
