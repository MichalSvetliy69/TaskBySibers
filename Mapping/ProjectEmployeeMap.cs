using AutoMapper;
using TaskBySibers.Models;
using TaskBySibers.ViewModels;

namespace TaskBySibers.Mapping
{
    public class ProjectEmployeeMap : Profile
    {
        public ProjectEmployeeMap()
        {
            CreateMap<ProjectEmployee, ProjectEmployeeVM>();
            CreateMap<ProjectEmployeeVM, ProjectEmployee>();

        }
    }
}
