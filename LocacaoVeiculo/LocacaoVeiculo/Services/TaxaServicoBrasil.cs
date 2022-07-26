namespace LocacaoVeiculo.Services
{
    public class TaxaServicoBrasil
    {
        public double Taxa(double quantia) {
            if(quantia <= 100)
            {
                return quantia * 20 / 100;
            }
            else
            {
                return quantia * 15 / 100;
            }
        }
    }
}