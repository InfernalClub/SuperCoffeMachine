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
    public partial class ModificarProductos : Form
    {
        public ModificarProductos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ModificarProductos_Load(object sender, EventArgs e)
        {
            string query = "SELECT nombre FROM productos";
            DataTable nombres = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < nombres.Rows.Count; i++)
            {
                listaProductos.Items.Add(nombres.Rows[i]["nombre"]);
            }
        }

        private void actualizarStockBoton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE productos SET stock = @stock WHERE nombre = @nombre";
            MySqlParameter[] parameters =
                {
                    new MySqlParameter("stock", int.Parse(nuevoStock.Text)),
                    new MySqlParameter("@nombre", listaProductos.Text)
                };
            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("Stock actualizado exitosamente");



        }

        private void precioActualizarBoton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE productos SET precio = @precio WHERE nombre = @nombre";
            MySqlParameter[] parameters =
                {
                new MySqlParameter("precio", int.Parse(nuevoPrecioBox.Text)),
                new MySqlParameter("@nombre", listaProductos.Text)
                };
            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("Costo cambiado exitosamente");
        }

        private void nuevoStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT stock FROM productos WHERE nombre = @nombre";
            string[] parameters = { "@nombre", listaProductos.Text };
            string stock = ConnectMySQL.Instance.SelectQueryScalar(query, parameters);
            stockActual.Text = stock;

            string query2 = "SELECT precio FROM productos WHERE nombre = @nombre";
            string[] parameters2 = { "@nombre", listaProductos.Text };
            string precio = ConnectMySQL.Instance.SelectQueryScalar(query2, parameters2);
            precioActualBox.Text = precio;
        }
    }
}
