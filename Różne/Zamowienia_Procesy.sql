use IDEA
go
/*
DROP VIEW Zamowienia_Procesy
go
CREATE VIEW Zamowienia_Procesy AS 
(
SELECT 
	zk.ID_Zamowienia_Klienci, zk.Numer, sk.ID_Sklad_Zamowienia, sk.ID_Produkt, p.Nazwa AS Produkt, np.Nazwa AS 'Nazwa procesu', mm.Koszt_Roboczogodziny
FROM	 
	Zamowienia_Klienci zk
	INNER JOIN Sklad_Zamowienia sk ON zk.ID_Zamowienia_Klienci = sk.ID_Zamowienia_Klienci
	INNER JOIN Produkt p ON p.ID_Produkt = sk.ID_Produkt
	INNER JOIN Proces_Technologiczny pt ON pt.ID_Produkt = p.ID_Produkt
	INNER JOIN Nazwa_Procesu np ON np.ID_Nazwa_Procesu = pt.ID_Nazwa_Procesu
	INNER JOIN Rodzaj_Maszyny rm ON rm.ID_Rodzaj_Maszyny = pt.ID_Rodzaj_Maszyny
	INNER JOIN Model_Maszyny mm ON mm.ID_Rodzaj_Maszyny = rm.ID_Rodzaj_Maszyny
	AND mm.Koszt_Roboczogodziny = (SELECT MAX(Koszt_Roboczogodziny) FROM Model_Maszyny WHERE ID_Rodzaj_Maszyny = rm.ID_Rodzaj_Maszyny)
)
go
*/

DROP VIEW Produkty_Procesy
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

DECLARE @Zamowienie int = 2; 

SELECT 
	SUM(pp.Koszt_Roboczogodziny) AS 'Suma roboczogodzin', SUM(sk.Ilosc) AS 'Ilosc'
FROM
	Produkty_Procesy pp
	INNER JOIN Produkt p ON p.ID_Produkt = pp.ID_Produkt
	INNER JOIN Sklad_Zamowienia sk ON sk.ID_Produkt = p.ID_Produkt 
	INNER JOIN Zamowienia_Klienci zk ON zk.ID_Zamowienia_Klienci = sk.ID_Zamowienia_Klienci
WHERE
	
	