using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ToDoItemController : Controller
    {
        private IRepository _repo;

        public ToDoItemController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult CreateItem(ToDoItem item)
        {
            _repo.CreateItem(item);
            return View();
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var responseItem = _repo.GetItemList();
            return View(responseItem);
        }
    }
}
