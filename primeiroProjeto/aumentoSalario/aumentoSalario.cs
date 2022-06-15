// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace aumentoSalario
{
    class AumentoSalario
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- AUMENTO DE SALÁRIO ----------");

            double salarioAtual, novoSalario, reajuste;
            string percentual;

            Console.Write("Digite seu salário atual: ");
            salarioAtual = double.Parse(Console.ReadLine());

            if (salarioAtual > 0 && salarioAtual <= 400)
            {
                novoSalario = salarioAtual + salarioAtual * 15/100;
                reajuste = novoSalario - salarioAtual;
                percentual = "15%";
            }
            else
            {
                if (salarioAtual >= 400.01 && salarioAtual <= 800)
                {
                    novoSalario = salarioAtual + salarioAtual * 12/100;
                    reajuste = novoSalario - salarioAtual;
                    percentual = "12%";
                }
                else
                {
                    if (salarioAtual >= 800.01 && salarioAtual <= 1200)
                    {
                        novoSalario = salarioAtual + salarioAtual * 10/100;
                        reajuste = novoSalario - salarioAtual;
                        percentual = "10%";
                    }
                    else
                    {
                        if (salarioAtual >= 1200.01 && salarioAtual <= 2000)
                        {
                            novoSalario = salarioAtual + salarioAtual * 7/100;
                            reajuste = novoSalario - salarioAtual;
                            percentual = "7%";
                        }
                        else
                        {
                            novoSalario = salarioAtual + salarioAtual * 4/100;
                            reajuste = novoSalario - salarioAtual;
                            percentual = "4%";
                        }
                    }
                }
            }
            Console.WriteLine("Seu novo salário é: R$" + novoSalario.ToString("F2"));
            Console.WriteLine("Seu reajuste foi de: R$" + reajuste.ToString("F2"));
            Console.WriteLine("Seu percentual de reajuste é: " + percentual);
        }
    }
}