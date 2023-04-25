using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace IDEA.Database.Repozytoria
{
    public class Repository<T> where T : class
    {
        private readonly IDEAEntities _db = IDEADatabase.GetInstance();
        private readonly DbSet<T> _tabela = null;

        public Repository()
        {
            _tabela = _db.Set<T>();
        }

        public DbSet<T> Get()
            => _tabela;

        public T PobierzPoId(int id)
            => _tabela.Find(id);

        public void Dodaj(T rekord)
            => _tabela.Add(rekord);

        public int SaveChanges()
            => _db.SaveChanges();
    }
}
