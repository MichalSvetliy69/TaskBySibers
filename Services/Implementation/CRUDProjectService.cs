using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TaskBySibers.Data.Context;
using TaskBySibers.Models;
using TaskBySibers.Repository.Implementation;
using TaskBySibers.Repository.Interfaces;
using TaskBySibers.Services.interfaces;
using TaskBySibers.Validation;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Services
{
    public class CRUDProjectService : ICRUDProjectService
    {
        private BaseRepository<Project> _repository;
        private readonly IMapper _mapper;
        private DataValidator<Project> _projectValidator;
        public CRUDProjectService(BaseRepository<Project> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _projectValidator = new DataValidator<Project>();
        }
        public string AddProjectAsync(ProjectVM projectVM)
        {
            try
            {
                Project project = _mapper.Map<Project>(projectVM);
                var ValidResult = _projectValidator.Validate(project);
                if (!ValidResult.IsValid)
                {
                    return null;
                }
                _repository.Create(project);
                return "Successfull added!";
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string DeleteProject(int projectId)
        {
            try
            {
                _repository.Delete(projectId);
                return "Successfull deleted!";
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ProjectVM> GetAllProjects()
        {
            try
            {
                return (_mapper.Map<List<ProjectVM>>(_repository.GetAll()));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ProjectVM GetProject(int projectId)
        {
            try
            { 
                return (_mapper.Map<ProjectVM>(_repository.Get(projectId)));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string UpdateProject(ProjectVM projectVM)
        {
            try
            {

                Project project = _mapper.Map<Project>(projectVM);
                var ValidResult = _projectValidator.Validate(project);
                if (!ValidResult.IsValid)
                {
                    return null;
                }
                _repository.Update(project);
                return "Successful update!";
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
