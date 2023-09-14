int numero,numeroDecimal;

Console.Write("Introduce numero binario: ");
string numero0=Console.ReadLine();
Console.WriteLine();

if(int.TryParse(numero0, out numero))
{
    if (VerificarBin(numero0)){
        numeroDecimal=ParseDecimal(numero0);

        Console.WriteLine("Numero decimal: " + numeroDecimal);
    }
    else
    {
        Console.WriteLine(numero0+" no es un numero binaro");
    }

}
else
{
    Console.WriteLine("Tipo de dato introducido incorrecto");
};

static int ParseDecimal(string numero0)
{
    int contador=numero0.Length;
    int sumatorio=0;
    char[] array = numero0.ToCharArray();
    foreach (char item in array)
    {
        if (item == '1')
        {
            sumatorio = sumatorio + ((int)Math.Pow(2, contador-1));
        }

        contador--;
    }
    return sumatorio;
}

static bool VerificarBin(string numeros0)
{
    int contador = 0;
    bool retorno=false;
    char[] array = numeros0.ToCharArray();
    foreach (char item in array)
    {
        if (item.Equals('1') || item.Equals('0'))
        {
            
        }
        else
        {
            contador++;
        }

    }

    if (contador == 0)
    {
        retorno = true;

    }
    else
    {
        retorno = false;
    }

    return retorno;
}