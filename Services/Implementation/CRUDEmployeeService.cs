using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using TaskBySibers.Data.Context;
using TaskBySibers.Models;
using TaskBySibers.Repository.Implementation;
using TaskBySibers.Repository.Interfaces;
using TaskBySibers.Services.interfaces;
using TaskBySibers.Validation;
using TaskBySibers.ViewModels;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Services.Implementation
{
    public class CRUDEmployeeService : ICRUDEmployeeService
    {
        private IEmployeeRepository _repository;
        private readonly IMapper _mapper;
        private DataValidator<Employee> _projectValidator;
        private MSSQLContext _context;
        IRepositoryManager _repositoryManager;
        public CRUDEmployeeService(IMapper mapper, MSSQLContext context, IRepositoryManager repositoryManager) //
        {
            //_repository = repository;
            _mapper = mapper;
            _projectValidator = new DataValidator<Employee>();
            _context = context;
            _repositoryManager = repositoryManager;
        }

        public string AddEmployee(EmployeeVM employeeVM)
        {
            try
            {
                Employee employee = _mapper.Map<Employee>(employeeVM);
                var ValidResult = _projectValidator.Validate(employee);
                if (!ValidResult.IsValid)
                {
                    return null;
                }
                _repositoryManager.EmployeeRepository.Create(employee);
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
                _repositoryManager.EmployeeRepository.Delete(employeeId);
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
                
                return (_mapper.Map<List<EmployeeVM>>(_repositoryManager.EmployeeRepository.GetAll()));
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
                return (_mapper.Map<EmployeeVM>(_repositoryManager.EmployeeRepository.Get(employeeId)));
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
                Employee employee = _mapper.Map<Employee>(employeeVM);
                var ValidResult = _projectValidator.Validate(employee);
                if (!ValidResult.IsValid)
                {
                    return null;
                }
                _repositoryManager.EmployeeRepository.Update(employee);
                return "Successful update!";
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<EmployeeVM> GetAllEmployeesByProject(int projectId)
        {
            try
            {

                return (_mapper.Map<List<EmployeeVM>>(_repositoryManager.EmployeeRepository.GetAll()));
            }
            catch (Exception)
            {
                return null;
            }
        }
            
    }
}
