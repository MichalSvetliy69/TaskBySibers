﻿namespace TaskBySibers.Models
{
    public class ProjectEmployee : BaseModel
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
