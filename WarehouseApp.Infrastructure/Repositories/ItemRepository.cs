﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Domain.Interfaces;
using WarehouseApp.Domain.Model;
using Type = WarehouseApp.Domain.Model.Type;

namespace WarehouseApp.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;
        public ItemRepository(Context context)
        {
            _context = context;
        }
        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if (item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }
        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item.Id;
        }
        public IQueryable<Item> GetItemsByTypeId(int typeId)
        {
            var items = _context.Items.Where(i => i.TypeId == typeId);
            return items;
        }
        public Item GetItemById(int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);
            return item;
        }
        public IQueryable<Tag> GetAllTags()
        {
            var tags = _context.Tags;
            return tags;
        }
        public IQueryable<Type> GetAllTypes()
        {
            var types = _context.Types;
            return types;
        }
    }
}
