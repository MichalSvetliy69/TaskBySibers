using AutoMapper;
using TaskBySibers.Data.Context;
using TaskBySibers.Models;
using TaskBySibers.Repository.Implementation;
using TaskBySibers.Services.interfaces;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Services
{
    public class CRUDProjectService : ICRUDProjectService
    {
        private BaseRepository<Project> _repository;
        private readonly IMapper _mapper;
        public CRUDProjectService(BaseRepository<Project> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
    }
        public string AddProject(ProjectVM projectVM)
        {
            try
            {
                _repository.Create(_mapper.Map<Project>(projectVM));
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

        public string UpdateProject(ProjectVM project)
        {
            try
            {
                _repository.Update(_mapper.Map<Project>(project));
                return "Successful update!";
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
