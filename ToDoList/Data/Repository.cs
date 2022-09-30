using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _appContext;

        public Repository(AppDbContext context)
        {
            _appContext = context;
        }

        public void CreateItem(ToDoItem item)
        {
            _appContext.ToDoItems.Add(item);
        }

        public void DeleteItem(int id)
        {
            _appContext.Remove(GetItem(id));
        }

        public ToDoItem GetItem(int id)
        {
            return _appContext.ToDoItems.FirstOrDefault(item => item.Id == id);
        }

        public IEnumerable<ToDoItem> GetItemList()
        {
            return _appContext.ToDoItems.ToList();
        }

        public void UpdateItem(ToDoItem item)
        {
            _appContext.ToDoItems.Update(item);
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _appContext.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        //public IEnumerable<ToDoItem> GetItemsForDate()
        //{
        //    var items = new List<ToDoItem>();
        //}
    }
}
