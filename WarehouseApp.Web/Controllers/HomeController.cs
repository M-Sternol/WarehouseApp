using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WarehouseApp.Application.Interfaces;
using WarehouseApp.Domain.Model;
using WarehouseApp.Web.Models;
using WarehouseApp.Application.Interfaces;
using Item = WarehouseApp.Web.Models.Item;

namespace WarehouseApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemService _itemService;

        public HomeController(ILogger<HomeController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }
        public IActionResult Index()
        {
            var items = _itemService.GetAllItems();
            return View(items);
        }
        public IActionResult ViewListOfItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Id = 1, Name = "Truskawka", TypeName = "Owoce" });
            items.Add(new Item() { Id = 2, Name = "Pomarańcza", TypeName = "Owoce" });
            items.Add(new Item() { Id = 3, Name = "Jabłko", TypeName = "Owoce" });
            return View(items);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}