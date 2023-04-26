using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Modele;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Services
{
    public class TypZasobuService
    {
        private readonly Repository<TypZasobu> _repository = new Repository<TypZasobu>();

        public IEnumerable<TypZasobuCmb> ViewData()
            => _repository
                .Get()
                .AsEnumerable()
                .Select(x => new TypZasobuCmb
                {
                    Nazwa = x.Nazwa,
                }).Distinct().ToList();
    }
}
