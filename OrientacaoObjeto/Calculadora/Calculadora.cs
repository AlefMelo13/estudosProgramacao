namespace Calculadora
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- CALCUALDORA GERAL ----------");

            Console.WriteLine("Qual operação você quer fazer?");
            Console.Write("1-Soma, 2-Subtração, 3-Divisão ou 4-Multiplicação: ");
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int[] soma = new int[11];
            int[] subtracao = new int[11];
            int[] divisao = new int[11];
            int[] multiplicacao = new int[11];

            if (operacao == 1)
            {
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        soma[i] = numero + i;
                    }

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(numero + " + " + i + " = " + soma[i]);
                    }

                    Console.WriteLine();
                }

                if (operacao == 2)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        subtracao[i] = numero - i;
                    }

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(numero + " - " + i + " = " + subtracao[i]);
                    }
                }

                if (operacao == 3)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        divisao[i] = numero / i;
                    }

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(numero + " / " + i + " = " + divisao[i]);
                    }
                }

                if (operacao == 4)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        multiplicacao[i] = numero - i;
                    }

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(numero + " * " + i + " = " + multiplicacao[i]);
                    }
                }
            }
        }
    }
}