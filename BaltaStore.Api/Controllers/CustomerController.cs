using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Outputs;
using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.Handlers;
using BaltaStore.Domain.StoreContext.Queries;
using BaltaStore.Domain.StoreContext.Repositories;
using BaltaStore.Shared.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BaltaStore.Api.Controllers
{    
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;
        private readonly CustomerHandler _handler;

        public CustomerController(ICustomerRepository repository, CustomerHandler handler)
        {
            _repository = repository;
            _handler = handler;
        }

        [HttpGet]
        [Route("v1/customers")]
        [ResponseCache(Duration = 15)]
        public IEnumerable<ListCustomerOrdersQueryResult> Get()
        {
            return _repository.Get();
        }

        [HttpGet]
        [Route("v1/customers/{id:Guid}")]
        public GetCustomerQueryResult GetById(Guid id)
        {
            return _repository.Get(id);
        }
        
        [HttpGet]
        //metodo não esta funcionando. Somente para simular versionamento de rota
        [Route("v2/customers/{id:Guid}")]
        public GetCustomerQueryResult GetByDocument(Guid id)
        {
            return _repository.Get(id);
        }

        [HttpGet]
        [Route("v1/customers/{id:Guid}/orders")]
        public IEnumerable<ListCustomerOrdersQueryResult> GetOrders(Guid id)
        {
            return _repository.GetOrders(id);
        }

        [HttpPost]
        [Route("v1/customers")]
        public ICommandResult Post([FromBody]CreateCustomerCommand command)
        {
            var result = (CreateCustomerCommandResult)_handler.Handle(command);

            return result;           
        }

        [HttpPut]
        [Route("v1/customers/{id:Guid}")]
        public Customer Put(Guid id)
        {
            return null;
        }
        
        [HttpDelete]
        [Route("v1/customers/{id:Guid}")]
        public object Delete(Guid id)
        {
            return new { message = "Removido com sucesso" };
        }
    }
}
