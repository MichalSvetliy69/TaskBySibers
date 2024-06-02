using TaskBySibers.Data.Context;
using TaskBySibers.Models;
using TaskBySibers.Repository.Interfaces;


namespace TaskBySibers.Repository.Implementation
{
    public class BaseRepository<TDbModel> : IBaseRepository<TDbModel> where TDbModel : BaseModel
    {
        protected MSSQLContext Context { get; set; }
        public BaseRepository(MSSQLContext context)
        {
            Context = context;
        }

        public TDbModel Create(TDbModel model)
        {
            Context.Set<TDbModel>().Add(model);
            Context.SaveChanges();
            return model;
        }

        public void Delete(int Id)
        {
            var toDelete = Context.Set<TDbModel>().FirstOrDefault(m => m.Id == Id);
            Context.Set<TDbModel>().Remove(toDelete);
            Context.SaveChanges();
        }

        public List<TDbModel> GetAll()
        {
            return Context.Set<TDbModel>().ToList();
        }

        public TDbModel Update(TDbModel model)
        {
            var toUpdate = Context.Set<TDbModel>().FirstOrDefault(m => m.Id == model.Id);
            if (toUpdate != null)
            {
                Context.Entry(toUpdate).CurrentValues.SetValues(model);
                Context.SaveChanges();
            }
            
            return toUpdate;
        }

        public TDbModel Get(int Id)
        {
            return Context.Set<TDbModel>().FirstOrDefault(m => m.Id == Id);
        }
    }
}
