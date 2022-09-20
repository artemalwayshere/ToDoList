using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data;

namespace ToDoList.Controllers
{
    public class ToDoDoneItemController : Controller
    {
        private IRepository _repo;

        public ToDoDoneItemController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var responseItems = _repo.GetItemList().Where(i => i.IsDone == true);
            return View(responseItems);
        }
    }
}
