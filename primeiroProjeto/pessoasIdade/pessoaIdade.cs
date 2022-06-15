// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace pessoaIdade
{
    class PessoaIdade
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- PESSOA IDADE ----------");

            //DECLARAÇÃO DE VARIÁVEIS
            int i, n, cont;
            int[] idade;
            string[] aux;
            string[] nome;
            double[] altura;
            double alturaMedia;
            double alturaParcial;
            double pessoasMenores;
            double porcentagem;

            cont = 0;
            alturaParcial = 0.0;

            //LEITURA DOS DADOS DE QUANTIDADE DE PESSOAS
            Console.Write("Digite a quantidade de pessoas a serem lidas: ");
            n = int.Parse(Console.ReadLine());

            nome = new string[n];
            idade = new int[n];
            altura = new double[n];

            //ATRIBUIÇÃO DE DADOS NOS VETORES nome, idade e altura
            for (i = 0; i < n; i++)
            {
                Console.Write("Digite nome, idade e altura: ");
                aux = Console.ReadLine().Split(',');
                nome[i] = aux[0];
                idade[i] = int.Parse(aux[1]);
                altura[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);
            }

            //CÁLCULO DA ALTURA MÉDIA
            for (i = 0; i < n; i++)
            {
                alturaParcial = alturaParcial + altura[i];
            }

            alturaMedia = alturaParcial / n;

            Console.WriteLine("A altura média é: " + alturaMedia.ToString("F2"));

            //CÁLCULO DA PORCENTAGEM DE MENORES DE 16 ANOS
            for (i = 0; i < n; i++)
            {
                if (idade[i] < 16)
                {
                    cont++;
                }
            }
            porcentagem =  (double) cont / n * 100;

            Console.WriteLine("Pessoas com menos de 16 : " + porcentagem.ToString("F2") + "%");

            Console.WriteLine("---------- LISTA DE PESSOAS ----------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(nome[i] + ", " + idade[i] + " anos, " + altura[i] + " de altura.", CultureInfo.InvariantCulture);
            }
        }
    }
}