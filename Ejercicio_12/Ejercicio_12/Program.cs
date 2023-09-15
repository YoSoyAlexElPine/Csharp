int numeroDecimal;

Console.Write("Introduce numero hexadecimal: ");
string numeroHexadecimal = Console.ReadLine();
numeroHexadecimal = numeroHexadecimal.ToUpper();
Console.WriteLine();

if (VerificadorHexa(numeroHexadecimal))
{
    numeroDecimal = ParseHexadecimal(numeroHexadecimal);

    // Imprimir el resultado
    Console.WriteLine($"Número Hexadecimal: {numeroHexadecimal}");
    Console.WriteLine($"Número Decimal: {numeroDecimal}");
}
else
{
    Console.WriteLine(numeroHexadecimal+" no es de tipo hexadecimal");
}
   
;

static int ParseHexadecimal(string numero0)
{
    // Convertir el número hexadecimal a decimal (int de 32 bits)
     int numeroDecimal = Convert.ToInt32(numero0, 16);
    return numeroDecimal;
}

static bool VerificadorHexa(string cadena)
{
    cadena=cadena.ToUpper();
    int contador = 0,contador2=0;
    char[] array = cadena.ToCharArray();    
    char[] arrayVerif = { 'A', 'B', 'C', 'D', 'E', 'F', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

    foreach (char item in array)
    {
        foreach (char item2 in arrayVerif)
        {
            if (!item.Equals(item2))
            {
                contador++;
            }
        }
        if(contador == 16 )
        {
            contador2++;
        }

        contador = 0;
    }
    if(contador2>0)
    {
        return false;
    }
    else
    {
        return true;
    }


}