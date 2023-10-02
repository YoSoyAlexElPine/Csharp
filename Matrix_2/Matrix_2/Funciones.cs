using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_2
{
    public class Funciones
    {

    static Random rnd = new Random();

        //Funciones

        public static Boolean mismaCasilla(Persona pers1, Persona pers2)
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

        public static Persona?[,] inicializarTablero(int personas, int dimension)
        {
            Persona?[,] tablero = new Persona?[dimension, dimension];

            for (int i = 0; i < personas; i++)
            {
                Persona pers = Persona.generar();
                tablero[pers.ubicacionx, pers.ubicaciony] = pers;
            }

            return tablero;
        }

        public static Persona?[,] accionPeresonajes(Persona?[,] tablero)
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

        public static Neo movimientoNeo(Persona?[,] tablero, Neo neo)
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

        public static Smith movimientoSmith(Smith smith, Persona neo)
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


        public static Persona?[,] neoElegido(Persona?[,] tablero, Neo neo)
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

        public static void bienvenida()
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

        public static void despedida()
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

}

