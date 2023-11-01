using Microsoft.AspNetCore.Mvc;
using WarehouseApp.Application.Interfaces;
using WarehouseApp.Application.ViewModel.Customer;
using WarehouseApp.Domain.Model;

namespace WarehouseApp.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _custService;
        public CustomerController(ICustomerService custService) 
        { 
            _custService = custService;
        }

        public IActionResult Index()
        {
            var model = _custService.GetAllCustomersForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddCustomer() 
        { 
            return View();
        }
        //[HttpPost]
        //public IActionResult AddCustomer(NewCustomerVm model)
        //{
        //    var id = _custService.AddCustomer(model);
        //    return View();
        //}
        [HttpGet]
        public IActionResult AddNewAdressForClient(int customerId)
        {
            return View();
        }
       // [HttpPost]
        //public IActionResult AddNewAdressForClient(Address model) 
        //{
        //    return View();
        //}
        //public IActionResult ViewCustomer(int customerId) 
        //{
        //    var customerModel = _custService.GetCustomerDetails(customerId);
        //    return View(customerModel);
        //}
    }
}
