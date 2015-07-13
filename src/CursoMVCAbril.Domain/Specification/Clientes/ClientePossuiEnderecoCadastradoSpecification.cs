using System.Linq;
using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Specification;

namespace CursoMVCAbril.Domain.Specification.Clientes
{
    public class ClientePossuiEnderecoCadastradoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfieldBy(Cliente cliente)
        {
            return cliente.Enderecos != null && cliente.Enderecos.Any();
        }
    }
}