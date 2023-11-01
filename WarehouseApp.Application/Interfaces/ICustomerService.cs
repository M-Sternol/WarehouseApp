using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Application.ViewModel.Customer;

namespace WarehouseApp.Application.Interfaces
{
    public interface ICustomerService
    {
        ListCustomerForListVm GetAllCustomersForList();
        int AddCustomer(NewCustomerVm customer);
        CustomerDetailsVm GetCustomerDetails(int customerId);
    }
}
