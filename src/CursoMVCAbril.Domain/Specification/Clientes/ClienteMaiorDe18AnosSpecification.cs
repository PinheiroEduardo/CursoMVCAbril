using System;
using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Specification;

namespace CursoMVCAbril.Domain.Specification.Clientes
{
    public class ClienteMaiorDe18AnosSpecification : ISpecification<Cliente>
    {

        public bool IsSatisfieldBy(Cliente cliente)
        {
            return DateTime.Now.Year - cliente.DataNascimento.Year >= 18;
        }
    }
}