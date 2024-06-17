using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller2;

namespace SuperCoffeMachine
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            string query = "SELECT SUM(record_ventas.cantidad) AS cantidad_total_vendido " +
            "FROM record_ventas " +
            "WHERE YEAR(record_ventas.fecha) = YEAR(CURDATE());";
            string texto = ConnectMySQL.Instance.SelectQueryScalar(query);
            elValor.Text = texto;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Productos vendidos este año:")
            {
                string query = "SELECT nombre_producto, precio, cantidad, fecha FROM record_ventas WHERE nombre = @nombre AND YEAR(ventas.fecha) = YEAR(CURDATE());";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                gridEstadistico.DataSource = data;
                subtitulo.Text = "Productos vendidos este año:";
            }
            else if (comboBox1.Text == "Productos vendidos este año:")
            {
                string query = "SELECT nombre_producto, precio, cantidad, fecha FROM record_ventas WHERE nombre = @nombre AND YEAR(ventas.fecha) >= YEAR(CURDATE(), INTERVAL 2 YEAR);";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                gridEstadistico.DataSource = data;
                subtitulo.Text = "Productos vendidos ultimos 2 años:";
            }
            else if (comboBox1.Text == "Productos en Venta: ")
            {
                string query = "SELECT nombre FROM productos";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                gridEstadistico.DataSource = data;
                subtitulo.Text = "Productos en venta";
            }
        }

        private void elValor_Click(object sender, EventArgs e)
        {

        }

        private void gridEstadistico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
