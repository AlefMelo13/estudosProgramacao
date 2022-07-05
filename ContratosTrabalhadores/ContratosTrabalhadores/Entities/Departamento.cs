namespace ContratosTrabalhadores.Entities
{
    public class Departamento
    {
        public string Nome { get; set; }

        //CONSTRUTORES
        public Departamento()
        {
        }

        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}
