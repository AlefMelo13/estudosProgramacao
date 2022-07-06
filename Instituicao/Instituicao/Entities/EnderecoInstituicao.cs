using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituicao.Entities
{
    internal class EnderecoInstituicao
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }

        //CONSTRUTORES
        public EnderecoInstituicao()
        {
        }

        public EnderecoInstituicao(string rua, int numero, string complemento, string bairro, string cidade, string estado, string telefone)
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
            StringBuilder endInstituicao = new StringBuilder();
            endInstituicao.AppendLine(Rua);
            endInstituicao.AppendLine(Numero.ToString());
            endInstituicao.AppendLine(Complemento);
            endInstituicao.AppendLine(Bairro);
            endInstituicao.AppendLine(Cidade);
            endInstituicao.AppendLine(Estado);
            endInstituicao.AppendLine(Telefone);

            return endInstituicao.ToString();
        }
    }
}