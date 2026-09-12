using System.Text;
using Console_Hotel_Manager.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("José", "Antônio");
Pessoa p2 = new Pessoa("Adailtom", "Silva");
Pessoa p3 = new Pessoa("Lasminia", "do Amaral");
Pessoa p4 = new Pessoa("Jairo", "Quadros");
Pessoa p5 = new Pessoa("Biruliba", "Lesmano");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);

Suite suitePremium = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 80);
Suite suiteFamilia = new Suite(tipoSuite: "Familia", capacidade: 6, valorDiaria: 150);

Reserva reservaErrada = new Reserva(DiasReservaldos: 3);
reservaErrada.CadastrarSuite(suitePremium);
reservaErrada.CalcularValorDiaria(); // exibe o valor da diaria total sem desconto

Console.WriteLine($"valor {reservaErrada.DiasReservaldos} diárias: {reservaErrada.CalcularValorDiaria()}");

try
{
    reservaErrada.CadastrarHospedes(hospedes); // lança excessão por não comportar tantas pessoas
}
catch(Exception)
{
    Console.WriteLine("A suite nao permite tantas pessoas.");
}

Reserva reservaCorreta = new Reserva(DiasReservaldos: 10);
reservaCorreta.CadastrarSuite(suiteFamilia);
reservaCorreta.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reservaCorreta.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da Diária: {suiteFamilia.valorDiaria}");
Console.WriteLine($"valor {reservaCorreta.DiasReservaldos} diárias: {reservaCorreta.CalcularValorDiaria()} | Está com desconto de 10%");