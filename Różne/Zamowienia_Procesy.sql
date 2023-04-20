use IDEA
go

--DROP VIEW Produkty_Procesy
go
CREATE VIEW Produkty_Procesy AS 
(
SELECT 
	p.ID_Produkt, p.Nazwa AS Produkt, np.Nazwa AS 'Nazwa procesu', mm.Koszt_Roboczogodziny
FROM	 
	Produkt p 
	INNER JOIN Proces_Technologiczny pt ON pt.ID_Produkt = p.ID_Produkt
	INNER JOIN Nazwa_Procesu np ON np.ID_Nazwa_Procesu = pt.ID_Nazwa_Procesu
	INNER JOIN Rodzaj_Maszyny rm ON rm.ID_Rodzaj_Maszyny = pt.ID_Rodzaj_Maszyny
	INNER JOIN Model_Maszyny mm ON mm.ID_Rodzaj_Maszyny = rm.ID_Rodzaj_Maszyny
	AND mm.Koszt_Roboczogodziny = (SELECT MAX(Koszt_Roboczogodziny) FROM Model_Maszyny WHERE ID_Rodzaj_Maszyny = rm.ID_Rodzaj_Maszyny)
)
go

DROP VIEW Produkty_Procesy_Suma
go
CREATE VIEW Produkty_Procesy_Suma AS 
(
SELECT 
	ID_Produkt, SUM(Koszt_Roboczogodziny) AS Suma
FROM
	Produkty_Procesy
GROUP BY
	ID_Produkt
)
go

--DROP VIEW Kosztorys_Roboczogodziny
go
CREATE VIEW Kosztorys_Roboczogodziny AS
(
SELECT 
	zk.ID_Zamowienia_Klienci, sk.ID_Sklad_Zamowienia, pps.ID_Produkt, pps.Suma AS Wartosc_jednostkowa, sk.Ilosc, pps.Suma * sk.Ilosc AS Wartosc_calkowita
FROM
	Produkty_Procesy_Suma pps
	INNER JOIN Produkt p ON p.ID_Produkt = pps.ID_Produkt
	INNER JOIN Sklad_Zamowienia sk ON sk.ID_Produkt = p.ID_Produkt 
	INNER JOIN Zamowienia_Klienci zk ON zk.ID_Zamowienia_Klienci = sk.ID_Zamowienia_Klienci 
)
go
	
CREATE VIEW Produkty_Materialy AS
(
SELECT
	p.ID_Produkt, pt.ID_Proces_Technologiczny, ptm.ID_Material, ptm.Ilosc
FROM
	Produkt p
	INNER JOIN Proces_Technologiczny pt ON pt.ID_Produkt = p.ID_Produkt
	INNER JOIN Proces_Technologiczny_Material ptm ON ptm.ID_Proces_Technologiczny = pt.ID_Proces_Technologiczny
	INNER JOIN Material m ON m.ID_Material = ptm.ID_Material
)
go
CREATE VIEW Materialy_Srednia_Cena AS
(
SELECT
	m.ID_Material, AVG(sdm.KosztBrutto) AS Srednia_Dostaw
FROM
	Material m
	INNER JOIN SkladDostawa_Material sdm ON sdm.ID_Material = m.ID_Material
	INNER JOIN Dostawa d ON d.ID_Dostawa = sdm.ID_Dostawa
GROUP BY 
	m.ID_Material
)
go

--DROP VIEW Kosztorys_Materialy
go
CREATE VIEW Kosztorys_Materialy AS
(
SELECT 
	sz.ID_Sklad_Zamowienia, /*pm.Ilosc * msc.Srednia_Dostaw AS Koszt_jednostkowy,*/ SUM(sz.Ilosc * pm.Ilosc * msc.Srednia_Dostaw) AS Wartosc_calkowita
FROM
	Materialy_Srednia_Cena msc 
	INNER JOIN Produkty_Materialy pm ON pm.ID_Material = msc.ID_Material
	INNER JOIN Sklad_Zamowienia sz ON sz.ID_Produkt = pm.ID_Produkt
	INNER JOIN Zamowienia_Klienci zk ON zk.ID_Zamowienia_Klienci = sz.ID_Zamowienia_Klienci
GROUP BY
	sz.ID_Sklad_Zamowienia
)
go

CREATE VIEW Kosztorys AS
(
SELECT 
	sz.ID_Sklad_Zamowienia, kr.Wartosc_calkowita AS Wartosc_Calkowita_roboczogodziny, km.Wartosc_calkowita AS Wartosc_calkowita_material,
	p.Zlozonosc_produktu, (km.Wartosc_calkowita + kr.Wartosc_calkowita)*(1+CAST(p.Zlozonosc_produktu As Float)/10) AS Cena
FROM 
	Kosztorys_Roboczogodziny kr
	INNER JOIN Kosztorys_Materialy km ON km.ID_Sklad_Zamowienia = kr.ID_Sklad_Zamowienia
	INNER JOIN Sklad_Zamowienia sz ON sz.ID_Sklad_Zamowienia = km.ID_Sklad_Zamowienia
	INNER JOIN Produkt p ON p.ID_Produkt = sz.ID_Produkt
)