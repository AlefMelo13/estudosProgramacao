namespace Calculadora
{
    internal class Calculo
    {
        public int Numero { get; set; }
        public int Soma { get; set; }
        public int Subtracao { get; set; }
        public int Divisao { get; set; }
        public int Mulriplicacao { get; set; }

        public void SetSoma(int numero)
        {
            int[] soma = new int[10];

            for (int i = 0; i < 10; i++)
            {
                soma[i] = numero * i;
            }


        }

    }
}
