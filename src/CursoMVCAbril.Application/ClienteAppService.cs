using System;
using System.Collections.Generic;
using AutoMapper;
using CursoMVCAbril.Application.Interface;
using CursoMVCAbril.Application.Validation;
using CursoMVCAbril.Application.ViewModels;
using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Services;
using CursoMVCAbril.Infra.Data.Repositories;
using CursoMVCAbril.Infra.Data.Repositories.ReadOnly;

namespace CursoMVCAbril.Application
{
    public class ClienteAppService : AppServiceBase, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public ValidationAppResult Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);

            cliente.Enderecos.Add(endereco);

            BeginTransaction();

            var result = _clienteService.Adicionar(cliente);
            if (!result.IsValid)
            {
                return DomainToApplicationResult(result);
            }

            Commit();
            return DomainToApplicationResult(result);
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            var cliente = _clienteService.ObterPorId(id);
            return Mapper.Map<Cliente, ClienteViewModel>(cliente);
        }

        public ClienteViewModel ObterPorCPF(string cpf)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorCPF(cpf));
        }

        public void Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
            _clienteService.Atualizar(cliente);
        }

        public void Remover(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
            _clienteService.Remover(cliente);
        }

        public void Dispose()
        {
            _clienteService.Dispose();
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            var clientes = _clienteService.ObterTodos();
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clientes);
        }
    }
}