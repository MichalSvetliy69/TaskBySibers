using TaskBySibers.Models;

namespace TaskBySibers.ViewModels.ProjectVM
{
    public class ProjectVM
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CustomerCompanyName { get; set; } //Name of customer company
        public string? PrformerCompany { get; set; }
        public DateTime? StartProjectDate { get; set; }
        public DateTime? EndProjectDate { get; set; }
        public int ProjectPriority { get; set; }
        public Employee TeamLead { get; set; } //project manager
    }
}
