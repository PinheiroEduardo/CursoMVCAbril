using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Repository;
using CursoMVCAbril.Domain.Specification.Clientes;
using CursoMVCAbril.Domain.Validation.Base;

namespace CursoMVCAbril.Domain.Validation.Clientes
{
    public class ClienteAptoParaEntrarNoSistema : FiscalBase<Cliente>
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteAptoParaEntrarNoSistema(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;

            var clienteDuplicado = new ClienteCadastradoNaBaseSpecification(_clienteRepository);

            base.AdicionarRegra("ClienteDuplicado", new Regra<Cliente>(clienteDuplicado, "Já existe o mesmo CPF cadastrado na base"));
        }


    }
}