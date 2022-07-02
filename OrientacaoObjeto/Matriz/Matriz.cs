namespace Matriz
{
    internal class Matriz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- MATRIZ ----------");

            Console.Write("Digite o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            //ENTRADA DOS DADOS DA MATRIZ
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite as posições da linha {i+1} da matriz: ");
                string[] aux = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(aux[j]);
                }
            }

            //EXIBE A MATRIZ FORMADA
            Console.WriteLine("Matriz formada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            //EXIBE DIAGONAL DA MATRIZ
            Console.WriteLine();
            Console.Write("Números da diagonal da matriz:");
            for (int i = 0; i< n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            //EXIBE QUANTIDADE DE NÚMEROS NEGATIVOS
            Console.WriteLine();
            int count = 0;
            Console.Write("Quantidade de números negativos: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}