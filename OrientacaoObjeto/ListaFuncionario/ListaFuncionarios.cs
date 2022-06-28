namespace ListaFuncionario
{
    internal class ListaFuncionarios
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- LISTA DE FUNCIONÁRIOS ----------");
            Console.WriteLine();

            Console.Write("Quantos funcionários vão ser cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados dos funcionáros:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o salário: ");
                double salario = int.Parse(Console.ReadLine());

                List<string> nomeFuncionario = new List<string> { nome };
                List<int> idFuncionario = new List<int> { id };
                List<double> salarioFuncionario = new List<double> { salario };
            }

           


        }
    }
}