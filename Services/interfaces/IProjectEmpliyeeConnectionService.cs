using TaskBySibers.ViewModels;

namespace TaskBySibers.Services.interfaces
{
    public interface IProjectEmpliyeeConnectionService
    {
        public string AddEmployeeByProject(ProjectEmployeeVM projectEmployeeVM);
        public string DeleteEmployeeByProject(ProjectEmployeeVM projectEmployeeVM);
        public List<EmployeeVM> GetAllEmployeesByProject(int projectId);
    }
}
