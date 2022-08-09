using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Data
{
    interface IRepository
    {
        IEnumerable<ToDoItem> GetItemList();

        public ToDoItem GetItem(int id);
        public void CreateItem(ToDoItem item);
        public void UpdateItem(ToDoItem item);
        public void DeleteItem(int id);
        Task<bool> SaveChangesAsync();

    }
}
