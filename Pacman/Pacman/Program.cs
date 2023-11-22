using Pacman;
using System;


class Program
{
    static void Main(string[] args)
    {
        int[,] tableroSolucion = Tablero.generarTablero(); ;

        Console.WriteLine("Creado :)");

        Tablero.MostrarTablero(tableroSolucion, tableroSolucion);


    }
}