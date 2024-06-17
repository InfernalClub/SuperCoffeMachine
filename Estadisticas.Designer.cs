namespace SuperCoffeMachine
{
    partial class Estadisticas
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
            this.subtitulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridEstadistico = new System.Windows.Forms.DataGridView();
            this.label_2 = new System.Windows.Forms.Label();
            this.elValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstadistico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadisticas generales";
            // 
            // subtitulo
            // 
            this.subtitulo.AutoSize = true;
            this.subtitulo.Location = new System.Drawing.Point(278, 110);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(218, 16);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Productos vendidos ultimos 2 años:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gridEstadistico
            // 
            this.gridEstadistico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstadistico.Location = new System.Drawing.Point(281, 147);
            this.gridEstadistico.Name = "gridEstadistico";
            this.gridEstadistico.RowHeadersWidth = 51;
            this.gridEstadistico.RowTemplate.Height = 24;
            this.gridEstadistico.Size = new System.Drawing.Size(347, 150);
            this.gridEstadistico.TabIndex = 3;
            this.gridEstadistico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEstadistico_CellContentClick);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(92, 356);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(297, 16);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "La cantidad de productos vendidos este año fue:";
            this.label_2.Click += new System.EventHandler(this.label2_Click);
            // 
            // elValor
            // 
            this.elValor.AutoSize = true;
            this.elValor.Location = new System.Drawing.Point(396, 356);
            this.elValor.Name = "elValor";
            this.elValor.Size = new System.Drawing.Size(14, 16);
            this.elValor.TabIndex = 5;
            this.elValor.Text = "0";
            this.elValor.Click += new System.EventHandler(this.elValor_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elValor);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.gridEstadistico);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.subtitulo);
            this.Controls.Add(this.label1);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEstadistico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subtitulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView gridEstadistico;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label elValor;
    }
}