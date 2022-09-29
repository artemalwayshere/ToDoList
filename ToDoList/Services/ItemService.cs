using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class ItemService
    {
        private readonly IRepository repo; 

        public ItemService(IRepository _repo)
        {
            repo = _repo;
        }

        public IEnumerable<ToDoItem> SortByDate(IRepository repo)
        {
            var responseByDate = repo.GetItemList().OrderBy(i => i.DateTimeCreate);
            return responseByDate;
        }
    }
}
