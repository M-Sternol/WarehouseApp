using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Domain.Model;
using Type = WarehouseApp.Domain.Model.Type;

namespace WarehouseApp.Domain.Interfaces
{
    public interface IItemRepository
    {
        void DeleteItem(int itemId);
        int AddItem(Item item);
        IQueryable<Item> GetItemsByTypeId(int typeId);
        Item GetItemById(int itemId);
        IQueryable<Tag> GetAllTags();
        IQueryable<Type> GetAllTypes();
    }
}
