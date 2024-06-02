using TaskBySibers.Models;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Services.interfaces
{
    public interface ICRUDProjectService
    {
        ProjectVM GetProject(int projectId);
        List<ProjectVM> GetAllProjects();
        string AddProjectAsync (ProjectVM project);
        string UpdateProject (ProjectVM project);
        string DeleteProject (int projectId);

    }
}
