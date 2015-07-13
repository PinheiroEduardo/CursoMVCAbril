using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Specification;
using CursoMVCAbril.Domain.Validation.Documentos;

namespace CursoMVCAbril.Domain.Specification.Clientes
{
    public class ClientePossuiCPFValido : ISpecification<Cliente>
    {

        public bool IsSatisfieldBy(Cliente cliente)
        {
            return CPFValidation.Validar(cliente.CPF);
        }
    }
}