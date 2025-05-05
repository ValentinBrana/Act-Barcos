using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Barcos
{
    public class Tanques
    {
        private static List<Tanques> tanquecitos = new List<Tanques>();
        private string nombre;
        private string pais;
        private int anio;
        private int peso;
        private List<string> aliados;

        public static List<Tanques> Tanquecitos { get => tanquecitos; set => tanquecitos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Anio { get => anio; set => anio = value; }
        public int Peso { get => peso; set => peso = value; }
        public List<string> Aliados { get => aliados; set => aliados = value; }

        public Tanques(string nombre, string pais, int anio, int peso, List<string> aliados)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.anio = anio;
            this.peso = peso;
            this.aliados = aliados;
        }

        public Tanques()
        {
            nombre = string.Empty;
            pais = string.Empty;
            anio = 0;
            peso = 0;
            aliados = new List<string>();
        }

        public void Guardar()
        {
            Tanques.Tanquecitos.Add(this);
        }

        private string MostrarDatos()
        {
            return " Nombre: " + this.Nombre + " Pais: " + this.pais + " Año: " + this.anio + " Peso: " + this.peso;
        }

        public static Tanques Seleccionar(List<Tanques> lista)
        {
            Console.WriteLine("\nSeleccione el barco que quiera saquear:");
            int i = 1;
            foreach (Tanques x in lista)
            {
                Console.WriteLine("Tanque " + i + "- " + x.nombre);
                i++;
            }

            int numSel = int.Parse(Console.ReadLine());
            return lista[numSel - 1];
        }


        public static void Batalla(List<Tanques> lista)
        {
            Tanques primerTanque = Seleccionar(lista);
            Tanques segundoTanque;
            do
            {
                Console.WriteLine("Seleccione el segundo tanque:");
                segundoTanque = Seleccionar(lista);

                if (primerTanque == segundoTanque)
                    Console.WriteLine("No puedes seleccionar el mismo tanque. Eligi uno diferente.");
            }
            while (primerTanque == segundoTanque);

            Console.WriteLine("Reglas: " + " Tanque con mayor peso que el otro suma 1 punto." + " Tanque con año mas actual que el otro suma un punto.");

            Console.WriteLine("Primer tanque:");
            Console.WriteLine(primerTanque.MostrarDatos());

            Console.WriteLine("Segundo tanque:");
            Console.WriteLine(segundoTanque.MostrarDatos());

            int puntosTanque = 0;
            int puntos2doTanque = 0;

            if (primerTanque.anio > segundoTanque.anio)
                puntosTanque++;
            else if (segundoTanque.anio > primerTanque.anio)
                puntos2doTanque++;

            if (primerTanque.peso > segundoTanque.peso)
                puntosTanque++;
            else if (segundoTanque.peso > primerTanque.peso)
                puntos2doTanque++;

            Console.WriteLine("Resultado de la batalla:");
            if (puntosTanque > puntos2doTanque)
                Console.WriteLine("Gana el tanque " + primerTanque.nombre);
            else if (puntos2doTanque > puntosTanque)
                Console.WriteLine("Gana el tanque " + segundoTanque.nombre);
            else
                Console.WriteLine("Empate!");
        }
    }
}
