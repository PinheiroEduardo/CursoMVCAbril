using CursoMVCAbril.Domain.Entities;

namespace CursoMVCAbril.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
    }
}