namespace Inventarios
{
    partial class Inventario
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
            this.txtInsBarras = new System.Windows.Forms.TextBox();
            this.labInsCod = new System.Windows.Forms.Label();
            this.textNomPro = new System.Windows.Forms.TextBox();
            this.labNomPro = new System.Windows.Forms.Label();
            this.labArtGondola = new System.Windows.Forms.Label();
            this.LabArtBodega = new System.Windows.Forms.Label();
            this.txtArtGondola = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labCompania = new System.Windows.Forms.Label();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.gbArt = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labTotalArt = new System.Windows.Forms.Label();
            this.gbArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInsBarras
            // 
            this.txtInsBarras.Location = new System.Drawing.Point(118, 57);
            this.txtInsBarras.Name = "txtInsBarras";
            this.txtInsBarras.Size = new System.Drawing.Size(176, 20);
            this.txtInsBarras.TabIndex = 0;
            this.txtInsBarras.TextChanged += new System.EventHandler(this.txtInsBarras_TextChanged);
            // 
            // labInsCod
            // 
            this.labInsCod.AutoSize = true;
            this.labInsCod.Location = new System.Drawing.Point(25, 60);
            this.labInsCod.Name = "labInsCod";
            this.labInsCod.Size = new System.Drawing.Size(87, 13);
            this.labInsCod.TabIndex = 1;
            this.labInsCod.Text = "Código de barras";
            // 
            // textNomPro
            // 
            this.textNomPro.Location = new System.Drawing.Point(118, 83);
            this.textNomPro.Name = "textNomPro";
            this.textNomPro.ReadOnly = true;
            this.textNomPro.Size = new System.Drawing.Size(462, 20);
            this.textNomPro.TabIndex = 2;
            // 
            // labNomPro
            // 
            this.labNomPro.AutoSize = true;
            this.labNomPro.Location = new System.Drawing.Point(25, 86);
            this.labNomPro.Name = "labNomPro";
            this.labNomPro.Size = new System.Drawing.Size(90, 13);
            this.labNomPro.TabIndex = 3;
            this.labNomPro.Text = "Nombre Producto";
            // 
            // labArtGondola
            // 
            this.labArtGondola.AutoSize = true;
            this.labArtGondola.Location = new System.Drawing.Point(6, 29);
            this.labArtGondola.Name = "labArtGondola";
            this.labArtGondola.Size = new System.Drawing.Size(102, 13);
            this.labArtGondola.TabIndex = 4;
            this.labArtGondola.Text = "Artículo en Gondola";
            // 
            // LabArtBodega
            // 
            this.LabArtBodega.AutoSize = true;
            this.LabArtBodega.Location = new System.Drawing.Point(6, 65);
            this.LabArtBodega.Name = "LabArtBodega";
            this.LabArtBodega.Size = new System.Drawing.Size(99, 13);
            this.LabArtBodega.TabIndex = 5;
            this.LabArtBodega.Text = "Artículo en Bodega";
            // 
            // txtArtGondola
            // 
            this.txtArtGondola.Location = new System.Drawing.Point(112, 26);
            this.txtArtGondola.Name = "txtArtGondola";
            this.txtArtGondola.Size = new System.Drawing.Size(111, 20);
            this.txtArtGondola.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 7;
            // 
            // labCompania
            // 
            this.labCompania.AutoSize = true;
            this.labCompania.Location = new System.Drawing.Point(28, 116);
            this.labCompania.Name = "labCompania";
            this.labCompania.Size = new System.Drawing.Size(54, 13);
            this.labCompania.TabIndex = 8;
            this.labCompania.Text = "Compañia";
            // 
            // txtCompania
            // 
            this.txtCompania.Location = new System.Drawing.Point(118, 116);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.ReadOnly = true;
            this.txtCompania.Size = new System.Drawing.Size(462, 20);
            this.txtCompania.TabIndex = 9;
            // 
            // gbArt
            // 
            this.gbArt.Controls.Add(this.labTotalArt);
            this.gbArt.Controls.Add(this.textBox1);
            this.gbArt.Controls.Add(this.txtArtGondola);
            this.gbArt.Controls.Add(this.labArtGondola);
            this.gbArt.Controls.Add(this.LabArtBodega);
            this.gbArt.Controls.Add(this.textBox2);
            this.gbArt.Location = new System.Drawing.Point(118, 155);
            this.gbArt.Name = "gbArt";
            this.gbArt.Size = new System.Drawing.Size(462, 100);
            this.gbArt.TabIndex = 10;
            this.gbArt.TabStop = false;
            this.gbArt.Text = "Conteo de artículos";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(347, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // labTotalArt
            // 
            this.labTotalArt.AutoSize = true;
            this.labTotalArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalArt.Location = new System.Drawing.Point(229, 42);
            this.labTotalArt.Name = "labTotalArt";
            this.labTotalArt.Size = new System.Drawing.Size(113, 17);
            this.labTotalArt.TabIndex = 9;
            this.labTotalArt.Text = "Total Artículos";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 331);
            this.Controls.Add(this.gbArt);
            this.Controls.Add(this.txtCompania);
            this.Controls.Add(this.labCompania);
            this.Controls.Add(this.labNomPro);
            this.Controls.Add(this.textNomPro);
            this.Controls.Add(this.labInsCod);
            this.Controls.Add(this.txtInsBarras);
            this.MinimizeBox = false;
            this.Name = "Inventario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.TopMost = true;
            this.gbArt.ResumeLayout(false);
            this.gbArt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInsBarras;
        private System.Windows.Forms.Label labInsCod;
        private System.Windows.Forms.TextBox textNomPro;
        private System.Windows.Forms.Label labNomPro;
        private System.Windows.Forms.Label labArtGondola;
        private System.Windows.Forms.Label LabArtBodega;
        private System.Windows.Forms.TextBox txtArtGondola;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labCompania;
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.GroupBox gbArt;
        private System.Windows.Forms.Label labTotalArt;
        private System.Windows.Forms.TextBox textBox1;
    }
}