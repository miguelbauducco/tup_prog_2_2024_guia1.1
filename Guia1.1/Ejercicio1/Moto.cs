using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public class Moto
    {
        //propiedades
        public string Marca { get; private set; }

        public int Modelo { get; private set; }

        public double ValorFabricacion { get; private set; }


        //constructor del objeto
        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;   
            ValorFabricacion= valorFabricacion;

        }

        //METODOS DE LA CLASE
        public string VerDescripcion()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Valor Fabricación:${ValorFabricacion}";
        }

        public double DepreciacionLineal(int año, int vidaUtil) 
        {

            return ValorFabricacion - (ValorFabricacion * (año - Modelo) / vidaUtil);

        }

        public double DepreceacionAnual(int año, double tasa)
        {
            //ESTO ESTA MAL XD

            return ValorFabricacion * (1-tasa);

        }




    }
}
