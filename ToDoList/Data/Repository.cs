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
        void IRepository.CreateItem(ToDoItem item)
        {
            throw new NotImplementedException();
        }

        void IRepository.DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        ToDoItem IRepository.GetItem(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ToDoItem> IRepository.GetItemList()
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        void IRepository.UpdateItem(ToDoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
