int multiplicacion;


Console.WriteLine("*|   1  2  3  4  5  6  7  8  9 10");
Console.WriteLine("---------------------------------");
for (int i = 1; i < 10; i++)
{
    Console.Write(i + "| ");
    for (int j = 1; j < 11; j++)
    {
        multiplicacion = i * j;

        switch(multiplicacion.ToString().Length)
        {
            case 3:
                Console.Write("{0}", multiplicacion);
                break;
            case 2:
                Console.Write(" {0}", multiplicacion);
                break;
            case 1:
                Console.Write("  {0}", multiplicacion);
                break;
            case 0:
                Console.Write("   {0}", multiplicacion);
                break;
            default:
                Console.Write("   {0}", multiplicacion);
                break;
        }
        

    }
    Console.WriteLine();
}

