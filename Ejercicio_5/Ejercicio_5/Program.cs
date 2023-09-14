int numero = 50;
double suma1 = 0;
double suma2 = 0;
bool conmutador = true;
double division;

for (int i = 1; i < numero + 1; i += 2)
{
    division = (double)1 / i;

    if (conmutador)
    {
        suma1 = suma1 - division;
        conmutador = false;
    }
    else
    {
        suma1 = suma1 + division;
        conmutador = true;
    }
}

for (int i = 1; i < numero + 1; i += 2)
{

    //Console.WriteLine(CalcularFactorial(i));
    //Console.WriteLine(CalcularFactorialImpar(i));


    division = (double)CalcularFactorial(i) / (double)CalcularFactorialImpar(i);

    suma2 = suma2 + division;
}

Console.WriteLine("Suma del enunciado: {0}", Math.Abs(4 * suma1));
Console.WriteLine("Suma correcta: {0}", 2*suma2);
Console.WriteLine("Diferencia: {0}", suma2 - suma1);
Console.WriteLine();
Console.WriteLine("La segunsa es mas precisa pero necesita de muchos mas mas operaciones para mostrar el numero pi");

static double CalcularFactorial(int n)
{
    double suma = 1;
    for (int i = 1; i <= n; i++)
    {
        suma *= i;
    }
    return suma;
}

static double CalcularFactorialImpar(int n)
{
    double suma = 1;
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 != 0) // Corrección: Verificar si i es impar
        {
            suma *= i;
        }
    }
    return suma;
}
