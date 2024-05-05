namespace TaskBySibers.Models
{
    public class Project : BaseModel
    {
        public string? Name { get; set; }
        public string? CustomerCompanyName { get; set; } //Name of customer company
        public string? PrformerCompany { get; set; }
        public DateTime? StartProjectDate { get; set; }
        public DateTime? EndProjectDate { get; set; }
        public int ProjectPriority { get; set; }
        public int TeamLeadId { get; set; }
        public Employee TeamLead { get; set; } //project manager
        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set;}

        public Project ()
        {
            ProjectEmployees = new List<ProjectEmployee> ();
        }

    }
}
