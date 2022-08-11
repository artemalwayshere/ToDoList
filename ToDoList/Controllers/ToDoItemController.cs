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
        private readonly IRepository _repo;

        public ToDoItemController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult ToDoItem(int id)
        {
            var responseItem = _repo.GetItem(id);
            return View(responseItem);
        }

        [HttpGet]
        public IActionResult CreateItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ToDoItem item)
        {
            var toDoitem = new ToDoItem
            {
                Id = item.Id,
                Title = item.Title,
                Description = item.Description
            };

            if (toDoitem.Id < 1)
            {
                _repo.CreateItem(toDoitem);
            }
            else
            {

            }

            if (await _repo.SaveChangesAsync())
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(toDoitem);
            }
        }
    }
}
