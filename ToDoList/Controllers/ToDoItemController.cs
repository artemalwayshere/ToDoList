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

        public async Task<IActionResult> Remove(int id)
        {
            _repo.DeleteItem(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult UpdateItem(int? id)
        {
            if (id == null)
            {
                return View(new ToDoItem());
            }
            else
            {
                var item = _repo.GetItem((int)id);
                return View(new ToDoItem
                {
                    Id = item.Id,
                    Title = item.Title,
                    DateTimeCreate = item.DateTimeCreate
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateItem(ToDoItem updItem)
        {
            var item = new ToDoItem
            {
                Id = updItem.Id,
                Title = updItem.Title,
                DateTimeCreate = updItem.DateTimeCreate,
            };

            if(item.Id > 0)
            {
                _repo.UpdateItem(item);
            }
            else
            {
                _repo.CreateItem(item);
            }

            if(await _repo.SaveChangesAsync())
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(item);
            }
        }
    }
}
