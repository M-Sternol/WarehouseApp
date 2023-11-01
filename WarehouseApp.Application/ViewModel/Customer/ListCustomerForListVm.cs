using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp.Application.ViewModel.Customer
{
    public class ListCustomerForListVm
    {
        public List<CustomerForListVm> Customers { get; set; }
        public int Count { get; set; }
    }
}
