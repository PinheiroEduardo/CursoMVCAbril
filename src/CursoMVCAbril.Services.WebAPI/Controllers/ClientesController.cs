using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CursoMVCAbril.Application;
using CursoMVCAbril.Application.Interface;
using CursoMVCAbril.Application.ViewModels;

namespace CursoMVCAbril.Services.WebAPI.Controllers
{
    public class ClientesController : ApiController
    {
        private readonly IClienteAppService _clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }
        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return _clienteAppService.ObterTodos();
        }

        // GET: api/Clientes/5
        public ClienteViewModel Get(Guid id)
        {
            return _clienteAppService.ObterPorId(id);
        }

        // POST: api/Clientes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clientes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clientes/5
        public void Delete(int id)
        {
        }
    }
}
