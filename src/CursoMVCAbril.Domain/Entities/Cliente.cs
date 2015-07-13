using System;
using System.Collections.Generic;
using CursoMVCAbril.Domain.Interfaces.Validation;
using CursoMVCAbril.Domain.Validation.Clientes;
using CursoMVCAbril.Domain.ValueObjects;

namespace CursoMVCAbril.Domain.Entities
{
    public class Cliente : ISelfValidator
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
            Enderecos = new List<Endereco>();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public ValidationResult ResultadoValidacao { get; set; }

        public bool IsValid()
        {
            var fiscal = new ClienteEstaConsistenteValidation();
            ResultadoValidacao = fiscal.Validar(this);

            return ResultadoValidacao.IsValid;
        }
    }
}