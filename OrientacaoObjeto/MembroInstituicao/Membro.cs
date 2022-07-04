using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembroInstituicao
{
    internal class Membro
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }

        //CONSTRUTORES
        public Membro(int codigo, string nome, int idade, string endereco, int numero, string bairro, string cidade, string estado, string telefone)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return " Código: " + Codigo +
                   "\r\n Nome: " + Nome +
                   "\r\n Idade: " + Idade +
                   "\r\n Endereço: " +Endereco +
                   "\r\n Bairro: " + Bairro +
                   "\r\n Cidade: " + Cidade +
                   "\r\n Estado :" + Estado +
                   "\r\n Telefone: " + Telefone;
        }
    }
}