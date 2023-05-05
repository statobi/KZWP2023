
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
CREATE VIEW V_Bilans_Kwoty AS
(
SELECT  
-Kwota_Netto AS Suma , Data AS 'Data', 'Suma' AS 'Rodzaj'
FROM Oplaty_Administracyjne 
UNION SELECT
-KosztNetto*Ilosc AS Suma_ZM , Data, 'Suma_AS'  
FROM SkladDostawa_Material 
INNER JOIN Dostawa ON SkladDostawa_Material.ID_Dostawa = Dostawa.ID_Dostawa 
UNION SELECT 
-Koszt_netto AS Suma_EM , Data_od, 'Suma_EM'  
FROM Obslugi  
UNION SELECT 
-KosztNetto AS Suma_EP_T , Data, 'Suma_EP_T'  
FROM Tankowanie  
UNION SELECT 
-KosztNetto AS Suma_EP_P , Data, 'Suma_EP_P'  
FROM PrzegladPojazdu  
UNION SELECT 
-KosztNetto AS Suma_EP_U , DataOd, 'Suma_EP_U'  
FROM Ubezpieczenie  
UNION SELECT 
-KosztNetto AS Suma_EP_OT , Data, 'Suma_EP_OT'  
FROM ObslugiPojazdow  
UNION SELECT 
-Koszt_Zakupu_Netto AS Suma_ZSM , Data_Przychodu, 'Suma_ZSM'  
FROM Srodki_Majatkowe 
UNION SELECT 
-Kwota_Netto AS Suma_KR , Data, 'Suma_KR'  
FROM Koszty_Rozne
UNION SELECT 
Przychod_Ze_Sprzedazy_Brutto AS Suma_PZS , Data_Rozchodu, 'Suma_PZS'  
FROM Srodki_Majatkowe
UNION SELECT 
Ilosc*Cena_Brutto AS Suma_SM , Data_Realizacji, 'Suma_SM'  
FROM Sklad_Zamowienia  
INNER JOIN Zamowienia_Klienci ON Sklad_Zamowienia.ID_Zamowienia_Klienci = Zamowienia_Klienci.ID_Zamowienia_Klienci
UNION SELECT ---------------------------------------------------------------------------------------------styczeń--------------
SUM(-Pensja_Brutto * DATEDIFF(MONTH,IIF(Data_od > '2023-01-01', Data_od, '2023-01-01'),  
IIF(Data_do IS NULL OR Data_do > '2023-01-01', '2023-02-01', '2023-02-01'))) AS Suma_P, '2023-01-01', 'Suma_P'  
FROM Pracownicy_Zatrudnienie 
WHERE
(Data_od <= '2023-02-01' AND (Data_do IS NULL OR Data_do >= '2023-01-01'))  
OR  
(Data_od >= '2023-01-01' AND Data_od <= '2023-02-01' AND Data_do IS NULL) 
UNION SELECT ---------------------------------------------------------------------------------------------luteń--------------
SUM(-Pensja_Brutto * DATEDIFF(MONTH,IIF(Data_od > '2023-02-01', Data_od, '2023-02-01'),  
IIF(Data_do IS NULL OR Data_do > '2023-02-01', '2023-03-01', '2023-03-01'))) AS Suma_P, '2023-02-01', 'Suma_P'  
FROM Pracownicy_Zatrudnienie 
WHERE
(Data_od <= '2023-03-01' AND (Data_do IS NULL OR Data_do >= '2023-02-01'))  
OR  
(Data_od >= '2023-02-01' AND Data_od <= '2023-03-01' AND Data_do IS NULL) 
UNION SELECT ---------------------------------------------------------------------------------------------marzeń--------------
SUM(-Pensja_Brutto * DATEDIFF(MONTH,IIF(Data_od > '2023-03-01', Data_od, '2023-03-01'),  
IIF(Data_do IS NULL OR Data_do > '2023-03-01', '2023-04-01', '2023-04-01'))) AS Suma_P, '2023-03-01', 'Suma_P'  
FROM Pracownicy_Zatrudnienie 
WHERE
(Data_od <= '2023-04-01' AND (Data_do IS NULL OR Data_do >= '2023-03-01'))  
OR  
(Data_od >= '2023-03-01' AND Data_od <= '2023-04-01' AND Data_do IS NULL) 
UNION SELECT ---------------------------------------------------------------------------------------------kwiecień--------------
SUM(-Pensja_Brutto * DATEDIFF(MONTH,IIF(Data_od > '2023-04-01', Data_od, '2023-04-01'),  
IIF(Data_do IS NULL OR Data_do > '2023-04-01', '2023-05-01', '2023-05-01'))) AS Suma_P, '2023-04-01', 'Suma_P'  
FROM Pracownicy_Zatrudnienie 
WHERE
(Data_od <= '2023-05-01' AND (Data_do IS NULL OR Data_do >= '2023-04-01'))  
OR  
(Data_od >= '2023-04-01' AND Data_od <= '2023-05-01' AND Data_do IS NULL) 
UNION SELECT ---------------------------------------------------------------------------------------------majeń--------------
SUM(-Pensja_Brutto * DATEDIFF(MONTH,IIF(Data_od > '2023-05-01', Data_od, '2023-05-01'),  
IIF(Data_do IS NULL OR Data_do > '2023-05-01', '2023-06-01', '2023-06-01'))) AS Suma_P, '2023-05-01', 'Suma_P'  
FROM Pracownicy_Zatrudnienie 
WHERE
(Data_od <= '2023-06-01' AND (Data_do IS NULL OR Data_do >= '2023-05-01'))  
OR  
(Data_od >= '2023-05-01' AND Data_od <= '2023-06-01' AND Data_do IS NULL) 
UNION SELECT ---------------------------------------------------------------------------------------------czerwień--------------
SUM(-Pensja_Brutto * DATEDIFF(MONTH,IIF(Data_od > '2023-06-01', Data_od, '2023-06-01'),  
IIF(Data_do IS NULL OR Data_do > '2023-06-01', '2023-07-01', '2023-07-01'))) AS Suma_P, '2023-06-01', 'Suma_P'  
FROM Pracownicy_Zatrudnienie 
WHERE
(Data_od <= '2023-07-01' AND (Data_do IS NULL OR Data_do >= '2023-06-01'))  
OR  
(Data_od >= '2023-06-01' AND Data_od <= '2023-07-01' AND Data_do IS NULL) 
)
go

CREATE VIEW V_Bilans AS
(
SELECT
	(SELECT SUM(Suma) FROM V_Bilans_Kwoty WHERE Data BETWEEN '2023-01-01' AND '2023-02-01') AS 'Styczeń',
	(SELECT SUM(Suma) FROM V_Bilans_Kwoty WHERE Data BETWEEN '2023-02-01' AND '2023-03-01') AS 'Luty',
	(SELECT SUM(Suma) FROM V_Bilans_Kwoty WHERE Data BETWEEN '2023-03-01' AND '2023-04-01') AS 'Marzec',
	(SELECT SUM(Suma) FROM V_Bilans_Kwoty WHERE Data BETWEEN '2023-04-01' AND '2023-05-01') AS 'Kwiecień',	
	(SELECT SUM(Suma) FROM V_Bilans_Kwoty WHERE Data BETWEEN '2023-05-01' AND '2023-06-01') AS 'Maj',	
	(SELECT SUM(Suma) FROM V_Bilans_Kwoty WHERE Data BETWEEN '2023-06-01' AND '2023-07-01') AS 'Czerwiec'
)
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


CREATE VIEW ModelMaszyny_Parametry AS (
SELECT
Model_Maszyny.Model AS 'Model_maszyny',
Rodzaj_Strategii_Eksp.Nazwa AS 'Rodzaj_strategii_eksploatacji',
Parametr_Maszyny.Nazwa_Parametru AS 'Nazwa_Badanrgo_parametru',
Parametr_Maszyny.Wartosc_Nominalna AS 'Nominalna_wartosc_parametru',
Parametr_Maszyny.Dolna_Granica 'Minimalna_wartosc_parametru',
Parametr_Maszyny.Gorna_Granica AS 'Maksymalna_wartosc_parametru'
FROM Maszyny
INNER JOIN Model_Maszyny ON Maszyny.ID_Model_Maszyny=Model_Maszyny.ID_Model_Maszyny
INNER JOIN Rodzaj_Strategii_Eksp ON Rodzaj_Strategii_Eksp.ID_Rodzaj_Strategii_Eksp=Model_Maszyny.ID_Rodzaj_Strategii_Eksp
INNER JOIN Parametr_Maszyny ON Maszyny.ID_Model_Maszyny=Parametr_Maszyny.ID_Model_Maszyny
) 
GO



CREATE VIEW RodzajObsl_Model AS(
SELECT 
Obslugi.ID_Obslugi,
Rodzaj_Obslugi_Maszyny.Nazwa AS 'Rodzaj_obsługi_maszyny',
Maszyny.Symbol AS 'Symbol_maszyny',
Obslugi.Data_od,
Obslugi.Data_do,
Obslugi.Koszt_brutto
FROM Obslugi, Maszyny, Rodzaj_Obslugi_Maszyny
WHERE  Obslugi.ID_Rodzaj_Obslugi_Maszyny=Rodzaj_Obslugi_Maszyny.ID_Rodzaj_Obslugi_Maszyny and Obslugi.ID_Maszyny=Maszyny.ID_Maszyny
)
go

CREATE VIEW Maszyny_Ewidencja AS(
SELECT
Maszyny.ID_Maszyny,
Rodzaj_Maszyny.Nazwa AS 'Rodzaj_maszyny',
Maszyny.Symbol AS 'Symbol_maszyny',
Model_Maszyny.Marka AS 'Marka_maszyny',
Model_Maszyny.Model AS 'Model_maszyny',
Maszyny.Data_przychodu,
Maszyny.Data_rozchodu,
Rodzaj_Strategii_Eksp.Nazwa AS 'Rodzaj_strategii_eksploatacji'
FROM Maszyny
INNER JOIN Model_Maszyny ON Maszyny.ID_Model_Maszyny=Model_Maszyny.ID_Model_Maszyny
INNER JOIN Rodzaj_Strategii_Eksp ON Rodzaj_Strategii_Eksp.ID_Rodzaj_Strategii_Eksp=Model_Maszyny.ID_Rodzaj_Strategii_Eksp
INNER JOIN Rodzaj_Maszyny ON Model_Maszyny.ID_Rodzaj_Maszyny=Rodzaj_Maszyny.ID_Rodzaj_Maszyny
)
go

CREATE VIEW  Widok_Model_Stategia_PP AS(
SELECT 
Maszyny.Symbol AS 'Symbol_maszyny',
Rodzaj_Strategii_Eksp.Nazwa AS 'Rodzaj_strategii_eksploatacji',
Normy_Eksploatacyjne.Nr_Normy
FROM 
	Maszyny, Rodzaj_Strategii_Eksp, Model_Maszyny, Normy_Eksploatacyjne
WHERE 
	Maszyny.ID_Model_Maszyny=Model_Maszyny.ID_Model_Maszyny AND Model_Maszyny.ID_Model_Maszyny=Normy_Eksploatacyjne.ID_Model_Maszyny AND Nazwa='Strategia eksploatacji według planowanej profilaktyki'
)
go



CREATE VIEW  Widok_Model_Strategia_ST AS(
SELECT 
Maszyny.Symbol AS 'Symbol_maszyny',
Rodzaj_Strategii_Eksp.Nazwa AS 'Rodzaj_strategii_eksploatacj',
Parametr_Maszyny.Nazwa_Parametru AS 'Badany_parametr',
Parametr_Maszyny.Dolna_Granica 'Minimalna_wartosc_parametru',
Parametr_Maszyny.Gorna_Granica AS 'Maksymalna_wartosc_parametru',
Badany_Parametr.Wartosc AS 'Zbadana_wartosc_parametru',
Badanie_Maszyny.Data AS 'Data_badania'
FROM Maszyny
INNER JOIN Model_Maszyny ON Maszyny.ID_Model_Maszyny=Model_Maszyny.ID_Model_Maszyny
INNER JOIN Parametr_Maszyny ON Maszyny.ID_Model_Maszyny=Parametr_Maszyny.ID_Model_Maszyny
INNER JOIN Badanie_Maszyny ON Maszyny.ID_Maszyny=Badanie_Maszyny.ID_Maszyny
INNER JOIN Badany_Parametr ON  Badany_Parametr.ID_Badanie=Badanie_Maszyny.ID_Badanie
INNER JOIN Rodzaj_Strategii_Eksp ON Rodzaj_Strategii_Eksp.ID_Rodzaj_Strategii_Eksp=Model_Maszyny.ID_Rodzaj_Strategii_Eksp
WHERE Nazwa='Strategia eksploatacji według stanu technicznego'
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



CREATE VIEW Proces_Technologiczny_Produktu AS(
SELECT 
  Produkt.Nazwa AS 'Nazwa produktu',
  Nazwa_Procesu.Nazwa AS 'Nazwa Procesu',
  Proces_Technologiczny.Kolejnosc, 
  Rodzaj_Maszyny.Nazwa AS 'Potrzebny rodzaj maszyny',
  Proces_Technologiczny.Ilosc_Godzin ,
  Proces_Technologiczny.Ilosc_Pracownikow ,
  Material.Nazwa AS 'Potrzebny materiał',
  Material.Opis AS 'Opis materiału',
  Proces_Technologiczny_Material.Ilosc AS 'Ilość potrzebnego materiału',
  Jednostka_miary.Nazwa As 'Jednostka'

FROM 
  Proces_Technologiczny
  INNER JOIN Produkt ON Produkt.ID_Produkt = Proces_Technologiczny.ID_Produkt
  INNER JOIN Nazwa_Procesu ON Nazwa_Procesu.ID_Nazwa_Procesu = Proces_Technologiczny.ID_Nazwa_Procesu
  INNER JOIN Proces_Technologiczny_Material ON  Proces_Technologiczny.ID_Proces_Technologiczny = Proces_Technologiczny_Material.ID_Proces_Technologiczny
  INNER JOIN Material ON Proces_Technologiczny_Material.ID_Material = Material.ID_Material
  INNER JOIN Jednostka_miary ON Jednostka_miary.ID_Jednostka_miary = Material.ID_Jednostka_miary
  INNER JOIN Rodzaj_Maszyny ON Proces_Technologiczny.ID_Rodzaj_Maszyny = Rodzaj_Maszyny.ID_Rodzaj_Maszyny

)
go

CREATE VIEW Praca_Pracownikow_Produkcji AS(
SELECT
Proces.ID_Proces,
Pracownicy.ID_Pracownicy,
Sklad_Zamowienia.ID_Sklad_Zamowienia,
--Pracownicy.Imie,
Pracownicy.Nazwisko,
Stanowisko.Nazwa AS 'Stanowisko Pracownika',
Zamowienia_Klienci.Numer AS 'Numer Zamówienia',
Proces.Ilosc AS 'Ilość w procesie',
Nazwa_Procesu.Nazwa AS 'Nazwa Procesu',
Maszyny.Symbol AS 'Symbol Maszyny',
Proces.Data_Planowanego_Rozpoczecia AS 'Planowana Data Rozpoczecia',
Proces.Data_Planowanego_Zakonczenia AS 'Planowana Data Zakończenia',
Proces.Data_Rzeczywistego_Rozpoczecia AS 'Rzeczywista Data Rozpoczecia',
Proces.Data_Rzeczywistego_Zakonczenia AS 'Rzeczywista Data Zakończenia',
Proces_Pracownicy.Czas_Pracy AS 'Czas pracy pracownika [h]',
Proces.Czas_Pracy_Maszyny AS 'Czas pracy maszyny [h]'


FROM Pracownicy
	INNER JOIN Proces_Pracownicy ON Pracownicy.ID_Pracownicy = Proces_Pracownicy.ID_Pracownicy
	INNER JOIN Pracownicy_Stanowisko ON Pracownicy.ID_Pracownicy = Pracownicy_Stanowisko.ID_Pracownicy
	INNER JOIN Stanowisko ON Pracownicy_Stanowisko.ID_Stanowisko = Stanowisko.ID_Stanowisko
	INNER JOIN Proces ON Proces.ID_Proces = Proces_Pracownicy.ID_Proces 
	INNER JOIN Nazwa_Procesu ON Nazwa_Procesu.ID_Nazwa_Procesu = Proces.ID_Nazwa_Procesu
	INNER JOIN Sklad_Zamowienia ON Sklad_Zamowienia.ID_Sklad_Zamowienia = Proces.ID_Sklad_Zamowienia
	INNER JOIN Zamowienia_Klienci ON Zamowienia_Klienci.ID_Zamowienia_Klienci = Sklad_Zamowienia.ID_Zamowienia_Klienci
	INNER JOIN Maszyny ON Maszyny.ID_Maszyny = Proces.ID_Maszyny
)
go


CREATE VIEW V_Operatorzy_Maszyn AS(
SELECT
Pracownicy.Imie,
Pracownicy.Nazwisko,
Stanowisko.Nazwa AS 'Nazwa Stanowiska'


FROM Pracownicy
	LEFT JOIN Proces_Pracownicy ON Pracownicy.ID_Pracownicy = Proces_Pracownicy.ID_Pracownicy
	LEFT JOIN Pracownicy_Stanowisko ON Pracownicy.ID_Pracownicy = Pracownicy_Stanowisko.ID_Pracownicy
	LEFT JOIN Stanowisko ON Pracownicy_Stanowisko.ID_Stanowisko = Stanowisko.ID_Stanowisko
	LEFT JOIN Proces ON Proces.ID_Proces = Proces_Pracownicy.ID_Proces 
	LEFT JOIN Nazwa_Procesu ON Nazwa_Procesu.ID_Nazwa_Procesu = Proces.ID_Nazwa_Procesu
	INNER JOIN Pracownicy_Zatrudnienie ON Pracownicy.ID_Pracownicy = Pracownicy_Zatrudnienie.ID_Pracownicy

	Group by 
	Pracownicy.Imie,
Pracownicy.Nazwisko,
Stanowisko.Nazwa,
Pracownicy_Zatrudnienie.Data_do
		Having
Stanowisko.Nazwa = 'Operator maszyn' and ( Pracownicy_Zatrudnienie.Data_do IS NULL)
)

go



CREATE VIEW Dostepnosc_Operatorow_Maszyn AS(
SELECT
Pracownicy.Imie,
Pracownicy.Nazwisko,
Stanowisko.Nazwa AS 'Nazwa Stanowiska'


FROM Pracownicy
	LEFT JOIN Proces_Pracownicy ON Pracownicy.ID_Pracownicy = Proces_Pracownicy.ID_Pracownicy
	LEFT JOIN Pracownicy_Stanowisko ON Pracownicy.ID_Pracownicy = Pracownicy_Stanowisko.ID_Pracownicy
	LEFT JOIN Stanowisko ON Pracownicy_Stanowisko.ID_Stanowisko = Stanowisko.ID_Stanowisko
	LEFT JOIN Proces ON Proces.ID_Proces = Proces_Pracownicy.ID_Proces 
	LEFT JOIN Nazwa_Procesu ON Nazwa_Procesu.ID_Nazwa_Procesu = Proces.ID_Nazwa_Procesu
	INNER JOIN Pracownicy_Zatrudnienie ON Pracownicy.ID_Pracownicy = Pracownicy_Zatrudnienie.ID_Pracownicy

	Group by 
	Pracownicy.Imie,
Pracownicy.Nazwisko,
Stanowisko.Nazwa,
Pracownicy_Zatrudnienie.Data_do
		Having
Stanowisko.Nazwa = 'Operator maszyn' and
MAX(Proces.Data_Planowanego_Zakonczenia)< GETDATE() OR Stanowisko.Nazwa = 'Operator maszyn' AND MAX(Proces.Data_Planowanego_Zakonczenia) is NULL  AND ( Pracownicy_Zatrudnienie.Data_do IS NULL)
)

go

CREATE VIEW Raport_z_pracy_Operatorow AS(
SELECT
Pracownicy.Imie,
Pracownicy.Nazwisko,
Stanowisko.Nazwa AS 'Nazwa Stanowiska',

SUM(Proces_Pracownicy.Czas_Pracy) AS 'Czas pracy [h]'

FROM Pracownicy
	INNER JOIN Proces_Pracownicy ON Pracownicy.ID_Pracownicy = Proces_Pracownicy.ID_Pracownicy
	INNER JOIN Pracownicy_Stanowisko ON Pracownicy.ID_Pracownicy = Pracownicy_Stanowisko.ID_Pracownicy
	INNER JOIN Stanowisko ON Pracownicy_Stanowisko.ID_Stanowisko = Stanowisko.ID_Stanowisko
	INNER JOIN Proces ON Proces.ID_Proces = Proces_Pracownicy.ID_Proces 
	INNER JOIN Nazwa_Procesu ON Nazwa_Procesu.ID_Nazwa_Procesu = Proces.ID_Nazwa_Procesu
	Group by
	Pracownicy.Imie,
Pracownicy.Nazwisko,
Stanowisko.Nazwa 

)
go

CREATE VIEW Czas_Pracy_Maszyny AS(
SELECT 
Maszyny.Symbol AS 'Symbol_maszyny',
Maszyny.Przebieg_poczatkowy,
SUM(Proces.Czas_Pracy_Maszyny) AS 'Przebie_maszyny_z_procesow'
FROM Maszyny
INNER JOIN Model_Maszyny ON Maszyny.ID_Model_Maszyny=Model_Maszyny.ID_Model_Maszyny
LEFT JOIN Proces ON Maszyny.ID_Maszyny=Proces.ID_Maszyny
GROUP BY Maszyny.Symbol,
Maszyny.Przebieg_poczatkowy
)
go

CREATE VIEW Przekroczenie_parametru AS (
SELECT 
Maszyny.Symbol AS 'Symbol_maszyny',
Parametr_Maszyny.Nazwa_Parametru AS 'Badany_parametr',
Parametr_Maszyny.Dolna_Granica 'Minimalna_wartosc_parametru',
Parametr_Maszyny.Gorna_Granica AS 'Maksymalna_wartosc_parametru',
Badany_Parametr.Wartosc AS 'Zbadana_wartosc_parametru',
Badanie_Maszyny.Data AS 'Data_badania'
FROM Maszyny
INNER JOIN Model_Maszyny ON Maszyny.ID_Model_Maszyny=Model_Maszyny.ID_Model_Maszyny
INNER JOIN Parametr_Maszyny ON Maszyny.ID_Model_Maszyny=Parametr_Maszyny.ID_Model_Maszyny
INNER JOIN Badanie_Maszyny ON Maszyny.ID_Maszyny=Badanie_Maszyny.ID_Maszyny
INNER JOIN Badany_Parametr ON  Badany_Parametr.ID_Badanie=Badanie_Maszyny.ID_Badanie
INNER JOIN Rodzaj_Strategii_Eksp ON Rodzaj_Strategii_Eksp.ID_Rodzaj_Strategii_Eksp=Model_Maszyny.ID_Rodzaj_Strategii_Eksp
WHERE Nazwa='Strategia eksploatacji według stanu technicznego' AND Parametr_Maszyny.Dolna_Granica>Badany_Parametr.Wartosc OR Badany_Parametr.Wartosc>Parametr_Maszyny.Gorna_Granica
)
go 
CREATE VIEW Dostepny_material AS(
SELECT
Nazwa_Procesu.Nazwa AS 'Nazwa Procesu',
Material.Nazwa AS 'Nazwa Materialu',
Proces_Technologiczny_Material.Ilosc AS 'Ilość potrzebnego',
RozlozeniePolki_Materialy.Ilosc AS 'Ilość materiału',
Jednostka_miary.Nazwa AS 'Jednostka'

FROM Material
  INNER JOIN Jednostka_miary ON Jednostka_miary.ID_Jednostka_miary = Material.ID_Jednostka_miary
  INNER JOIN Proces_Technologiczny_Material ON Proces_Technologiczny_Material.ID_Material = Material.ID_Material
  INNER JOIN Proces_Technologiczny ON Proces_Technologiczny.ID_Proces_Technologiczny = Proces_Technologiczny_Material.ID_Proces_Technologiczny
  INNER JOIN Nazwa_Procesu ON Nazwa_Procesu.ID_Nazwa_Procesu =Proces_Technologiczny.ID_Nazwa_Procesu
  INNER JOIN RozlozeniePolki_Materialy ON RozlozeniePolki_Materialy.ID_Material = Material.ID_Material

  WHERE
  RozlozeniePolki_Materialy.Ilosc > Proces_Technologiczny_Material.Ilosc

)
go  

CREATE VIEW Brakujacy_material AS(
SELECT
Nazwa_Procesu.Nazwa AS 'Nazwa Procesu',
Material.Nazwa AS 'Nazwa Materialu',
Proces_Technologiczny_Material.Ilosc AS 'Ilość potrzebnego',
RozlozeniePolki_Materialy.Ilosc AS 'Ilość materiału',
Jednostka_miary.Nazwa AS 'Jednostka'

FROM Material
  INNER JOIN Jednostka_miary ON Jednostka_miary.ID_Jednostka_miary = Material.ID_Jednostka_miary
  INNER JOIN Proces_Technologiczny_Material ON Proces_Technologiczny_Material.ID_Material = Material.ID_Material
  INNER JOIN Proces_Technologiczny ON Proces_Technologiczny.ID_Proces_Technologiczny = Proces_Technologiczny_Material.ID_Proces_Technologiczny
  INNER JOIN Nazwa_Procesu ON Nazwa_Procesu.ID_Nazwa_Procesu =Proces_Technologiczny.ID_Nazwa_Procesu
  INNER JOIN RozlozeniePolki_Materialy ON RozlozeniePolki_Materialy.ID_Material = Material.ID_Material

  WHERE
  RozlozeniePolki_Materialy.Ilosc < Proces_Technologiczny_Material.Ilosc
)
go  
CREATE VIEW Dostepnosc_Maszyn AS (
SELECT
Rodzaj_Maszyny.Nazwa AS 'Rodzaj Maszyny',
Model_Maszyny.Model AS 'Model Maszyny',
Maszyny.Symbol AS 'Symbol Maszyny',
MAX(Proces.Data_Planowanego_Zakonczenia) AS 'Data dostępności',
Maszyny.Data_rozchodu

FROM Maszyny
	INNER JOIN Model_Maszyny ON Model_Maszyny.ID_Model_Maszyny = Maszyny.ID_Model_Maszyny
	INNER JOIN Rodzaj_Maszyny ON Model_Maszyny.ID_Rodzaj_Maszyny = Rodzaj_Maszyny.ID_Rodzaj_Maszyny
	LEFT JOIN Proces ON Maszyny.ID_Maszyny = Proces.ID_Maszyny
	WHERE
	Maszyny.Data_rozchodu is NULL
	Group by 
	Rodzaj_Maszyny.Nazwa ,
	Model_Maszyny.Model ,
	Maszyny.Symbol,
	Maszyny.Data_rozchodu
)

go  

CREATE VIEW V_Sklad_Zamowienia AS (
SELECT
Sklad_Zamowienia.ID_Zamowienia_Klienci,
Sklad_Zamowienia.ID_Sklad_Zamowienia AS 'Numer Skladu Zamowienia',
--Klient.Imie AS 'Imie_Klienta',
--Klient.Nazwisko AS 'Nazwisko_Klienta',
Produkt.Nazwa AS 'Nazwa_Produktu',
Sklad_Zamowienia.Ilosc
--Sklad_Zamowienia.Cena_Netto,
--Sklad_Zamowienia.Cena_Brutto,
--Zamowienia_Klienci.Data_Zamowienia,
--Zamowienia_Klienci.Data_Realizacji


FROM Sklad_Zamowienia
	INNER JOIN Zamowienia_Klienci ON Sklad_Zamowienia.ID_Zamowienia_Klienci = Zamowienia_Klienci.ID_Zamowienia_Klienci
	INNER JOIN Klient ON Zamowienia_Klienci.ID_Klient = Klient.ID_Klient
	INNER JOIN Produkt ON Sklad_Zamowienia.ID_Produkt = Produkt.ID_Produkt

)
go

CREATE VIEW V_AF_Sklad_Zamowienia AS (
SELECT
	sz.ID_Zamowienia_Klienci,
	sz.ID_Sklad_Zamowienia,
	p.Nazwa AS 'Nazwa Produktu',
	sz.Ilosc,
	sz.Cena_Netto,
	sz.Cena_Brutto
FROM 
	Sklad_Zamowienia sz
	INNER JOIN Produkt p ON sz.ID_Produkt = p.ID_Produkt
)
go

CREATE VIEW V_Zamowienia_Klienci AS (
SELECT
Zamowienia_Klienci.ID_Zamowienia_Klienci AS 'ID_Zamowienia',
Klient.Imie AS 'Imie_Klienta',
Klient.Nazwisko AS 'Nazwisko_Klienta',
Pracownicy.Imie AS 'Imie_Pracownika',
Pracownicy.Nazwisko AS 'Nazwisko_Pracownika',
Zamowienia_Klienci.Data_Zamowienia,
Zamowienia_Klienci.Data_Realizacji,
Zamowienia_Klienci.Numer,
Zamowienia_Klienci.ID_Faktury



FROM Zamowienia_Klienci
	INNER JOIN Pracownicy ON Zamowienia_Klienci.ID_Pracownicy = Pracownicy.ID_Pracownicy
	INNER JOIN Klient ON Zamowienia_Klienci.ID_Klient = Klient.ID_Klient


)
go

CREATE VIEW V_AF_zk AS (
SELECT
	zk.ID_Zamowienia_Klienci,
	k.Imie + ' ' + k.Nazwisko AS 'Klient',
	p.Imie + ' ' + p.Nazwisko AS 'Pracownik',
	zk.Data_Zamowienia,
	zk.Data_Realizacji,
	zk.Numer,
	zk.ID_Faktury,
	sz.Nazwa AS 'Status'
FROM 
	Zamowienia_Klienci zk
	INNER JOIN Pracownicy p ON zk.ID_Pracownicy = p.ID_Pracownicy
	INNER JOIN Klient k ON zk.ID_Klient = k.ID_Klient
	INNER JOIN ZamowieniaKlienci_StatusZamowienia zksz ON zk.ID_Zamowienia_Klienci = zksz.ID_Zamowienia_Klienci
	AND zksz.ID_Status_Zamowienia = (SELECT MAX(ID_Status_Zamowienia) FROM ZamowieniaKlienci_StatusZamowienia WHERE ID_Zamowienia_Klienci = zk.ID_Zamowienia_Klienci) 
	INNER JOIN Status_Zamowienia sz ON sz.ID_Status_Zamowienia = zksz.ID_Status_Zamowienia
)
go

CREATE VIEW Zlecenia_w_realizacji AS (
SELECT
V_AF_zk.ID_Zamowienia_Klienci,
V_AF_zk.Numer AS 'Numer Zamowienia',
V_AF_zk.Data_Zamowienia,
V_AF_zk.Data_Realizacji
FROM V_AF_zk

WHERE
V_AF_zk.Status = 'W realizacji'

)
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

--DROP VIEW Produkty_Procesy_Suma
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

GO

CREATE VIEW V_Kontrola_Jakosci AS
(
SELECT
	Kontrola_Jakosci_Zamowienia.ID_Kontrola_Jakosci_Zamowienia,
	Zamowienia_Klienci.Numer AS 'Numer Zamowienia',
	Kontrola_Jakosci_Zamowienia.ID_Sklad_Zamowienia AS 'Numer skladu zamowienia',
	Produkt.Nazwa AS 'Nazwa Produktu',
	Proces.Ilosc AS 'Ilosc w procesie',
	Kontrola_Jakosci_Zamowienia.Zaakcpetowane,
	Kontrola_Jakosci_Zamowienia.Odrzucone,
	Kontrola_Jakosci_Zamowienia.Data AS 'Data kontroli',
	Kontrola_Jakosci_Zamowienia.Uwagi
	FROM
	Kontrola_Jakosci_Zamowienia
	INNER JOIN Sklad_Zamowienia  ON Sklad_Zamowienia.ID_Sklad_Zamowienia = Kontrola_Jakosci_Zamowienia.ID_Sklad_Zamowienia
	INNER JOIN Produkt ON Produkt.ID_Produkt =Sklad_Zamowienia.ID_Produkt
	INNER JOIN Zamowienia_Klienci ON Zamowienia_Klienci.ID_Zamowienia_Klienci = Sklad_Zamowienia.ID_Zamowienia_Klienci
	INNER JOIN Proces ON Proces.ID_Sklad_Zamowienia = Sklad_Zamowienia.ID_Zamowienia_Klienci
)

GO


CREATE VIEW V_Zwrot_Kontrola_Jakosci AS
(
SELECT *
	
	FROM
	V_Kontrola_Jakosci

	WHERE 
	V_Kontrola_Jakosci.Odrzucone !=0
)

GO

CREATE VIEW V_Zakonczenie_Produkcji AS
(
SELECT 
	--Kontrola_Jakosci_Zamowienia.ID_Kontrola_Jakosci_Zamowienia,
	Zamowienia_Klienci.ID_Zamowienia_Klienci,
	Zamowienia_Klienci.Numer AS 'Numer Zamowienia',
	Kontrola_Jakosci_Zamowienia.ID_Sklad_Zamowienia AS 'Numer skladu zamowienia',
	Produkt.Nazwa AS 'Nazwa Produktu',
	Sklad_Zamowienia.Ilosc AS 'Ilosc w zamowieniu',
	Kontrola_Jakosci_Zamowienia.Zaakcpetowane

	FROM
	Kontrola_Jakosci_Zamowienia
	INNER JOIN Sklad_Zamowienia  ON Sklad_Zamowienia.ID_Sklad_Zamowienia = Kontrola_Jakosci_Zamowienia.ID_Sklad_Zamowienia
	INNER JOIN Produkt ON Produkt.ID_Produkt =Sklad_Zamowienia.ID_Produkt
	INNER JOIN Zamowienia_Klienci ON Zamowienia_Klienci.ID_Zamowienia_Klienci = Sklad_Zamowienia.ID_Zamowienia_Klienci
	INNER JOIN V_AF_zk ON V_AF_zk.ID_Zamowienia_Klienci = Zamowienia_Klienci.ID_Zamowienia_Klienci
	WHERE
	V_AF_zk.Status = 'W realizacji'
	GROUP BY
	Zamowienia_Klienci.ID_Zamowienia_Klienci,
	Zamowienia_Klienci.Numer,
	Kontrola_Jakosci_Zamowienia.ID_Sklad_Zamowienia,
	Produkt.Nazwa,
	Sklad_Zamowienia.Ilosc,
	Kontrola_Jakosci_Zamowienia.Zaakcpetowane
	HAVING
	SUM(Kontrola_Jakosci_Zamowienia.Zaakcpetowane) >= Sklad_Zamowienia.Ilosc
)

GO



CREATE VIEW V_Dodawanie_Modelu AS
(
SELECT
	
	Model_Maszyny.ID_Model_Maszyny,
	Model_Maszyny.Marka,
	Model_Maszyny.Model,
	Rodzaj_Maszyny.ID_Rodzaj_Maszyny,
	Rodzaj_Maszyny.Nazwa AS 'Rodzaj Maszyny',
	Rodzaj_Strategii_Eksp.Nazwa AS 'Rodzaj strategii'
	FROM 
	Model_Maszyny
	LEFT JOIN Rodzaj_Strategii_Eksp ON Rodzaj_Strategii_Eksp.ID_Rodzaj_Strategii_Eksp = Model_Maszyny.ID_Rodzaj_Strategii_Eksp
	LEFT JOIN Rodzaj_Maszyny ON Rodzaj_Maszyny.ID_Rodzaj_Maszyny = Model_Maszyny.ID_Rodzaj_Maszyny
)

-- DZIAŁ LOGISTYKI
go
create view Ewidencja_Materialow_Na_Polkach as (
    SELECT
        m.Nazwa AS 'Nazwa magazynu',
        m.Telefon AS 'Telefon magazynu',
        m.PowierzchniaRobocza AS 'Powierzchnia robocza magazynu',
        s.ID_Sekcja AS 'ID sekcji',
        s.Numer AS 'Numer sekcji',
        s.PowierzchniaRobocza AS 'Powierzchnia robocza sekcji',
        p.ID_Polka AS 'ID półki',
        p.Numer AS 'Numer półki',
        p.SzerokoscPietra AS 'Szerokość półki',
        p.DlugoscPietra AS 'Głębokość półki',
        p.WysokoscPietra AS 'Wysokość półki',
        p.Udzwig AS 'Udźwig półki',
        rzp.ID_RozlozeniePolki_Materialy AS 'ID rozłożenia na półce (materiały)',
        mat.Nazwa AS 'Nazwa materiału',
        mat.ID_Jednostka_miary AS 'Jednostka materiału',
        rzp.Ilosc AS 'Ilość materiału',
        rzp.DataOd AS 'Data rozłożenia (materiały)',
        rzp.DataDo AS 'Data pobrania (materiały)'
    FROM
        Magazyn m
        INNER JOIN Sekcja s ON m.ID_Magazyn = s.ID_Magazyn
        INNER JOIN Polka p ON s.ID_Sekcja = p.ID_Sekcja
        LEFT JOIN RozlozeniePolki_Materialy rzp ON p.ID_Polka = rzp.ID_Polka
        LEFT JOIN Material mat ON rzp.ID_Material = mat.ID_Material
    where
        rzp.DataDo is not null
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
CREATE VIEW Pojazdy_All AS 
(  
SELECT
Pojazd.
ID_Pojazd,
Marka, 
Model,
PojemnoscSilnika,
Nosnosc,
StanLicznikaPoczatkowy AS 'Stan licznika początkowy',
NrRejestracyjny AS 'Numer rejestracyjny',
RokProdukcji AS 'Rok produkcji',
DataPrzychodu AS 'Data przychodu',
DataRozchodu AS 'Data rozchodu',
DataDo AS 'Data Ubezpieczenia',
DataDoP AS 'Data przeglądu'
FROM ModelePojazdu
INNER JOIN Pojazd ON ModelePojazdu.ID_ModelPojazd = Pojazd.ID_ModelPojazd 
INNER JOIN Ubezpieczenie ON Pojazd.ID_Pojazd = Ubezpieczenie.ID_Pojazd 
INNER JOIN PrzegladPojazdu ON Pojazd.ID_Pojazd = PrzegladPojazdu.ID_Pojazd 
) 

go


CREATE VIEW Dostawy_All AS
(
SELECT
RodzajDostawcy.Nazwa as 'Rodzaj dostawcy',
d.NazwaFirmy as 'Nazwa firmy',
d.Telefon,
concat(p.Imie,' ', p.Nazwisko) as 'Pracownik',
m.Nazwa as 'Magazyn',
Material.Nazwa as 'Produkt',
sdm.Ilosc as 'Ilość',
sdm.KosztNetto as 'Koszt netto',
sdm.KosztBrutto as 'Koszt brutto',
Dostawa.Data
FROM Dostawa 
INNER JOIN Dostawca_RodzajDostawcy rd ON rd.ID_Dostawcy = Dostawa.ID_Dostawcy
INNER JOIN RodzajDostawcy ON rd.ID_RodzajDostawcy = RodzajDostawcy.ID_RodzajDostawcy
INNER JOIN Dostawcy d ON rd.ID_Dostawcy = d.ID_Dostawcy
INNER JOIN Pracownicy p ON Dostawa.ID_Pracownik = p.ID_Pracownicy
INNER JOIN Magazyn m ON m.ID_Magazyn = Dostawa.ID_Magazyn
INNER JOIN SkladDostawa_Material sdm ON sdm.ID_Dostawa = Dostawa.ID_Dostawa
INNER JOIN Material ON Material.ID_Material = sdm.ID_Material
)
go

--drop view Wysylki_All
CREATE VIEW Wysylki_All AS
(
SELECT
w.ID_Wysylka as 'ID wysyłki',
concat(m.Marka, ' ', m.Model ,' [', poj.NrRejestracyjny, ']') as 'Pojazd',
concat(p.Imie,' ', p.Nazwisko) as 'Kierowca',
w.Odleglosc as 'Odległość',
w.Data
FROM Wysylka w
INNER JOIN Pracownicy p ON w.ID_Pracownik = p.ID_Pracownicy
INNER JOIN Pojazd poj ON w.ID_Pojazd = poj.ID_Pojazd
INNER JOIN ModelePojazdu m ON poj.ID_ModelPojazd = m.ID_ModelPojazd
)
go


go
CREATE VIEW Transport_wewnetrzny_Produkt AS 
(  
SELECT
Zlecenie_Magazynowe.ID_Zlecenie_Magazynowe,
Produkt.Nazwa as 'Produkt',
Zlecenie_magazynowe.[Data] as 'Data_zlecenia',
IloscProduktow as 'Ilosc_sztuk',
(IloscProduktow * Szerokosc * Wysokosc * Glebokosc) /1000000 as 'Objetosc_zamowienia',
IloscProduktow * Masa as 'Masa_zamowienia',
Wysokosc,
Szerokosc,
Glebokosc,
Masa
FROM Zlecenie_Magazynowe
INNER JOIN Sklad_Zlecenie_Produkt ON Zlecenie_Magazynowe.ID_Zlecenie_Magazynowe = Sklad_Zlecenie_Produkt.ID_Zlecenie_Magazynowe
INNER JOIN Produkt ON Sklad_Zlecenie_Produkt.ID_Sklad_Zlecenie_Produkt = Produkt.ID_Produkt
) 
go
CREATE VIEW Transport_wewnetrzny_Material AS 
(
SELECT
Zlecenie_Magazynowe.ID_Zlecenie_Magazynowe,
Material.Nazwa as 'Material',
Zlecenie_Magazynowe.[Data] as 'Data_Zlecenia',
IloscMaterialow as 'Ilosc_sztuk',
Wysokosc,
Szerokosc,
Glebokosc,
Masa,
(IloscMaterialow * Szerokosc * Wysokosc * Glebokosc) /1000000 as 'Objetosc_zamowienia',
IloscMaterialow * Masa as 'Masa_zamowienia'
FROM Zlecenie_Magazynowe
INNER JOIN Sklad_Zlecenie_Magazynowe ON Zlecenie_Magazynowe.ID_Zlecenie_Magazynowe = Sklad_Zlecenie_Magazynowe.ID_Zlecenie_Magazynowe
INNER JOIN Material ON Sklad_Zlecenie_Magazynowe.ID_Sklad_Zlecenie_Magazynowe = Material.ID_Material
INNER JOIN Rodzaj_Materialu ON Material.ID_Material = Rodzaj_Materialu.ID_Rodzaj_Materialu
)
go
CREATE VIEW Dostepne_Pojazdy AS 
(  
SELECT  
Pojazd.ID_Pojazd, Marka, Model,
NrRejestracyjny AS 'Numer rejestracyjny',
RodzajPojazdu.Nazwa AS 'Rodzaj pojazdu',
Nosnosc AS 'Nosnosc pojazdu',
(Szerokosc * Wysokosc * Glebokosc)*1000 as 'Pojemnosc_samochodu'
FROM ModelePojazdu
INNER JOIN Pojazd ON ModelePojazdu.ID_ModelPojazd = Pojazd.ID_ModelPojazd 
INNER JOIN Ubezpieczenie ON Pojazd.ID_Pojazd = Ubezpieczenie.ID_Pojazd 
INNER JOIN PrzegladPojazdu ON Pojazd.ID_Pojazd = PrzegladPojazdu.ID_Pojazd 
INNER JOIN RodzajPojazdu ON ModelePojazdu.ID_RodzajPojazdu = RodzajPojazdu.ID_RodzajPojazdu
WHERE (DataDoP) > GETDATE() AND (DataRozchodu IS NULL) AND DataDo > GETDATE()
) 