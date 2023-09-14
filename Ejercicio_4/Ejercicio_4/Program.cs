
int numero = 50000;
double suma1=0;
double suma2 = 0;
double division;

for (int i = 1; i < numero+1; i++) { 
    division = (double)1/i;
    suma1 += division;
}

for (int i = numero; i > 0; i--)
{
    division = (double)1 / i;
    suma2 += division;
}
Console.WriteLine("Suma de derecha a izquierda: {0}", suma1);
Console.WriteLine("Suma de izquierda a derecha: {0}", suma2);
Console.WriteLine("Diferencia: {0}", suma2 - suma1);