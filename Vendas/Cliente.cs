using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas
{
    class Cliente
    {
        //construtor ctor
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public Cliente()
        {
            criadoEm = DateTime.Now;
        }
        //Atributos, propriedades e caracteristica
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public DateTime criadoEm {get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {criadoEm}";
        }
    }
}
