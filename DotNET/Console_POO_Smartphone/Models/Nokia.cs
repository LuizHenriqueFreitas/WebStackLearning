namespace Console_POO_Smartphone.Models;

public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imie, int memoria) : base (numero, modelo, imie, memoria){}

    public override void InstalarAplicativo(string app)
    {
        Console.WriteLine($"Instalando aplicativo {app} no Nokia.");
    }
}