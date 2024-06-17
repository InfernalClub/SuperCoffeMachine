using MySql.Data.MySqlClient;
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
    public partial class Comprar : Form
    {
        public Comprar()
        {
            InitializeComponent();
        }

        private void listaVenta_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT stock FROM productos WHERE nombre = @nombre";
            string[] parameters = { "@nombre", comboBox1.Text };
            string stock = ConnectMySQL.Instance.SelectQueryScalar(query, parameters);
            stockActual.Text = stock;

            string query2 = "SELECT precio FROM productos WHERE nombre = @nombre";
            string[] parameters2 = { "@nombre", comboBox1.Text };
            string precio = ConnectMySQL.Instance.SelectQueryScalar(query2, parameters2);
            precioActual.Text = precio;
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            string query = "SELECT nombre FROM productos";
            DataTable nombres = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < nombres.Rows.Count; i++)
            {
                comboBox1.Items.Add(nombres.Rows[i]["nombre"]);
            }



        }

        private void botonAniadir_Click(object sender, EventArgs e)
        {
            int d;
            string query = "INSERT INTO venta(nombre_producto, precio, cantidad, fecha) VALUES (@nombre, @precio, @cantidad, @fecha)";
            if (int.Parse(cantidadCompra.Text) > int.Parse(stockActual.Text))
            {
                MessageBox.Show("No se puede comprar una mayour cantidad de productos que el stock actual");
            }
            else
            {
                MySqlParameter[] parameters =
                    {
                        new MySqlParameter("@nombre", comboBox1.Text),
                        new MySqlParameter("@precio", precioActual.Text),
                        new MySqlParameter("@cantidad", cantidadCompra.Text),
                        new MySqlParameter("@fecha", DateTime.Now)


                    };
                ConnectMySQL.Instance.ExecuteQuery(query, parameters);
                MessageBox.Show("Producto agregado al pedido exitosamente");
                d = int.Parse(stockActual.Text) - int.Parse(stockActual.Text);
                stockActual.Text = d.ToString();
            }
            string query2 = "SELECT nombre_producto, precio, cantidad, fecha FROM ventas WHERE nombre = @nombre;";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query2);
            dataGridView1.DataSource = data;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void valorFinal_Click(object sender, EventArgs e)
        {
            


        }

        private void PrecioFinalOrden_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT SUM(precio * cantidad )) AS costo_total FROM venta";
            string texto = ConnectMySQL.Instance.SelectQueryScalar(query);
            PrecioFinalOrden.Text = texto;
        }

        private void botonPagar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO record_ventas (nombre_Producto, precio, cantidad, fecha)" +
                "SELECT nombre_Producto, precio, cantidad, fecha" +
                "FROM venta;";
            ConnectMySQL.Instance.ExecuteQuery(query);
            string query2 = "TRUNCATE TABLE venta;";
            ConnectMySQL.Instance.ExecuteQuery(query2);
            MessageBox.Show("Productos Agregados exitosamente");
        }

        private void stockActual_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
