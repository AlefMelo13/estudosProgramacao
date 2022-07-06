using Instituicao.Entities;
using System.Text;

namespace Instituicao.Entities
{
    class Membros
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        List<EnderecoMembro> Endereco { get; set; } = new List<EnderecoMembro>();

        //CONSTRUTORES
        public Membros()
        {
        }

        public Membros(string nome, string sobrenome, int idade, string sexo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Sexo = sexo;
        }

        public void AdicionaEndereco(EnderecoMembro endereco)
        {
            Endereco.Add(endereco);
        }

        public void RemoveEndereco(EnderecoMembro endereco)
        {
            Endereco.Remove(endereco);
        }

        public override string ToString()
        {
            StringBuilder membro = new StringBuilder();
            membro.AppendLine(Nome);
            membro.AppendLine(Sobrenome);
            membro.AppendLine(Idade.ToString());
            membro.Append(Sexo);

            return membro.ToString();
        }
    }
}