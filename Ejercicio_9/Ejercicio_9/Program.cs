
Console.Write("Ingresa una cadena: ");
string cadena = Console.ReadLine();

string reversa = ReverseString(cadena);

Console.WriteLine("Cadena al revés: " + reversa);


static string ReverseString(string cadena)
{
    char[] array = cadena.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}