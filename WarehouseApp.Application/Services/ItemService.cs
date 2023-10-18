using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Application.Interfaces;

namespace WarehouseApp.Application.Services
{
    public class ItemService : IItemService
    {
        public List<int> GetAllItems()
        {
            var items = new List<int>();
            return items;
        }
    }
}
