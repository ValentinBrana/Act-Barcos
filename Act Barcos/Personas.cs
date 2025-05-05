using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Barcos
{
    public class Personas
    {
        private static List<Personas> persones = new List<Personas>();
        private string nombre;
        private int edad;
        private string genero;

        public static List<Personas> Persones { get => persones; set => persones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }

        public Personas(string nombre, int edad, string genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }

        public Personas()
        {
            nombre = string.Empty;
            edad = 0;
            genero = string.Empty;
        }

        public void Guardar()
        {
            Personas.Persones.Add(this);
        }

        public string Hablar()
        {
            return "Mi nombre es " + this.nombre + ", Soy " + this.genero + " y tengo " + this.edad + " años.";
        }

        public static Personas SeleccionarPersona(List<Personas> lista)
        {
            Console.WriteLine("Seleccione la persona con la que quiera conversar:");
            int i = 1;
            foreach (Personas x in lista)
            {
                Console.WriteLine(i + " - " + x.nombre);
                i++;
            }

            int numSel = int.Parse(Console.ReadLine());
            return lista[numSel - 1];
        }

        public static void HablarCon(List<Personas> lista)
        {
            Personas seleccionado = SeleccionarPersona(lista);

            Console.WriteLine(seleccionado.Hablar());
        }
    }
}
