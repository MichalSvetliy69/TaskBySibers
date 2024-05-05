namespace TaskBySibers.Models
{
    public class Project : BaseModel
    {
        public string? Name { get; set; } 
        public string?  CustomerCompanyName { get; set; } //Name of customer company
        public string? PrformerCompany { get; set; }
        public DateTime? StartProjectDate { get; set; }
        public DateTime? EndProjectDate { get; set; }
        public int ProjectPriority { get; set;}
        public ICollection<Employee> Team { get; set; } //project participants
        public Employee TeamLead { get; set; } //project manager

    }
}
