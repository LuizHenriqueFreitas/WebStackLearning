namespace Console_POO_Smartphone.Models;

public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imie, int memoria) : base (numero, modelo, imie, memoria){}

    public override void InstalarAplicativo(string app)
    {
        Console.WriteLine($"Instalando aplicativo {app} no Iphone.");
    }
}