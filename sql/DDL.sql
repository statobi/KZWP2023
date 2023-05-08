--drop database IDEA
CREATE DATABASE IDEA;

GO
  USE IDEA
GO
  --Material   
  Create table TypZasobu (
  ID_TypZasobu int identity(1, 1) primary key,
  Nazwa nvarchar(25) not null
);

  CREATE TABLE Rodzaj_Materialu (
    ID_Rodzaj_Materialu int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	ID_TypZasobu int foreign key references TypZasobu not null,
    Nazwa nvarchar(50) not null,
  );

CREATE TABLE Jednostka_miary (
  ID_Jednostka_miary int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) not null,
);

CREATE TABLE Wlasciwosc_Materialu (
  ID_Wlasciwosc_Materialu int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) not null,
  ID_Jednostka_miary int NOT NULL FOREIGN KEY REFERENCES Jednostka_miary
);

CREATE TABLE Material (
  ID_Material int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Rodzaj_Materialu int NOT NULL FOREIGN KEY REFERENCES Rodzaj_Materialu,
  ID_Jednostka_miary int NOT NULL FOREIGN KEY REFERENCES Jednostka_miary,
  Nazwa nvarchar(30) not null,
  Szerokosc float null,
  Glebokosc float null,
  Wysokosc float null,
  Masa float null,
  Opis nvarchar(50) null
);

CREATE TABLE Material_Wlasciwosc_Material (
  ID_Material_Wlasciwosc_Material int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Material int NOT NULL FOREIGN KEY REFERENCES Material,
  ID_Wlasciwosc_Materialu int NOT NULL FOREIGN KEY REFERENCES Wlasciwosc_Materialu,
  Wartosc float not null
);

--Produkt   
CREATE TABLE Rodzaj_Produktu (
  ID_Rodzaj_Produktu int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_TypZasobu int foreign key references TypZasobu not null,
  Nazwa nvarchar(30) not null,
);

CREATE TABLE Produkt (
  ID_Produkt int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Rodzaj_Produktu int NOT NULL FOREIGN KEY REFERENCES Rodzaj_Produktu,
  Nazwa nvarchar(30) not null,
  Szerokosc float not null,
  Glebokosc float not null,
  Wysokosc float not null,
  Masa float not null,
  Zlozonosc_produktu int not null
);

/*   
 Dzial Administracyjno-Finansowy ------------------------------------------------------------------------------   
 */
CREATE TABLE Pracownicy (
  ID_Pracownicy int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Imie nvarchar(30) NOT NULL,
  Nazwisko nvarchar(30) NOT NULL,
  PESEL nvarchar(11) NOT NULL,
  Adres_Ulica nvarchar(30) NOT NULL,
  Adres_Kod_Pocztowy nvarchar(6) NOT NULL,
  Adres_Miasto nvarchar(30) NOT NULL,
  Numer_Konta_Bankowego nvarchar(28) NULL,
  Telefon nvarchar(30) NULL,
  E_mail nvarchar(50) NULL,
);

CREATE TABLE Pracownicy_Zatrudnienie (
  ID_Pracownicy_Zatrudnienie int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Pracownicy int NOT NULL REFERENCES Pracownicy(ID_Pracownicy),
  Pensja_Netto decimal(15, 2) NOT NULL,
  Pensja_Brutto decimal(15, 2) NOT NULL,
  Data_od date NOT NULL,
  Data_do date NULL,
  Dotychczasowy_Staz int NOT NULL,
);

CREATE TABLE Rodzaj_Urlopu (
  ID_Rodzaj_Urlopu int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Urlopy (
  ID_Urlopy int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Pracownicy int NOT NULL REFERENCES Pracownicy(ID_Pracownicy),
  ID_Rodzaj_Urlopu int NOT NULL REFERENCES Rodzaj_Urlopu(ID_Rodzaj_Urlopu),
  Data_od date NOT NULL,
  Data_do date NOT NULL,
  Dni_Robocze int NOT NULL
);

CREATE TABLE Rodzaj_Umowy (
  ID_Rodzaj_Umowy int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Pracownicy_RodzajUmowy (
  ID_Pracownicy_RodzajUmowy int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Pracownicy int NOT NULL FOREIGN KEY REFERENCES Pracownicy(ID_Pracownicy),
  ID_Rodzaj_Umowy int NOT NULL FOREIGN KEY REFERENCES Rodzaj_Umowy(ID_Rodzaj_Umowy),
  Data date NOT NULL
);

CREATE TABLE Dzialy (
  ID_Dzialy int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Pracownicy_Dzialy (
  ID_Pracownicy_Dzialy int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Pracownicy int NOT NULL FOREIGN KEY REFERENCES Pracownicy(ID_Pracownicy),
  ID_Dzialy int NOT NULL FOREIGN KEY REFERENCES Dzialy(ID_Dzialy),
  Data date NOT NULL
);

CREATE TABLE Stanowisko (
  ID_Stanowisko int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Pracownicy_Stanowisko (
  ID_Pracownicy_Stanowisko int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Pracownicy int NOT NULL FOREIGN KEY REFERENCES Pracownicy(ID_Pracownicy),
  ID_Stanowisko int NOT NULL FOREIGN KEY REFERENCES Stanowisko(ID_Stanowisko),
  Data date NOT NULL
);

CREATE TABLE Jezyki (
  ID_Jezyki int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Poziom_Znajomosci (
  ID_Poziom_Znajomosci int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Pracownicy_Jezyki (
  ID_Pracownicy_Jezyki int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Pracownicy int NOT NULL FOREIGN KEY REFERENCES Pracownicy(ID_Pracownicy),
  ID_Jezyki int NOT NULL REFERENCES Jezyki(ID_Jezyki),
  ID_Poziom_Znajomosci int NOT NULL REFERENCES Poziom_Znajomosci(ID_Poziom_Znajomosci),
  Data date NOT NULL
);

CREATE TABLE Rodzaj_Faktury (
  ID_Rodzaj_Faktury int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Stan_Faktury (
  ID_Stan_Faktury int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Faktury (
  ID_Faktury int NOT NULL PRIMARY KEY,
  ID_Rodzaj_Faktury int NOT NULL REFERENCES Rodzaj_Faktury(ID_Rodzaj_Faktury),
  Data_Wplywu date NOT NULL,
  Termin_platnosci int NOT NULL,
  --dni  
  ID_Pracownicy int NOT NULL REFERENCES Pracownicy(ID_Pracownicy),
  Nazwa_Podmiotu nvarchar(30) NULL,
  NIP nvarchar(10) NULL,
  Adres_Ulica nvarchar(30) NOT NULL,
  Adres_Kod_Pocztowy nvarchar(30) NOT NULL,
  Adres_Miasto nvarchar(30) NOT NULL,
  Kwota_Netto decimal(15, 2) NOT NULL,
  Kwota_Brutto decimal(15, 2) NOT NULL,
  Data_Zaplaty date NULL,
  Plik image NULL,
  ID_Stan_Faktury int NOT NULL REFERENCES Stan_Faktury(ID_Stan_Faktury),
);

CREATE TABLE Rodzaj_Koszty_Rozne (
  ID_Rodzaj_Koszty_Rozne int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Koszty_Rozne (
  ID_Koszty_Rozne int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Rodzaj_Koszty_Rozne int NOT NULL REFERENCES Rodzaj_Koszty_Rozne(ID_Rodzaj_Koszty_Rozne),
  ID_Pracownicy int NOT NULL REFERENCES Pracownicy(ID_Pracownicy),
  Kwota_Netto decimal(15, 2) NOT NULL,
  Kwota_Brutto decimal(15, 2) NOT NULL,
  ID_Faktury int NULL REFERENCES Faktury(ID_Faktury),
  Data date NOT NULL
);

CREATE TABLE Srodki_Majatkowe (
  ID_Srodki_Majatkowe int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL,
  Symbol nvarchar(30) NOT NULL,
  ID_Dzialy int NOT NULL REFERENCES Dzialy(ID_Dzialy),
  Koszt_Zakupu_Netto decimal(15, 2) NOT NULL,
  Koszt_Zakupu_Brutto decimal(15, 2) NOT NULL,
  ID_Faktury_Zakup int NULL REFERENCES Faktury(ID_Faktury),
  Data_Przychodu date NOT NULL,
  Przychod_Ze_Sprzedazy_Netto decimal(15, 2) NULL,
  Przychod_Ze_Sprzedazy_Brutto decimal(15, 2) NULL,
  ID_Faktury_Sprzedaz int NULL REFERENCES Faktury(ID_Faktury),
  Data_Rozchodu date NULL
);

CREATE TABLE Rodzaj_Oplaty_Administracyjnej (
  ID_Rodzaj_Oplaty_Administracyjnej int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Oplaty_Administracyjne (
  ID_Oplaty_Administracyjne int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Pracownicy int NOT NULL REFERENCES Pracownicy(ID_Pracownicy),
  ID_Rodzaj_Oplaty_Administracyjnej int NOT NULL REFERENCES Rodzaj_Oplaty_Administracyjnej(ID_Rodzaj_Oplaty_Administracyjnej),
  Nazwa nvarchar(30) NOT NULL,
  Kwota_Netto decimal(15, 2) NOT NULL,
  Kwota_Brutto decimal(15, 2) NOT NULL,
  ID_Faktury int NULL REFERENCES Faktury(ID_Faktury),
  Data date NOT NULL,
  Okres_od date NULL,
  Okres_do date NULL
);

CREATE TABLE Klient (
  ID_Klient int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Imie nvarchar(30) NOT NULL,
  Nazwisko nvarchar(30) NOT NULL,
  Nazwa_Podmiotu nvarchar(30) NULL,
  NIP nvarchar(10) NULL,
  Adres_Ulica nvarchar(30) NOT NULL,
  Adres_Kod_Pocztowy nvarchar(6) NOT NULL,
  Adres_Miasto nvarchar(30) NOT NULL,
  Telefon nvarchar(30) NULL,
  E_mail nvarchar(50) NULL,
);

CREATE TABLE Status_Zamowienia (
  ID_Status_Zamowienia int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL
);

CREATE TABLE Zamowienia_Klienci (
  ID_Zamowienia_Klienci int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Klient int NOT NULL REFERENCES Klient(ID_Klient),
  ID_Pracownicy int NOT NULL REFERENCES Pracownicy(ID_Pracownicy),
  Data_Zamowienia date NOT NULL,
  Data_Realizacji date NOT NULL,
  Numer nvarchar(30) NOT NULL,
  ID_Faktury int NULL REFERENCES Faktury(ID_Faktury)
);

CREATE TABLE ZamowieniaKlienci_StatusZamowienia (
  ID_ZamowieniaKlienci_StatusZamowienia int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Zamowienia_Klienci int NOT NULL FOREIGN KEY REFERENCES Zamowienia_Klienci(ID_Zamowienia_Klienci),
  ID_Status_Zamowienia int NOT NULL FOREIGN KEY REFERENCES Status_Zamowienia(ID_Status_Zamowienia),
  Data date NOT NULL
);

CREATE TABLE Sklad_Zamowienia (
  ID_Sklad_Zamowienia int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Zamowienia_Klienci int NOT NULL REFERENCES Zamowienia_Klienci(ID_Zamowienia_Klienci),
  ID_Produkt int NOT NULL REFERENCES Produkt(ID_Produkt),
  Ilosc int NOT NULL,
  Cena_Netto decimal(15, 2) NOT NULL,
  Cena_Brutto decimal(15, 2) NOT NULL,
  Komentarz nvarchar(100) NULL,
  IloscWyslanychProduktow int default 0 NULL
);

CREATE TABLE Kontrola_Jakosci_Zamowienia (
  ID_Kontrola_Jakosci_Zamowienia int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Sklad_Zamowienia int NOT NULL REFERENCES Sklad_Zamowienia(ID_Sklad_Zamowienia),
  Ilosc int NULL,
  Zaakcpetowane int NULL,
  Odrzucone int NULL,
  Data date NULL,
  Uwagi nvarchar(100) NULL
);

/*  
 
 
 
 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  
 
 
 
 Tabela [Produkt] musi znaleść się przed tabelą [Sklad_Zamowienia]  
 
 
 
 */
/*  
 
 
 
 Dzial Produkcji   
 
 
 
 */
/*  
 
 
 
 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  
 
 
 
 Proszę o dodanie przy wszystkich kosztach:  
 
 
 
 ID_Faktury int NULL REFERENCES Faktury(ID_Faktury),  
 
 
 
 I kosztów w formacie decimal(15,2)  
 
 
 
 */
/*  
 Dzial Produkcja ------------------------------------------------------------------------------  
 */
--Maszyny  
CREATE TABLE Rodzaj_Strategii_Eksp (
  ID_Rodzaj_Strategii_Eksp int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(100) NOT NULL
);

CREATE TABLE Rodzaj_Maszyny (
  ID_Rodzaj_Maszyny int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(25) NOT NULL
);

CREATE TABLE Model_Maszyny (
  ID_Model_Maszyny int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Rodzaj_Strategii_Eksp INT NOT NULL FOREIGN KEY REFERENCES Rodzaj_Strategii_Eksp(ID_Rodzaj_Strategii_Eksp),
  Marka nvarchar(25) NOT NULL,
  Model nvarchar(25) NOT NULL,
  ID_Rodzaj_Maszyny int NOT NULL FOREIGN KEY REFERENCES Rodzaj_Maszyny(ID_Rodzaj_Maszyny),
  Koszt_Roboczogodziny float NOT NULL
);

CREATE TABLE Maszyny (
  ID_Maszyny int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Model_Maszyny int NOT NULL FOREIGN KEY REFERENCES Model_Maszyny(ID_Model_Maszyny),
  Symbol nvarchar(25) NOT NULL,
  Data_przychodu date NOT NULL,
  Data_rozchodu date NULL,
  Przebieg_poczatkowy float NOT NULL
);

CREATE TABLE Rodzaj_Obslugi_Maszyny (
  ID_Rodzaj_Obslugi_Maszyny int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(100) NOT NULL,
);

CREATE TABLE Normy_Eksploatacyjne (
  ID_Normy_Eksploatacyjne int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Model_Maszyny int NOT NULL FOREIGN KEY REFERENCES Model_Maszyny(ID_Model_Maszyny),
  Nr_Normy nvarchar(100) NOT NULL
);

CREATE TABLE Czynnosci_Eksploatacyjne (
  ID_Czynnosci_Eksploatacyjne int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Normy_Eksploatacyjne int NOT NULL FOREIGN KEY REFERENCES Normy_Eksploatacyjne(ID_Normy_Eksploatacyjne),
  ID_Rodzaj_Obslug_Maszyny int NOT NULL FOREIGN KEY REFERENCES Rodzaj_Obslugi_Maszyny(ID_Rodzaj_Obslugi_Maszyny),
  Godziny float NULL
);

CREATE TABLE Obslugi (
  ID_Obslugi int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Maszyny int NOT NULL FOREIGN KEY REFERENCES Maszyny(ID_Maszyny),
  ID_Pracownicy int NOT NULL FOREIGN KEY REFERENCES Pracownicy(ID_Pracownicy),
  ID_Rodzaj_Obslugi_Maszyny int NOT NULL FOREIGN KEY REFERENCES Rodzaj_Obslugi_Maszyny(ID_Rodzaj_Obslugi_Maszyny),
  Koszt_netto float NOT NULL,
  Koszt_brutto float NOT NULL,
  Opis nvarchar(50) NOT NULL,
  Data_od date NOT NULL,
  Data_do date NOT NULL
);

CREATE TABLE Parametr_Maszyny (
  ID_Parametr_Maszyny int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Model_Maszyny int NOT NULL FOREIGN KEY REFERENCES Model_Maszyny(ID_Model_Maszyny),
  Nazwa_Parametru nvarchar(100) NOT NULL,
  Wartosc_Nominalna float NOT NULL,
  Dolna_Granica float NOT NULL,
  Gorna_Granica float NOT NULL
);

CREATE TABLE Badanie_Maszyny (
  ID_Badanie int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Maszyny int NOT NULL FOREIGN KEY REFERENCES Maszyny(ID_Maszyny),
  ID_Pracownicy int NOT NULL FOREIGN KEY REFERENCES Pracownicy(ID_Pracownicy),
  Data date NOT NULL,
  Opis nvarchar(500) NOT NULL
);

CREATE TABLE Badany_Parametr (
  ID_Badany_Parametr int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Badanie int NOT NULL FOREIGN KEY REFERENCES Badanie_Maszyny(ID_Badanie),
  ID_Parametr_Maszyny int NOT NULL FOREIGN KEY REFERENCES Parametr_Maszyny(ID_Parametr_Maszyny),
  Wartosc float NOT NULL
);

-- Produkt  
CREATE TABLE Rodzaj_Dokumentacja(
  ID_Rodzaj_Dokumentacja int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) not null,
);

CREATE TABLE Dokumentacja (
  ID_Dokumentacja int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Rodzaj_Dokumentacja int NOT NULL FOREIGN KEY REFERENCES Rodzaj_Dokumentacja(ID_Rodzaj_Dokumentacja),
  ID_Produkt int NOT NULL FOREIGN KEY REFERENCES Produkt,
  Plik nvarchar(50) not null,
  Data_ date not null,
);

CREATE TABLE Funkcja_w_Dokumentacji(
  ID_Funkcja_w_Dokumentacji int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) not null,
);

CREATE TABLE Dokumentacja_Pracownicy (
  ID_Dokumentacja int NOT NULL FOREIGN KEY REFERENCES Dokumentacja,
  ID_Pracownicy int NOT NULL FOREIGN KEY REFERENCES Pracownicy(ID_Pracownicy),
  ID_Funkcja_w_Dokumentacji int NOT NULL FOREIGN KEY REFERENCES Funkcja_w_Dokumentacji(ID_Funkcja_w_Dokumentacji)
);

--Narzedzia  
CREATE TABLE Rodzaj_Narzedzia(
  ID_Rodzaj_Narzedzia int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) not null,
);

CREATE TABLE Narzedzia(
  ID_Narzedzia int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Rodzaj_Narzedzia int NOT NULL FOREIGN KEY REFERENCES Rodzaj_Narzedzia(ID_Rodzaj_Narzedzia),
  Symbol nvarchar(30) null,
  Opis nvarchar(30) null,
  Data_przychodu date not null,
  Data_rozchodu date null
);

--Proces  
CREATE TABLE Nazwa_Procesu (
  ID_Nazwa_Procesu int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  Nazwa nvarchar(30) NOT NULL,
);

CREATE TABLE Proces (
  ID_Proces int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Sklad_Zamowienia int NOT NULL FOREIGN KEY REFERENCES Sklad_Zamowienia(ID_Sklad_Zamowienia),
  ID_Maszyny int NOT NULL FOREIGN KEY REFERENCES Maszyny(ID_Maszyny),
  ID_Nazwa_Procesu int NOT NULL FOREIGN KEY REFERENCES Nazwa_Procesu(ID_Nazwa_Procesu),
  Ilosc INT NOT NULL,
  Data_Planowanego_Rozpoczecia date NOT NULL,
  Data_Planowanego_Zakonczenia date NOT NULL,
  Data_Rzeczywistego_Rozpoczecia date NULL,
  Data_Rzeczywistego_Zakonczenia date NULL,
  Czas_Pracy_Maszyny int NULL,
);

CREATE TABLE Proces_Pracownicy (
  Proces_Pracownicy int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Proces int NOT NULL FOREIGN KEY REFERENCES Proces(ID_Proces),
  ID_Pracownicy int NOT NULL FOREIGN KEY REFERENCES Pracownicy(ID_Pracownicy),
  Czas_Pracy int NOT NULL,
);

CREATE TABLE Proces_Technologiczny (
  ID_Proces_Technologiczny int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Produkt int NOT NULL REFERENCES Produkt(ID_Produkt),
  ID_Rodzaj_Maszyny int NOT NULL REFERENCES Rodzaj_Maszyny(ID_Rodzaj_Maszyny),
  ID_Nazwa_Procesu int NOT NULL REFERENCES Nazwa_Procesu(ID_Nazwa_Procesu),
  Kolejnosc int NOT NULL,
  Ilosc_Godzin int NOT NULL,
  Ilosc_Pracownikow int NOT NULL,
);

CREATE TABLE Proces_Narzedzia(
  ID_Proces_Narzedzia int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Narzedzia int NOT NULL FOREIGN KEY REFERENCES Narzedzia(ID_Narzedzia),
  ID_Proces int NOT NULL FOREIGN KEY REFERENCES Proces
);

CREATE TABLE Proces_Technologiczny_Material(
  ID_Proces_Technologiczny_Material int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Proces_Technologiczny int NOT NULL FOREIGN KEY REFERENCES Proces_Technologiczny(ID_Proces_Technologiczny),
  ID_Material int NOT NULL FOREIGN KEY REFERENCES Material(ID_Material),
  Ilosc int not null
);

--Dzial Logistyki   
Create table Magazyn (
  ID_Magazyn int identity(1, 1) primary key,
  Nazwa nvarchar(25) not null,
  Telefon int not null,
  PowierzchniaRobocza int not null
);

-- Zlecenia_Magazynowe  
CREATE TABLE Zlecenie_Magazynowe (
  ID_Zlecenie_Magazynowe int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Sklad_Zamowienia int REFERENCES Sklad_Zamowienia(ID_Sklad_Zamowienia),
  ID_Pracownicy int REFERENCES Pracownicy(ID_Pracownicy),
  ID_Magazyn int foreign key references Magazyn not null default 1,
  [Data] DATE NOT NULL,
  CzyZlecenieStale VARCHAR(50) NOT NULL,
  Zwrot bit NULL,
  Uwagi VARCHAR(300) NULL
);

CREATE TABLE ZleceniaStale (
  ID_ZleceniaStale int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Zlecenie_Magazynowe INT NOT NULL FOREIGN KEY REFERENCES Zlecenie_Magazynowe(ID_Zlecenie_Magazynowe),
  Co_ile smallint NOT NULL,
  DataDo DATE NOT NULL
);

CREATE TABLE Sklad_Zlecenie_Magazynowe (
  ID_Sklad_Zlecenie_Magazynowe int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Zlecenie_Magazynowe int NOT NULL FOREIGN KEY REFERENCES Zlecenie_Magazynowe(ID_Zlecenie_Magazynowe),
  ID_Material INT NOT NULL FOREIGN KEY REFERENCES Material(ID_Material),
  Data DATE NOT NULL,
  CzyZlecenieStale VARCHAR(50) NOT NULL,
  Zwrot VARCHAR(50) NULL,
  Uwagi VARCHAR(300) NULL,
  IloscMaterialow int not null
);

CREATE TABLE Sklad_Zlecenie_Produkt (
  ID_Sklad_Zlecenie_Produkt int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
  ID_Zlecenie_Magazynowe int NOT NULL FOREIGN KEY REFERENCES Zlecenie_Magazynowe(ID_Zlecenie_Magazynowe),
  ID_Produkt int NOT NULL FOREIGN KEY REFERENCES Produkt(ID_Produkt),
  Data DATE NOT NULL,
  CzyZlecenieStale VARCHAR(50) NOT NULL,
  Zwrot VARCHAR(50) NULL,
  Uwagi VARCHAR(300) NULL,
  IloscProduktow int not null
);


--create table TypZasobu_RodzajMaterialu (
--  ID_TypZasobu int not null,
--  ID_Rodzaj_Materialu int not null,
--  primary key (ID_TypZasobu, ID_Rodzaj_Materialu),
--  foreign key (ID_TypZasobu) references TypZasobu(ID_TypZasobu),
--  foreign key (ID_Rodzaj_Materialu) references Rodzaj_Materialu(ID_Rodzaj_Materialu)
--);

Create table Sekcja (
  ID_Sekcja int identity(1, 1) primary key,
  ID_Magazyn int foreign key references Magazyn(ID_Magazyn) not null,
  ID_TypZasobu int foreign key references TypZasobu(ID_TypZasobu) not null,
  Numer varchar(25) not null,
  PowierzchniaRobocza float not null
);

create table Polka (
  ID_Polka int identity(1, 1) primary key,
  ID_Sekcja int foreign key references Sekcja(ID_Sekcja) not null,
  Numer varchar(5) not null,
  SzerokoscPietra float not null,
  DlugoscPietra float not null,
  WysokoscPietra float not null,
  Udzwig float not null,
  LiczbaPieter int not null
);

create table Nierozlozone_Materialy (
  ID_NierozlozoneMaterialy int identity(1, 1) primary key,
  ID_Material int foreign key references Material(ID_Material) not null,
  Ilosc int not null,
  DataOd date not null default GetDate(),
  DataDo date
)

create table Nierozlozone_Produkty (
  ID_NierozlozoneProdukty int identity(1, 1) primary key,
  ID_Produkt int foreign key references Produkt(ID_Produkt) not null,
  Ilosc int not null,
  DataOd date not null default GetDate(),
  DataDo date
)

create table RozlozeniePolki_Materialy (
  ID_RozlozeniePolki_Materialy int identity(1, 1) primary key,
  ID_Polka int foreign key references Polka(ID_Polka) not null,
  ID_Material int foreign key references Material(ID_Material) not null,
  ID_Pracownik int foreign key references Pracownicy(ID_Pracownicy) not null,
  Ilosc int not null,
  DataOd date not null default GetDate(),
  DataDo date
);

create table RozlozeniePolki_Produkty (
  ID_RozlozeniePolki_Produkty int identity(1, 1) primary key,
  ID_Polka int foreign key references Polka(ID_Polka) not null,
  ID_Produkt int foreign key references Produkt(ID_Produkt) not null,
  ID_Pracownik int foreign key references Pracownicy(ID_Pracownicy) not null,
  Ilosc int not null,
  DataOd date not null default GetDate(),
  DataDo date
);

create table RodzajDostawcy (
  ID_RodzajDostawcy int identity(1, 1) primary key,
  Nazwa nvarchar(30) not null
);

create table Dostawcy (
  ID_Dostawcy int identity(1, 1) primary key,
  NazwaFirmy nvarchar(30),
  Telefon varchar(12)
);

create table Dostawca_RodzajDostawcy (
  ID_RodzajDostawcy int not null,
  ID_Dostawcy int not null,
  primary key (ID_RodzajDostawcy, ID_Dostawcy),
  foreign key (ID_RodzajDostawcy) references RodzajDostawcy(ID_RodzajDostawcy),
  foreign key (ID_Dostawcy) references Dostawcy(ID_Dostawcy)
);

create table Dostawa (
  ID_Dostawa int identity(1, 1) primary key,
  ID_Dostawcy int foreign key references Dostawcy(ID_Dostawcy) not null,
  ID_Pracownik int foreign key references Pracownicy(ID_Pracownicy) not null,
  ID_Magazyn int foreign key references Magazyn(ID_Magazyn) not null,
  [Data] date not null
);

create table SkladDostawa_Material (
  ID_Dostawa int not null,
  ID_Material int not null,
  primary key (ID_Dostawa, ID_Material),
  foreign key (ID_Dostawa) references Dostawa(ID_Dostawa),
  foreign key (ID_Material) references Material(ID_Material),
  Ilosc int not null,
  KosztNetto decimal(15, 2) not null,
  KosztBrutto decimal(15, 2) not null,
  ID_Faktury int NULL REFERENCES Faktury(ID_Faktury),
);


create table RodzajPojazdu (
  ID_RodzajPojazdu int identity(1, 1) primary key,
  Nazwa varchar(30) not null
);

create table ModelePojazdu (
  ID_ModelPojazd int identity(1, 1) primary key,
  ID_RodzajPojazdu int foreign key references RodzajPojazdu(ID_RodzajPojazdu),
  Marka nvarchar(25) not null,
  Model nvarchar(25) not null,
  Nosnosc float not null,
  PojemnoscSilnika float not null,
  Szerokosc float not null,
  Glebokosc float not null,
  Wysokosc float not null
);

create table Pojazd (
  ID_Pojazd int identity(1, 1) primary key,
  ID_ModelPojazd int foreign key references ModelePojazdu(ID_ModelPojazd) not null,
  NrRejestracyjny nvarchar(20) not null,
  RokProdukcji date not null,
  DataPrzychodu date not null,
  StanLicznikaPoczatkowy int not null,
  DataRozchodu date null
);

create table NormyEksploatacyjne_Pojazd (
  ID_ModelPojazd int primary key foreign key references ModelePojazdu(ID_ModelPojazd),
  JednostkaMiar nvarchar(30) null,
  RemontSredni nvarchar(30),
  -- idk co to jest. Do sprawdzenia  
  RemontGlowny nvarchar(30),
  -- idk co to jest. Do sprawdzenia  
);

create table RodzajPaliwa (
  ID_RodzajPaliwa int identity(1, 1) primary key,
  Nazwa nvarchar(30) not null
);

create table Tankowanie (
  ID_Tankowanie int identity(1, 1) primary key,
  ID_Pojazd int foreign key references Pojazd(ID_Pojazd) not null,
  ID_RodzajPaliwa int foreign key references RodzajPaliwa(ID_RodzajPaliwa) not null,
  LiczbaLitrow float not null,
  KosztNetto int not null,
  KosztBrutto int not null,
  ID_Faktury int NULL REFERENCES Faktury(ID_Faktury),
  [Data] date not null
);

create table StanLicznika (
  ID_StanLicznika int identity(1, 1) primary key,
  ID_Pojazd int foreign key references Pojazd(ID_Pojazd) not null,
  ID_Pracownik int foreign key references Pracownicy(ID_Pracownicy) not null,
  StanLicznika float not null,
  [Data] date not null
);

create table PrzegladPojazdu (
  ID_PrzegladPojazdu int identity(1, 1) primary key,
  ID_Pojazd int foreign key references Pojazd(ID_Pojazd) not null,
  [Data] date null,
  DataDoP date null,
  KosztNetto int not null,
  KosztBrutto int not null,
  ID_Faktury int NULL REFERENCES Faktury(ID_Faktury)
);

create table RodzajUbezpieczenia (
  ID_RodzajUbezpieczenia int identity(1, 1) primary key,
  Nazwa nvarchar(35) not null
);

create table Ubezpieczyciel (
  ID_Ubezpieczyciel int identity(1, 1) primary key,
  NazwaFirmy nvarchar(30) not null
);


create table Ubezpieczenie (
  ID_Ubezpieczenie int identity(1, 1) primary key,
  ID_Pojazd int foreign key references Pojazd(ID_Pojazd) not null,
  ID_Ubezpieczyciel int foreign key references Ubezpieczyciel(ID_Ubezpieczyciel) not null,
  ID_RodzajUbezpieczenia int foreign key references RodzajUbezpieczenia(ID_RodzajUbezpieczenia) not null,
  DataOd date null,
  DataDo date null,
  KosztNetto int not null,
  KosztBrutto int not null,
  ID_Faktury int NULL REFERENCES Faktury(ID_Faktury)
);

create table RodzajObslugi_Pojazdow (
  ID_RodzajObslugi_Pojazdow int identity(1, 1) primary key,
  Nazwa nvarchar(50) not null
);

create table ObslugiPojazdow (
  ID_ObslugiPojazdow int identity(1, 1) primary key,
  ID_Pojazd int foreign key references Pojazd(ID_Pojazd) not null,
  ID_RodzajObslugi_Pojazdow int foreign key references RodzajObslugi_Pojazdow(ID_RodzajObslugi_Pojazdow) not null,
  ID_Pracownik int foreign key references Pracownicy(ID_Pracownicy) not null,
  DataObslugiOd date null,
  DataObslugiDo date null,
  KosztNetto int not null,
  KosztBrutto int not null,
  ID_Faktury int NULL REFERENCES Faktury(ID_Faktury)
);

create table RodzajZdarzenia_Wysylka (
  ID_RodzajZdarzenia_Wysylka int identity(1, 1) primary key,
  Nazwa nvarchar(30) not null
);

--ID_Pojazd przeniesiony z tabeli SkladWysylkaProdukt
--Jednym pojazdem można wysłac różne produkty

--Usunięto Adres z tabeli Wysylka
--AF musi przekazać do Działu Logistyki gdzie wysyłac gotowe zamówienia!!!
--Można przyjąć że adres klienta to adres do wysyłki... albo dodac adres do formularza "Zamówienia"
--W ramach jednej wysyłki można dostarczyć zamówenia do kilku klientów (jeśli adresy są blisko siebie)
create table Wysylka (
  ID_Wysylka int identity(1, 1) primary key,
  ID_Pojazd int foreign key references Pojazd(ID_Pojazd) not null,
  ID_Pracownik int foreign key references Pracownicy(ID_Pracownicy) not null,
  Odleglosc float not null,
  [Data] date not null
);

create table SkladWysylka_Produkt (
  ID_SkladWysylka_Produkt int identity(1, 1) primary key,
  ID_Wysylka int foreign key references Wysylka(ID_Wysylka) not null,
  ID_ZamowieniaKlienci int foreign key references Zamowienia_Klienci(ID_Zamowienia_Klienci) not null,
  ID_Produkt int foreign key references Produkt(ID_Produkt) not null,
  ID_Magazyn int foreign key references Magazyn(ID_Magazyn) not null,
  ID_Pracownik int foreign key references Pracownicy(ID_Pracownicy) not null,
  Ilosc int not null
);

create table ZdarzenieWysylka (
  ID_ZdarzenieWysylka int identity(1, 1) primary key,
  ID_Wysylka int foreign key references Wysylka(ID_Wysylka) not null,
  ID_RodzajZdarzenia_Wysylka int foreign key references RodzajZdarzenia_Wysylka(ID_RodzajZdarzenia_Wysylka) not null,
  Opis nvarchar(30) not null
);

create table TransportWewnetrzny(
  ID_TransportWewnetrzny int identity(1, 1) primary key,
  ID_Zlecenie_Magazynowe int foreign key references Zlecenie_Magazynowe(ID_Zlecenie_Magazynowe) not null,
  ID_Magazyn_pocz int foreign key references Magazyn(ID_Magazyn) not null,
  ID_Magazyn_konc int foreign key references Magazyn(ID_Magazyn) not null,
  ID_Pojazd int foreign key references Pojazd(ID_Pojazd) not null,
  ID_Pracownik int foreign key references Pracownicy(ID_Pracownicy) not null,
  Data date not null,
);

create table Sklad_TransportWewnetrzny_Material (
  ID_Sklad_TransportWewnetrzny_Material int identity(1, 1) primary key,
  ID_TransportWewnetrzny int foreign key references TransportWewnetrzny(ID_TransportWewnetrzny) not null,
  ID_Material int foreign key references Material(ID_Material) not null,
  Ilosc int not null
);