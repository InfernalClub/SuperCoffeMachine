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
            string nombre = textoNombre.Text;
            string ciudad = textoCiudad.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo de nombre no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(ciudad))
            {
                MessageBox.Show("El campo de ciudad no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (PasswordForm passwordForm = new PasswordForm())
            {
                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    // Verificar la contraseña
                    if (passwordForm.Password != "hola")
                    {
                        MessageBox.Show("Contraseña incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
