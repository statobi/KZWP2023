using IDEA.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Magazyny
{
    public class MagazynRepozytorium
    {
        private readonly IDEAEntities _db;
        public MagazynRepozytorium()
        {
            _db= new IDEAEntities();
        }

        public IEnumerable<Magazyn> PobierzMagazyny()
            => _db.Magazyn.ToList();
    }
}
