using System.Collections.Generic;
using System.Linq;

namespace IDEA.Database.Repozytoria
{
    public class MagazynRepozytorium : Repozytorium
    {
        public List<Magazyn> PobierzWszystko()
            => _db.Magazyns.ToList();

        public Magazyn PobierzPoId(int id)
            => _db.Magazyns.FirstOrDefault(x => x.ID_Magazyn == id);

        public void Dodaj(Magazyn magazyn)
            => _db.Magazyns.Add(magazyn);
    }
}
