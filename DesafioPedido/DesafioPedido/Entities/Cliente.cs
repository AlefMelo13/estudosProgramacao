﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPedido.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        //CONSTRUTORES
        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            StringBuilder cliente = new StringBuilder();
            cliente.Append(Nome);

            return cliente.ToString();
        }
    }
}