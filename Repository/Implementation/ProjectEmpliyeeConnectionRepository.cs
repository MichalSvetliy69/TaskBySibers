using TaskBySibers.Repository.Interfaces;
using TaskBySibers.Repository.Implementation;
using TaskBySibers.Models;
using TaskBySibers.Data.Context;
using TaskBySibers.ViewModels;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Repository.Implementation
{
    public class ProjectEmpliyeeConnectionRepository : BaseRepository<ProjectEmployee> , IProjectEmpliyeeConnectionRepository
    {
        private MSSQLContext Context { get; set; }

        public ProjectEmpliyeeConnectionRepository(MSSQLContext context) : base(context)
        {
            Context = context;
        }

        public ProjectEmployeeVM Create(ProjectEmployeeVM projectEmpliyeeVM)
        {

            var existingModel = Context.Set<ProjectEmployee>()
                                   .FirstOrDefault(pe => pe.ProjectId == projectEmpliyeeVM.ProjectId && pe.EmployeeId == projectEmpliyeeVM.EmployeeId);
            if (existingModel!= null)
            {
                Context.Set<ProjectEmployee>().Add(new ProjectEmployee
                {
                    ProjectId = projectEmpliyeeVM.ProjectId,
                    EmployeeId = projectEmpliyeeVM.EmployeeId,
                });
                Context.SaveChanges();
                return projectEmpliyeeVM;
            }
            
            return null;
        }

        public void Delete(ProjectEmployeeVM projectEmpliyeeVM)
        {
            var existingModel = Context.Set<ProjectEmployee>()
                                   .FirstOrDefault(pe => pe.ProjectId == projectEmpliyeeVM.ProjectId && pe.EmployeeId == projectEmpliyeeVM.EmployeeId);
            if (existingModel != null)
            {
                Context.Set<ProjectEmployee>().Remove(existingModel);
                Context.SaveChanges();
            }
        }

        public List<Employee> GetAll(int projectId)
        {
            var existingModel = Context.Set<ProjectEmployee>()
                .Where(e => e.ProjectId == projectId)
                .Select(pe => pe.Employee).ToList();
            return existingModel;
        }


    }
}
