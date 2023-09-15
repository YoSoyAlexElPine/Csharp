// See httclass Figuras {
class Figuras
{


    public static void a()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("# ");
            }
            Console.WriteLine();
        }
    }

    public static void b()
    {
        for (int i = 9; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("# ");
            }
            Console.WriteLine();
        }
    }

    public static void c()
    {
        int contador = 0, contador2 = 0;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (contador2 > 0)
                {
                    Console.Write("  ");
                    contador2--;
                }
                else
                {
                    Console.Write("# ");
                }

            }
            Console.WriteLine();
            contador++;
            contador2 = contador;
        }
    }

    public static void d()
    {
        int contador = 9, contador2 = 9;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (contador2 > 0)
                {
                    Console.Write("  ");
                    contador2--;
                }
                else
                {
                    Console.Write("# ");
                }

            }
            Console.WriteLine();
            contador--;
            contador2 = contador;
        }
    }
    public static void e()
    {
        for (int i = 0; i < 9; i++)
        {
            if (i == 0 || i == 8)
            {
                for (int i1 = 0; i1 < 9; i1++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            else
            {


                for (int j = 0; j < 9; j++)
                {
                    if (j == 0 || j == 8)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
    public static void f()
    {
        int contador = 0, contador2 = 1;

        for (int i = 0; i < 9; i++)
        {
            if (i == 0 || i == 8)
            {
                for (int i1 = 0; i1 < 9; i1++)
                {
                    Console.Write("# ");
                }
            }
            else

                for (int j = 0; j < 9; j++)
                {
                    contador2--;
                    if (contador2 == -1)
                    {
                        Console.Write("# ");


                    }
                    else
                    {
                        Console.Write("  ");
                    }


                }
            Console.WriteLine();
            contador++;
            contador2 = contador;
        }
    }
    public static void g()
    {
        int espacios = 8, contador2 = 8;

        for (int i = 0; i < 10; i++)
        {
            if (i == 0 || i == 9)
            {
                for (int i1 = 0; i1 < 9; i1++)
                {
                    Console.Write("# ");
                }
            }
            else
            {

                for (int j = 0; j < 9; j++)
                {
                    if (contador2 == 0)
                    {
                        Console.Write("# ");
                        contador2--;

                    }
                    else
                    {
                        Console.Write("  ");
                        contador2--;
                    }
                }
                Console.WriteLine();
                espacios--;
                contador2 = espacios;
            }
        }
    }
    public static void h()
    {
        int espacios = 3, contador2 = 2;
        bool cosa = false;

        for (int i = 0; i < 8; i++)
        {
            if (i == 0 || i == 7)
            {
                for (int i1 = 0; i1 < 7; i1++)
                {
                    Console.Write("# ");
                }
            }
            else
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Math.Abs(contador2) == Math.Abs(espacios))
                    {

                        if (cosa)
                        {
                            Console.Write("# ");

                        }
                        cosa = true;
                        contador2--;

                    }
                    else
                    {
                        Console.Write("  ");
                        contador2--;
                    }
                }
                Console.WriteLine();
                contador2 = 3;
                espacios--;
            }
        }
    }

    public static void i()
    {
        int espacios = 3, contador2 = 2;
        bool cosa = false;

        for (int i = 0; i < 8; i++)
        {
            if (i == 0 || i == 7)
            {
                for (int i1 = 0; i1 < 7; i1++)
                {
                    Console.Write("# ");
                }
            }
            else
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0 || j == 6)
                    {
                        Console.Write("# ");
                    }
                    if (Math.Abs(contador2) == Math.Abs(espacios))
                    {

                        if (cosa)
                        {
                            Console.Write("# ");

                        }
                        cosa = true;
                        contador2--;

                    }
                    else
                    {
                        Console.Write("  ");
                        contador2--;
                    }
                }
                Console.WriteLine();
                contador2 = 3;
                espacios--;
            }
        }
    }
    public static void j()
    {
        int espacios = 0, contador = 0;
        for (int i = 9; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (espacios < contador)
                {
                    espacios++;
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("# ");
                }

            }
            espacios = 0;
            contador++;
            Console.WriteLine();
        }
    }
    public static void k()
    {
        int espacios = 6, contador = 0;
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                if (Math.Abs(espacios) <= Math.Abs(contador))
                {
                    Console.Write("# ");
                }
                else
                {
                    Console.Write("  ");
                }
                espacios--;

            }
            espacios = 6;
            contador++;
            Console.WriteLine();
        }
    }

    public static void l()
    {
        int espacios = 6, contador = 0;
        for (int i = 0; i < 7*2-1; i++)
        {
            if (i<6)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (Math.Abs(espacios) <= Math.Abs(contador))
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    espacios--;

                }
                espacios = 6;
                contador++;
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < 13; j++)
                {
                    if (Math.Abs(espacios) <= Math.Abs(contador))
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    espacios--;

                }
                espacios = 6;
                contador--;
                Console.WriteLine();
            }

        }

    }
}
class Programa
{
    static void Main()
    {
        Figuras.l();
    }
}
