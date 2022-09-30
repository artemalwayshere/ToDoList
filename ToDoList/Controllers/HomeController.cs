using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repo;

        public HomeController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index(string sortOrder)
        {
            ViewData["DateSortParam"] = sortOrder == "Date" ? "date_desc" : "Date";

            var responseItem = _repo.GetItemList();

            switch (sortOrder)
            {
                case "date_desc":
                    responseItem =  responseItem.OrderBy(i => i.DateTimeCreate);
                    break;
                case "Date":
                    responseItem = responseItem.OrderByDescending(i => i.DateTimeCreate);
                    break;
                default:
                    responseItem = responseItem.OrderBy(s => s.DateTimeCreate);
                    break;
            }

            return View(responseItem);
        }
    }
}
