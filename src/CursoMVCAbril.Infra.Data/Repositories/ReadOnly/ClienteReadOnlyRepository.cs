using System;
using System.Collections.Generic;
using System.Linq;
using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Repository.ReadOnly;
using Dapper;

namespace CursoMVCAbril.Infra.Data.Repositories.ReadOnly
{
    public class ClienteReadOnlyRepository : BaseReadOnlyRepository, IClienteReadOnlyRepository
    {
        public IEnumerable<Cliente> ObterTodos()
        {
            const string sql = @"select * from clientes c";

            using (var cn = Connection)
            {
                cn.Open();
                var cliente = cn.Query<Cliente>(sql);
                return cliente;
            }
        }

        public Cliente ObterPorId(Guid id)
        {
            const string sql = @"select * from clientes c " +
                               "inner join enderecos e " +
                               "on c.clienteid = e.clienteid " +
                               "where c.clienteid = @sid";

            using (var cn = Connection)
            {
                cn.Open();
                var cliente = cn.Query<Cliente, Endereco, Cliente>(sql,
                    (c, e) =>
                    {
                        c.Enderecos.Add(e);
                        return c;
                    }, new { sid = id }, splitOn: "ClienteId, EnderecoId");

                return cliente.FirstOrDefault();
            }
        }

        public Cliente ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}