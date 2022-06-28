namespace Pensaionato
{
    internal class Pensionato
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CADASTRO DE PENSIONATO ----------");

            Console.Write("Digite a quantidade de quartos a ser alugados: ");
            int n = int.Parse(Console.ReadLine());

            Inquilino[] inquilino = new Inquilino[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Digite o número do quarto a ser alugado: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                inquilino[i] = new Inquilino { Nome = nome, Email = email, NumeroQuarto = numeroQuarto };
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inquilino " + i);
                Console.WriteLine("Nome: " + inquilino[i].Nome);
                Console.WriteLine("E-mail: " + inquilino[i].Email);
                Console.WriteLine("Quarto: " + inquilino[i].NumeroQuarto);
                Console.WriteLine();
            }
        }
    }
}