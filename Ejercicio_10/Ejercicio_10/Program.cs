
Console.Write("Escribe una palabra: ");
string cadena=Console.ReadLine();
Console.WriteLine();

if (EsPalindroma(cadena) == true)
{
    Console.WriteLine(cadena + " es palindroma");
} 
else 
{ 
    Console.WriteLine(cadena + " no es palindromma"); 
}

static bool EsPalindroma(string cadena)
{
    if (cadena.Equals(Revertir(cadena))){
        return true;
    } else 
    { 
        return false; 
    }
}

static string Revertir(string cadena)
{
    char[] array = cadena.ToCharArray();    
    Array.Reverse(array);
    return new string(array);
}
