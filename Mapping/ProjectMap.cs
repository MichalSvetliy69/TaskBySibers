using AutoMapper;
using TaskBySibers.Models;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Mapping
{
    public class ProjectMap : Profile
    {
        public ProjectMap()
        {
            CreateMap<Project, ProjectVM>(); 
            CreateMap<ProjectVM, Project>();
            //CreateMap<List<Project>, List<ProjectVM>>();
            //CreateMap<List<ProjectVM>, List<Project>>();
        }
    }
}
