using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {

            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(tbModelo.Text);
            int año = Convert.ToInt32(tbAño.Text);
            double valor = Convert.ToDouble(tbValorFabricacion.Text);
            double tasa = Convert.ToDouble(tbTasaDepre.Text);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);

            //NO MORE ! 
            //formResultados.lbResultados.Items.Add("Marca: " + marca + ". Modelo: " + modelo + ". Valor Fabricacion: " + valor + ". Depreciacion lineal:$ " + ". Depreciacion anual:$ ");

            //instaciacion / creacion del objeto
            Moto m = new Moto(marca, modelo, valor);

            //instaciacion / creacion de ventana modal
            Resultados formResultados = new Resultados();

            formResultados.lbResultados.Items.Add(m.VerDescripcion());

            double valorLineal = m.DepreciacionLineal(año, vidaUtil);
            formResultados.lbResultados.Items.Add($"Depreciacion lineal: {valorLineal}");

            double valorAnual = m.DepreciacionAnual(año, tasa);
            formResultados.lbResultados.Items.Add($"Depreciacion Anual:{valorAnual}");

            formResultados.ShowDialog();
           



        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
           //Dispose();
            Close();

        }
    }
}
