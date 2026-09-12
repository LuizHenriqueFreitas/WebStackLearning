namespace Console_Hotel_Manager.Models;
public class Suite
{
    private string _TipoSuite;
    public string tipoSuite
    { 
        get
        {
            return _TipoSuite;
        } 
        set
        {
           _TipoSuite = value;
        } 
    }

    private int _Capacidade;
    public int capacidade
    { 
        get
        {
            return _Capacidade;
        } 
        set
        {
            _Capacidade = value;
        } 
    }

    private  decimal _ValorDiaria;
    public decimal valorDiaria
    { 
        get
        {
            return _ValorDiaria;
        } 
        set
        {
            _ValorDiaria = value;
        } 
    }

    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        this.tipoSuite = tipoSuite;
        this.capacidade = capacidade;
        this.valorDiaria = valorDiaria;
    }
}