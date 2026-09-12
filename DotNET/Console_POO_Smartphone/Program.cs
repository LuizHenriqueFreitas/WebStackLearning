using Console_POO_Smartphone.Models;

Console.WriteLine("Smatphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imie: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smatphone Nokia: ");
Smartphone iphone = new Iphone(numero: "7891011", modelo: "Modelo 2", imie: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");