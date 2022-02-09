using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.Handlers;
using BaltaStore.Domain.StoreContext.Queries;
using BaltaStore.Domain.StoreContext.Repositories;
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
        [Route("customers")]
        public IEnumerable<ListCustomerOrdersQueryResult> Get()
        {
            return _repository.Get();
        }

        [HttpGet]
        [Route("customers/{id:Guid}")]
        public GetCustomerQueryResult GetById(Guid id)
        {
            return _repository.Get(id);
        }

        [HttpGet]
        [Route("customers/{id:Guid}/orders")]
        public IEnumerable<ListCustomerOrdersQueryResult> GetOrders(Guid id)
        {
            return _repository.GetOrders(id);
        }

        [HttpPost]
        [Route("customers")]
        public object Post([FromBody]CreateCustomerCommand command)
        {
            var result = (CreateCustomerCommand)_handler.Handle(command);

            if(_handler.IsValid)
                return result;

            return BadRequest(_handler.Notifications);
        }

        [HttpPut]
        [Route("customers/{id:Guid}")]
        public Customer Put(Guid id)
        {
            return null;
        }
        
        [HttpDelete]
        [Route("customers/{id:Guid}")]
        public object Delete(Guid id)
        {
            return new { message = "Removido com sucesso" };
        }
    }
}
