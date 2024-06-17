namespace SuperCoffeMachine
{
    partial class IngresoClientecs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.tituloClientes = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoCiudad = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.botonEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(111, 164);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(56, 16);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // ciudad
            // 
            this.ciudad.AutoSize = true;
            this.ciudad.Location = new System.Drawing.Point(361, 164);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(50, 16);
            this.ciudad.TabIndex = 1;
            this.ciudad.Text = "Ciudad";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(623, 164);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(35, 16);
            this.tipo.TabIndex = 2;
            this.tipo.Text = "Tipo";
            // 
            // tituloClientes
            // 
            this.tituloClientes.AutoSize = true;
            this.tituloClientes.Location = new System.Drawing.Point(341, 65);
            this.tituloClientes.Name = "tituloClientes";
            this.tituloClientes.Size = new System.Drawing.Size(100, 16);
            this.tituloClientes.TabIndex = 3;
            this.tituloClientes.Text = "Ingresar Cliente";
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(66, 192);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(135, 22);
            this.textoNombre.TabIndex = 4;
            // 
            // textoCiudad
            // 
            this.textoCiudad.Location = new System.Drawing.Point(321, 192);
            this.textoCiudad.Name = "textoCiudad";
            this.textoCiudad.Size = new System.Drawing.Size(135, 22);
            this.textoCiudad.TabIndex = 5;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(573, 192);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(132, 24);
            this.comboTipo.TabIndex = 6;
            // 
            // botonEnviar
            // 
            this.botonEnviar.Location = new System.Drawing.Point(355, 298);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(75, 23);
            this.botonEnviar.TabIndex = 7;
            this.botonEnviar.Text = "Aceptar";
            this.botonEnviar.UseVisualStyleBackColor = true;
            this.botonEnviar.Click += new System.EventHandler(this.botonEnviar_Click);
            // 
            // IngresoClientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonEnviar);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.textoCiudad);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.tituloClientes);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.nombre);
            this.Name = "IngresoClientecs";
            this.Text = "IngresoClientecs";
            this.Load += new System.EventHandler(this.IngresoClientecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label ciudad;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label tituloClientes;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.TextBox textoCiudad;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Button botonEnviar;
    }
}