﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class ToDoItemViewModel
    {
        public IEnumerable<ToDoItem> ToDolist { get; set; }
        public ToDoItem ToDo { get; set; }
    }
}
