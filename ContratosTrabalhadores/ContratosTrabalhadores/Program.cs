using ContratosTrabalhadores.Entities;

namespace ContratosTrabalhadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o departamento: ");
            string departamento = Console.ReadLine();

            Console.WriteLine("Digite os dados do trabalhador:");

            Console.WriteLine();

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Nível :");
            string nivel = Console.ReadLine();

            Console.WriteLine("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos contratos o funcionário tem? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                List<HoraContrato> contrato = new List<HoraContrato>();
            }
        }
    }
}