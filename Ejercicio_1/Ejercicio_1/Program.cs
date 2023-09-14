Console.WriteLine("Introduce el valor de mark");
string mark0 = Console.ReadLine();
int mark=0;

if (int.TryParse(mark0,out mark))
{
    if (mark<50)
    {
        Console.WriteLine("SUSPENSO");
    }
    else
    {
        Console.WriteLine("APROBADO");
    }
}
else
{
    Console.WriteLine("Tipo de dato incorrecto");
}