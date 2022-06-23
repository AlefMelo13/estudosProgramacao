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
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (operacao == 1)
            {

            }

        }
    }
}