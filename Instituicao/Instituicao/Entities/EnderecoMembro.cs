using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituicao.Entities
{
    internal class EnderecoMembro
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }

        //CONSTRUTORES
        public EnderecoMembro()
        {
        }

        public EnderecoMembro(string rua, int numero, string complemento, string bairro, string cidade, string estado, string telefone)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
        }

        public override string ToString()
        {
            StringBuilder endMembro = new StringBuilder();
            endMembro.AppendLine(Rua);
            endMembro.AppendLine(Numero.ToString());
            endMembro.AppendLine(Complemento);
            endMembro.AppendLine(Bairro);
            endMembro.AppendLine(Cidade);
            endMembro.AppendLine(Estado);
            endMembro.AppendLine(Telefone);

            return endMembro.ToString();
        }
    }
}