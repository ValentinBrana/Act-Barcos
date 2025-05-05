
using Act_Barcos;

public class Program
    {
        static void Main(string[] args)
        {
            PrecargarDatos();

            int opcion;
            do
            {
                opcion = Menu();

                switch (opcion)
                {
                    case 1:
                        Personas.HablarCon(Personas.Persones);
                        break;
                    case 2:
                        bool estado = Barcos.valeLaPenaSaquear(Barcos.Barquitos);
                        if (estado)
                            Console.WriteLine("Sirve saquear el barco");
                        else
                            Console.WriteLine("No sirve saquear este barco.");
                        break;
                    case 3:
                    Tanques.Batalla(Tanques.Tanquecitos);
                        break;
                    case 4:
                        Bloque.MenuB();
                        break;
                }

                Console.WriteLine("Toque una tecla para continuar");
                Console.Clear();
            } while (opcion != 0);
        }

        private static void PrecargarDatos()
        {
            Tanques t = new Tanques("Panzer", "Argentina", 1993, 4500, new List<string> { "Gaucho", "El pomberito" });
            t.Guardar();

            Tanques t2 = new Tanques("Tigger", "Japon", 1992, 2350, new List<string> { "Naruto", "Goku" });
            t2.Guardar();

            Tanques t3 = new Tanques("M1 Abrams", "Estados Unidos", 2015, 4300, new List<string> { "Obama", "Bush" });
            t3.Guardar();

            Tanques t4 = new Tanques("Challenger", "Alemania", 2011, 7600, new List<string> { "Hitler", "Marx" });
            t4.Guardar();

            Barcos b = new Barcos(100, 20);
            b.Guardar();

            Barcos b2 = new Barcos(20, 10);
            b2.Guardar();

            Barcos b3 = new Barcos(150, 30);
            b3.Guardar();

            Personas p1 = new Personas("Valentin", 21, "Hombre");
            p1.Guardar();

            Personas p2 = new Personas("Juan", 20, "Hombre");
            p2.Guardar();

            Personas p3 = new Personas("Joaquin", 22, "Hombre");
            p3.Guardar();

            Bloque bloque = new Bloque(4, 3, 2);
            bloque.Guardar();

            Bloque bloque2 = new Bloque(4, 4, 4);
            bloque2.Guardar();

            Bloque bloque3 = new Bloque(2, 3, 4);
            bloque3.Guardar();

        }

        private static int Menu()
        {
            int opcion;

            Console.WriteLine("Ingrese el número de la opción y luego enter:\n");
            Console.WriteLine("1  Hablar a:");
            Console.WriteLine("2  Sirve saquear?");
            Console.WriteLine("3  Guerra de tanques.");
            Console.WriteLine("4  Calcular bloque.");

            Console.WriteLine("0 - Salir\n");

            opcion = Validaciones.LeerInt(0, 4);
            return opcion;
        }
    }

