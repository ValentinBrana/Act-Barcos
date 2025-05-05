using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Barcos
{
    public class Barcos
    {
        private static List<Barcos> barquitos = new List<Barcos>();
        private double cargamento;
        private int tripulacion;

        public static List<Barcos> Barquitos { get => barquitos; set => barquitos = value; }
        public double Cargamento { get => cargamento; set => cargamento = value; }
        public int Tripulacion { get => tripulacion; set => tripulacion = value; }

        public Barcos(double cargamento, int tripulacion)
        {
            this.cargamento = cargamento;
            this.tripulacion = tripulacion;
        }

        public Barcos()
        {
            cargamento = 0;
            tripulacion = 0;
        }

        public void Guardar()
        {
            Barcos.Barquitos.Add(this);
        }
        public static Barcos Seleccionar(List<Barcos> lista)
        {
            Console.WriteLine("Seleccione el barco que quiera saquear:");
            int i = 1;
            foreach (Barcos x in lista)
            {
                Console.WriteLine("Barco " + i);
                i++;
            }

            int numSel = int.Parse(Console.ReadLine());
            return lista[numSel - 1];
        }



        public static bool valeLaPenaSaquear(List<Barcos> lista)
        {
            Barcos barcoSeleccionado = Seleccionar(lista);

            if ((barcoSeleccionado.cargamento - barcoSeleccionado.tripulacion) > 20)
                return true;
            else
                return false;
        }
    }
}
    

