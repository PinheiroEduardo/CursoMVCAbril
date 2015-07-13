using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Specification;

namespace CursoMVCAbril.Domain.Specification.Clientes
{
    public class ClientePossuiStatusAtivo : ISpecification<Cliente>
    {

        public bool IsSatisfieldBy(Cliente cliente)
        {
            return cliente.Ativo;
        }
    }
}