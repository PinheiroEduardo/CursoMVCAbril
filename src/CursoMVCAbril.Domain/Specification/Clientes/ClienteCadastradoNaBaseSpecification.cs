using System.Linq;
using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Repository;
using CursoMVCAbril.Domain.Interfaces.Specification;

namespace CursoMVCAbril.Domain.Specification.Clientes
{
    public class ClienteCadastradoNaBaseSpecification : ISpecification<Cliente>
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteCadastradoNaBaseSpecification(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool IsSatisfieldBy(Cliente Cliente)
        {
            return !_clienteRepository.Find(c => c.CPF == Cliente.CPF).Any();
        }
    }
}