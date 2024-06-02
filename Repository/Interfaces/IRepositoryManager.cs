namespace TaskBySibers.Repository.Interfaces
{
    public interface IRepositoryManager
    {
        IEmployeeRepository EmployeeRepository { get; }
        void Save();
    }
}
