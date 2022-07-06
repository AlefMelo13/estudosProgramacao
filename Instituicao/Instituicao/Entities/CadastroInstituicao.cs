using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituicao.Entities
{
    class CadastroInstituicao
    {
        public string CnpjCpf { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        List<EnderecoInstituicao> Endereco { get; set; } = new List<EnderecoInstituicao>();
        List<Membros> Membro { get; set; } = new List<Membros>();

        //CONSTRUTORES
        public CadastroInstituicao()
        {
        }

        public CadastroInstituicao(string cnpjCpf, string razaoSocial, string nomeFantasia)
        {
            CnpjCpf = cnpjCpf;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
        }

        public CadastroInstituicao(string cnpjCpf, string razaoSocial, string nomeFantasia, List<EnderecoInstituicao> endereco)
        {
            CnpjCpf = cnpjCpf;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Endereco = endereco;
        }

        //MÉTODO PARA ADICIONAR ENDEREÇO NA CLASSE
        public void AdicionaEndereco(EnderecoInstituicao endereco)
        {
            Endereco.Add(endereco);
        }

        //MÉTODO PARA REMOVER ENDEREÇO DA CLASSE
        public void RemoveEndereco(EnderecoInstituicao endereco)
        {
            Endereco.Remove(endereco);
        }

        //MÉTODO PARA ADICIONAR MEMBRO NA CLASSE
        public void AdicionaMembro(Membros membro)
        {
            Membro.Add(membro);
        }

        //MÉTODO PARA REMOVER MEMBRO DA CLASSE
        public void RemoveMembro(Membros membro)
        {
            Membro.Remove(membro);
        }

        public override string ToString()
        {
            StringBuilder inst = new StringBuilder();
            inst.AppendLine(CnpjCpf.ToString());
            inst.AppendLine(RazaoSocial);
            inst.AppendLine(NomeFantasia);

            return inst.ToString();
        }
    }
}