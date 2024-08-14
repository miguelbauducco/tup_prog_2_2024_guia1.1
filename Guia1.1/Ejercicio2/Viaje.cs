using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Viaje
    {
     
        public int Transportados { get; private set; } 
        public int Asientos { get; private set; }
        public int HDemora { get; private set; }
        public int MDemora { get; private set; }
        public int CantParadas { get; private set; }
        public int HDuracionViaje { get; private set; }
        public int MDuracionViaje { get; private set; }

        public Viaje(int transportados, int asientos, int hDemora, int mDemora, int cantParadas, int hDuracionViaje, int mDuracionViaje) 
        {
            Transportados = transportados;
            Asientos = asientos;    
            HDemora = hDemora;
            MDemora = mDemora;
            CantParadas = cantParadas;
            HDuracionViaje = hDuracionViaje;
            MDuracionViaje = mDuracionViaje;
            
        }

        public void Viaje()










    }
}
