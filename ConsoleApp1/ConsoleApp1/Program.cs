using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        string input = Console.ReadLine();

        int number=0;

        if (int.TryParse(input, out number) && number > 1)
        {
            bool esPrimo = EsPrimo(number);

            if (esPrimo)
            {
                Console.WriteLine($"{number} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{number} no es un número primo.");
            }
        }
        else
        {
            Console.WriteLine("Ingrese un número entero positivo mayor que 1 válido.");
        }
    }

    static bool EsPrimo(int number)
    {
        int cont = 0;
        for (int i = 1; i <=number; i++)
        {
            if (number % i == 0)
            {
                cont++;
            }
        }

        if (cont==2)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
