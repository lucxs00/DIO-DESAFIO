using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ParkingLibrary
{
    public class Estacionamento
    {
        public List<string> parking = new List<string>();
        DateTime GlobalDate = DateTime.Now; // Imaginar que esse global date eh a data oficial de um servidor
        public string tempo;
        
        private decimal ValorInicial = 5.00M;
        private decimal Adicional2Horas = 5.50M;
        private decimal TotalPagar;



        


        public void AdicionarVeiculo()
        {
            Console.Clear();
            string placa;
            Console.WriteLine("Insira a placa do veiculo: ");
            placa = Console.ReadLine();
            DateTime dataAtual = DateTime.Now;
             Console.WriteLine("Horario de entrada: " + dataAtual);
            tempo = DateTime.Now.ToString("\tdd/MM/yyyy:HH:mm:ss");
            parking.Add(placa + tempo); // Adicionando a placa inserida na lista de estacionamento e o seu horario



        }
        public void RemoverVeiculo()
        {
            Console.Clear();
            string RemoverPlaca;
            Console.WriteLine("Lista de veiculos: ");
            ListarVeiculos(); // Listando o veiculo para facilitar na hora de remover 
            Console.WriteLine("Insira a placa do veiculo que deseja remover: ");
            RemoverPlaca = Console.ReadLine();
            DateTime HoraRemocao = DateTime.Now;
            
            System.TimeSpan result = HoraRemocao.Subtract(GlobalDate);
            Console.WriteLine($"{result}");


            if(result.TotalMinutes > 120)
            {
                Console.WriteLine($"Permanencia: {result}");
                Console.WriteLine($"Valor minimo: {ValorInicial} + Adicional de 2 Horas: {Adicional2Horas}, Valor a Pagar = {ValorInicial + Adicional2Horas}");
            }
            else
            {
                Console.WriteLine($"Permanencia: {result}");
                Console.WriteLine($"Valor a Pagar = {ValorInicial} ");
            }
            parking.Remove(RemoverPlaca + tempo); 




            // TotalPagar = ValorInicial + ()


        }
        public void ListarVeiculos()
        {
            Console.Clear();
            if (parking.Count > 0)
            {
                Console.WriteLine("Lista de Veiculos Cadastrados\n");
                foreach (string veiculo in parking)
                {
                    Console.WriteLine($"{veiculo}");

                }
            }
            else
            {
                Console.WriteLine("Nenhum veiculo cadastrado");
            }
        }
    }
}
