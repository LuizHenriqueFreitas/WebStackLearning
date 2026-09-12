namespace Console_POO_Smartphone.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    private string _Modelo;
    public string modelo { get => _Modelo; set{_Modelo = value;} }
    private string _IMEI;
    public string imei { get => _IMEI; set{_IMEI = value;} }
    private int _Memoria;
    public int memoria { get => _Memoria; set{_Memoria = value;} }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        this.modelo = modelo;
        this.imei = imei;
        this.memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine("Fazendo Ligação");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo Ligação");
    }

    public abstract void InstalarAplicativo(string app);
}