
	public Persona()
	{

        public static Random rnd = new Random();

    public class Persona
    {
        static int id;
        protected string nombre, ciudad;
        protected int edad;
        public int muerte = 0;
        public int ubicacionx = rnd.Next(0, 15), ubicaciony = rnd.Next(0, 15);
        string[] nombres = { "Michelle", "Alexander", "James", "Caroline", "Claire", "Jessica", "Erik", "Mike" };
        string[] ciudades = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };

        public static Persona generar()
        {
            return new Persona();
        }

        public static void mostrarTablero(Persona[,] tablero)
        {
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    ConsoleColor colorAnterior = Console.ForegroundColor; // Guarda el color actual
                    char inicial = ' '; // Inicial por defecto

                    if (tablero[i, j] != null)
                    {
                        string nombre = tablero[i, j].nombre.ToUpper();
                        inicial = nombre[0]; // Obtiene la inicial del nombre

                        switch (inicial)
                        {
                            case 'N':
                                Console.ForegroundColor = ConsoleColor.Yellow; // Cambia el color a amarillo para NEO
                                break;
                            case 'S':
                                Console.ForegroundColor = ConsoleColor.Red; // Cambia el color a rojo para SMITH
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green; // Cambia el color a verde para otras personas
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White; // Cambia el color a blanco para casillas vacías
                    }

                    Console.Write(" [ " + inicial + " ] ");
                    Console.ForegroundColor = colorAnterior; // Restaura el color anterior
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ResetColor(); // Restablece el color de la fuente al predeterminado
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }




        public Persona()
        {
            id++;
            nombre = nombres[rnd.Next(0, nombres.Length)];
            ciudad = ciudades[rnd.Next(0, ciudades.Length)];
            edad = rnd.Next(18, 80);
            muerte = rnd.Next(0, 100);
        }

        public int getMuerte()
        {
            return muerte;
        }

        public string getNombre()
        {
            return nombre;
        }

        Persona solicitar(int dimension, int id)
        {
            return new Persona();
        }

        string imprimir()
        {
            return "id:" + id;
        }
    }

    public class Smith : Persona
    {
        public int infeccion = rnd.Next(1, 5);

        public Smith() : base()
        {
            nombre = "Smith";
            edad = 300;
            ciudad = "New Mexico";
            muerte = 0;
        }
    }

    public class Neo : Persona
    {
        public bool elegido;

        public Neo() : base()
        {
            ciudad = "Lower Downtown, Capital City";
            nombre = "Neo";
            edad = 37;
        }
    }

