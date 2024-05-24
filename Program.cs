using ParkingLibrary;

Estacionamento park = new Estacionamento();




string op;

// Criando menu de escolhas
do
{
   
    Console.WriteLine("[1]Adicionar Veiculo\n");
    Console.WriteLine("[2]Remover Veiculo\n");
    Console.WriteLine("[3]Listar Veiculos\n");
    Console.WriteLine("[4]Encerrar Programa\n");
    Console.WriteLine("Escolha: ");
    op = Console.ReadLine();


    switch (op)
    {
        case "1":
            park.AdicionarVeiculo();

            break;
        case "2":
            park.RemoverVeiculo();
            break;
        case "3":
            park.ListarVeiculos();
            break;
        default:

            break;

    }



} while (op != "4");

