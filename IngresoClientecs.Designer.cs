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
            this.nombre.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(80, 153);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(99, 27);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // ciudad
            // 
            this.ciudad.AutoSize = true;
            this.ciudad.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad.Location = new System.Drawing.Point(342, 162);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(99, 27);
            this.ciudad.TabIndex = 1;
            this.ciudad.Text = "Ciudad";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(602, 162);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(59, 27);
            this.tipo.TabIndex = 2;
            this.tipo.Text = "Tipo";
            // 
            // tituloClientes
            // 
            this.tituloClientes.AutoSize = true;
            this.tituloClientes.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloClientes.Location = new System.Drawing.Point(260, 32);
            this.tituloClientes.Name = "tituloClientes";
            this.tituloClientes.Size = new System.Drawing.Size(272, 36);
            this.tituloClientes.TabIndex = 3;
            this.tituloClientes.Text = "Ingresar Cliente";
            // 
            // textoNombre
            // 
            this.textoNombre.BackColor = System.Drawing.Color.PeachPuff;
            this.textoNombre.Location = new System.Drawing.Point(66, 192);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(135, 22);
            this.textoNombre.TabIndex = 4;
            // 
            // textoCiudad
            // 
            this.textoCiudad.BackColor = System.Drawing.Color.PeachPuff;
            this.textoCiudad.Location = new System.Drawing.Point(321, 192);
            this.textoCiudad.Name = "textoCiudad";
            this.textoCiudad.Size = new System.Drawing.Size(135, 22);
            this.textoCiudad.TabIndex = 5;
            // 
            // comboTipo
            // 
            this.comboTipo.BackColor = System.Drawing.Color.PeachPuff;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Normal",
            "Premium"});
            this.comboTipo.Location = new System.Drawing.Point(573, 192);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(132, 24);
            this.comboTipo.TabIndex = 6;
            // 
            // botonEnviar
            // 
            this.botonEnviar.BackColor = System.Drawing.Color.SandyBrown;
            this.botonEnviar.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEnviar.Location = new System.Drawing.Point(308, 297);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(169, 48);
            this.botonEnviar.TabIndex = 7;
            this.botonEnviar.Text = "Aceptar";
            this.botonEnviar.UseVisualStyleBackColor = false;
            this.botonEnviar.Click += new System.EventHandler(this.botonEnviar_Click);
            // 
            // IngresoClientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
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