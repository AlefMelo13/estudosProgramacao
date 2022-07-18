using Figuras.Entities;
using Figuras.Entities.Enums;

namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- TAMANHO FIGURAS ----------");

            Console.Write("Digite a quantidade de figuras: ");
            int n = int.Parse(Console.ReadLine());

            List<Figura> figura = new List<Figura>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da figura {i}: ");
                Console.WriteLine();

                Console.Write("Retangulo ou Círculo(r/c)? ");
                string resposta = Console.ReadLine();

                Console.WriteLine("Cor (Preto/Aul/Vermelho): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (resposta == "r" || resposta == "R")
                {
                    Console.Write("Base: ");
                    double baseRetangulo = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double alturaRetangulo = double.Parse(Console.ReadLine());

                    figura.Add(new Retangulo(baseRetangulo, alturaRetangulo, cor));
                }

                if (resposta == "c" || resposta == "C")
                {
                    Console.Write("Raio: ");
                    double raioCirculo = double.Parse(Console.ReadLine());

                    figura.Add(new Circulo(raioCirculo, cor));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Áreas das Figuras:");
            foreach (Figura fig in figura)
            {
                Console.WriteLine(fig.Area().ToString("F2"));
            }
        }
    }
}