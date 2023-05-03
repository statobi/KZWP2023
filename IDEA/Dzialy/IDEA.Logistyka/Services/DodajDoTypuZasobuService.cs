using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class DodajDoTypuZasobuService
    {
        private readonly Repository<TypZasobu> _repository = new Repository<TypZasobu>();

        public IEnumerable<TypZasobuCmb> GetTypZasobu()
            => _repository
                .Get()
                .AsEnumerable()
                .Select(x => new TypZasobuCmb
                {
                    Id = x.ID_TypZasobu,
                    Name = x.Nazwa
                }).ToList();

        public void AddTypZasobu(string name)
            => _repository.Add(new TypZasobu
            {
                Nazwa = name
            });
    }
}
