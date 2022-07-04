namespace MembroInstituicao
{
    internal class Membroinstituicao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CADASTRO DE MEMBRO ----------");

            //INFORMA A QUANTIDADE DE MEMBROS A CADASTRAR
            Console.Write("Quantos membros você quer cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            //INSTANCIA A LISTA "MEMBROS"
            List<Membro> membros = new List<Membro>();

            //POPULA A LISTA DE MEMBROS COM A QUANTIDADE DIGITADA
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite os dados do membro {i+1}:");
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

                //INSTANCIANDO LISTA

                membros.Add(new Membro(codigo, nome, idade, endereco, numero, bairro, cidade, estado, telefone));
                Console.WriteLine();
            }

            Console.WriteLine("Membro cadastrado com sucesso!");

            Console.WriteLine();

            Console.Write("Deseja ver o cadastro de um membro(s/n)? ");
            string resposta = Console.ReadLine();

            Console.WriteLine();

            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Digite o código do membro: ");
                int cod = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Membro membroProcura = membros.Find(x => x.Codigo == cod);

                if (membroProcura != null)
                {
                    Console.WriteLine(membroProcura.ToString());
                }
                else
                {
                    Console.WriteLine("Membro não localizado!");
                }
            }
            else
            {
                Console.WriteLine("Programa Finalizado!");
            }
        }
    }
}