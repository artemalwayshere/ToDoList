using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [StringLength(255, MinimumLength = 3, ErrorMessage = "Длина строки от 4 до 255 знаков")]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeCreate { get; set; } = DateTime.Now;
        public bool IsDone { get; set; } = false;
        public DateTime DeadLineDate { get; set; }
    }
}
