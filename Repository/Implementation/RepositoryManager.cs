using TaskBySibers.Data.Context;
using TaskBySibers.Repository.Interfaces;

namespace TaskBySibers.Repository.Implementation
{
    public class RepositoryManager : IRepositoryManager
    {
        private MSSQLContext _context;
        private IEmployeeRepository _employeeRepository;

        public RepositoryManager(MSSQLContext Context)
        {
            _context = Context;
        }

        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_context);
                return _employeeRepository;
            }
        }


        public void Save() => _context.SaveChanges();
    }
}
