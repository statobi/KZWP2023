# KZWP2023
sql and c#

**TODO dla ownera repo:**
- spróbuj określić role w tym repo tj. chcemy aby struktura w repo wyglądała mniej więcej: project-leader > team-leader > cała reszta

Oczywiście nie narzucam się, ale wydaje mi się, że ten podstawowy config jest jak najbardziej na miejscu ;p
Można też pobawić sie configiem i spróbować znaleźć "najlepsze" ustawienia dla tego repo


GIT Komendy:

git checkout tag - przełączenie się do gałęzi tag
git merge tag - scala zmiany gałęzi tag z gałęzią na której jesteśmy
git branch - pokazuje wszystkie gałęzie, na zielono zaznaczona jest ta na której jesteśmy
git branch tag - tworzy nową gałąź o nazwie tag
git add --all - zapisuje zmiany
git commit -a -m "Nazwa Commitu" - tworzy Commit o nazwie Nazwa Commitu(mogą być spacje i polskie znaki w ""), z załączeniem wszystkich zmienionych plików 
git push - wysyła zmiany
git reset hard - przywraca kod do stanu z poprzedniego commita
git reset –hard ORIG_HEAD - przywraca zmiany do ostatniego commita
git status - sprawdza poczynione zmiany w plikach
git branch -d nazwa_gałęzi - kasuje lokalną gałąź

Przykładowe utworzenie nowej funkcjonalności
1. Pobieramy najnowszą wersję projektu

    git pull origin main
    
2. Tworzymy nową lokalną gałąź z początkiem NazwaDzialu, DzialAF, DzialP, DzialL
    
    git branch DzialAF/Patryk/FormularzPracownicy
    git checkout DzialAF/Patryk/FormularzPracownicy
    
3. Sprawdzamy czy jesteśmy na nowej gałęzi!!!!

    git branch
    lub to coś w nawiasie ;)
    
4. Robimy piękny, działający formularz i następnie gdy chcemy wypchnąć nasze zmiany

    git commit -a -m "Utworzono Formularz, nawet działa"
    git push DzialAF/Patryk/FormularzPracownicy
    
5. Przechodzimy do repozytorium na github.com, wybieramy swoją gałąź i możemy zrobić pull request

    - nastepuje sprawdzenie, czy zmiany są prawidłowe
    - można kliknąć auto-merge lub po ukończonym sprawdzeniu, jeśli nie wywaliło błędu klikamy Merge!!!!!
