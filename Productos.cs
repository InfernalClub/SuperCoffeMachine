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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void agregarProductoBoton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO productos(nombre, precio, stock) VALUES (@nombre, @precio, @stock)";
            MySqlParameter[] parameters =
                    {
                        new MySqlParameter("@nombre", textoProducto.Text),
                        new MySqlParameter("@precio", textoStock.Text),
                        new MySqlParameter("@stock", textoPrecio.Text)
                    };
            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("Producto agregado exitosamente");
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
