using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using BaltaStore.Domain.StoreContext.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BaltaStore.Api.Controllers
{    
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("customers")]
        public List<Customer> Get()
        {
            return null;
        }

        [HttpGet]
        [Route("customers/{id:Guid}")]
        public Customer GetById(Guid id)
        {
            return null;
        }

        [HttpGet]
        [Route("customers/{id:Guid}/orders")]
        public List<Order> GetOrders(Guid id)
        {
            return null;
        }


        [HttpPost]
        [Route("customers")]
        public Customer Post([FromBody]CreateCustomerCommand command)
        {
            return null;
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
