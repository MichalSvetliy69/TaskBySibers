using TaskBySibers.Data.Context;
using TaskBySibers.Models;
using TaskBySibers.Repository.Interfaces;

namespace TaskBySibers.Repository.Implementation
{
    public class ProjectRepository : BaseRepository<Project>
    {
        public ProjectRepository(MSSQLContext context) : base(context)
        {
        }

    }
}
