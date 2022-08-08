﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public bool IsDone { get; set; }
    }
}
