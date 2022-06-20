using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda
{
    class Conversor
    {
        public static double dolar;
        public static double cotacao;
        public static double IOF = 6.0;

        public static double Converte(double cotacaoDolar, double quantiaDolar)
        {
            double total = quantiaDolar * cotacaoDolar;
            return total + total * IOF / 100;
        }
    }
}
