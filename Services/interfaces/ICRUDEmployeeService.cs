using TaskBySibers.ViewModels;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Services.interfaces
{
    public interface ICRUDEmployeeService
    {
        EmployeeVM GetEmployee(int projectId);
        List<EmployeeVM> GetAllEmployees();
        string AddEmployee(EmployeeVM employeeVM);
        string UpdateEmployee(EmployeeVM employeeVM);
        string DeleteEmployee(int employeeId);
    }
}
