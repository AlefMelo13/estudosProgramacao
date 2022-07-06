using ContratosTrabalhadores.Entities;
using ContratosTrabalhadores.Entities.Enums;

namespace ContratosTrabalhadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- PROGRAMA CONTRATO DE TRABALHADOR ----------");

            Console.Write("Digite o nome do departamento: ");
            string departamentoNome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite os dados do trabalhador:");
            Console.WriteLine("--------------------------------------");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível (Junior/Pleno/Sênior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());

            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Departamento departamento = new Departamento(departamentoNome);

            Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, departamento);
            Console.WriteLine("--------------------------------------");

            Console.Write("Quantos contratos o funcionário tem? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do contrato número {i}: ");
                Console.WriteLine();

                Console.Write($"Digite a data do contrato {i}: ");
                DateTime dataContrato = DateTime.Parse(Console.ReadLine());

                Console.Write("Digite o valor por horas: ");
                double valorHora = double.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de horas trabalhadas: ");
                int horasTrabalhadas = int.Parse(Console.ReadLine());

                HoraContrato contrato = new HoraContrato(dataContrato, valorHora, horasTrabalhadas);

                trabalhador.AddContrato(contrato);

                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine();

            Console.Write("Digite o MÊS e o ANO para calcular o ganho(MM/YYYY): ");
            string mesAnoGanho = Console.ReadLine();

            int mes = int.Parse(mesAnoGanho.Substring(0, 2));
            int ano = int.Parse(mesAnoGanho.Substring(3));
            Console.WriteLine();

            Console.WriteLine("Nome do Trabalhador: " + trabalhador.Nome);

            Console.WriteLine("Departamento; " + departamento.Nome);

            Console.WriteLine($"Ganho em {mesAnoGanho}: " + trabalhador.Ganho(ano, mes).ToString("F2"));
        }
    }
}