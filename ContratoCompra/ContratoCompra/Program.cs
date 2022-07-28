using System;
using ContratoCompra.Services;
using ContratoCompra.Entities;

namespace ContratoCompra
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CONTRATO DE COMPRA ----------");
            Console.WriteLine();

            Console.WriteLine("Digite os dados do contrato:");
            Console.WriteLine();
            Console.Write("Número do Contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data do Contrato: ");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do Contrato: ");
            double valorcontrato = double.Parse(Console.ReadLine());
            Console.Write("Número de Parcelas: ");
            int numeroParcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numeroContrato, dataContrato, valorcontrato);

            ServicoContrato servicoContrato = new ServicoContrato(new ServicoPayPal());
            servicoContrato.ProcessaContrato(contrato, numeroParcelas);

            Console.WriteLine();
            Console.WriteLine("PARCELAS:");
            Console.WriteLine();

            foreach(Parcela par in contrato.Parcela)
            {
                Console.WriteLine(par);
            }
        }
    }
}