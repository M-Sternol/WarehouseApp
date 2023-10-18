using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp.Application.Interfaces
{
    public interface IItemService
    {
        List<int> GetAllItems();
    }
}
