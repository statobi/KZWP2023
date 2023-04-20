namespace IDEA.Database.Repozytoria
{
    public abstract class Repozytorium
    {
        protected IDEAEntities _db;

        public Repozytorium()
        {
            _db = new IDEAEntities();
        }

        public int SaveChanges()
            => _db.SaveChanges();
    }
}
