namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFabricacion = new System.Windows.Forms.TextBox();
            this.tbTasaDepre = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año a calcular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tasa de depreciacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vida util (años) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor de fabricacion $";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(171, 46);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 7;
            // 
            // tbValorFabricacion
            // 
            this.tbValorFabricacion.Location = new System.Drawing.Point(171, 181);
            this.tbValorFabricacion.Name = "tbValorFabricacion";
            this.tbValorFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbValorFabricacion.TabIndex = 8;
            // 
            // tbTasaDepre
            // 
            this.tbTasaDepre.Location = new System.Drawing.Point(456, 75);
            this.tbTasaDepre.Name = "tbTasaDepre";
            this.tbTasaDepre.Size = new System.Drawing.Size(100, 20);
            this.tbTasaDepre.TabIndex = 9;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(456, 136);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 10;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(171, 91);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 20);
            this.tbModelo.TabIndex = 11;
            // 
            // tbAño
            // 
            this.tbAño.AllowDrop = true;
            this.tbAño.Location = new System.Drawing.Point(171, 136);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(100, 20);
            this.tbAño.TabIndex = 12;
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(155, 264);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(116, 60);
            this.btnCalcularCosto.TabIndex = 13;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(371, 264);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(116, 60);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 381);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbTasaDepre);
            this.Controls.Add(this.tbValorFabricacion);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbMarca;
        public System.Windows.Forms.TextBox tbValorFabricacion;
        public System.Windows.Forms.TextBox tbTasaDepre;
        public System.Windows.Forms.TextBox tbVidaUtil;
        public System.Windows.Forms.TextBox tbModelo;
        public System.Windows.Forms.TextBox tbAño;
        public System.Windows.Forms.Button btnCalcularCosto;
        public System.Windows.Forms.Button btnCerrar;
    }
}

