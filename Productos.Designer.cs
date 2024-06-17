namespace SuperCoffeMachine
{
    partial class Productos
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
            this.productoTitulo = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.costoLabel = new System.Windows.Forms.Label();
            this.textoProducto = new System.Windows.Forms.TextBox();
            this.textoStock = new System.Windows.Forms.TextBox();
            this.textoPrecio = new System.Windows.Forms.TextBox();
            this.agregarProductoBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productoTitulo
            // 
            this.productoTitulo.AutoSize = true;
            this.productoTitulo.Location = new System.Drawing.Point(321, 63);
            this.productoTitulo.Name = "productoTitulo";
            this.productoTitulo.Size = new System.Drawing.Size(120, 16);
            this.productoTitulo.TabIndex = 0;
            this.productoTitulo.Text = "Ingresar Productos";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(51, 163);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(132, 16);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre de Producto";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(341, 163);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(78, 16);
            this.stockLabel.TabIndex = 2;
            this.stockLabel.Text = "Stock Inicial";
            // 
            // costoLabel
            // 
            this.costoLabel.AutoSize = true;
            this.costoLabel.Location = new System.Drawing.Point(626, 163);
            this.costoLabel.Name = "costoLabel";
            this.costoLabel.Size = new System.Drawing.Size(46, 16);
            this.costoLabel.TabIndex = 3;
            this.costoLabel.Text = "Precio";
            // 
            // textoProducto
            // 
            this.textoProducto.Location = new System.Drawing.Point(73, 204);
            this.textoProducto.Name = "textoProducto";
            this.textoProducto.Size = new System.Drawing.Size(100, 22);
            this.textoProducto.TabIndex = 4;
            // 
            // textoStock
            // 
            this.textoStock.Location = new System.Drawing.Point(324, 204);
            this.textoStock.Name = "textoStock";
            this.textoStock.Size = new System.Drawing.Size(117, 22);
            this.textoStock.TabIndex = 5;
            // 
            // textoPrecio
            // 
            this.textoPrecio.Location = new System.Drawing.Point(599, 204);
            this.textoPrecio.Name = "textoPrecio";
            this.textoPrecio.Size = new System.Drawing.Size(122, 22);
            this.textoPrecio.TabIndex = 6;
            // 
            // agregarProductoBoton
            // 
            this.agregarProductoBoton.Location = new System.Drawing.Point(344, 308);
            this.agregarProductoBoton.Name = "agregarProductoBoton";
            this.agregarProductoBoton.Size = new System.Drawing.Size(75, 23);
            this.agregarProductoBoton.TabIndex = 7;
            this.agregarProductoBoton.Text = "Agregar";
            this.agregarProductoBoton.UseVisualStyleBackColor = true;
            this.agregarProductoBoton.Click += new System.EventHandler(this.agregarProductoBoton_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregarProductoBoton);
            this.Controls.Add(this.textoPrecio);
            this.Controls.Add(this.textoStock);
            this.Controls.Add(this.textoProducto);
            this.Controls.Add(this.costoLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.productoTitulo);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productoTitulo;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label costoLabel;
        private System.Windows.Forms.TextBox textoProducto;
        private System.Windows.Forms.TextBox textoStock;
        private System.Windows.Forms.TextBox textoPrecio;
        private System.Windows.Forms.Button agregarProductoBoton;
    }
}