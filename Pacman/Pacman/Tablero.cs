using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Tablero
    {
        public static Random rnd = new Random();
        public static int[,] generarTablero()
        {

            int dimension = 10;

            // Tablero
            int[,] tablero = new int[dimension, dimension];

            // Variables

            int casillaX, casillaY;
            Boolean horizontal,repetir=true;

            // Barco  1 de 4 casillas

            casillaX = rnd.Next(0, dimension);
            casillaY = rnd.Next(0, dimension);
            horizontal = (rnd.Next(0,1)==0);

            if (horizontal)
            {
                if (casillaX+4>10)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        tablero[casillaX - i, casillaY] = 1;
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        tablero[casillaX + i, casillaY] = 1;
                    }
                }
            } else
            {
                if (casillaY + 4 > 10)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        tablero[casillaX, casillaY - i] = 1;
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        tablero[casillaX, casillaY + i] = 1;
                    }
                }
            }

            // Barcos 2 de 3 casillas

            horizontal = (rnd.Next(0, 2) == 0);


            for (int i = 0; i < 2; i++)
            {
                while (repetir)
                {
                    casillaX = rnd.Next(0, dimension);
                    casillaY = rnd.Next(0, dimension);

                    if (horizontal)
                    {
                        // Horizontal

                        if (casillaX+3>10)
                        {
                            // Horizontal derecha

                            if (tablero[casillaX,casillaY]!=1 && tablero[casillaX-1, casillaY] != 1 && tablero[casillaX-2, casillaY] != 1)
                            {
                                tablero[casillaX-0, casillaY] = 1;
                                tablero[casillaX-1, casillaY] = 1;
                                tablero[casillaX-2, casillaY] = 1;

                                new Barco(casillaX-0,casillaY,casillaX-1,casillaY,casillaX-2,casillaY,-1,-1);

                                repetir = false;

                            }


                        }
                        else
                        {
                            // Horizontal izquierda

                            if (tablero[casillaX, casillaY] != 1 && tablero[casillaX + 1, casillaY] != 1 && tablero[casillaX + 2, casillaY] != 1)
                            {
                                tablero[casillaX + 0, casillaY] = 1;
                                tablero[casillaX + 1, casillaY] = 1;
                                tablero[casillaX + 2, casillaY] = 1;

                                new Barco(casillaX + 0, casillaY, casillaX + 1, casillaY, casillaX + 2, casillaY, -1, -1);


                                repetir = false;

                            }

                        }
                    }
                    else
                    {
                        // Vertical

                        if (casillaY + 3 > 10)
                        {
                            // Vertical abajo
                            if (tablero[casillaX, casillaY] != 1 && tablero[casillaX, casillaY - 1] != 1 && tablero[casillaX, casillaY - 2] != 1)
                            {
                                tablero[casillaX, casillaY - 0] = 1;
                                tablero[casillaX, casillaY - 1] = 1;
                                tablero[casillaX, casillaY - 2] = 1;

                                repetir = false;

                            }
                        }
                        else
                        {
                            // Vertical arriba
                            if (tablero[casillaX, casillaY] != 1 && tablero[casillaX, casillaY + 1] != 1 && tablero[casillaX, casillaY + 2] != 1)
                            {
                                tablero[casillaX, casillaY + 0] = 1;
                                tablero[casillaX, casillaY + 1] = 1;
                                tablero[casillaX, casillaY + 2] = 1;

                                repetir = false;

                            }
                        }
                    }

                }

            repetir = true;
            }

            // Barcos 3 de 2 casillas

            horizontal = (rnd.Next(0, 1) == 0);


            for (int i = 0; i < 3; i++)
            {


                while (repetir)
                {
                    casillaX = rnd.Next(0, dimension);
                    casillaY = rnd.Next(0, dimension);

                    if (horizontal)
                    {
                        // Horizontal

                        if (casillaX + 2 > 10)
                        {
                            // Horizontal derecha

                            if (tablero[casillaX, casillaY] != 1 && tablero[casillaX - 1, casillaY] != 1)
                            {
                                tablero[casillaX - 0, casillaY] = 1;
                                tablero[casillaX - 1, casillaY] = 1;

                                repetir = false;

                            }


                        }
                        else
                        {
                            // Horizontal izquierda

                            if (tablero[casillaX, casillaY] != 1 && tablero[casillaX + 1, casillaY] != 1)
                            {
                                tablero[casillaX + 0, casillaY] = 1;
                                tablero[casillaX + 1, casillaY] = 1;

                                repetir = false;

                            }

                        }
                    }
                    else
                    {
                        // Vertical

                        if (casillaY + 2 > 10)
                        {
                            // Vertical abajo
                            if (tablero[casillaX, casillaY] != 1 && tablero[casillaX, casillaY - 1] != 1)
                            {
                                tablero[casillaX, casillaY - 0] = 1;
                                tablero[casillaX, casillaY - 1] = 1;

                                repetir = false;

                            }
                        }
                        else
                        {
                            // Vertical arriba
                            if (tablero[casillaX, casillaY] != 1 && tablero[casillaX, casillaY + 1] != 1)
                            {
                                tablero[casillaX, casillaY + 0] = 1;
                                tablero[casillaX, casillaY + 1] = 1;

                                repetir = false;

                            }
                        }
                    }

                }
                repetir = true;
            }

            // Barcos 4 de 1 casillas

            int contadorCuatro=0;

            while (contadorCuatro<4)
            {
                casillaX = rnd.Next(0, dimension);
                casillaY = rnd.Next(0, dimension);

                if (tablero[casillaX,casillaY]!=1)
                {
                    tablero[casillaX, casillaY]=1;
                    contadorCuatro++;
                }
            }

            return tablero;
        }




        public static void MostrarTablero(int[,] tableroJugador, int[,] tableroSolucion)
        {
            Console.WriteLine("     A   B   C   D   E   F   G   H   I   J");
            
            try
            { 
                for (int i = 0; i < tableroJugador.GetLength(0); i++)
                {

                    Console.Write(i+1);

                    if (i+1<10)
                    {
                        Console.Write("  ");
                    } else
                    {
                        Console.Write(" ");
                    }


                    for (int j = 0; j < tableroJugador.GetLength(1); j++)
                    {
                        ConsoleColor colorAnterior = Console.ForegroundColor; // Guarda el color actual
                        char inicial = ' '; // Inicial por defecto

                    
                        int estado = tableroJugador[i, j];

                        switch (estado)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.White; // Cambia el color a amarillo para NEO
                                break;
                                case 1:

                                if (tableroSolucion[i,j]==0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue; // Cambia el color a amarillo para NEO
                                    inicial = 'O';
                                }

                                if (tableroSolucion[i, j] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red; // Cambia el color a amarillo para NEO
                                    inicial = 'X';
                                }

                                if (tableroSolucion[i, j] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray; // Cambia el color a amarillo para NEO
                                    inicial = 'X';
                                }

                            break;
                        }
                    

                        Console.Write(" [" + inicial + "]");
                        Console.ForegroundColor = colorAnterior; // Restaura el color anterior

                    }
                    Console.WriteLine();
                }
            } catch(Exception ex) {
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static int ParseLetraNumero(char letra)
        {
            char letraMinusc = char.ToLower(letra); // Convertir la letra a minúscula

            switch (letraMinusc)
            {
                case 'a': return 0;
                case 'b': return 1;
                case 'c': return 2;
                case 'd': return 3;
                case 'e': return 4;
                case 'f': return 5;
                case 'g': return 6;
                case 'h': return 7;
                case 'i': return 8;
                case 'j': return 9;
                default: return -1; // Retornar -1 si la letra no está en el rango 'a' - 'j'
            }
        }

    }
}
