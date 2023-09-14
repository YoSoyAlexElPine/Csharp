
int numero = 500000000;
double suma1 = 0;
double suma2 = 0;
bool conmutador=true;
double division;

for (int i = 1; i < numero + 1; i+=2)
{
    division = (double)1 / i;

    if (conmutador)
    {
        suma1 = suma1 - division;
        conmutador = false;
    } else
    {
        suma1 = suma1 + division;
        conmutador = true;
    }


}



Console.WriteLine("Suma del enunciado: {0}", 4*suma1);
Console.WriteLine("Suma correcta: {0}", suma2);
Console.WriteLine("Diferencia: {0}", suma2 - suma1);