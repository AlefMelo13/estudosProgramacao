using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosRetangulo
{
    internal class Retangulo
    {
        public double Base;
        public double Altura;

        //RETORNA A ÁREA DO RETÂNGULO
        public double Area()
        {

            return Base * Altura;
        }

        //RETORNA O PERÍMETRO DO RETÂNGULO
        public double Perimetro()
        {
            return 2 * (Base + Altura);
        }

        //RETORNA A DIAGONAL DO RETÂNGULO
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
        }
    }
}
