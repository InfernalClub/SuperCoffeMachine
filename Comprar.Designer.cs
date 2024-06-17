namespace SuperCoffeMachine
{
    partial class Comprar
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stockActual = new System.Windows.Forms.TextBox();
            this.precioActual = new System.Windows.Forms.TextBox();
            this.cantidadCompra = new System.Windows.Forms.TextBox();
            this.botonAniadir = new System.Windows.Forms.Button();
            this.listaVenta = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonPagar = new System.Windows.Forms.Button();
            this.costoLabel = new System.Windows.Forms.Label();
            this.valorFinal = new System.Windows.Forms.Label();
            this.PrecioFinalOrden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(65, 82);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(99, 16);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Elegir Producto";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(348, 27);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(123, 16);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Comprar Productos";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad a comprar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // stockActual
            // 
            this.stockActual.Location = new System.Drawing.Point(290, 117);
            this.stockActual.Name = "stockActual";
            this.stockActual.ReadOnly = true;
            this.stockActual.Size = new System.Drawing.Size(100, 22);
            this.stockActual.TabIndex = 6;
            this.stockActual.TextChanged += new System.EventHandler(this.stockActual_TextChanged);
            // 
            // precioActual
            // 
            this.precioActual.Location = new System.Drawing.Point(430, 116);
            this.precioActual.Name = "precioActual";
            this.precioActual.ReadOnly = true;
            this.precioActual.Size = new System.Drawing.Size(100, 22);
            this.precioActual.TabIndex = 7;
            // 
            // cantidadCompra
            // 
            this.cantidadCompra.Location = new System.Drawing.Point(570, 114);
            this.cantidadCompra.Name = "cantidadCompra";
            this.cantidadCompra.Size = new System.Drawing.Size(100, 22);
            this.cantidadCompra.TabIndex = 8;
            // 
            // botonAniadir
            // 
            this.botonAniadir.Location = new System.Drawing.Point(351, 173);
            this.botonAniadir.Name = "botonAniadir";
            this.botonAniadir.Size = new System.Drawing.Size(75, 23);
            this.botonAniadir.TabIndex = 9;
            this.botonAniadir.Text = "Añadir";
            this.botonAniadir.UseVisualStyleBackColor = true;
            this.botonAniadir.Click += new System.EventHandler(this.botonAniadir_Click);
            // 
            // listaVenta
            // 
            this.listaVenta.AutoSize = true;
            this.listaVenta.Location = new System.Drawing.Point(50, 239);
            this.listaVenta.Name = "listaVenta";
            this.listaVenta.Size = new System.Drawing.Size(139, 16);
            this.listaVenta.TabIndex = 10;
            this.listaVenta.Text = "Productos Agregados";
            this.listaVenta.Click += new System.EventHandler(this.listaVenta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(493, 130);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // botonPagar
            // 
            this.botonPagar.Location = new System.Drawing.Point(631, 348);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(75, 23);
            this.botonPagar.TabIndex = 12;
            this.botonPagar.Text = "Pagar";
            this.botonPagar.UseVisualStyleBackColor = true;
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // costoLabel
            // 
            this.costoLabel.AutoSize = true;
            this.costoLabel.Location = new System.Drawing.Point(628, 283);
            this.costoLabel.Name = "costoLabel";
            this.costoLabel.Size = new System.Drawing.Size(79, 16);
            this.costoLabel.TabIndex = 13;
            this.costoLabel.Text = "Costo Total:";
            // 
            // valorFinal
            // 
            this.valorFinal.AutoSize = true;
            this.valorFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorFinal.Location = new System.Drawing.Point(796, 9);
            this.valorFinal.Name = "valorFinal";
            this.valorFinal.Size = new System.Drawing.Size(2, 18);
            this.valorFinal.TabIndex = 14;
            this.valorFinal.Click += new System.EventHandler(this.valorFinal_Click);
            // 
            // PrecioFinalOrden
            // 
            this.PrecioFinalOrden.Location = new System.Drawing.Point(618, 302);
            this.PrecioFinalOrden.Name = "PrecioFinalOrden";
            this.PrecioFinalOrden.ReadOnly = true;
            this.PrecioFinalOrden.Size = new System.Drawing.Size(100, 22);
            this.PrecioFinalOrden.TabIndex = 15;
            this.PrecioFinalOrden.TextChanged += new System.EventHandler(this.PrecioFinalOrden_TextChanged);
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrecioFinalOrden);
            this.Controls.Add(this.valorFinal);
            this.Controls.Add(this.costoLabel);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listaVenta);
            this.Controls.Add(this.botonAniadir);
            this.Controls.Add(this.cantidadCompra);
            this.Controls.Add(this.precioActual);
            this.Controls.Add(this.stockActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.nombreLabel);
            this.Name = "Comprar";
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.Comprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockActual;
        private System.Windows.Forms.TextBox precioActual;
        private System.Windows.Forms.TextBox cantidadCompra;
        private System.Windows.Forms.Button botonAniadir;
        private System.Windows.Forms.Label listaVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonPagar;
        private System.Windows.Forms.Label costoLabel;
        private System.Windows.Forms.Label valorFinal;
        private System.Windows.Forms.TextBox PrecioFinalOrden;
    }
}