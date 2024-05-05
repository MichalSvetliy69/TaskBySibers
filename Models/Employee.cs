namespace TaskBySibers.Models
{
    public class Employee : BaseModel
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? SurName { get; set; }
        public string? Email { get; set; }
        public string? EmployeeStatus { get; set; }
        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }
        public Employee()
        {
            ProjectEmployees = new List<ProjectEmployee>();
        }

    }
}
