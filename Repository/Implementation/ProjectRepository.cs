using TaskBySibers.Data.Context;
using TaskBySibers.Models;
using TaskBySibers.Repository.Interfaces;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Repository.Implementation
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(MSSQLContext context) : base(context)
        {
        }

       
    }
}
