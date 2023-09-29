using System.Data;
class Barco
{
    public int eslora {get;}  
    public int year { get;}
    public string matricula { get; }

    public Barco(int eslora, int year,string matricula)
    {
        this.eslora = eslora;
        this.year = year;
        this.matricula = matricula;
    }

    public int alquilar(int dia_i,int dia_f)
    {
        int retorno = (dia_f - dia_i) * 12 * this.eslora;
        return retorno;
    }
}

class Velero : Barco
{
    public int mastiles { get; }
    public Velero(int eslora, int year, string matricula,int mastiles) : base(eslora, year, matricula)
    {
        this.mastiles = mastiles;
    }



}
class Embarcaciones_deportivas : Barco
{
    public int potencia { get; }
    public Embarcaciones_deportivas(int eslora, int year, string matricula,int potencia) : base(eslora, year, matricula)
    {
        this.potencia = potencia;
    }



}
class Yates : Barco
{
    public int potencia { get; }
    public int camarotes { get; }
    public Yates(int eslora, int year, string matricula,int potencia,int camarotes) : base(eslora, year, matricula)
    {
        this.potencia = potencia;
        this.camarotes = camarotes;
    }



}

public class Programa
{
    static void Main()
    {
        string hola = "hola";

        Console.WriteLine(hola[0]);

        Velero vel = new Velero(10,200,"sdf",5);

        Console.WriteLine(vel.matricula);
        Console.WriteLine(vel.alquilar(2, 34)+" ");
    }
}