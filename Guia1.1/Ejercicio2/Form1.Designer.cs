namespace Ejercicio2
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
            this.btn1IniciarViaje = new System.Windows.Forms.Button();
            this.btnFinalizarViaje = new System.Windows.Forms.Button();
            this.btn3IngresarParada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbMinutos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1IniciarViaje
            // 
            this.btn1IniciarViaje.Location = new System.Drawing.Point(77, 32);
            this.btn1IniciarViaje.Name = "btn1IniciarViaje";
            this.btn1IniciarViaje.Size = new System.Drawing.Size(427, 23);
            this.btn1IniciarViaje.TabIndex = 0;
            this.btn1IniciarViaje.Text = "Iniciar Viaje";
            this.btn1IniciarViaje.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarViaje
            // 
            this.btnFinalizarViaje.Location = new System.Drawing.Point(319, 231);
            this.btnFinalizarViaje.Name = "btnFinalizarViaje";
            this.btnFinalizarViaje.Size = new System.Drawing.Size(185, 34);
            this.btnFinalizarViaje.TabIndex = 1;
            this.btnFinalizarViaje.Text = "Finalizar Viaje";
            this.btnFinalizarViaje.UseVisualStyleBackColor = true;
            // 
            // btn3IngresarParada
            // 
            this.btn3IngresarParada.Location = new System.Drawing.Point(77, 76);
            this.btn3IngresarParada.Name = "btn3IngresarParada";
            this.btn3IngresarParada.Size = new System.Drawing.Size(427, 23);
            this.btn3IngresarParada.TabIndex = 2;
            this.btn3IngresarParada.Text = "Ingresar Parada";
            this.btn3IngresarParada.UseVisualStyleBackColor = true;
            this.btn3IngresarParada.Click += new System.EventHandler(this.btn3IngresarParada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Finalizar Parada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora de finalizacion (HH:MM)";
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(211, 165);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(45, 20);
            this.tbHoras.TabIndex = 5;
            // 
            // tbMinutos
            // 
            this.tbMinutos.Location = new System.Drawing.Point(278, 165);
            this.tbMinutos.Name = "tbMinutos";
            this.tbMinutos.Size = new System.Drawing.Size(45, 20);
            this.tbMinutos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMinutos);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3IngresarParada);
            this.Controls.Add(this.btnFinalizarViaje);
            this.Controls.Add(this.btn1IniciarViaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1IniciarViaje;
        private System.Windows.Forms.Button btnFinalizarViaje;
        private System.Windows.Forms.Button btn3IngresarParada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.TextBox tbMinutos;
        private System.Windows.Forms.Label label3;
    }
}

