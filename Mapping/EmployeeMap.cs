using AutoMapper;
using TaskBySibers.Models;
using TaskBySibers.ViewModels;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Mapping
{
    public class EmployeeMap : Profile
    {
        public EmployeeMap()
        {
            CreateMap<Employee, EmployeeVM>();
            CreateMap<EmployeeVM, Employee>();
            CreateMap<List<Employee>, List<Employee>>();
            CreateMap<List<Employee>, List<Employee>>();
        }
    }
}
