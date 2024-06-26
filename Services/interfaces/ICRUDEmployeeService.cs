﻿using TaskBySibers.ViewModels;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Services.interfaces
{
    public interface ICRUDEmployeeService
    {
        EmployeeVM GetEmployee(int employeeId);
        List<EmployeeVM> GetAllEmployees();
        List<EmployeeVM> GetAllEmployeesByProject(int projectId);
        string AddEmployee(EmployeeVM employeeVM);
        string UpdateEmployee(EmployeeVM employeeVM);
        string DeleteEmployee(int employeeId);
    }
}
