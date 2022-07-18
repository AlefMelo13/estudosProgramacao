using Figuras.Entities.Enums;

namespace Figuras.Entities
{
    class Retangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double baseRetangulo, double altura, Cor cor) : base(cor)
        {
            Base = baseRetangulo;
            Altura = altura;
        }

        public override double Area()
        {
            return Base * Altura;
        }
    }
}