using Contribuintes.Entities;

namespace Contribuintes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CONTRIBUINTES ----------");

            Console.Write("Digite a quantidade de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            List<Pessoa> pessoa = new List<Pessoa>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte {i}:");
                Console.Write("Pessoa Física ou Jurídica(F/J)? ");
                string resposta = Console.ReadLine();

                Console.Write("Nome: ");
                string nomèPessoa = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if (resposta == "f" || resposta == "F")
                {
                    Console.Write("Gastos com Saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine());

                    pessoa.Add(new PessoaFisica(nomèPessoa, rendaAnual, gastosSaude));
                }
                if (resposta == "j" || resposta == "J")
                {
                    Console.Write("Número de Funcionários: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());

                    pessoa.Add(new PessoaJuridica(nomèPessoa, rendaAnual, numeroFuncionarios));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Impostos de Contribuintes:");
            double soma = 0.0;
            foreach (Pessoa pes in pessoa)
            {
                Console.WriteLine(pes.NomePessoa + ": R$" + pes.Imposto().ToString("F2"));
                soma += pes.Imposto();
            }
            Console.WriteLine($"Total de Impostos: R${soma.ToString("F2")}");
        }
    }
}