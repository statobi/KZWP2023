USE IDEA
GO
  --DZIAŁ FINANSÓW I ADMINISTRACJI  
  --Sylwia Jankowska Pracownicy - Dzialy, Stanowiska, Umowy, Jezyki  

  insert into
  Magazyn (Nazwa, PowierzchniaRobocza, Telefon)
values
  ('Magazyn Produkcji', 30000, '312313431'),
  ('Magazyn1', 50000, '123123123'),
  ('Magazyn2', 60000, '111222333');



INSERT INTO
  Pracownicy (
    Imie,
    Nazwisko,
    PESEL,
    Adres_Ulica,
    Adres_Kod_Pocztowy,
    Adres_Miasto,
    Numer_Konta_Bankowego,
    Telefon,
    E_mail
  )
VALUES
  (
    'Jan',
    'Kowalski',
    '91010112345',
    'ul. Kwiatowa 7',
    '12-345',
    'Warszawa',
    '993456789012345678901234',
    '923456789',
    'jan.kowalski@example.com'
  ),
  (
    'Anna',
    'Nowak',
    '92121298766',
    'ul. Szkolna 4',
    '34-567',
    'Kraków',
    '987654321098765432109876',
    '634567890',
    'anna.nowak@example.com'
  ),
  (
    'Piotr',
    'Zieliński',
    '93030376543',
    'ul. Zielona 10',
    '54-321',
    'Wrocław',
    '567890123456789012345678',
    '345678901',
    'piotr.zielinski@example.com'
  ),
  (
    'Marta',
    'Lewandowska',
    '94040465432',
    'ul. Ogrodowa 12',
    '67-890',
    'Poznań',
    '901234567890123456789012',
    '456789012',
    'marta.lewandowska@example.com'
  ),
  (
    'Krzysztof',
    'Duda',
    '95050554321',
    'ul. Leśna 1',
    '98-765',
    'Gdańsk',
    '345678901234567890123456',
    '567890123',
    'krzysztof.duda@example.com'
  ),
  (
    'Karolina',
    'Szymańska',
    '96060643210',
    'ul. Polna 14',
    '43-210',
    'Katowice',
    '678901234567890123456789',
    '678901234',
    'karolina.szymanska@example.com'
  ),
  (
    'Adam',
    'Wójcik',
    '97070732109',
    'ul. Piaskowa 3',
    '76-543',
    'Szczecin',
    '012345678901234567890123',
    '789012345',
    'adam.wojcik@example.com'
  ),
  (
    'Alicja',
    'Kaczmarek',
    '98080821098',
    'ul. Miodowa 8',
    '90-123',
    'Łódź',
    '456789012345678901234567',
    '890123456',
    'alicja.kaczmarek@example.com'
  ),
  (
    'Marcin',
    'Piotrowski',
    '99090910987',
    'ul. Cicha 6',
    '01-234',
    'Bydgoszcz',
    '789012345678901234567890',
    '901234567',
    'marcin.piotrowski@example.com'
  ),
  (
    'Magdalena',
    'Jankowska',
    '00010109876',
    'ul. Wodna 11',
    '45-678',
    'Rzeszów',
    '234567890123456789012345',
    '012345678',
    'magdalena.jankowska@example.com'
  ),
  (
    'Tomasz',
    'Mazur',
    '01111298765',
    'ul. Konopnickiej 2',
    '87-654',
    'Kielce',
    '567890123456789012345678',
    '123456789',
    'tomasz.mazur@example.com'
  ),
  (
    'Piotr',
    'Maj',
    '81081387654',
    'ul. Zielona 3',
    '02-003',
    'Gdańsk',
    '34567890123456789012345678',
    '333444555',
    'piotr.maj@mail.com'
  ),
  (
    'Katarzyna',
    'Wójcik',
    '93062334567',
    'ul. Kwiatowa 4',
    '03-004',
    'Poznań',
    '45678901234567890123456789',
    '444555666',
    'katarzyna.wojcik@mail.com'
  ),
  (
    'Michał',
    'Kamiński',
    '88012398765',
    'ul. Słoneczna 5',
    '04-005',
    'Wrocław',
    '56789012345678901234567890',
    '555666777',
    'michal.kaminski@mail.com'
  ),
  (
    'Agnieszka',
    'Duda',
    '90042623456',
    'ul. Morska 6',
    '05-006',
    'Szczecin',
    '67890123456789012345678901',
    '666777888',
    'agnieszka.duda@mail.com'
  ),
  (
    'Tomasz',
    'Górski',
    '94091565432',
    'ul. Kwiatowa 7',
    '06-007',
    'Katowice',
    '78901234567890123456789012',
    '777888999',
    'tomasz.gorski@mail.com'
  ),
  (
    'Karolina',
    'Zając',
    '86033143210',
    'ul. Szkolna 8',
    '07-008',
    'Bydgoszcz',
    '89012345678901234567890123',
    '888999000',
    'karolina.zajac@mail.com'
  ),
  (
    'Bartosz',
    'Lewandowski',
    '92022276543',
    'ul. Zielona 9',
    '08-009',
    'Lublin',
    '90123456789012345678901234',
    '999000111',
    'bartosz.lewandowski@mail.com'
  ),
  (
    'Magdalena',
    'Kowalczyk',
    '89041523456',
    'ul. Słoneczna 10',
    '09-010',
    'Łódź',
    '01234567890123456789012345',
    '000111222',
    'magdalena.kowalczyk@mail.com'
  ),
  (
    'Krzysztof',
    'Szymański',
    '90080854321',
    'ul. Morska 11',
    '10-011',
    'Rzeszów',
    '12345678901234567890123456',
    '111222333',
    'krzysztof.szymanski@mail.com'
  ),
  (
    'Michał',
    'Ziętal',
    '95010112345',
    'ul. Zielona 4',
    '30-001',
    'Kraków',
    '75102010260000042270270271',
    '456789012',
    'michal.zietal@example.com'
  ),
  (
    'Sylwia',
    'Jankowska',
    '83080112345',
    'ul. Kwiatowa 5',
    '90-001',
    'Łódź',
    '75109010140000000201006656',
    '567890123',
    'sylwia.jankowska@example.com'
  ),
  (
    'Adam',
    'Pawłowski',
    '85080112345',
    'ul. Czarna 8',
    '90-001',
    'Łódź',
    '89109010140000000201006656',
    '692890123',
    'adam.pawlowski@example.com'
  ),
  (
    'Patryk',
    'Cedro',
    '83052112345',
    'ul. Biała 9',
    '09-421',
    'Płock',
    '76109210140000000201006656',
    '755890123',
    'patryk.cedro@example.com'
  ),
  (
    'Katarzyna',
    'Adamska',
    '99080112345',
    'ul. Różana 15',
    '01-476',
    'Warszawa',
    '71108010130000000201006656',
    '985890123',
    'katarzyna.adamska@example.com'
  ),
  (
    'Krzesław',
    'Stolorz',
    '97061526854',
    'ul. Szkolna 16',
    '05-077',
    'Białystok',
    '41361346136134616161346436',
    '897354756',
    'krzeslaw.stolorz@mail.com'
  );

INSERT INTO
  Pracownicy_Zatrudnienie (
    ID_Pracownicy,
    Pensja_Netto,
    Pensja_Brutto,
    Data_od,
    Data_do,
    Dotychczasowy_Staz
  )
VALUES
  (1, 5200, 5500, '2016-12-01', null, '8'),
  (2, 4000, 4400, '2010-11-01', '2022-11-01', '14'),
  (3, 4100, 4500, '2014-09-05', null, '10'),
  (4, 4700, 5000, '2017-03-31', null, '8'),
  (5, 4600, 4900, '2019-06-05', null, '5'),
  (6, 4800, 5100, '2018-01-02', '2023-01-15', '6'),
  (7, 4500, 4900, '2019-11-01', null, '5'),
  (8, 4300, 4700, '2017-05-07', null, '7'),
  (9, 4500, 4800, '2015-10-05', null, '10'),
  (10, 4000, 4500, '2020-07-08', '2022-12-01', '3'),
  (11, 4000, 4400, '2021-08-11', null, '4'),
  (12, 4300, 4500, '2022-09-01', null, '11'),
  (13, 4000, 4500, '2013-01-01', null, '12'),
  (14, 4400, 4800, '2018-10-10', null, '5'),
  (15, 5200, 5500, '2017-04-10', null, '7'),
  (16, 4100, 4500, '2018-05-25', null, '9'),
  (17, 4600, 4900, '2015-01-01', null, '11'),
  (18, 4500, 4800, '2014-06-10', null, '9'),
  (19, 4800, 5100, '2018-07-10', null, '7'),
  (20, 4600, 5000, '2015-08-01', null, '18'),
  (21, 5200, 5500, '2020-09-01', null, '5'),
  (22, 6200, 6500, '2015-10-05', null, '12'),
  (23, 4200, 4600, '2018-04-01', null, '8'),
  (24, 3800, 4200, '2019-07-01', null, '8'),
  (25, 3500, 3800, '2023-01-01', null, '2'),
  (26, 4000, 4400, '2022-01-01', null, '1');



INSERT INTO
  Rodzaj_Umowy (Nazwa)
VALUES
  ('Umowa o pracę'),
  ('Umowa zlecenie');

INSERT INTO
  Pracownicy_RodzajUmowy (ID_Pracownicy, ID_Rodzaj_Umowy, Data)
VALUES
  (1, 1, '2016-12-01'),
  (2, 1, '2010-11-01'),
  (3, 1, '2014-09-05'),
  (4, 1, '2017-03-31'),
  (5, 1, '2019-06-05'),
  (6, 1, '2018-01-02'),
  (7, 1, '2019-11-01'),
  (8, 1, '2017-05-07'),
  (9, 1, '2015-10-05'),
  (10, 1, '2020-07-08'),
  (11, 2, '2021-08-11'),
  (12, 2, '2022-09-01'),
  (13, 1, '2013-01-01'),
  (14, 1, '2018-10-10'),
  (15, 1, '2017-04-10'),
  (16, 1, '2018-05-25'),
  (17, 1, '2015-01-01'),
  (18, 1, '2014-06-10'),
  (19, 1, '2018-07-10'),
  (20, 1, '2015-08-01'),
  (21, 2, '2020-09-01'),
  (22, 1, '2015-10-05'),
  (23, 1, '2018-04-01'),
  (24, 1, '2019-07-01'),
  (25, 2, '2023-01-01'),
  (26, 2, '2023-01-01');


INSERT INTO
  Dzialy (Nazwa)
VALUES
  ('Produkcja'),
  ('Logistyka'),
  ('Finanse i administracja'),
  ('Przygotowanie produkcji'),
  ('Marketing');

INSERT INTO
  Pracownicy_Dzialy (ID_Pracownicy, ID_Dzialy, Data)
VALUES
  (1, 1, '2016-12-01'),
  (2, 1, '2010-11-01'),
  (3, 1, '2014-09-05'),
  (4, 1, '2017-03-31'),
  (5, 1, '2019-06-05'),
  (6, 1, '2018-01-02'),
  (7, 1, '2019-11-01'),
  (8, 1, '2017-05-07'),
  (9, 1, '2015-10-05'),
  (10, 1, '2020-07-08'),
  (11, 1, '2021-08-11'),
  (12, 1, '2022-09-01'),
  (13, 1, '2013-01-01'),
  (14, 1, '2018-10-10'),
  (15, 2, '2017-04-10'),
  (16, 2, '2018-05-25'),
  (17, 2, '2015-01-01'),
  (18, 2, '2014-06-10'),
  (19, 2, '2018-07-10'),
  (20, 2, '2015-08-01'),
  (21, 3, '2020-09-01'),
  (22, 3, '2015-10-05'),
  (23, 3, '2018-04-01'),
  (24, 3, '2019-07-01'),
  (25, 3, '2023-01-01'),
  (26, 2, '2023-01-01');

INSERT INTO
  Stanowisko (Nazwa)
VALUES
  ('Kierownik'),
  ('Kierownik działu'),
  ('Kontroler jakości'),
  ('Inżynier produkcji'),
  ('Operator maszyn'),
  ('Inżynier utrzymania ruchu'),
  ('Magazynier'),
  ('Logistyk'),
  ('Kierowca'),
  ('Obsługa klienta'),
  ('Księgowy');

INSERT INTO
  Pracownicy_Stanowisko (ID_Pracownicy, ID_Stanowisko, Data)
VALUES
  (1, 2, '2016-12-01'),
  (2, 3, '2010-11-01'),
  (3, 3, '2014-09-05'),
  (4, 4, '2017-03-31'),
  (5, 4, '2019-06-05'),
  (6, 4, '2018-01-02'),
  (7, 5, '2019-11-01'),
  (8, 5, '2017-05-07'),
  (9, 5, '2015-10-05'),
  (10, 5, '2020-07-08'),
  (11, 5, '2021-08-11'),
  (12, 6, '2022-09-01'),
  (13, 6, '2013-01-01'),
  (14, 6, '2018-10-10'),
  (15, 2, '2017-04-10'),
  (16, 7, '2018-05-25'),
  (17, 8, '2015-01-01'),
  (18, 8, '2014-06-10'),
  (19, 9, '2018-07-10'),
  (20, 9, '2015-08-01'),
  (21, 2, '2020-09-01'),
  (22, 1, '2015-10-05'),
  (23, 10, '2018-04-01'),
  (24, 11, '2019-07-01'),
  (25, 11, '2023-01-01'),
  (26, 7, '2023-01-01');


INSERT INTO
  Jezyki (Nazwa)
VALUES
  ('angielski'),
  ('niemiecki'),
  ('francuski');

INSERT INTO
  Poziom_Znajomosci (Nazwa)
VALUES
  ('A1'),
  ('A2'),
  ('B1'),
  ('B2'),
  ('C1'),
  ('C2');

INSERT INTO
  Pracownicy_Jezyki (
    ID_Pracownicy,
    ID_Jezyki,
    ID_Poziom_Znajomosci,
    Data
  )
VALUES
  (1, 1, 2, '2016-12-01'),
  (2, 1, 3, '2010-11-01'),
  (3, 2, 3, '2014-09-05'),
  (4, 1, 3, '2017-03-31'),
  (5, 3, 2, '2019-06-05'),
  (6, 1, 4, '2018-01-02'),
  (7, 1, 4, '2019-11-01'),
  (8, 1, 4, '2017-05-07'),
  (9, 1, 1, '2015-10-05'),
  (10, 1, 3, '2020-07-08'),
  (11, 3, 5, '2021-08-11'),
  (12, 2, 1, '2022-09-01'),
  (13, 2, 2, '2013-01-01'),
  (14, 1, 3, '2018-10-10'),
  (15, 1, 3, '2017-04-10'),
  (16, 1, 1, '2018-05-25'),
  (17, 1, 2, '2015-01-01'),
  (18, 2, 2, '2014-06-10'),
  (19, 2, 3, '2018-07-10'),
  (20, 3, 4, '2015-08-01'),
  (21, 3, 1, '2020-09-01'),
  (22, 1, 6, '2015-10-05'),
  (23, 1, 3, '2018-04-01'),
  (24, 1, 3, '2019-07-01'),
  (25, 1, 4, '2023-01-01'),
  (25, 1, 4, '2023-01-01');


--Michal Zietal, Klienci, Faktury, Sklad_Zamowienia  
INSERT
  Rodzaj_Faktury(Nazwa)
VALUES
  ('Opłaty administracyjne'),
  --1XXX  
  ('Dostawa Materiału'),
  --2XXX  
  ('Obsługi maszyn'),
  --3XXX  
  ('Tankowanie'),
  --4XXX  
  ('Przegląd pojazdu'),
  --5XXX  
  ('Ubezpieczenie'),
  --6XXX  
  ('Obsługi pojazdów'),
  --7XXX  
  ('Koszty środki majątkowe'),
  --8XXX  

  ('Koszty różne'),
  --9XXX  
  ('Przychody środki majątkowe'),
  --10XXX  
  ('Przychody zamówienia') --11XXX  
INSERT
  Stan_Faktury(Nazwa)
VALUES
  ('Opłacona'),
  ('Nieopłacona');

INSERT
  Faktury(
    ID_Faktury,
    ID_Rodzaj_Faktury,
    Data_Wplywu,
    Termin_platnosci,
    ID_Pracownicy,
    Nazwa_Podmiotu,
    NIP,
    Adres_Ulica,
    Adres_Kod_Pocztowy,
    Adres_Miasto,
    Kwota_Netto,
    Kwota_Brutto,
    Data_Zaplaty,
    ID_Stan_Faktury
  )
VALUES
  (
    1001,
    1,
    '2023-02-20',
    14,
    1,
    'MALPOL',
    '9876543218',
    'ul. Krótka 47',
    '09-478',
    'Warszawa',
    2500.00,
    3075.00,
    '2023-02-27',
    1
  ),
  (
    1002,
    1,
    '2023-01-21',
    14,
    2,
    'HIP-POL',
    '7546543218',
    'ul. Długa 46',
    '09-471',
    'Szczecin',
    1500.00,
    1800.00,
    '2023-02-03',
    1
  ),
  (
    1003,
    1,
    '2023-03-22',
    14,
    1,
    'AGRO-LOS',
    '7545813218',
    'ul. Słoneczna 12',
    '05-471',
    'Kraków',
    1200.00,
    1500.00,
    '2023-03-25',
    1
  ),
  (
    9001,
    9,
    '2023-03-15',
    14,
    1,
    'MIX',
    '7545813222',
    'ul. Piękna 12',
    '01-852',
    'Warszawa',
    1200.00,
    1476.00,
    '2023-03-17',
    1
  ),
  (
    9002,
    9,
    '2023-03-22',
    14,
    1,
    'ALPAKA',
    '7547113222',
    'ul. Aksamitna 17',
    '02-152',
    'Gdańsk',
    500.00,
    615.00,
    '2023-03-29',
    1
  ),
  (
    9003,
    9,
    '2023-04-02',
    14,
    1,
    'KWIATPOL',
    '9645813222',
    'ul. Niebieska 63',
    '03-652',
    'Płock',
    2000.00,
    2460.00,
    '2023-04-10',
    1
  ),
  (
    8001,
    8,
    '2022-12-05',
    14,
    1,
    'BUDPOL',
    '9645000222',
    'ul. Fioletowa 35',
    '05-652',
    'Gdynia',
    800000.00,
    984000.00,
    '2022-12-15',
    1
  ),
  (
    8002,
    8,
    '2023-04-02',
    14,
    1,
    'BIUROMASZ',
    '6585813222',
    'ul. Granatowa 60',
    '06-612',
    'Szczecin',
    80000.00,
    98400.00,
    '2023-04-09',
    1
  ),
  (
    11001,
    11,
    '2023-04-01',
    14,
    1,
    'POLMAK',
    '6269813222',
    'ul. Rybna 8',
    '07-512',
    'Wrocław',
    45000.00,
    63000.00,
    '2023-04-05',
    1
  ),
  (
    11002,
    11,
    '2023-04-02',
    14,
    1,
    'MOPSOL',
    '6585813847',
    'ul. Różana 10',
    '04-147',
    'Gliwice',
    144000.00,
    174800.00,
    '2023-04-12',
    1
  );

INSERT
  Klient(
    Imie,
    Nazwisko,
    Nazwa_Podmiotu,
    NIP,
    Adres_Ulica,
    Adres_Kod_Pocztowy,
    Adres_Miasto,
    Telefon,
    E_mail
  )
VALUES
  (
    'Stefan',
    'Kowalski',
    'StrangerThings',
    '2512524237',
    'Konwaliowa 4',
    '04-250',
    'Tulów',
    '560320520',
    'stefan.kowalski@example.com'
  ),
  (
    'Marianna',
    'Styga',
    'PolCom',
    '1413894532',
    'Motylowa 4',
    '01-226',
    'Szczecin',
    '551245550',
    'marianna.styga@example.com'
  ),
  (
    'Eryk',
    'Prawus',
    'LewusPOL',
    '2614528337',
    'Tępa 46',
    '74-223',
    'Gdańsk',
    '509304220',
    'eryk.prawus@example.com'
  );

INSERT
  Status_Zamowienia (Nazwa)
VALUES
  ('Do rozpatrzenia'),
  ('Zaakceptowane'),
  ('W realizacji'),
  ('Gotowe do wysyłki'),
  ('Zakończone'),
  ('Anulowane');

INSERT
  Zamowienia_Klienci (
    ID_Klient,
    ID_Pracownicy,
    Data_Zamowienia,
    Data_Realizacji,
    Numer,
    ID_Faktury
  )
VALUES
  (1, 1, '2023-03-01', '2023-04-01', 235, 11001),
  (1, 2, '2023-04-02', '2023-05-31', 342, 11002),
  (2, 2, '2023-04-19', '2023-05-23', 343, null);

INSERT
  ZamowieniaKlienci_StatusZamowienia (ID_Zamowienia_Klienci, ID_Status_Zamowienia, Data)
VALUES
  (1, 1, '2023-03-01'),
  (1, 2, '2023-03-03'),
  (1, 3, '2023-03-04'),
  (1, 4, '2023-03-28'),
  (1, 5, '2023-03-30'),

  (2, 1, '2023-04-02'),
  (2, 2, '2023-04-03'),
  (2, 3, '2023-04-05'),
  (2, 4, '2023-05-26'),
  (2, 5, '2023-04-30'),

  (3, 1, '2023-04-19'),
  (3, 2, '2023-04-22'),
  (3, 3, '2023-04-23');

--Tomasz_Zaloga_Urlopy_Srodki_majatkowe  
INSERT
  Rodzaj_Koszty_Rozne (Nazwa)
VALUES
  ('Szkolenie'),
  ('Akcja promocyjna'),
  ('Zwroty i reklamacje'),
  ('Przyjęcie okolicznościowe');

INSERT
  Rodzaj_Oplaty_Administracyjnej (Nazwa)
VALUES
  ('Zużycie energii elektrycznej'),
  ('Zużycie wody'),
  ('Ogrzewanie'),
  ('Odpady komunalne'),
  ('Ubezpieczenia'),
  ('Internet'),
  ('Abonament telefoniczny'),
  ('Czynsz');

INSERT
  Rodzaj_Urlopu (Nazwa)
VALUES
  ('Wypoczynkowy'),
  ('Chorobowy'),
  ('Na żądanie');

INSERT
  Urlopy (
    ID_Pracownicy,
    ID_Rodzaj_Urlopu,
    Data_od,
    Data_do,
    Dni_Robocze
  )
VALUES
  (1, 2, '2023-03-01', '2023-03-07', 5),
  (13, 1, '2023-03-15', '2023-03-21', 5),
  (21, 3, '2023-04-01', '2023-04-04', 3);

INSERT
  Srodki_Majatkowe (
    Nazwa,
    Symbol,
    ID_Dzialy,
    Koszt_Zakupu_Netto,
    Koszt_Zakupu_Brutto,
    ID_Faktury_Zakup,
    Data_Przychodu,
    Przychod_Ze_Sprzedazy_Netto,
    Przychod_Ze_Sprzedazy_Brutto,
    ID_Faktury_Sprzedaz,
    Data_Rozchodu
  )
VALUES
  (
    'Hala produkcyjna',
    'WS003',
    1,
    800000.00,
    984000.00,
    8001,
    '2022-12-05',
    NULL,
    NULL,
    NULL,
    NULL
  ),
  (
    'Biuro',
    'WNS003',
    2,
    80000.00,
    98400.00,
    8002,
    '2022-02-05',
    NULL,
    NULL,
    NULL,
    NULL
  );

INSERT
  Koszty_Rozne (
    ID_Rodzaj_Koszty_Rozne,
    ID_Pracownicy,
    Kwota_Netto,
    Kwota_Brutto,
    ID_Faktury,
    Data
  )
VALUES
  (1, 5, 12000.00, 14760.00, 9001, '2023-03-15'),
  (2, 12, 5000.00, 6150.00, 9002, '2023-03-22'),
  (3, 8, 20000.00, 24600.00, 9003, '2023-04-02');

INSERT
  Oplaty_Administracyjne (
    ID_Pracownicy,
    ID_Rodzaj_Oplaty_Administracyjnej,
    Nazwa,
    Kwota_Netto,
    Kwota_Brutto,
    ID_Faktury,
    Data,
    Okres_od,
    Okres_do
  )
VALUES
  (
    8,
    4,
    'Opłata za odpady komunalne',
    25000.00,
    30750.00,
    1001,
    '2023-02-20',
    '2023-02-01',
    '2022-03-31'
  ),
  (
    5,
    5,
    'Opłata za ubezpieczenie',
    15000.00,
    18000.00,
    1002,
    '2023-01-21',
    '2023-01-01',
    '2023-01-31'
  ),
  (
    1,
    6,
    'Opłata za internet',
    12000.00,
    15000.00,
    1003,
    '2023-03-22',
    '2023-03-01',
    '2023-03-31'
  );

-------------------------------------------------------Produkcja------------------------------------------------------  
INSERT
  Nazwa_Procesu (Nazwa)
VALUES
  ('Cięcie siedziska'), --1
  ('Cięcie podparcia'), --2
  ('Toczenie nóg stołu'),     --3
  ('Składanie krzesła'),--4
  ('Cięcie półki'),     --5
  ('Cięcie nogi regału'),--6
  ('Cięcie desek'), --7
  ('Frezowanie blatu stołu'),--8
  ('Toczenie nóg stołu'),--9
  ('Wiercenie'),        --10
  ('Klejenie'),         --11
  ('Szlifowanie'),      --12
  ('Skręcanie regału'),        --13
  ('Składanie'),        --14
  ('Kontrola jakości'), --15
  ('Pakowanie'),        --16
  ('Frezowanie blatu stolika'),--17
  ('Klejenie krzesła'),         --18
  ('Klejenie stołu'),         --19
  ('Klejenie stolika') ,        --20
  ('Składanie krzesła'),        --21
  ('Składanie stołu'),        --22
  ('Składanie stolika'),     --23
  ('Toczenie nóg stolika'),     --24
  ('Cięcie półki regału');     --25
INSERT
  Rodzaj_Dokumentacja (Nazwa)
VALUES
  ('Konstrukcyjna'),
  ('Technologiczna');

INSERT
  Funkcja_w_Dokumentacji (Nazwa)
VALUES
  ('Technolog'),
  ('Konstruktor');

INSERT
  Jednostka_miary (Nazwa)
VALUES
  ('[mm]'),
  ('[m2]'),
  ('[m]'),
  ('[szt]'),
  ('[l]'),
  ('[ml]'),
  ('[kg]'),
  ('[g]'),
  ('[kg/cm2]'),
  ('[kg/m3]'),
  ('[HB]'),
  ('brak');

  insert into
  TypZasobu(Nazwa)
values
  ('Drewno'),
  ('Szkło'),
  ('Elementy metalowe'),
  ('Chemia'),
  ('Półfabrykat drewniany'),
  ('Wyroby drewniane');

INSERT
  Rodzaj_Materialu (ID_TypZasobu, Nazwa)
VALUES
--materiał drewniany zamawiamy jako półprodukty 
  (1, 'Materiał drewniany'),
  (3, 'Wkręt'),
  (3, 'Gwóźdź'),
  (4, 'Farba'),
  (4, 'Klej'),
--dopisane przez zespół logistyki 
  (1, 'Deska drewniana'),
  (1, 'Płyta drewniana'),
  (1, 'Listwa drewniana'),
  (1, 'Okleina drewniana'),
  (2, 'Szkło'),
  (3, 'Zamek'),
  (3, 'Zawias meblowy');

INSERT
  Rodzaj_Produktu (ID_TypZasobu, Nazwa)
VALUES
  (6, 'Regał'),
  (6, 'Krzesło'),
  (6, 'Stół'),
  (6, 'Półka'),
  (6, 'Stolik');
INSERT
  Rodzaj_Narzedzia (Nazwa)
VALUES
  ('Tarcza do Drewna'),
  ('Nóż tokarski do Drewna'),
  ('Srubokret_Plaski'),
  ('Srubokret_Philips'),
  ('Wiertarka01'),
  ('Wkretarka01'),
  ('Szlifierka_Katowa'),
  ('Szlifierka_Oscylacyjna'),
  ('Zestaw_Wietel'),
  ('Pilnik01'),
  ('Dluto01'),
  ('Frez do drewna');

INSERT
  Rodzaj_Maszyny(Nazwa)
VALUES
  ('Frezarka'),
  ('Tokarka'),
  ('Wiertarka Stołowa'),
  ('Piła Stołowa'),
  ('Brak');

INSERT
  Rodzaj_Strategii_Eksp(Nazwa)
VALUES
  ('Strategia eksploatacji według planowanej profilaktyki'),
  ('Strategia eksploatacji według stanu technicznego');

INSERT
  Rodzaj_Obslugi_Maszyny(Nazwa)
VALUES
  ('Kalibracja sond pomiarowych'),
  ('Smarowanie układów'),
  ('Regulacja układów pneumatycznych/hydraulicznych'),
  ('Wymiana filtrów'),
  ('Regeneracja wrzeciona'),
  ('Wymiana łożysk'),
  ('Regeneracja układu zasilania');

INSERT
  Material (
    ID_Rodzaj_Materialu,
    ID_Jednostka_miary,
    Nazwa,
    Szerokosc,
    Glebokosc,
    Wysokosc,
    Masa,
    Opis
  )
VALUES

--regał/półka
  (1, 4, 'Sklejka sosnowa', 1.25, 0.45, 0.03, 4, 'półfabrykat do półki/regału'),
  (1, 4, 'Sklejka sosnowa lakierowana', 1.85, 0.5, 0.3, 4, 'półfabrykat do regału'),
  --krzesło
  (1, 4, 'Sklejka dębowa', 0.5, 0.5, 0.015, 5, 'pólfabrykat do siedziska krzesła'),
  (1, 4, 'Sklejka dębowa lakierowana', 0.35, 0.2, 0.015, 2, 'pólfabrykat do podparcia krzesła'),
  (1, 4, 'Belka dębowa', 0.04, 0.04, 0.6, 2, 'pólfabrykat do nogi krzesła'),
--stół
  (1, 4, 'Deska dębowa', 1.25, 0.15, 0.02, 5, 'półfabrykat do stołu'),
  (1, 4, 'Belka jarzębowa', 0.08, 0.08, 0.08, 6, 'pólfabrykat do nogi stołu'),
--materiały dopełniające produkty
  (2, 4, 'Wkręt', 0.003, 0.002, 0.002, 0.01, 'wkręt do drewna'),
  (2, 4, 'Wkręt', 0.06, 0.002, 0.001, 0.001, 'wkręt do drewna'),
  (4, 5, 'Lakier bezbarwny', 0.02, 0.3, 0.02, 3, 'lakier bezbarwny szybkoschnący'),
  (4, 5, 'Bejca', 0.02, 0.35, 0.02, 1.5, 'kolor kasztanowy'),
  (5, 5, 'Klej', 0.02, 0.02, 0.02, 3, 'mocny klej'),
--dopisane przez zespół logistyki 
  (6, 4, 'Deska sosnowa', 0.100, 0.035, 0.900, 2.0, null),
  (6, 4, 'Deska jesionowa', 0.150 , 0.025 , 2.000 , 1.8, null),
  (6, 4, 'Deska bukowa', 0.150 , 2.5 , 0.03, 1.9, null),
  (6, 4, 'Deska lipowa', 0.100, 2.5 , 0.03, 2.1, null),
  (6, 4, 'Deska olchowa', 0.100, 3.5, 3.000, 2.2, null),
  (7, 4, 'Płyta MDF', 1.220, 1.8, 2.440, 1.4, null),
  (7, 4, 'Płyta OSB', 1.220, 2.5, 2.440, 1.5, null),
  (7, 4, 'Płyta HDF', 1.220, 0.8, 2.440, 1.2, null),
  (7, 4, 'Płyta laminowana', 1.220, 1.8, 2.440, 1.4, null),
  (7, 4, 'Płyta wiórowo-drewniana', 1.220, 16, 2.440, 1.5, null),
  (8, 4, 'Listwa sosnowa', 0.050, 1.2, 2.000, 2, null),
  (8, 4, 'Płaska listwa jesionowa', 0.020, 5, 2.000, 2.5, null),
  (9, 4, 'Okleina orzechowa', 0.200, 0.6, 2.000, 1.5, null),
  (9, 4, 'Okleina klonowa', 0.150, 0.5, 2.000, 1.5, null),
  (9, 4, 'Okleina dębowa', 0.150, 0.5, 2.000, 1.7, null),
  (10, 4, 'Szkło przezroczyste', 2.440, 0.03, 1830, 2.5, null),
  (10, 4, 'Szkło lustrzane', 2.440, 0.03, 1.830, 2.5, null),
  (10, 4, 'Szkło satynowe', 2.000, 0.04, 1.000, 2.6, 'matowe'),
  (10, 4, 'Szkło hartowane', 2.134, 0.1, 3.050, 3.8, 'wzmocnione'),
  (11, 4, 'Zamek kłódkowy', 0.060, 0.040, 0.025, 0.2, null),
  (11, 4, 'Zamek wklęsły', 0.080, 0.060, 0.030, 0.5, null),
  (11, 4, 'Zamek kłódkowy', 0.100, 0.070, 0.040, 0.8, null),
  (11, 4, 'Zamek wielopunktowy', 0.150, 0.100, 0.50, 0.3, null),
  (12, 4, 'Zawias piankowy', 0.08, 0.02, 0.11, 0.15, null),
  (12, 4, 'Zawias tulejowy', 0.09, 0.03, 0.1, 0.2, null),
  (12, 4, 'Zawias wenecki', 0.08, 0.04, 0.15, 0.3, null);

INSERT
  Wlasciwosc_Materialu (Nazwa, ID_Jednostka_miary)
VALUES
  ('Gęstość', 10),
  ('Wytrzymałość', 9),
  ('Twardość', 11),
  ('Wydajność pokrycia', 2),
  ('Skok gwintu', 1);

INSERT
  Material_Wlasciwosc_Material(ID_Material, ID_Wlasciwosc_Materialu, Wartosc)
VALUES
  (1, 1, 10),
  (2, 2, 10),
  (3, 2, 10),
  (4, 3, 10),
  (5, 4, 10);

INSERT
  Produkt (
    ID_Rodzaj_Produktu,
    Nazwa,
    Szerokosc,
    Glebokosc,
    Wysokosc,
    Masa,
    Zlozonosc_produktu
  )
VALUES
  (1, 'Regał Sosnowy', 1.200, 0.400, 1.800, 25, 6),
  (2, 'Krzesło Dębowe', 0.450, 0.450, 1.000, 7, 4),
  (3, 'Stół Dębowy', 1.200, 1.200, 0.700, 20, 4),
  (4, 'Półka Sosnowa', 1.200, 0.300, 0.040, 2, 1),
  (5, 'Stolik Dębowy', 0.800, 0.800, 0.600, 10, 3);

INSERT
  Narzedzia (
    ID_Rodzaj_Narzedzia,
	Symbol,
    Opis,
    Data_przychodu,
    Data_rozchodu
  )
VALUES
  (1,'TDD-63', 'fi300mm', '2023-03-01', null),
  (2,'NTDD-24x24x150', '24x24x160', '2023-03-01', null),
  (3,'SP-300', '300g', '2023-03-01', null),
  (4,'SP-4', '4mm', '2023-03-01', null),
  (5,'W-4', '4mm', '2023-03-01', null),
  (6,'W-BOSCH', ' BOSCH ', '2023-03-01', null),
  (7,'SK-BOSCH', ' BOSCH ', '2023-03-01', '2023-04-01'),
  (8,'SO-BOSCH', ' BOSCH ', '2023-03-01', '2023-04-01'),
  (9,'ZW-BOSCH', ' BOSCH ', '2023-03-01', null),
  (10,'P-NEO', 'NEO', '2023-03-01', null),
  (11,'D-NEO', 'Okragly', '2023-03-01', null),
  (12,'FDD-Płaskie', 'Plaskie', '2023-03-01', null),
  (12,'FDD-10', 'fi10_2P', '2023-03-01', null);

INSERT
  Model_Maszyny(
    ID_Rodzaj_Strategii_Eksp,
    Marka,
    Model,
    ID_Rodzaj_Maszyny,
    Koszt_Roboczogodziny
  )
VALUES
  (1, 'BERNARDO', 'TS 1300 TC', 1, 79),
  (2, 'BERNARDO', 'TS 1300 TCE', 1, 75),
  (1, 'CENTAURO', 'TC 1200', 2, 95),
  (2, 'DINCMAK', 'PRO.TM-2-1000', 2, 88),
  (1, 'BERNARDO', 'TB 20 T', 3, 45),
  (2, 'BOSCH', 'PBD 40', 3, 40),
  (1, 'Verto', '52G219', 4, 20),
  (2, 'BOSCH', 'GTS 10 XC', 4, 50),
  (2, 'brak', 'brak', 5, 30);

INSERT
  Normy_Eksploatacyjne (ID_Model_Maszyny, Nr_Normy)
VALUES
  (1, 'PN-EN-56103:1978'),
  (3, 'PN-EN-50110:1998'),
  (5, 'PN-EN-50113:2001'),
  (7, 'PN-EN-51113:2000');

INSERT
  Maszyny(
    ID_Model_Maszyny,
    Symbol,
    Data_przychodu,
    Data_rozchodu,
    Przebieg_poczatkowy
  )
VALUES
  (1, 'Fr-01', '2023-02-01', NULL, 2),
  (2, 'Fr-02', '2023-02-01', NULL, 2),
  (3, 'Tk-01', '2023-01-15', NULL, 0),
  (4, 'Tk-02', '2023-01-30', NULL, 3),
  (5, 'WS-01', '2023-02-01', '2023-04-01', 5),
  (6, 'WS-02', '2023-01-15', NULL, 1),
  (7, 'PT-01', '2023-02-01', NULL, 7),
  (8, 'PT-02', '2023-01-15', NULL, 2),
  (9, 'BRK', '2023-01-15', NULL, 0);

--ZAPOZYCZENIE Z AF --------------------------------------------------------------------------------------------------------------------- 
INSERT
  Sklad_Zamowienia (
    ID_Zamowienia_Klienci,
    ID_Produkt,
    Ilosc,
    Cena_Netto,
    Cena_Brutto,
    Komentarz
  )
VALUES
  (1, 1, 15, 3000, 4200, null),
  (2, 2, 20, 6500, 7800, null),
  (2, 4, 5, 700, 940, null),
  (3, 4, 10, 1400, 1880, null),
  (3, 3, 3, 1000, 1230, null);

--KONIEC ---------------------------------------------------------------------------------------------------------------------------------- 
INSERT
  Proces (
    ID_Sklad_Zamowienia,
    ID_Maszyny,
    ID_Nazwa_Procesu,
	Ilosc,
    Data_Planowanego_Rozpoczecia,
    Data_Planowanego_Zakonczenia,
    Data_Rzeczywistego_Rozpoczecia,
    Data_Rzeczywistego_Zakonczenia,
    czas_pracy_maszyny
  )
VALUES

  --procesy do produkcji regału
  (1,8,1,15,'2023-03-12','2023-03-14','2023-03-12','2023-03-14',14),  --Cięcie półki
  (1,8,3,15,'2023-03-12','2023-03-14','2023-03-12','2023-03-14',14),  --Cięcie nogi regału

  --procesy do produkcji krzesła
  (2,7,1,20,'2023-03-12','2023-03-14','2023-03-12','2023-03-14',14), --Cięcie siedziska
  (2,7,2,20,'2023-03-14','2023-03-16','2023-03-14','2023-03-16',16), --Cięcie podparcia
  (2,3,3,20,'2023-03-16','2023-03-18','2023-03-16','2023-03-18',18), --Toczenie nóg
  (2,3,4,20,'2023-03-16','2023-03-18','2023-03-16','2023-03-18',10), --Składanie
  (2,9,11,20,'2023-03-16','2023-03-18','2023-03-16','2023-03-18',10),--Klejenie

  --procesy do produkcji półki
  (3,8,11,10,'2023-04-19','2023-05-25','2023-04-23',null,10);



INSERT
  Dokumentacja (ID_Rodzaj_Dokumentacja, ID_Produkt, Plik, Data_)
VALUES
  (1, 1, 'RegalSosnowy_Kv1', '2023-03-01'),
  (2, 1, 'RegalSosnowy_Tv1', '2023-03-01'),
  (1, 2, 'KrzesloSosnowe_Kv1', '2023-03-01'),
  (2, 2, 'KrzesloSosnowe_Tv1', '2023-03-01'),
  (1, 3, 'StolDebowy_Kv1', '2023-03-01'),
  (2, 3, 'StolDebowy_Tv1', '2023-03-01'),
  (1, 4, 'PolkaDebowa_Kv1', '2023-03-01'),
  (2, 4, 'PolkaDebowa_Tv1', '2023-03-01'),
  (1, 5, 'StolikDebowy_Kv1', '2023-03-01'),
  (2, 5, 'StolikDebowy_Tv1', '2023-03-01');

INSERT
  Czynnosci_Eksploatacyjne(
    ID_Normy_Eksploatacyjne,
    ID_Rodzaj_Obslug_Maszyny,
    Godziny
  )
VALUES
  (1, 1, 70),
  (1,4,70),
  (1, 3, 80),
  (2, 2, 80),
  (2, 5, 80),
  (3, 5, 80),
  (3,1,75),
  (3,4,88),
  (4, 3, 87),
  (4, 4, 87),
  (4, 6, 90);

INSERT
  Obslugi(
    ID_Maszyny,
    ID_Pracownicy,
    ID_Rodzaj_Obslugi_Maszyny,
    Koszt_netto,
    Koszt_brutto,
    Opis,
    Data_od,
    Data_do
  )
VALUES
  (1,1,1,887.56,1097.7,'Kalibracja przebiegła pomyślnie','2023-02-03','2023-02-03'),
  (1,2,4,587.58,722.72,'Filtry wymienione','2023-03-15','2023-03-20'),
  (1,2,3,8880,10922.40,'Regeneracja wrzeciona przebiegła pomyślnie','2023-04-04','2023-04-12'),
  (3,1,5,887.56,1097.7,'Wrzeciono zregenerowne','2023-03-05','2023-03-05'),
  (3,2,1,887.56,1097.7,'Kalibracja przebiegła pomyślnie','2023-04-03','2023-04-08'),
  (3,2,4,587.58,722.72,'Filtry wymienione','2023-04-15','2023-04-17');

INSERT
  Parametr_Maszyny(
    ID_Model_Maszyny,
    Nazwa_Parametru,
    Wartosc_Nominalna,
    Dolna_Granica,
    Gorna_Granica
  )
VALUES
  (2, 'Zasilanie', 24, 23, 25),
  (4, 'Zasilanie', 120, 115, 125),
  (6, 'Całkowity pobór mocy',8000, 7000, 9000),
  (8, 'Całkowity pobór mocy', 2000, 1500, 3000);


INSERT
  Badanie_Maszyny(ID_Maszyny, ID_Pracownicy, Data, Opis)
VALUES
  (2, 12, '2023-05-05', 'Brak opisu'),
  (4, 12, '2023-05-06', 'Brak opisu'),
(4, 12, '2023-05-07', 'Brak opisu'),
(4,12,'2023-05-09','Brak opisu'),
  (6, 12, '2023-03-04', 'Brak opisu'),
  (8, 12, '2023-03-04', 'Brak opisu'),
(2,12,'2023-05-06','Brak opisu'),
(2,12,'2023-05-09','Brak opisu');



INSERT
  Badany_Parametr(ID_Badanie, ID_Parametr_Maszyny, Wartosc)
VALUES
  (1, 1, 25),
  (2, 2, 122),
(3, 2, 120),
(4, 2,118),
  (5, 3, 6999),
  (6, 4, 2000),
(7,1,24),
(8,1,23);


INSERT
  Zlecenie_Magazynowe (
    ID_Sklad_Zamowienia,
    ID_Pracownicy,
    data,
    CzyzlecenieStale,
    Zwrot,
    Uwagi
  )
VALUES
  (2, 6, '2023-03-01', 'TAK', 0, 'Brak uwag'),
  (3, 4, '2023-03-01', 'NIE', 0, 'Brak uwag'),
  (2, 3, '2024-02-02', 'TAK', 0, 'Brak uwag'),
  (1, 9, '2024-05-05', 'TAK', 0, 'Brak uwag'),
  (1, 6, '2024-10-10', 'TAK', 0, 'Brak uwag');
INSERT
  ZleceniaStale (ID_Zlecenie_Magazynowe, Co_Ile, DataDo)
VALUES
  (1, 10, '2023-03-01'),
  (2, 5, '2023-03-01'),
  (3, 6, '2023-03-01');

INSERT
  Sklad_Zlecenie_Magazynowe (
    ID_Zlecenie_Magazynowe,
    ID_Material,
    Data,
    CzyZlecenieStale,
    Zwrot,
    Uwagi,
	IloscMaterialow
  )
VALUES
  (1, 1, '2023-03-01', 'Tak', 'nie', 'brak',10),
  (1, 2, '2023-03-01', 'Tak', 'nie', 'brak',5),
  (2, 1, '2023-03-01', 'Tak', 'nie', 'brak',5),
  (2, 2, '2023-03-01', 'Tak', 'nie', 'brak',5),
  (4, 2, '2024-05-10', 'Tak', 'nie', 'brak',10);


INSERT
  Sklad_Zlecenie_Produkt (
    ID_Zlecenie_Magazynowe,
    ID_Produkt,
    Data,
    CzyZlecenieStale,
    Zwrot,
    Uwagi,
	IloscProduktow
  )
VALUES
  (1, 1, '2023-03-01', 'Tak', 'nie', 'brak',5),
  (1, 1, '2023-03-01', 'Tak', 'nie', 'brak',10),
  (3, 2, '2023-05-05', 'Tak', 'nie', 'brak',20),
  (2, 2, '2023-03-01', 'Tak', 'nie', 'brak',5),
  (3, 1, '2023-09-05', 'Tak', 'nie', 'brak',5),
  (5, 2, '2023-06-05', 'Tak', 'tak', 'brak',1000);
INSERT
  Proces_Narzedzia (ID_Narzedzia, ID_Proces)
VALUES
  (1, 1),
  (1, 2),
  (2, 3),
  (9, 4);

INSERT
  Proces_Pracownicy (ID_Proces, ID_Pracownicy, Czas_Pracy)
VALUES
  (1, 7, 1),
  (2, 7, 1),
  (3, 8, 1),
  (4, 9, 1),
  (5, 6, 1),
  (6, 5, 1),
  (7, 10, 1),
  (8, 11, 1);

INSERT
  Dokumentacja_Pracownicy (
    ID_Dokumentacja,
    ID_Pracownicy,
    ID_Funkcja_w_Dokumentacji
  )
VALUES
  (1, 1, 1),
  (2, 2, 2),
  (3, 1, 1),
  (4, 2, 2),
  (5, 1, 1),
  (6, 2, 2),
  (7, 1, 1),
  (8, 2, 2);

INSERT
  Proces_Technologiczny(ID_Produkt,ID_Rodzaj_Maszyny,ID_Nazwa_Procesu,Kolejnosc,Ilosc_Godzin,Ilosc_Pracownikow)
VALUES

--Regał
  (1, 4, 25, 1, 1, 1),
  (1, 2, 6, 2, 1, 1),
  (1, 5, 11, 3, 1, 1),
  (1, 5, 14, 4, 1, 1),
  
--Krzesło  
  (2, 4, 1, 1, 1, 1),
  (2, 4, 2, 2, 1, 1),
  (2, 2, 3, 3, 1, 1),
  (2, 5, 18, 4, 1, 1),
  (2, 5, 4, 5, 1, 1),
  
--Stół
  (3, 4, 7, 1, 1, 1),
  (3, 1, 8, 2, 1, 1),
  (3, 2, 9, 3, 1, 1),
  (3, 5, 19, 4, 1, 1),
  (3, 5, 22, 5, 1, 1),

--Półka
  (4, 5, 5, 1, 1, 1),

--Stolik
--  (5, 4, 7, 1, 1, 1), cięcie desek
  (5, 1, 17, 1, 1, 1),  --frezowanie blatu stolika
  (5, 2, 24, 2, 1, 1),  -- toczenie nóg
  (5, 5, 20, 3, 1, 1), -- klejenie
  (5, 5, 23, 4, 1, 1); -- składanie

 
INSERT
  Proces_Technologiczny_Material (ID_Proces_Technologiczny, ID_Material, Ilosc)
VALUES
--regal
  (1, 1, 6),
  (2, 2, 2),
  (3, 12, 1),
  (4, 13, 0),
--krzesło
  (5, 3, 1),
  (6, 4, 1),
  (7, 5, 4),
  (8, 12, 1),
  (9, 13, 0),
--stol
  (10, 6, 1),
  (11, 6, 1),
  (12, 7, 4),
  (13, 12, 1),
  (14, 13, 0),
--polka
  (15, 1, 1),
 --stolik
  
  (16, 6, 1),
  (17, 7, 4),
  (18, 12, 1),
  (19, 13, 0);

  
------------------------------------DZIAŁ LOGISTYKI----------------------------------------------------------------------  
INSERT INTO
  RodzajPojazdu(Nazwa)
VALUES
  ('Dostawczy'),
  ('Pol-ciezarowy'),
  ('Ciezarowy');

 INSERT INTO
  ModelePojazdu(
    ID_RodzajPojazdu,
    Marka,
    Model,
    Nosnosc,
    PojemnoscSilnika,
    Szerokosc,
    Glebokosc,
    Wysokosc
  )
VALUES
  ('1', 'Ford', 'Transit', '700', '2000', '1.75', '2.5', '1.4'),
  ('1','Renault','Master','700','2500','1.7','2.5','1.7'),
  ('2', 'Hino', '338', '1500', '5000', '2.2', '4.5', '2.2'),
  ('3','Iveco','Stralis','4000','10000','2.5','13.5','2.5'),
  ('3', 'Man', 'TGX', '4000', '10000', '3.5', '15', '2.5'),
  ('3', 'Scania', 'R-series', '3500', '10000', '3', '12', '2.5'),
  ('1', 'Mercedes', 'Sprinter', '800', '2500', '2.2', '4.5', '2.2');

INSERT INTO
  Pojazd(
    ID_ModelPojazd,
    NrRejestracyjny,
    RokProdukcji,
    DataPrzychodu,
    StanLicznikaPoczatkowy,
    DataRozchodu
  )
VALUES
  (
    '1',
    'WD71292',
    '2010',
    '2023-03-01',
    '50000',
    '2023-03-25'
  ),
  ('2', 'WB11462', '2015', '2023-03-01', '25000', null),
  ('2', 'WB91821', '2015', '2023-03-01', '30000', null),
  ('3', 'WB719SA', '2020', '2023-03-01', '40000', null),
  ('4', 'WD61G61', '2014', '2023-03-01', '100000', null),
  ('5', 'WD61FS0', '2014', '2023-03-01', '100000', null),
  ('6', 'WA52121', '2018', '2023-03-01', '20000', null),
  ('7', 'WG5SA12', '2016', '2023-03-01', '25000', null);
INSERT INTO
  NormyEksploatacyjne_Pojazd(ID_ModelPojazd, RemontSredni, RemontGlowny)
VALUES
  ('1', '5000', '25000'),
  ('2', '5000', '25000'),
  ('3', '4000', '20000'),
  ('4', '6000', '28000'),
  ('5', '7000', '30000'),
  ('6', '4000', '20000'),
  ('7', '6000', '30000');
INSERT INTO
  RodzajPaliwa(Nazwa)
VALUES
  ('Benzyna 95'),
  ('Benzyna 98'),
  ('Olej napędowy'),
  ('Gaz LPG');

INSERT INTO
  RodzajUbezpieczenia(Nazwa)
VALUES
  ('OC'),
  ('AC'),
  ('Assistance'),
  ('OC+AC');

INSERT INTO
  Ubezpieczyciel(NazwaFirmy)
VALUES
  ('PZU'),
  ('Warta'),
  ('AXA');

INSERT INTO
  RodzajObslugi_Pojazdow(Nazwa)
VALUES
  ('Awaria'),
  ('Wymiana klockow i tarcz hamulcowych'),
  ('Zmiana opon'),
  ('Wymiana filtrow');

INSERT INTO
  RodzajDostawcy(Nazwa)
VALUES
  ('Tartak'),
  ('Hurtownia');

INSERT INTO
  Dostawcy(NazwaFirmy, Telefon)
VALUES
  ('Tartak Stary Młyn', '523 894 761'),
  ('Sosnowiec', '728 456 123'),
  ('Stal-Export', '546 863 485'),
  ('GlassDepot', '666 420 069');

INSERT INTO
  PrzegladPojazdu(ID_Pojazd, KosztNetto, KosztBrutto, data, DataDoP)
VALUES
  (1, '1000', '1200', '2023-03-01', '2024-03-01'),
  (2, '1000', '1200', '2023-03-01', '2024-03-01'),
  (3, '1200', '1440', '2023-03-01', '2024-03-01'),
  (4, '2000', '2400', '2023-03-01', '2024-03-01'),
  (5, '3000', '3600', '2023-03-01', '2024-03-01'),
  (6, '3000', '3600', '2023-03-01', '2023-04-01'),
  (7, '3000', '3600', '2023-03-01', '2024-03-01'),
  (8, '2500', '3000', '2023-03-01', '2024-03-01');

INSERT INTO
  ObslugiPojazdow(
    ID_Pojazd,
    ID_RodzajObslugi_Pojazdow,
    ID_Pracownik,
    DataObslugiOd,
	DataObslugiDo,
    KosztNetto,
    KosztBrutto
  )
VALUES
  (1, 1, 2, '2023-03-15','2023-04-15', '2000', '2400'),
  (1, 2, 2, '2023-03-15','2023-06-15', '500', '600'),
  (2, 4, 2, '2023-03-20','2023-03-17', '600', '720'),
  (3, 4, 2, '2023-03-10','2023-03-16', '300', '360'),
  (2, 2, 2, '2023-05-08','2023-05-13', '300', '360');

INSERT INTO
  Ubezpieczenie(
    ID_Pojazd,
    ID_Ubezpieczyciel,
    ID_RodzajUbezpieczenia,
    DataOd,
    DataDo,
    KosztNetto,
    KosztBrutto
  )
VALUES
  (1, 1, 4, '2023-03-01', '2024-03-01', '1400', '1680'),
  (2, 2, 4, '2023-03-01', '2024-03-01', '1200', '1440'),
  (3, 3, 4, '2023-03-01', '2024-03-01', '1000', '1200'),
  (4, 2, 4, '2023-03-01', '2024-03-01', '3000', '3600'),
  (5, 1, 4, '2023-03-01', '2023-04-01', '3800', '4560'),
  (6, 3, 4, '2023-03-01', '2024-03-01', '4000', '4400'),
  (7, 1, 2, '2023-03-01', '2024-03-01', '2000', '2400'),
  (8, 2, 2, '2023-03-01', '2024-03-01', '4000', '4400');

INSERT INTO
  Tankowanie(
    ID_Pojazd,
    ID_RodzajPaliwa,
    LiczbaLitrow,
    KosztNetto,
    KosztBrutto,
    [Data]
  )
VALUES
  (1, 2, '100', '700', '830', '2023-03-01'),
  (2, 3, '100', '650', '800', '2023-03-01'),
  (2, 3, '100', '650', '800', '2023-04-01'),
  (3, 1, '100', '600', '720', '2023-03-01'),
  (3, 1, '100', '600', '720', '2023-04-01'),
  (4, 3, '150', '900', '1080', '2023-03-01'),
  (4, 3, '150', '900', '1080', '2023-04-01'),
  (5, 3, '500', '3000', '3600', '2023-03-01'),
  (5, 3, '500', '3000', '3600', '2023-04-01'),
  (6, 3, '600', '3600', '4320', '2023-03-01'),
  (6, 3, '600', '3600', '4320', '2023-04-01'),
  (7, 3, '600', '3600', '4320', '2023-03-01'),
  (7, 3, '600', '3600', '4320', '2023-04-01'),
  (8, 3, '600', '3600', '4320', '2023-03-01'),
  (8, 3, '600', '3600', '4320', '2023-04-01');
INSERT INTO
  StanLicznika(ID_Pojazd, ID_Pracownik, StanLicznika, data)
VALUES
  (1, 1, '50000', '2023-03-01'),
  (1, 1, '50600', '2023-04-01'),
  (2, 2, '25000', '2023-03-01'),
  (2, 2, '25600', '2023-04-01'),
  (3, 3, '50000', '2023-03-01'),
  (3, 3, '50500', '2023-04-01'),
  (4, 4, '40000', '2023-03-01'),
  (4, 4, '40500', '2023-04-01'),
  (5, 5, '100000', '2023-03-01'),
  (5, 5, '100800', '2023-04-01'),
  (6, 6, '100000', '2023-03-01'),
  (6, 6, '100700', '2023-04-01'),
  (7, 6, '20000', '2023-03-01'),
  (7, 6, '20500', '2023-04-01'),
  (8, 6, '25000', '2023-03-01'),
  (8, 6, '25500', '2023-04-01');

  GO

INSERT INTO
  Dostawa(ID_Dostawcy, ID_Pracownik, Data)
VALUES
  (1, 16, '2023-01-01'),
  (3, 16, '2023-01-15'),
  (4, 16, '2023-01-22'),
  (1, 16, '2023-04-01'); --tartak stary mlyn

  GO

INSERT INTO
  SkladDostawa_Material(
    ID_Material,
    ID_Dostawa,
    ID_Faktury,
    Ilosc,
    KosztNetto,
    KosztBrutto
  )
VALUES
  (1, 1, 1001, 50, 21.37, 26.29),
  (2, 3, 1002, 10, 42.0, 63.6),
  (3, 2, 1003, 10, 59.0, 72.57),
  (4, 3, 9001, 10, 30.00, 36.90),
  (1,4,NULL,10, 20, 30), -- sklejka sosnowa
  (2,4,NULL,10, 20, 30), -- sklejka sosnowa lakierowana
  (3,4,NULL,10, 25, 35), --sklejka dębowa 
  (4,4,NULL,10, 25, 35), --sklejka dębowa lakierowana
  (5,4,NULL,10, 30, 40), --delka debowa
  (6,4,NULL,10, 30, 40), --deska debowa
  (7,4,NULL,10, 20, 30), --belka jarzębowa
  (13,4,NULL,10, 20, 30), --deska sosnowa
  (14,4,NULL,10, 20, 30), --deska jesionowa
  (15,4,NULL,10, 20, 30), --deska bukowa
  (16,4,NULL,10, 20, 30), --deska lipowa
  (17,4,NULL,10, 20, 30); --deska olchowa
INSERT INTO
  Wysylka(
  	ID_Pojazd,
    ID_Pracownik,
    Odleglosc,
    Data
  )
VALUES
  (
	1,
    19,
    200,
	'2023-01-01'
  ),
  (
	1,
    20,
    20,
	'2023-01-01'
  ),
  (
	2,
    19,
    700,
	'2023-01-01'
  ),
  (
	3,
    20,
    500,
	'2023-01-01'
  );

INSERT INTO
  SkladWysylka_Produkt(
    ID_Wysylka,
	ID_ZamowieniaKlienci,
    ID_Produkt,
	ID_Magazyn,
    ID_Pracownik,
    Ilosc
  )
VALUES
  (1, 1, 1, 1, 18, 5),
  (1, 1, 2, 1, 18, 4),
  (2, 1, 2, 1, 17, 3),
  (2, 1, 3, 1, 17, 2),
  (2, 1, 4, 1, 17, 3),
  (3, 1, 3, 1, 18, 1),
  (4, 1, 4, 1, 17, 2);

insert into
  Sekcja (
    ID_Magazyn,
    ID_TypZasobu,
    Numer,
    PowierzchniaRobocza
  )
values
  (1, 1, 'Produkcja-dr', 5000),
  (1, 2, 'Produkcja-szk', 5000),
  (1, 3, 'Produkcja-el-met', 5000),
  (1, 4, 'Produkcja-chem', 5000),
  (1, 5, 'Produkcja-polfab', 5000),
  (1, 6, 'Produkcja-wyr-drew', 5000),
  (2, 1, 'MPS3', 6000),
  (2, 2, 'MPS4', 6000),
  (2, 3, 'MPS4', 6000),
  (2, 4, 'MPS4', 6000),
  (3, 5, 'MPS5', 7000),
  (3, 6, 'MPS6', 7000);

insert into
  Polka (
  ID_Sekcja,
  Numer,
  SzerokoscPietra,
  DlugoscPietra,
  WysokoscPietra,
  Udzwig,
  LiczbaPieter
  )
values
  (1, 'MP1',   50,  100, 10,  10000, 1),
  (2, 'MP2',   50,  100, 10,  10000, 1),
  (3, 'MP3',   50,  100, 10,  10000, 1),
  (4, 'MP4',   50,  100, 10,  10000, 1),
  (5, 'MP5',   50,  100, 10,  10000, 1),
  (6, 'MP6',   50,  100, 10,  10000, 1),
  (7, 'MP7',   1.5, 20,  2,   1000,  6),
  (7, 'MP8',   2,   25,  2.5, 1500,  6),
  (8, 'MP9',   1.5, 20,  2,   1000,  6),
  (8, 'MP10',  2,   25,  2.5, 1500,  6),
  (9, 'MP11',  1.5, 20,  2,   1000,  6),
  (9, 'MP12',  2,   25,  2.5, 1500,  6),
  (10, 'MP13', 1.5, 20,  2,   1000,  6),
  (10, 'MP14', 2,   25,  2.5, 1500,  6),
  (11, 'MP15', 1.5, 20,  2,   1000,  6),
  (11, 'MP16', 2,   25,  2.5, 1500,  6),
  (12, 'MP17', 10,  20,  5,   10000, 1),
  (12, 'MP18', 10,  25,  5,   1000,  1);

insert into 
  Nierozlozone_Materialy (
	ID_Material,
	Ilosc,
	DataOd,
	DataDo
  )
values
  ( 1, 1000, '2023-01-01', null),
  ( 2, 3, '2023-01-02', null),
  ( 3, 4, '2023-01-03', null),
  ( 33, 4, '2023-01-05', null),
  ( 13, 2, '2023-01-04', null);

  insert into 
  Nierozlozone_Produkty(
	ID_Produkt,
	Ilosc,
	DataOd,
	DataDo
  )
values
  ( 1, 1, '2023-01-01', null),
  ( 2, 2, '2023-01-02', null),
  ( 3, 3, '2023-01-03', null);

insert into
  RozlozeniePolki_Produkty (
    ID_Polka,
    ID_Pracownik,
    ID_Produkt,
    Ilosc,
    DataOd,
    DataDo
  )
values
  (6, 2, 2, 2, '2023-01-01', null),
  (6, 1, 2, 5,  '2023-01-02', null);

insert into
  RozlozeniePolki_Materialy(
    ID_Polka,
    ID_Pracownik,
    ID_Material,
    Ilosc,
    DataOd,
    DataDo
  )
values
  (7, 2, 1, 50, '2023-01-01', null),
  (7, 1, 2, 45,  '2023-01-02', null),
  (7, 1, 3, 60,  '2023-01-02', null),
  (7, 1, 4, 30,  '2023-01-02', null),
  (7, 1, 5, 52,  '2023-01-02', null),
  (7, 1, 6, 44,  '2023-01-02', null),
  (7, 1, 7, 30,  '2023-01-02', null),
  (7, 1, 8, 10,  '2023-01-02', null),
  (9, 1, 29, 30,  '2023-01-02', null),
  (9, 1, 30, 25,  '2023-01-02', null),
  (9, 1, 31, 25,  '2023-01-02', null),
  (11, 1, 31, 30,  '2023-01-02', null),
  (11, 1, 36, 30,  '2023-01-02', null),
  (11, 1, 37, 50,  '2023-01-02', null),
  (12, 1, 38, 40,  '2023-01-02', null),
  (12, 1, 32, 80,  '2023-01-02', null),
  (12, 1, 33, 90,  '2023-01-02', null),
  (12, 1, 34, 80,  '2023-01-02', null),
  (13, 1, 11, 45,  '2023-01-02', null),
  (13, 1, 12, 50,  '2023-01-02', null);

insert into
  TransportWewnetrzny (
    ID_Zlecenie_Magazynowe,
    ID_Pracownik,
    ID_Pojazd,
    ID_Magazyn_pocz,
    ID_Magazyn_konc,
    [Data]
  )
values
  (1, 1, 1, 1, 2, '2020-01-01'),
  (2, 2, 1, 2, 3, '2020-01-02'),
  (3, 1, 1, 3, 1, '2020-01-03');

INSERT INTO
  Dostawca_RodzajDostawcy(ID_RodzajDostawcy, ID_Dostawcy)
VALUES
  (1, 1),
  (1, 2),
  (2, 3),
  (2, 4);

insert into
  Sklad_TransportWewnetrzny_Material (ID_TransportWewnetrzny, ID_Material, Ilosc)
values
  (2, 1, 3),
  (3, 1, 2);

 GO

  insert into
Kontrola_Jakosci_Zamowienia(ID_Sklad_Zamowienia, Ilosc, Zaakcpetowane, Odrzucone, [Data], Uwagi)
values
(1,20, 15, 5,'2023-03-26','uwaga');

--insert into 
--  TypZasobu_RodzajMaterialu (
--    ID_TypZasobu,
--	ID_Rodzaj_Materialu
--  )
--values
--  (1, 1),
--  (1, 7),
--  (1, 8),
--  (1, 9),
--  (1, 10),
--  (2, 11),
--  (3, 2),
--  (3, 3),
--  (3, 12),
--  (3, 13),
--  (4, 4),
--  (4, 5);
