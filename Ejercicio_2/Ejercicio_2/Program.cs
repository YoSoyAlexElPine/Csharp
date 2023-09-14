Console.WriteLine("Introduce el numero");
string a0=Console.ReadLine();
int a;
if (int.TryParse(a0,out a))
{
    if (a%2==0)
    {
        Console.WriteLine("{0} es par", a);
    } else
    {
        Console.WriteLine("{0} es impar", a);
    }
}
else
{
    Console.WriteLine("Tipo de dato incorrecto");
}