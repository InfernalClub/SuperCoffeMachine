namespace SuperCoffeMachine
{
    partial class ModificarProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.listaProductos = new System.Windows.Forms.ComboBox();
            this.StockLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stockActual = new System.Windows.Forms.TextBox();
            this.nuevoStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precioActualBox = new System.Windows.Forms.TextBox();
            this.nuevoPrecioBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.actualizarStockBoton = new System.Windows.Forms.Button();
            this.precioActualizarBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // listaProductos
            // 
            this.listaProductos.FormattingEnabled = true;
            this.listaProductos.Location = new System.Drawing.Point(71, 133);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.Size = new System.Drawing.Size(121, 24);
            this.listaProductos.TabIndex = 1;
            this.listaProductos.SelectedIndexChanged += new System.EventHandler(this.listaProductos_SelectedIndexChanged);
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Location = new System.Drawing.Point(355, 94);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(81, 16);
            this.StockLabel.TabIndex = 2;
            this.StockLabel.Text = "Stock Actual";
            this.StockLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock Nuevo";
            // 
            // stockActual
            // 
            this.stockActual.Location = new System.Drawing.Point(358, 133);
            this.stockActual.Name = "stockActual";
            this.stockActual.ReadOnly = true;
            this.stockActual.Size = new System.Drawing.Size(100, 22);
            this.stockActual.TabIndex = 4;
            // 
            // nuevoStock
            // 
            this.nuevoStock.Location = new System.Drawing.Point(358, 239);
            this.nuevoStock.Name = "nuevoStock";
            this.nuevoStock.Size = new System.Drawing.Size(100, 22);
            this.nuevoStock.TabIndex = 5;
            this.nuevoStock.TextChanged += new System.EventHandler(this.nuevoStock_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio Actual";
            // 
            // precioActualBox
            // 
            this.precioActualBox.Location = new System.Drawing.Point(631, 133);
            this.precioActualBox.Name = "precioActualBox";
            this.precioActualBox.ReadOnly = true;
            this.precioActualBox.Size = new System.Drawing.Size(100, 22);
            this.precioActualBox.TabIndex = 7;
            // 
            // nuevoPrecioBox
            // 
            this.nuevoPrecioBox.Location = new System.Drawing.Point(631, 239);
            this.nuevoPrecioBox.Name = "nuevoPrecioBox";
            this.nuevoPrecioBox.Size = new System.Drawing.Size(100, 22);
            this.nuevoPrecioBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio Nuevo";
            // 
            // actualizarStockBoton
            // 
            this.actualizarStockBoton.Location = new System.Drawing.Point(364, 314);
            this.actualizarStockBoton.Name = "actualizarStockBoton";
            this.actualizarStockBoton.Size = new System.Drawing.Size(101, 23);
            this.actualizarStockBoton.TabIndex = 10;
            this.actualizarStockBoton.Text = "Actualizar";
            this.actualizarStockBoton.UseVisualStyleBackColor = true;
            this.actualizarStockBoton.Click += new System.EventHandler(this.actualizarStockBoton_Click);
            // 
            // precioActualizarBoton
            // 
            this.precioActualizarBoton.Location = new System.Drawing.Point(634, 314);
            this.precioActualizarBoton.Name = "precioActualizarBoton";
            this.precioActualizarBoton.Size = new System.Drawing.Size(97, 23);
            this.precioActualizarBoton.TabIndex = 11;
            this.precioActualizarBoton.Text = "Actualizar";
            this.precioActualizarBoton.UseVisualStyleBackColor = true;
            this.precioActualizarBoton.Click += new System.EventHandler(this.precioActualizarBoton_Click);
            // 
            // ModificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.precioActualizarBoton);
            this.Controls.Add(this.actualizarStockBoton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nuevoPrecioBox);
            this.Controls.Add(this.precioActualBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nuevoStock);
            this.Controls.Add(this.stockActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.listaProductos);
            this.Controls.Add(this.label1);
            this.Name = "ModificarProductos";
            this.Text = "ModificarProductos";
            this.Load += new System.EventHandler(this.ModificarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaProductos;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockActual;
        private System.Windows.Forms.TextBox nuevoStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precioActualBox;
        private System.Windows.Forms.TextBox nuevoPrecioBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button actualizarStockBoton;
        private System.Windows.Forms.Button precioActualizarBoton;
    }
}