using System;
using System.Collections.Generic;

namespace ToDoService.Models
{
    public partial class Scheduler
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
