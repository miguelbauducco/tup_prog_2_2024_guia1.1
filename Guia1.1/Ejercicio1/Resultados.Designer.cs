namespace Ejercicio1
{
    partial class Resultados
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
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(52, 79);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(578, 95);
            this.lbResultados.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(281, 203);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(116, 60);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 316);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbResultados);
            this.Controls.Add(this.label1);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lbResultados;
        public System.Windows.Forms.Button btnCerrar;
    }
}