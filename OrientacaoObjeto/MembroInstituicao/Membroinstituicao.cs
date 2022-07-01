namespace MembroInstituicao
{
    internal class Membroinstituicao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CADASTRO DE MEMBRO ----------");

            Console.WriteLine("Digite os dados do membro:");
            Console.WriteLine();
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string? nome = (Console.ReadLine());

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Endereço: ");
            string? endereco = (Console.ReadLine());

            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Bairro: ");
            string? bairro = (Console.ReadLine());

            Console.Write("Cidade: ");
            string? cidade = (Console.ReadLine());

            Console.Write("Estado: ");
            string? estado = (Console.ReadLine());

            Console.Write("Telefone: ");
            string? telefone = (Console.ReadLine());

            //INSTÂNCIANDO LISTA
            List<Membro> membros = new List<Membro>();

            for (int i = 0; i < 1; i++)
            {
                membros.Add(new Membro(codigo, nome, idade, endereco, numero, bairro, cidade, estado, telefone));
            }
            Console.WriteLine();

            Console.WriteLine("Membro cadastrado com sucesso!");

            Console.Write("Deseja ver o membro cadastrado(s/n)? ");
            string resposta = Console.ReadLine();
            
            Console.WriteLine();

            if (resposta == "s" || resposta == "S")
            {
                foreach (Membro obj in membros)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
            else
            {
                Console.WriteLine("Programa Finalizado!");
            }
        }
    }
}