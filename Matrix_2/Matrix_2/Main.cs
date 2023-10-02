using Matrix_2;
using System;
using System.Data;
using System.Numerics;
using System.Threading;


namespace Matrix_2
{

    class main
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int dimension = 15, contador = 0, personas = 35;
            Boolean repetir = true;

            // Inicializar el tablero con las personas y sus posiciones iniciales
            Persona?[,] tablero = Funciones.inicializarTablero(personas, dimension);

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
            Funciones.bienvenida();

            while (repetir)
            {
                contador++;

                // Acciones de los personajes
                tablero = Funciones.accionPeresonajes(tablero);

                // Acciones de Smith
                if (contador % 2 == 0)
                {
                    // Limpiar la antigua posición de Smith
                    tablero[smith.ubicacionx, smith.ubicaciony] = null;

                    // Mover a Smith hacia Neo
                    smith = Funciones.movimientoSmith(smith, neo);

                    // Colocar a Smith en su nueva ubicación
                    tablero[smith.ubicacionx, smith.ubicaciony] = smith;

                    // Comprobar si Neo y Smith están en la misma casilla (colisión)
                    if (Funciones.mismaCasilla(neo, smith))
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
                        Funciones.neoElegido(tablero, neo);
                        tablero[neo.ubicacionx, neo.ubicaciony] = Persona.generar();
                    }

                    // Mover a Neo
                    neo = Funciones.movimientoNeo(tablero, neo);

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
            Funciones.despedida();
        }
    }
}