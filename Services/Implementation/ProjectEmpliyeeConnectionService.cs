using AutoMapper;
using TaskBySibers.Models;
using TaskBySibers.Repository.Implementation;
using TaskBySibers.Services.interfaces;
using TaskBySibers.ViewModels;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Services.Implementation
{
    public class ProjectEmpliyeeConnectionService : IProjectEmpliyeeConnectionService
    {
        private ProjectEmpliyeeConnectionRepository _repository;
        private readonly IMapper _mapper;

        public ProjectEmpliyeeConnectionService(ProjectEmpliyeeConnectionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public string AddEmployeeByProject(ProjectEmployeeVM projectEmployeeVM) //Creates a new project <==> Employee binding to add a new executor to the project
        {
            try
            {
                _repository.Create(projectEmployeeVM);
                return "Successfull added!";
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string DeleteEmployeeByProject(ProjectEmployeeVM projectEmployeeVM)
        {
            try
            {
                _repository.Delete(projectEmployeeVM);
                return "Successfull deleted!";
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
                return (_mapper.Map<List<EmployeeVM>>(_repository.GetAll(projectId)));
            }
            catch (Exception)
            {
                return null;
            }
        }


        //public string UpdateProject(ProjectEmployeeVM projectEmployeeVM)
        //{
        //    try
        //    {
        //        _repository.Update(_mapper.Map<ProjectEmployee>(projectEmployeeVM));
        //        return "Successful update!";
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
    }

}
