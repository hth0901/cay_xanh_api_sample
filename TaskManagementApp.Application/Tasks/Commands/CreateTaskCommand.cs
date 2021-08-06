﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp.Application.Tasks.Commands
{
    public class CreateTaskCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime DueDate { get; set; }
    }
}
