using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectManagementHelper
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public IList<Task> Tasks { get; set; } = new List<Task>();
    }
}
