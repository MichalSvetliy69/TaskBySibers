using AutoMapper;
using TaskBySibers.Models;
using TaskBySibers.Repository.Implementation;
using TaskBySibers.Services.interfaces;
using TaskBySibers.ViewModels;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Services.Implementation
{
    public class CRUDEmployeeService : ICRUDEmployeeService
    {
        private BaseRepository<Employee> _repository;
        private readonly IMapper _mapper;

        public CRUDEmployeeService(BaseRepository<Employee> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public string AddEmployee(EmployeeVM employeeVM)
        {
            try
            {
                _repository.Create(_mapper.Map<Employee>(employeeVM));
                return "Successfull added!";
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string DeleteEmployee(int employeeId)
        {
            try
            {
                _repository.Delete(employeeId);
                return "Successfull deleted!";
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<EmployeeVM> GetAllEmployees()
        {
            try
            {
                return (_mapper.Map<List<EmployeeVM>>(_repository.GetAll()));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public EmployeeVM GetEmployee(int employeeId)
        {
            try
            {
                return (_mapper.Map<EmployeeVM>(_repository.Get(employeeId)));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string UpdateEmployee(EmployeeVM employeeVM)
        {
            try
            {
                _repository.Update(_mapper.Map<Employee>(employeeVM));
                return "Successful update!";
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
