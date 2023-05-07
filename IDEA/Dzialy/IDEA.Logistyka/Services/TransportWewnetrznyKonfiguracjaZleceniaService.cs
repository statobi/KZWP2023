﻿using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Enums;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class TransportWewnetrznyKonfiguracjaZleceniaService
    {
        private readonly Repository<Magazyn> _magazynRepository = new Repository<Magazyn>();
        private readonly Repository<Produkt> _produktRepository = new Repository<Produkt>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();

        public IEnumerable<MagazynCmb> GetMagazyny()
            => _magazynRepository
            .Get()
            .Where(x => x.ID_Magazyn != 1)
            .Select(x => new MagazynCmb
            {
                IdMagazyn = x.ID_Magazyn,
                Nazwa = x.Nazwa
            });

        public IEnumerable<MagazynZawartosc> GetAsortymentFromMagazyn(int idMagazyn)
            => ZawartoscMaterial(idMagazyn).Concat(ZawartoscProdukt(idMagazyn));

        private IEnumerable<MagazynZawartosc> ZawartoscMaterial(int idMagazyn)
            => _magazynRepository
                .GetById(idMagazyn)
                .Sekcjas
                .SelectMany(x => x.Polkas)
                .SelectMany(x => x.RozlozeniePolki_Materialy)
                .GroupBy(x => x.ID_Material)
                .Select(x => new MagazynZawartosc
                {
                    IdAsortyment = x.Key,
                    UfId = $"M{x.Key}",
                    TypAsortymentu = TypAsortymentu.Material,
                    Nazwa = GetMaterialNazwa(x.Key),
                    Ilosc = x.Sum(s => s.Ilosc)
                });


        private IEnumerable<MagazynZawartosc> ZawartoscProdukt(int idMagazyn)
            => _magazynRepository
                .GetById(idMagazyn)
                .Sekcjas
                .SelectMany(x => x.Polkas)
                .SelectMany(x => x.RozlozeniePolki_Produkty)
                .GroupBy(x => x.ID_Produkt)
                .Select(x => new MagazynZawartosc
                {
                    IdAsortyment = x.Key,
                    UfId = $"M{x.Key}",
                    TypAsortymentu = TypAsortymentu.Produkt,
                    Nazwa = GetMaterialNazwa(x.Key),
                    Ilosc = x.Sum(s => s.Ilosc)
                });

        private string GetProduktNazwa(int idProdukt)
            => _produktRepository
            .GetById(idProdukt)
            .Nazwa;

        private string GetMaterialNazwa(int idMaterial)
            => _materialRepository
            .GetById(idMaterial)
            .Nazwa;
    }
}
