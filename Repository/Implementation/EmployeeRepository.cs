using Microsoft.EntityFrameworkCore;
using TaskBySibers.Data.Context;
using TaskBySibers.Models;
using TaskBySibers.Repository.Interfaces;

namespace TaskBySibers.Repository.Implementation
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        protected MSSQLContext Context { get; set; }


        public EmployeeRepository(MSSQLContext context) : base (context)
        {
            Context = context;
        }


        public Employee Create(Employee model)
        {
            Context.Set<Employee>().Add(model);
            Context.SaveChanges();
            return model;
        }

        public void Delete(int Id)
        {
            var toDelete = Context.Set<Employee>().FirstOrDefault(m => m.Id == Id);
            Context.Set<Employee>().Remove(toDelete);
            Context.SaveChanges();
        }

        public Employee Get(int Id)
        {
            return Context.Set<Employee>().FirstOrDefault(m => m.Id == Id);
        }

        public List<Employee> GetAll()
        {
            return Context.Set<Employee>().ToList();
        }

        //public List<Employee> GetAllEmployeesByProject(int projectId)
        //{
        //    return Context.Set<ProjectEmployee>()
        //              .Where(pe => pe.ProjectId == projectId)
        //              .Include(pe => pe.Employee)
        //              .Select(pe => pe.Employee)
        //              .ToList();
        //}

        public Employee Update(Employee model)
        {
            var toUpdate = Context.Set<Employee>().FirstOrDefault(m => m.Id == model.Id);
            if (toUpdate != null)
            {
                Context.Entry(toUpdate).CurrentValues.SetValues(model);
                Context.SaveChanges();
            }

            return toUpdate;
        }
    }
}
