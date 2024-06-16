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
    public partial class IngresoClientecs : Form
    {
        public IngresoClientecs()
        {
            InitializeComponent();
        }

        private void botonEnviar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO clientes(nombre, ciudad, tipo, fecha_inscripción, estado) VALUES (@nombre, @ciudad, @tipo, @fecha,  @estado)";
            if (comboTipo.Text == "Normal")
            {
                MySqlParameter[] parameters =
                    {
                        new MySqlParameter("@nombre", textoNombre.Text),
                        new MySqlParameter("@ciudad", textoCiudad.Text),
                        new MySqlParameter("@tipo", 1),
                        new MySqlParameter("@fecha", DateTime.Today),
                        new MySqlParameter("@estado", 1)
                        
                    };
                ConnectMySQL.Instance.ExecuteQuery(query, parameters);
                MessageBox.Show("Cliente Normal agregado exitosamente");
            }
            else
            {
                MySqlParameter[] parameters =
    {
                        new MySqlParameter("@nombre", textoNombre.Text),
                        new MySqlParameter("@ciudad", textoCiudad.Text),
                        new MySqlParameter("@tipo", 2),
                        new MySqlParameter("@fecha", DateTime.Today),
                        new MySqlParameter("@estado", 1)
                    };
                ConnectMySQL.Instance.ExecuteQuery(query, parameters);
                MessageBox.Show("Cliente Premium agregado exitosamente");

            }
        }
    }
}
