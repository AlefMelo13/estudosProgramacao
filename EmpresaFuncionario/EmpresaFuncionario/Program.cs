using EmpresaFuncionario.Entities;

namespace EmpresaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- EMPRESA FUNCIONÁRIOS ----------");

            Console.Write("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do funcionario {i}: ");
                Console.WriteLine();

                Console.Write("O funcionário é terceirizado(s/n)? ");
                string resposta = Console.ReadLine();

                if(resposta == "n" || resposta == "N")
                {
                    Console.WriteLine();

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Horas trabalhadas: ");
                    int horasTrabalhadas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: ");
                    double valorHora = double.Parse(Console.ReadLine());

                    List<Funcionario> funcionario = new Funcionario(nome, horasTrabalhadas, valorHora);
                }
                else
                {

                }
            }
            

        }
    }
}