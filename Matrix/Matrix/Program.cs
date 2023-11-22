
class Program
{

    //Objeto random

    public static Random rnd = new Random();
    static void Main(string[] args)
    {
        int dimension = 15, contador = 0, personas = 35;
        Boolean repetir = true;

        // Inicializar el tablero con las personas y sus posiciones iniciales
        Persona?[,] tablero = inicializarTablero(personas, dimension);

        // Crear instancias de Neo y Smith
        Neo neo = new Neo();
        Smith smith = new Smith();

        // Asignar ubicaciones aleatorias para Neo y Smith en el tablero
        neo.ubicacionx = rnd.Next(1, dimension - 1);
        neo.ubicaciony = rnd.Next(1, dimension - 1);

        smith.ubicacionx = rnd.Next(1, dimension - 1);
        smith.ubicaciony = rnd.Next(1, dimension - 1);

        // Colocar a Neo y Smith en el tablero
        tablero[neo.ubicacionx, neo.ubicaciony] = neo;
        tablero[smith.ubicacionx, smith.ubicaciony] = smith;

        // Mostrar mensaje de bienvenida
        bienvenida();

        while (repetir)
        {
            contador++;

            // Acciones de los personajes
            tablero = accionPeresonajes(tablero);

            // Acciones de Smith
            if (contador % 2 == 0)
            {
                // Limpiar la antigua posición de Smith
                tablero[smith.ubicacionx, smith.ubicaciony] = null;

                // Mover a Smith hacia Neo
                smith = movimientoSmith(smith, neo);

                // Colocar a Smith en su nueva ubicación
                tablero[smith.ubicacionx, smith.ubicaciony] = smith;

                // Comprobar si Neo y Smith están en la misma casilla (colisión)
                if (mismaCasilla(neo, smith))
                {
                    // Si colisionan, Smith atrapa a Neo y el juego termina
                    tablero[neo.ubicacionx, neo.ubicaciony] = smith;
                    repetir = false;
                    Console.WriteLine();
                    Console.WriteLine("!!! Smith atrapó a Neo !!!");
                    Console.WriteLine();
                }
            }

            // Acciones de Neo
            if (contador % 5 == 0 && repetir == true)
            {
                // Limpiar la antigua posición de Neo
                tablero[neo.ubicacionx, neo.ubicaciony] = null;

                // Elegir aleatoriamente si Neo será "elegido"
                neo.elegido = rnd.Next(2) == 0;

                if (neo.elegido)
                {
                    // Realizar acciones específicas si Neo es "elegido"
                    neoElegido(tablero, neo);
                    tablero[neo.ubicacionx, neo.ubicaciony] = Persona.generar();
                }

                // Mover a Neo
                neo = movimientoNeo(tablero, neo);

                // Colocar a Neo y Smith en sus nuevas ubicaciones
                tablero[neo.ubicacionx, neo.ubicaciony] = neo;
                tablero[smith.ubicacionx, smith.ubicaciony] = smith;
            }

            // Mostrar información y tablero en consola
            Console.WriteLine("Segundo número: " + contador);
            Console.WriteLine();
            Persona.mostrarTablero(tablero);

            // Esperar un segundo antes de continuar
            Thread.Sleep(1000);
        }

        // Mostrar mensaje de despedida
        despedida();
    }


















    //Clase persona

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

    //Herenciad de clases persona
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

    //Funciones
    private static Boolean mismaCasilla(Persona pers1, Persona pers2)
    {
        Boolean retorno = false;
        if (pers1.ubicacionx == pers2.ubicacionx && pers1.ubicaciony == pers2.ubicaciony)
        {
            retorno = true;
        }
        else
        {
            retorno = false;
        }
        return retorno;
    }

    private static Persona?[,] inicializarTablero(int personas, int dimension)
    {
        Persona?[,] tablero = new Persona?[dimension, dimension];

        for (int i = 0; i < personas; i++)
        {
            Persona pers = Persona.generar();
            tablero[pers.ubicacionx, pers.ubicaciony] = pers;
        }

        return tablero;
    }

    protected static Persona?[,] accionPeresonajes(Persona?[,] tablero)
    {
        for (int j = 0; j < tablero.GetLength(0); j++)
        {
            for (int k = 0; k < tablero.GetLength(1); k++)
            {
                if (tablero[j, k] != null)
                {
                    if (tablero[j, k].getMuerte() > 70 && tablero[j, k].getNombre().ToUpper() != "SMITH" && tablero[j, k].getNombre().ToUpper() != "NEO")
                    {
                        tablero[j, k] = Persona.generar();
                    }
                    else
                    {
                        tablero[j, k].muerte += 10;
                    }
                }
            }
        }

        return tablero;
    }

    protected static Neo movimientoNeo(Persona?[,] tablero, Neo neo)
    {

        int direccion = rnd.Next(1, 5);

        switch (direccion)
        {
            case 1: // Mover hacia arriba
                if (neo.ubicaciony < tablero.GetLength(0))
                {
                    neo.ubicaciony++;
                }
                else
                {
                    neo.ubicaciony--;
                }
                break;
            case 2: // Mover hacia abajo
                if (neo.ubicaciony > 0)
                {
                    neo.ubicaciony--;
                }
                else
                {
                    neo.ubicaciony++;
                }
                break;
            case 3: // Mover hacia la izquierda

                if (neo.ubicacionx > 0)
                {
                    neo.ubicacionx--;
                }
                else
                {
                    neo.ubicacionx++;
                }
                break;
            case 4: // Mover hacia la derecha
                if (neo.ubicacionx < tablero.GetLength(0))
                {
                    neo.ubicacionx++;
                }
                else
                {
                    neo.ubicacionx--;
                }
                break;
            default:
                // En caso de un número no válido, no hacer nada o manejar el error según sea necesario
                break;
        }


        return neo;
    }

    protected static Smith movimientoSmith(Smith smith, Persona neo)
    {


        if (smith.ubicacionx < neo.ubicacionx)
        {
            smith.ubicacionx++;
        }
        else
        {
            smith.ubicacionx--;
        }

        if (smith.ubicaciony < neo.ubicaciony)
        {
            smith.ubicaciony++;
        }
        else
        {
            smith.ubicaciony--;
        }

        return smith;
    }


    protected static Persona?[,] neoElegido(Persona?[,] tablero,Neo neo)
    {
        if (neo.ubicacionx + 1 < tablero.GetLength(0))
        {
            tablero[neo.ubicacionx + 1, neo.ubicaciony] = Persona.generar();
        }
        if (neo.ubicacionx - 1 > 0)
        {
            tablero[neo.ubicacionx - 1, neo.ubicaciony] = Persona.generar();
        }

        if (neo.ubicaciony + 1 < tablero.GetLength(0))
        {
            tablero[neo.ubicacionx, neo.ubicaciony + 1] = Persona.generar();
        }
        if (neo.ubicacionx - 1 > 0)
        {
            tablero[neo.ubicacionx, neo.ubicaciony - 1] = Persona.generar();
        }

        if (neo.ubicacionx + 1 < tablero.GetLength(0) && neo.ubicaciony + 1 < tablero.GetLength(0))
        {
            tablero[neo.ubicacionx + 1, neo.ubicaciony + 1] = Persona.generar();
        }

        if (neo.ubicacionx - 1 > 0 && neo.ubicaciony - 1 > 0)
        {
            tablero[neo.ubicacionx - 1, neo.ubicaciony - 1] = Persona.generar();
        }

        if (neo.ubicacionx + 1 < tablero.GetLength(0) && neo.ubicaciony - 1 > 0)
        {
            tablero[neo.ubicacionx + 1, neo.ubicaciony - 1] = Persona.generar();
        }

        if (neo.ubicacionx - 1 > 0 && neo.ubicaciony + 1 < tablero.GetLength(0))
        {
            tablero[neo.ubicacionx - 1, neo.ubicaciony + 1] = Persona.generar();
        }
        return tablero;
    }

    private static void bienvenida()
    {

        Console.WriteLine(" ____  _                           _     _                   __  __       _        _      ");
        Console.WriteLine("|  _ \\(_)                         (_)   | |                 |  \\/  |     | |      (_)     ");
        Console.WriteLine("| |_) |_  ___ _ ____   _____ _ __  _  __| | ___      __ _   | \\  / | __ _| |_ _ __ ___  __");
        Console.WriteLine("|  _ <| |/ _ \\ '_ \\ \\ / / _ \\ '_ \\| |/ _` |/ _ \\    / _` |  | |\\/| |/ _` | __| '__| \\ \\/ /");
        Console.WriteLine("| |_) | |  __/ | | \\ V /  __/ | | | | (_| | (_) |  | (_| |  | |  | | (_| | |_| |  | |>  < ");
        Console.WriteLine("|____/|_|\\___|_| |_|\\_/ \\___|_| |_|_|\\__,_|\\___/    \\__,_|  |_|  |_|\\__,_|\\__|_|  |_/_/\\_\\");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pulsa cualquier tecla para empezar...");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine();
    }

    private static void despedida()
    {
        Console.WriteLine(" ______ _                          __  ");
        Console.WriteLine(" |  ____(_)                    _    \\ \\ ");
        Console.WriteLine(" | |__   _ _ __               (_)    | |");
        Console.WriteLine(" |  __| | | '_ \\                     | |");
        Console.WriteLine(" | |    | | | | |              _     | |");
        Console.WriteLine(" |_|    |_|_| |_|             (_)    | |");
        Console.WriteLine("                                    /_/ ");

    }
}


