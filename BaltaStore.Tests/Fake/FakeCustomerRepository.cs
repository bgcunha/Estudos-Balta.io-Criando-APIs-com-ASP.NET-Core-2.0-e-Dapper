using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.Queries;
using BaltaStore.Domain.StoreContext.Repositories;
using System;
using System.Collections.Generic;

namespace BaltaStore.Tests.Fake
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public bool CheckDocument(string document)
        {
            return false;
        }

        public bool CheckEmail(string email)
        {
            return false;
        }

        public IEnumerable<ListCustomerOrdersQueryResult> Get()
        {
            return null;
        }

        public GetCustomerQueryResult Get(Guid id)
        {
            return null;
        }

        public CustomerOrdersCountResult GetCustomerOrdersCount(string document)
        {
            return null;
        }

        public IEnumerable<ListCustomerOrdersQueryResult> GetOrders(Guid id)
        {
            return null;
        }

        public void Save(Customer customer)
        {
            
        }
    }
}
