using System.Linq;
using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Repository;

namespace CursoMVCAbril.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCpf(string cpf)
        {
            return Find(c => c.CPF == cpf).FirstOrDefault();
        }
    }
}