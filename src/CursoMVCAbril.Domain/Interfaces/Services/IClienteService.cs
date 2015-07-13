using System;
using System.Collections.Generic;
using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.ValueObjects;

namespace CursoMVCAbril.Domain.Interfaces.Services
{
    public interface IClienteService : IDisposable
    {
        ValidationResult Adicionar(Cliente cliente);

        Cliente ObterPorId(Guid id);

        Cliente ObterPorCPF(string cpf);

        IEnumerable<Cliente> ObterTodos();

        void Atualizar(Cliente cliente);

        void Remover(Cliente cliente);
    }
}