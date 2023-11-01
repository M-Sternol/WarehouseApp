using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Application.Interfaces;
using WarehouseApp.Application.ViewModel.Customer;
using WarehouseApp.Domain.Interfaces;

namespace WarehouseApp.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IMapper _mapper;
        public CustomerService ( ICustomerRepository customerRepo, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
        }
        public int AddCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVm GetAllCustomersForList()
        {
            var customers = _customerRepo.GetAllActiveCustomer()
                .ProjectTo<CustomerForListVm>(_mapper.ConfigurationProvider).ToList();

            var customerList = new ListCustomerForListVm()
            {
                Customers = customers,
                Count = customers.Count
            };

            return customerList;
            
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            var customer = _customerRepo.GetCustomer(customerId);
            var customerVm = _mapper.Map<CustomerDetailsVm>(customer);

            customerVm.Addresses = new List<AddressForListVm>();
            customerVm.PhoneNumbers = new List<ContactDetailListVm>();
            customerVm.Emails = new List<ContactDetailListVm>();

            foreach (var address in customer.Addresses)
            {
                var add = new AddressForListVm()
                {
                    Id = address.Id,
                    Country = address.Country,
                    City = address.City
                };
                customerVm.Addresses.Add(add);
            }
            return customerVm;

            

        }
    }
}
