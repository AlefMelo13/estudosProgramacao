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

            List<Funcionario> funcionario = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o salário: ");
                double salario = double.Parse(Console.ReadLine());

                funcionario.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Digite o ID do funcionário a receber aumento: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario procuraFuncionario = funcionario.Find(x => x.Id == searchId);

            if (procuraFuncionario != null)
            {
                Console.Write("Digite o percentual a ser aumentado: ");
                int porcentagem = int.Parse(Console.ReadLine());
                procuraFuncionario.AcrescimoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Usuário não localizado!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de Funcionários:");

            foreach (Funcionario lista in funcionario)
            {
                Console.WriteLine(lista);
            }
        }
    }
}