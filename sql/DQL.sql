
use IDEA;
go
-- DZIAŁ FINANSOWO - ADMINISTRACYJNY
use IDEA 
go 
---DROP VIEW Pracownicy_Ewidencja 
go 
CREATE VIEW Pracownicy_Ewidencja AS 
( 
SELECT p.Imie, p.Nazwisko, p.PESEL, p.Adres_Ulica, p.Adres_Kod_Pocztowy, p.Adres_Miasto, 
       dz.Nazwa AS 'Dzial', s.Nazwa AS 'Stanowisko', ru.Nazwa AS 'Rodzaj umowy',  
       pz.Pensja_Brutto 
 FROM Pracownicy p 
INNER JOIN Pracownicy_Zatrudnienie pz ON p.ID_Pracownicy = pz.ID_Pracownicy 
INNER JOIN Pracownicy_Dzialy pd ON p.ID_Pracownicy = pd.ID_Pracownicy  
AND pd.Data = (SELECT MAX(Data) FROM Pracownicy_Dzialy WHERE ID_Pracownicy = p.ID_Pracownicy) 
INNER JOIN Dzialy dz ON pd.ID_Dzialy = dz.ID_Dzialy 
INNER JOIN Pracownicy_Stanowisko ps ON p.ID_Pracownicy = ps.ID_Pracownicy  
AND ps.Data = (SELECT MAX(Data) FROM Pracownicy_Stanowisko WHERE ID_Pracownicy = p.ID_Pracownicy) 
INNER JOIN Stanowisko s ON ps.ID_Stanowisko = s.ID_Stanowisko 
INNER JOIN Pracownicy_RodzajUmowy pru ON p.ID_Pracownicy = pru.ID_Pracownicy  
AND pru.Data = (SELECT MAX(Data) FROM Pracownicy_RodzajUmowy WHERE ID_Pracownicy = p.ID_Pracownicy) 
INNER JOIN Rodzaj_Umowy ru ON ru.ID_Rodzaj_Umowy = pru.ID_Rodzaj_Umowy 
WHERE pz.Data_do IS NULL 
) 
go 
----------------------------------------------------------------------------------- 
/* 
DROP VIEW Koszty_Rozne_Ewidencja 
GO 
DECLARE @Okres_od Date = '2023-01-01'; 
DECLARE @Okres_do Date = '2023-12-31'; 
 
CREATE VIEW Koszty_Rozne_Ewidencja AS 
( 
SELECT  
SUM(Kwota_Netto) AS Suma_OA , 'Suma_OA'  
FROM Oplaty_Administracyjne  
WHERE Data BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(Pensja_Brutto * DATEDIFF(MONTH,IIF(Data_od > @Okres_od, Data_od, @Okres_od),  
IIF(Data_do IS NULL OR Data_do > @Okres_do, @Okres_do, Data_do))) AS Suma_P, 'Suma_P'  
FROM Pracownicy_Zatrudnienie 
WHERE  
(Data_od <= @Okres_do AND (Data_do IS NULL OR Data_do >= @Okres_od))  
OR  
(Data_od >= @Okres_od AND Data_od <= @Okres_do AND Data_do IS NULL) 
UNION SELECT 
SUM(KosztNetto*Ilosc) AS Suma_ZM , 'Suma_AS'  
FROM SkladDostawa_Material 
INNER JOIN Dostawa ON SkladDostawa_Material.ID_Dostawa = Dostawa.ID_Dostawa  
WHERE Data BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(Koszt_netto) AS Suma_EM , 'Suma_EM'  
FROM Obslugi  
WHERE Data_od BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(KosztNetto) AS Suma_EP_T , 'Suma_EP_T'  
FROM Tankowanie  
WHERE Data BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(KosztNetto) AS Suma_EP_P , 'Suma_EP_P'  
FROM PrzegladPojazdu  
WHERE Data BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(KosztNetto) AS Suma_EP_U , 'Suma_EP_U'  
FROM Ubezpieczenie  
WHERE DataOd BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(KosztNetto) AS Suma_EP_OT , 'Suma_EP_OT'  
FROM ObslugiPojazdow  
WHERE Data BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(Koszt_Zakupu_Netto) AS Suma_ZSM , 'Suma_ZSM'  
FROM Srodki_Majatkowe  
WHERE Data_Przychodu BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(Kwota_Netto) AS Suma_KR , 'Suma_KR'  
FROM Koszty_Rozne  
WHERE Data BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(Przychod_Ze_Sprzedazy_Brutto) AS Suma_PZS , 'Suma_PZS'  
FROM Srodki_Majatkowe  
WHERE Data_Przychodu BETWEEN @Okres_od AND @Okres_do 
UNION SELECT 
SUM(Ilosc*Cena_Brutto) AS Suma_SM , 'Suma_SM'  
FROM Sklad_Zamowienia  
INNER JOIN Zamowienia_Klienci ON Sklad_Zamowienia.ID_Zamowienia_Klienci = Zamowienia_Klienci.ID_Zamowienia_Klienci 
WHERE Data_Zamowienia BETWEEN @Okres_od AND @Okres_do 
)*/ 
----------------------------------------------------------------------------------- 
--DROP VIEW Wykorzystany_Urlop 
go 
CREATE VIEW Wykorzystany_Urlop AS 
(  
SELECT  
Urlopy.ID_Pracownicy, Imie, Nazwisko, SUM (Dni_Robocze) as Wykorzystany_Urlop  
FROM Urlopy  
INNER JOIN Pracownicy ON Pracownicy.ID_Pracownicy = Urlopy.ID_Pracownicy  
WHERE YEAR (data_od) = YEAR (GETDATE())   
GROUP BY Urlopy.ID_Pracownicy, Imie, Nazwisko   
)  
go  
-----------------------------------------------------------------------------------   
--DROP VIEW Wykorzystany_Urlop_Na_Zadanie  
go  
CREATE VIEW Wykorzystany_Urlop_Na_Zadanie AS 
(  
SELECT   
Urlopy.ID_Pracownicy, Imie, Nazwisko, SUM (Dni_Robocze) as Wykorzystany_Urlop_Na_Zadanie  
FROM Urlopy  
INNER JOIN Pracownicy ON Pracownicy.ID_Pracownicy = Urlopy.ID_Pracownicy  
WHERE (YEAR (data_od) = YEAR (GETDATE())) AND (ID_Rodzaj_Urlopu = 3)  
GROUP BY Urlopy.ID_Pracownicy, Imie, Nazwisko 
)  
go 
----------------------------------------------------------------------------------------------------------------------------------------  




-- DZIAŁ PRODUKCJI
CREATE VIEW RodzajObsl_Model AS(
SELECT 
Rodzaj_Obslugi_Maszyny.Nazwa,
Maszyny.Symbol,
Obslugi.Data_od,
Obslugi.Data_do,
Obslugi.Koszt_brutto
FROM Obslugi, Maszyny, Rodzaj_Obslugi_Maszyny
WHERE  Obslugi.ID_Rodzaj_Obslugi_Maszyny=Rodzaj_Obslugi_Maszyny.ID_Rodzaj_Obslugi_Maszyny and Obslugi.ID_Maszyny=Maszyny.ID_Maszyny
)
go



CREATE VIEW  Widok_Model_Stategia_PP AS(
SELECT 
Maszyny.Symbol,
Rodzaj_Strategii_Eksp.Nazwa,
Normy_Eksploatacyjne.Nr_Normy
FROM 
	Maszyny, Rodzaj_Strategii_Eksp, Model_Maszyny, Normy_Eksploatacyjne
WHERE 
	Maszyny.ID_Model_Maszyny=Model_Maszyny.ID_Model_Maszyny AND Model_Maszyny.ID_Model_Maszyny=Normy_Eksploatacyjne.ID_Model_Maszyny AND Nazwa='Strategia według planowanej profilaktyki'
)
go




CREATE VIEW  Widok_Model_Stategia_ST AS(
SELECT 
Maszyny.Symbol,
Rodzaj_Strategii_Eksp.Nazwa,
Parametr_Maszyny.Nazwa_Parametru,
Parametr_Maszyny.Dolna_Granica,
Parametr_Maszyny.Gorna_Granica,
Badany_Parametr.Wartosc,
Badanie_Maszyny.Data
FROM 
	Maszyny, Rodzaj_Strategii_Eksp, Model_Maszyny, Parametr_Maszyny, Badany_Parametr,Badanie_Maszyny
WHERE 
	Maszyny.ID_Model_Maszyny=Model_Maszyny.ID_Model_Maszyny AND Nazwa='Strategia według stanu technicznego' AND Maszyny.ID_Model_Maszyny=Parametr_Maszyny.ID_Model_Maszyny 
)
go


CREATE VIEW Narzedzia_w_procesie  AS (
SELECT
Rodzaj_Narzedzia.Nazwa AS Nazwa_Narzedzia,
Nazwa_Procesu.Nazwa AS Nazwa_Procesu,
Proces.Data_Rzeczywistego_Rozpoczecia,
Proces.Data_Rzeczywistego_Zakonczenia

FROM Proces_Narzedzia
	INNER JOIN Narzedzia ON Proces_Narzedzia.ID_Narzedzia = Narzedzia.ID_Narzedzia
	INNER JOIN Proces ON Proces_Narzedzia.ID_Proces = Proces.ID_Proces
	INNER JOIN Rodzaj_Narzedzia ON  Rodzaj_Narzedzia.ID_Rodzaj_Narzedzia = Narzedzia.ID_Rodzaj_Narzedzia
	INNER JOIN Nazwa_Procesu ON  Nazwa_Procesu.ID_Nazwa_Procesu = Proces.ID_Nazwa_Procesu
)
go

-- Szymon popraw widok

CREATE VIEW Proces_Technologiczny_Produktu AS(
SELECT 
  Produkt.Nazwa AS 'Nazwa produktu',
  Nazwa_Procesu.Nazwa AS 'Nazwa Procesu',
  Proces_Technologiczny.Ilosc_Godzin AS 'Ilosc godzin',
  Proces_Technologiczny.Ilosc_Pracownikow AS 'Ilość pracownikow',
  Proces_Technologiczny.Kolejosc AS 'Kolejnosc'
FROM 
  Produkt
  INNER JOIN Proces_Technologiczny ON Produkt.ID_Produkt = Proces_Technologiczny.ID_Produkt
  INNER JOIN Nazwa_Procesu ON Nazwa_Procesu.ID_Nazwa_Procesu = Proces_Technologiczny.ID_Nazwa_Procesu

)
go


-- DZIAŁ LOGISTYKI
create view Ewidencja_Materialow_Na_Polkach as (
    SELECT
        m.Nazwa AS 'Nazwa magazynu',
        m.Telefon AS 'Telefon magazynu',
        m.PowierzchniaRobocza AS 'Powierzchnia robocza magazynu',
        s.ID_Sekcja AS 'ID sekcji',
        s.Numer AS 'Numer sekcji',
        s.PowierzchniaRobocza AS 'Powierzchnia robocza sekcji',
        s.Wysokosc AS 'Wysokość sekcji',
        p.ID_Polka AS 'ID półki',
        p.Numer AS 'Numer półki',
        p.Szerokosc AS 'Szerokość półki',
        p.Glebokosc AS 'Głębokość półki',
        p.Wysokosc AS 'Wysokość półki',
        p.Udzwig AS 'Udźwig półki',
        rzp.ID_RozlozeniePolki_Materialy AS 'ID rozłożenia na półce (materiały)',
        mat.Nazwa AS 'Nazwa materiału',
        mat.ID_Jednostka_miary AS 'Jednostka materiału',
        rzp.Ilosc AS 'Ilość materiału',
        rzp.[Data] AS 'Data rozłożenia (materiały)',
        rzp.CzyPobrane AS 'Czy pobrane (materiały)'
    FROM
        Magazyn m
        INNER JOIN Sekcja s ON m.ID_Magazyn = s.ID_Magazyn
        INNER JOIN Polka p ON s.ID_Sekcja = p.ID_Sekcja
        LEFT JOIN RozlozeniePolki_Materialy rzp ON p.ID_Polka = rzp.ID_Polka
        LEFT JOIN Material mat ON rzp.ID_Material = mat.ID_Material
    where
        rzp.CzyPobrane = 0
)
go
    CREATE VIEW SprawdzeniePowierzchniRoboczej AS (
        SELECT
            m.Nazwa,
            m.PowierzchniaRobocza,
            SUM(s.PowierzchniaRobocza) AS SumaPowierzchniRoboczych
        FROM
            Magazyn as m
            inner join Sekcja as s ON m.ID_Magazyn = s.ID_Magazyn
        GROUP BY
            m.Nazwa,
            m.PowierzchniaRobocza
        HAVING
            SUM(s.PowierzchniaRobocza) > m.PowierzchniaRobocza
    )
go
----Lukasz logistyka
CREATE VIEW Dostepne_Pojazdy AS 
(  
SELECT  
Pojazd.ID_Pojazd,Marka, Model,
DataRozchodu,
DataDo as 'Data Ubezpieczenia',
DataDoP as 'Data przeglądu'
FROM ModelePojazdu
INNER JOIN Pojazd ON ModelePojazdu.ID_ModelPojazd = Pojazd.ID_ModelPojazd 
INNER JOIN Ubezpieczenie ON Pojazd.ID_Pojazd = Ubezpieczenie.ID_Pojazd 
INNER JOIN PrzegladPojazdu ON Pojazd.ID_Pojazd = PrzegladPojazdu.ID_Pojazd 
WHERE (DataDoP) >  GETDATE() AND (DataRozchodu IS NULL)  AND DataDo > GETDATE()
)  
