﻿namespace SuperCoffeMachine
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
            this.compraLabel = new System.Windows.Forms.Label();
            this.botonCompras = new System.Windows.Forms.Button();
            this.modificarboton = new System.Windows.Forms.Button();
            this.modificadorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CLIENTE
            // 
            this.CLIENTE.AutoSize = true;

            this.CLIENTE.TabIndex = 1;
            this.CLIENTE.Text = "Ingresar nuevos Clientes";
            this.CLIENTE.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar nuevos Productos";
            // 
            // botonProductos
            // 

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

            this.Ventas.TabIndex = 6;
            this.Ventas.Text = "Ver Estadisticas";
            this.Ventas.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // botonClientes
            // 

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

            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "Eliminar Clientes";
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
            // compraLabel
            // 
            this.compraLabel.AutoSize = true;
            this.compraLabel.Location = new System.Drawing.Point(572, 290);
            this.compraLabel.Name = "compraLabel";
            this.compraLabel.Size = new System.Drawing.Size(171, 16);
            this.compraLabel.TabIndex = 10;
            this.compraLabel.Text = "Realizar una nueva compra";
            this.compraLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // botonCompras
            // 
            this.botonCompras.Location = new System.Drawing.Point(601, 327);
            this.botonCompras.Name = "botonCompras";
            this.botonCompras.Size = new System.Drawing.Size(75, 23);
            this.botonCompras.TabIndex = 11;
            this.botonCompras.Text = "Ver";
            this.botonCompras.UseVisualStyleBackColor = true;
            this.botonCompras.Click += new System.EventHandler(this.botonCompras_Click);
            // 
            // modificarboton
            // 
            this.modificarboton.Location = new System.Drawing.Point(348, 327);
            this.modificarboton.Name = "modificarboton";
            this.modificarboton.Size = new System.Drawing.Size(75, 23);
            this.modificarboton.TabIndex = 12;
            this.modificarboton.Text = "Ver";
            this.modificarboton.UseVisualStyleBackColor = true;
            this.modificarboton.Click += new System.EventHandler(this.modificarboton_Click);
            // 
            // modificadorLabel
            // 
            this.modificadorLabel.AutoSize = true;
            this.modificadorLabel.Location = new System.Drawing.Point(320, 290);
            this.modificadorLabel.Name = "modificadorLabel";
            this.modificadorLabel.Size = new System.Drawing.Size(126, 16);
            this.modificadorLabel.TabIndex = 13;
            this.modificadorLabel.Text = "Modificar Productos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modificadorLabel);
            this.Controls.Add(this.modificarboton);
            this.Controls.Add(this.botonCompras);
            this.Controls.Add(this.compraLabel);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label compraLabel;
        private System.Windows.Forms.Button botonCompras;
        private System.Windows.Forms.Button modificarboton;
        private System.Windows.Forms.Label modificadorLabel;
    }
}

