namespace Console_Hotel_Manager.Models;
public class Pessoa
{
    private string _Nome;
    public string nome
    {
        get
        {
            return _Nome;   
        }
        set
        {
            _Nome = value;
        }
    }

    public string _Sobrenome;
    public string sobrenome 
    { 
        get
        {
            return _Sobrenome;       
        }
        set
        {
            _Sobrenome = value;
        } 
    }

    public Pessoa(string nome, string sobrenome)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
    }
}