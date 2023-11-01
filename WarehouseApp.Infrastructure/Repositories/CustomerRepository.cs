using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Domain.Interfaces;
using WarehouseApp.Domain.Model;

namespace WarehouseApp.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Context _context;
        public CustomerRepository (Context context)
        {
            _context = context;
        }
        public IQueryable<Customer> GetAllActiveCustomer()
        {
            return _context.Customer.Where(p => p.IsActive);
        }

        public Customer GetCustomer(int customerId)
        {
           return _context.Customer.FirstOrDefault(p => p.Id == customerId);
        }
    }
}
