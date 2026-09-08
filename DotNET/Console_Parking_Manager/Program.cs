using Console_Parking_Manager.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal perHourPrice = 0;

Console.WriteLine("Welcome to parking manager system!\n" +
                    "Type the initial price to parking:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now, how much is the price per hour parking?");
perHourPrice = Convert.ToDecimal(Console.ReadLine());

Parking pk = new Parking(initialPrice, perHourPrice);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Type one option:");
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Revmove Vericle");
    Console.WriteLine("3 - List Vericles");
    Console.WriteLine("4 - Shut Down");

    switch (Console.ReadLine())
    {
        case "1":
            pk.AdicionarVeiculo();
            break;
        case "2":
            pk.RemoverVeiculo();
            break;
        case "3":
            pk.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Invalid Option.");
            break;
    }

    Console.WriteLine("Press any key to continue");
    Console.ReadLine();
}

Console.WriteLine("The program is end.");