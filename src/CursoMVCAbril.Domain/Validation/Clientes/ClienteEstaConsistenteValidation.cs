using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Specification.Clientes;
using CursoMVCAbril.Domain.Validation.Base;

namespace CursoMVCAbril.Domain.Validation.Clientes
{
    public class ClienteEstaConsistenteValidation : FiscalBase<Cliente>
    {
        public ClienteEstaConsistenteValidation()
        {
            var clienteEndereco = new ClientePossuiEnderecoCadastradoSpecification();
            var clienteAtivo = new ClientePossuiStatusAtivo();
            var clienteCPFValido = new ClientePossuiCPFValido();
            var clienteMaior = new ClienteMaiorDe18AnosSpecification();

            base.AdicionarRegra("clienteEndereco", new Regra<Cliente>(clienteEndereco, "Cliente não possui endereço cadastrado"));
            base.AdicionarRegra("clienteAtivo", new Regra<Cliente>(clienteAtivo, "Cliente não está ativo no sistema"));
            base.AdicionarRegra("clienteCPFValido", new Regra<Cliente>(clienteCPFValido, "Cliente informou um CPF inválido"));
            base.AdicionarRegra("clienteMaior", new Regra<Cliente>(clienteMaior, "Cliente menor de 18 anos"));
        }
    }
}