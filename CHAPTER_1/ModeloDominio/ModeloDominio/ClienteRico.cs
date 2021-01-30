using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio
{
    class ClienteRico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public ClienteRico(int id, string nome, string endereco)
        {
            DomainExceptionValidation.When(id < 0, "ID inválido.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome deve ser informado.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "Endereço deve ser informado.");

            Id = id;
            Nome = nome;
            Endereco = endereco;
        }
    }
}
