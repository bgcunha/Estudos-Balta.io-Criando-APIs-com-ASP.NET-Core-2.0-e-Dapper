using BaltaStore.Domain.Queries;
using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Infra.StoreContext.Queries;
using System;
using System.Collections.Generic;

namespace BaltaStore.Domain.StoreContext.Repositories
{
    public interface ICustomerRepository
    {
        bool CheckDocument(string document);

        bool CheckEmail(string email);

        void Save(Customer customer);

        CustomerOrdersCountResult GetCustomerOrdersCount(string document);

        IEnumerable<ListCustomerOrdersQueryResult> Get();

        GetCustomerQueryResult Get(Guid id);

        IEnumerable<ListCustomerOrdersQueryResult> GetOrders(Guid id);

    }
}
