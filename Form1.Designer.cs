namespace SuperCoffeMachine
{
    partial class Form1
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
            this.CLIENTE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonProductos = new System.Windows.Forms.Button();
            this.MENU = new System.Windows.Forms.Label();
            this.botonVentas = new System.Windows.Forms.Button();
            this.Ventas = new System.Windows.Forms.Label();
            this.botonClientes = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Label();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CLIENTE
            // 
            this.CLIENTE.AutoSize = true;
            this.CLIENTE.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTE.Location = new System.Drawing.Point(132, 159);
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Size = new System.Drawing.Size(101, 27);
            this.CLIENTE.TabIndex = 1;
            this.CLIENTE.Text = "Clientes";
            this.CLIENTE.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Productos";
            // 
            // botonProductos
            // 
            this.botonProductos.BackColor = System.Drawing.Color.SandyBrown;
            this.botonProductos.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonProductos.Location = new System.Drawing.Point(364, 209);
            this.botonProductos.Name = "botonProductos";
            this.botonProductos.Size = new System.Drawing.Size(98, 32);
            this.botonProductos.TabIndex = 3;
            this.botonProductos.Text = "Ver";
            this.botonProductos.UseVisualStyleBackColor = false;
            this.botonProductos.Click += new System.EventHandler(this.botonProductos_Click);
            // 
            // MENU
            // 
            this.MENU.AutoSize = true;
            this.MENU.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU.Location = new System.Drawing.Point(238, 54);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(334, 36);
            this.MENU.TabIndex = 4;
            this.MENU.Text = "MENÚ PRINCIPAL";
            // 
            // botonVentas
            // 
            this.botonVentas.BackColor = System.Drawing.Color.SandyBrown;
            this.botonVentas.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVentas.Location = new System.Drawing.Point(606, 208);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Size = new System.Drawing.Size(94, 33);
            this.botonVentas.TabIndex = 5;
            this.botonVentas.Text = "Ver";
            this.botonVentas.UseVisualStyleBackColor = false;
            this.botonVentas.Click += new System.EventHandler(this.botonVentas_Click);
            // 
            // Ventas
            // 
            this.Ventas.AutoSize = true;
            this.Ventas.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.Location = new System.Drawing.Point(601, 159);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(87, 27);
            this.Ventas.TabIndex = 6;
            this.Ventas.Text = "Ventas";
            this.Ventas.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // botonClientes
            // 
            this.botonClientes.BackColor = System.Drawing.Color.SandyBrown;
            this.botonClientes.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonClientes.Location = new System.Drawing.Point(137, 208);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(106, 33);
            this.botonClientes.TabIndex = 7;
            this.botonClientes.Text = "Ver";
            this.botonClientes.UseVisualStyleBackColor = false;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSize = true;
            this.Eliminar.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(139, 286);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(115, 27);
            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "Eliminar";
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.SandyBrown;
            this.botonEliminar.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(144, 327);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(106, 34);
            this.botonEliminar.TabIndex = 9;
            this.botonEliminar.Text = "Ver";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.botonClientes);
            this.Controls.Add(this.Ventas);
            this.Controls.Add(this.botonVentas);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.botonProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLIENTE);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CLIENTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonProductos;
        private System.Windows.Forms.Label MENU;
        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Label Ventas;
        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Label Eliminar;
        private System.Windows.Forms.Button botonEliminar;
    }
}

