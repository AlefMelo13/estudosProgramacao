using Figuras.Entities.Enums;

namespace Figuras.Entities
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raioCirculo, Cor cor) : base(cor)
        {
            Raio = raioCirculo;
        }
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}