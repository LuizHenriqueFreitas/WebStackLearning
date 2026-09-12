namespace Console_Hotel_Manager.Models;
public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite SuiteReserva { get; set; }
    public int DiasReservaldos { get; set; }

    public Reserva(int DiasReservaldos)
    {
        this.DiasReservaldos = DiasReservaldos;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (SuiteReserva.capacidade >= hospedes.Count())
            Hospedes = hospedes;
        else
            throw new Exception();
    }

    public void CadastrarSuite(Suite suite)
    {
        SuiteReserva = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count();
    }

    public decimal CalcularValorDiaria()
    {
        if (DiasReservaldos < 10)
            return SuiteReserva.valorDiaria * DiasReservaldos;
        else
            return SuiteReserva.valorDiaria * DiasReservaldos * 0.9M;
    }
}