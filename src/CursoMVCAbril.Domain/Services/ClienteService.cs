using System;
using System.Collections.Generic;
using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Repository;
using CursoMVCAbril.Domain.Interfaces.Repository.ReadOnly;
using CursoMVCAbril.Domain.Interfaces.Services;
using CursoMVCAbril.Domain.ValueObjects;

namespace CursoMVCAbril.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteReadOnlyRepository _clienteReadOnlyRepository;

        public ClienteService(IClienteRepository clienteRepository, IClienteReadOnlyRepository clienteReadOnlyRepository)
        {
            _clienteRepository = clienteRepository;
            _clienteReadOnlyRepository = clienteReadOnlyRepository;
        }

        public ValidationResult Adicionar(Cliente cliente)
        {
            //regras
            var resultadovalidacao = new ValidationResult();
            if (!cliente.IsValid())
            {
                resultadovalidacao.AdicionarErro(cliente.ResultadoValidacao);
                return resultadovalidacao;
            }
            _clienteRepository.Add(cliente);
            return resultadovalidacao;
        }

        public Cliente ObterPorId(Guid id)
        {
           return _clienteReadOnlyRepository.ObterPorId(id);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return _clienteReadOnlyRepository.ObterPorCpf(cpf);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteReadOnlyRepository.ObterTodos();
        }

        public void Atualizar(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }

        public void Remover(Cliente cliente)
        {
            _clienteRepository.Remove(cliente);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}