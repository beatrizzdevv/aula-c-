using programa01;

Console.WriteLine("****************SISTEMA  DA LOJA BIKE CITY ***********");
Console.WriteLine();

//Instanciando objeto da Classe Bike
Bike bike = new Bike();

Console.Write("Modelo Bike:");
bike.Modelo = Console.ReadLine();

Console.Write("Capacidade da Bateria: ");
bike.Bateria = double.Parse(Console.ReadLine());

Console.Write("Peso do Ciclista:");
bike.PesoCiclista = Convert.ToDouble(Console.ReadLine());

Console.Write("Quantidade Estimada de Recargas por Mês:");
bike.RecargaMes = int.Parse(Console.ReadLine());

//EXIBIR NA TELA O RESULTADO
Console.WriteLine("\n-----RELATÓRIO DE DESEMPENHO DA BIKE------");
Console.WriteLine($"Bicicleta: {bike.Modelo.ToUpper()}");
Console.WriteLine($"Autonomia Estimada {bike.CalcularAutonomia():F1}Km por carga");
Console.WriteLine($"Consumo Mensal: {bike.CalcularConsumoMensal():F2}KWm");
Console.WriteLine($"Custo Mensal {bike.CalcularCustoMensal():N2}");
Console.WriteLine($"A Bike é Econômica {bike.BikeEconomica()}");


