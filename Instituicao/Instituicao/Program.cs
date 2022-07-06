using Instituicao.Entities;

namespace Instituicao
{
    internal class Program
    {
        private static IEnumerable<Membros> membro;

        static void Main(string[] args)
        {
            Console.WriteLine("---------- CADASTRO DE INSTITUIÇÃO E MEMBROS ----------");
            Console.WriteLine();

            Console.WriteLine("Digite os dados da instituição:");
            Console.Write("Cnpj ou Cpf: ");
            string cnpjCpf = Console.ReadLine();

            Console.Write("Razão Social: ");
            string razao = Console.ReadLine();

            Console.Write("Nome Fantasia: ");
            string fantasia = Console.ReadLine();

            Console.Write("Rua: ");
            string rua = Console.ReadLine();

            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Complemento: ");
            string complemento = Console.ReadLine();

            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();

            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Estado: ");
            string estado = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            EnderecoInstituicao enderecoInstituicao = new EnderecoInstituicao(rua, numero, complemento, bairro, cidade, estado, telefone);

            CadastroInstituicao instituicao = new CadastroInstituicao(cnpjCpf, fantasia, razao);

            Console.Write("Deseja adicionar membros a instituição(s/n)? ");
            string resposta = Console.ReadLine();

            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Quantos membros deseja adicionar? ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Sobrenome: ");
                    string sobrenome = Console.ReadLine();

                    Console.Write("Idade: ");
                    int idade = int.Parse(Console.ReadLine());

                    Console.Write("Sexo: ");
                    string sexo = Console.ReadLine();

                    Console.Write("Rua: ");
                    string ruaMembro = Console.ReadLine();

                    Console.Write("Número: ");
                    int numeroMembro = int.Parse(Console.ReadLine());

                    Console.Write("Complemento: ");
                    string complementoMembro = Console.ReadLine();

                    Console.Write("Bairro: ");
                    string bairroMembro = Console.ReadLine();

                    Console.Write("Cidade: ");
                    string cidadeMembro = Console.ReadLine();

                    Console.Write("Estado: ");
                    string estadoMembro = Console.ReadLine();

                    Console.Write("Telefone: ");
                    string telefoneMembro = Console.ReadLine();

                    EnderecoMembro enderecoMembro = new EnderecoMembro(ruaMembro, numeroMembro, complementoMembro, bairroMembro, cidadeMembro, estadoMembro, telefoneMembro);

                    Membros membro = new Membros(nome, sobrenome, idade, sexo);

                    instituicao.AdicionaMembro(membro);

                    membro.AdicionaEndereco(enderecoMembro);
                }

            }
            Console.WriteLine();

            Console.WriteLine("Dados da instituição:");
            Console.WriteLine(instituicao.ToString());
            Console.WriteLine(enderecoInstituicao);
            Console.WriteLine();

            Membros membro = new Membros();

            Console.WriteLine("Membros da instituição:");
            foreach(Membros m in membro)
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
}