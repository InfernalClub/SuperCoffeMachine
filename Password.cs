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
    public partial class PasswordForm : Form
    {
        public string Password { get; private set; }
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Password = textBoxPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
