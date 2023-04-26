using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace IDEA.Database.Repozytoria
{
    public class Repository<T> where T : class
    {
        private readonly IDEAEntities _dbContext = IDEADatabase.GetInstance();
        private readonly DbSet<T> _dbSet = null;

        public Repository()
        {
            _dbSet = _dbContext.Set<T>();
        }

        public DbSet<T> Get()
            => _dbSet;

        public T GetById(int id)
            => _dbSet.Find(id);

        public bool Add(T rekord)
        {
            _dbSet.Add(rekord);
            return SaveChanges();
        }

        public bool Update(int id, T entity)
        {
            if (GetById(id) is null)
                return false;

            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public bool Delete(int id)
        {
            var entity = GetById(id);
            if (entity is null)
                return false;

            _dbSet.Remove(entity);
            return SaveChanges();
        }

        public bool SaveChanges()
            => _dbContext.SaveChanges() > 0;
    }
}
