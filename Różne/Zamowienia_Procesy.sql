use IDEA
go

DROP VIEW Zamowienia_Procesy
go
CREATE VIEW Zamowienia_Procesy AS 
(
SELECT 
	zk.ID_Zamowienia_Klienci, zk.Numer, sk.ID_Sklad_Zamowienia, p.Nazwa AS Produkt, np.Nazwa, MAX(mm.Koszt_Roboczogodziny)
FROM	 
	Zamowienia_Klienci zk
	INNER JOIN Sklad_Zamowienia sk ON zk.ID_Zamowienia_Klienci = sk.ID_Zamowienia_Klienci
	INNER JOIN Produkt p ON p.ID_Produkt = sk.ID_Produkt
	INNER JOIN Proces_Technologiczny pt ON pt.ID_Produkt = p.ID_Produkt
	INNER JOIN Nazwa_Procesu np ON np.ID_Nazwa_Procesu = pt.ID_Nazwa_Procesu
	INNER JOIN Rodzaj_Maszyny rm ON rm.ID_Rodzaj_Maszyny = pt.ID_Rodzaj_Maszyny
	INNER JOIN Model_Maszyny mm ON mm.ID_Rodzaj_Maszyny = rm.ID_Rodzaj_Maszyny

)
go
DECLARE @Zlecenie int = 2; 

AND pd.Data = (SELECT MAX(Data) FROM Pracownicy_Dzialy WHERE ID_Pracownicy = p.ID_Pracownicy) 