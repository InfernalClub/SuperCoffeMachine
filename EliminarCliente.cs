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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "UPDATE clientes SET estado = 0, WHERE ID = @ID";
            MySqlParameter[] parameter =
            {
                new MySqlParameter("@ID",dataGrid.CurrentCell.Value)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parameter);
            MessageBox.Show("Cliente eliminado con exito");

            query = "SELECT ID, nombre, ciudad FROM clientes WHERE estado = 1";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGrid.DataSource = data;
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            string query = "SELECT ID, nombre, ciudad FROM clientes WHERE estado = 1";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGrid.DataSource = data;
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
