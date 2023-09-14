int numeroDecimal,numeroBinario;

Console.Write("Introduce numero hexadecimal: ");
string numeroHexadecimal = Console.ReadLine();
Console.WriteLine();

numeroDecimal = ParseDecimal(numero0);

Console.WriteLine("Numero decimal: " + numeroDecimal);
    
;

static int ParseDecimal(string numero0)
{
    int contador = numero0.Length;
    int sumatorio = 0;
    char[] array = numero0.ToCharArray();
    foreach (char item in array)
    {
        if (item == '1')
        {
            sumatorio = sumatorio + ((int)Math.Pow(2, contador - 1));
        }

        contador--;
    }
    return sumatorio;
}

static bool VerificadorHexa(string cadena)
{
    char[] array = cadena.ToCharArray();    
    char[] arrayVerif = { 'A', 'B', 'C', 'D', 'E', 'F', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

    foreach (char item in array)
    {
        if (array.Contains(arrayVerif))
        {
            
        }
    }


}