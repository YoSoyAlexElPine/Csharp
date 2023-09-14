string radio0;
double radio = 0;

Console.Write("Introduce el radio: ");

radio0 = Console.ReadLine();

Console.WriteLine();

if ( Double.TryParse(radio0, out radio))
{
    Console.WriteLine("Radio: "+ radio +" m");
    Console.WriteLine("Volumen: "+radio*Math.PI*radio + " m3");
    Console.WriteLine("Superficie: "+ radio * Math.PI * 2 + " m2");
}
else
{
    Console.WriteLine("Tipo de dato incorrecto");
}