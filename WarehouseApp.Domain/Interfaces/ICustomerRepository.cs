using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Domain.Model;

namespace WarehouseApp.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetAllActiveCustomer();
        Customer GetCustomer(int id);
    }
}
