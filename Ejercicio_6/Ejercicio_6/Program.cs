
int n = 20; // Número de términos Tribonacci a generar
long[] tribonacci = new long[n]; // Almacenar los números Tribonacci

// Los primeros tres términos son conocidos
tribonacci[0] = 1;
tribonacci[1] = 1;
tribonacci[2] = 2;

// Generar los términos restantes
for (int i = 3; i < n; i++)
{
    tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
}

// Imprimir los números Tribonacci
Console.WriteLine("Los primeros veinte números Tribonacci son:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine("T({0}) = {1}", i + 1, tribonacci[i]);
}
