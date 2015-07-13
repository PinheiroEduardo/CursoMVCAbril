using System;
using System.Collections.Generic;
using CursoMVCAbril.Domain.Entities;

namespace CursoMVCAbril.Domain.Interfaces.Repository.ReadOnly
{
    public interface IClienteReadOnlyRepository
    {
        IEnumerable<Cliente> ObterTodos();
        Cliente ObterPorId(Guid id);
        Cliente ObterPorCpf(string cpf);
    }
}