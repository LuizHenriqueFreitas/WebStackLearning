namespace Console_Parking_Manager.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal perHourPrice = 0;
        private List<string> veiculos = new List<string>();

        public Parking(decimal initialPrice, decimal perHourPrice)
        {
            this.initialPrice = initialPrice;
            this.perHourPrice = perHourPrice;
        }

        public void AdicionarVeiculo()
        {
            // Ask to user the car plate to parking
            Console.WriteLine("Type the car plate to parking:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Type the veicle plate to remove from parking:");

            // Ask user to type the car plate
            string placa = Console.ReadLine();

            // check if the veicle exists on the system
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0;

                Console.WriteLine("Type the hours amount the car stays on the parking:");
                horas = Convert.ToInt16(Console.ReadLine());
                valorTotal = (horas * perHourPrice) + initialPrice;

                // remove vericle by plate
                veiculos.Remove(placa);

                Console.WriteLine($"The vericle {placa} was removed and the total price was: R${valorTotal}");
            }
            else
            {
                Console.WriteLine($"Sorry, that vericle isn't parking here.");
            }
        }

        public void ListarVeiculos()
        {
            // check if there's parking vericles 
            if(veiculos.Any())
            {
                // exec a loop to run trought all vericles at the list
                Console.WriteLine("The parking vericles are: ");
                foreach(string plate in veiculos)
                    Console.WriteLine(plate);
            }
            else
            {
                Console.WriteLine("There's no parking vericles.");
            }
        }
    }
}