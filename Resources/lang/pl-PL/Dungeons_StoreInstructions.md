# Część 1 - Skrypt PowerShell
Wersja Minecraft Dungeons ze sklepu Microsoft Store nie zezwala na modyfikowanie jej plików/folderów. Aby obejść tę blokadę, wykonaj następujące czynności:

## Wymagania wstępne:
- Tymczasowo wyłącz jakiekolwiek oprogramowanie antywirusowe. Większość z nich wykryje, że uruchomiony jest nieznany skrypt i spróbuje go zatrzymać.
- Jeśli używasz programu Bitdefender, należy go odinstalować przed kontynuowaniem, ponieważ przerywa on skrypt, nawet jeśli zostanie wyłączony.
- Upewnij się, że posiadasz co najmniej 10 GB wolnego miejsca.
- Upewnij się, że Twoja gra jest aktualna. Aby to zrobić, naciśnij klawisze Windows + R, wpisz `ms-windows-store://DownloadsAndUpdates/` i naciśnij Enter. Następnie naciśnij "Pobierz aktualizacje" w prawym górnym rogu nowo otwartego okna.
- Zainstaluj [Pakiet redystrybucyjny Visual C++](https://aka.ms/vs/16/release/vc_redist.x64.exe). Zrób to, nawet jeśli uważasz, że jest już zainstalowane. Możesz posiadać starszą wersję, która nie zadziała.

## W Bedrock Launcher:
1. Upewnij się, że Źródło gry jest ustawione na `Microsoft Store`
3. Naciśnij na `Zainstaluj poprawkę sklepową`

## W oknie PowerShell:

3. Będzie konieczne wybranie folderu. Wybierz pusty folder, do którego ma zostać przeniesiona gra. Nie wybieraj folderu znajdującego się w Plikach programów lub OneDrive, ponieważ może dojść do awarii.
4. W pewnym momencie gra zostanie uruchomiona. Nie zamykaj jej, gdy tak się stanie. Jeśli napotkasz jakiekolwiek problemy, sprawdź sekcję Rozwiązywanie problemów poniżej.
5. Zostanie utworzony folder `~mods`. W nim umieścisz swoje modyfikacje.
7. Uruchamianie zmodyfikowanej wersji gry odbywa się tak samo, jak zwykłej wersji gry. Możesz ją uruchomić z menu Start, sklepu Microsoft Store, aplikacji Xbox itd, tak jak robisz to zazwyczaj. NIE uruchamiaj gry poprzez pliki .exe znajdujące się w folderze gry.

## Rozwiązywanie problemów:
- Jeśli napotkasz jakiekolwiek problemy podczas/po aktualizacji gry, niektóre z tych rozwiązań mogą Ci pomóc.
- Jeśli gra w ogóle nie uruchomiła się podczas aktualizacji oraz aktualizacja nie powiodła się, uruchom grę ręcznie przed przystąpieniem do aktualizacji. Pozostaw grę otwartą, dopóki sama się nie zamknie lub aktualizacja zostanie zakończona.
- Jeśli zostanie wyświetlony błąd weryfikacji posiadania gry, oznacza to, że uruchomiono grę poprzez plik .exe. Nie rób tego. Uruchom grę z menu Start, przez sklep Microsoft Store lub aplikację Xbox. If you did, but still get this error, reinstall the regular game and log in at least once (open the game and select a character) before patching it.

# Part 2 - The Bedrock Launcher Setup
1. Set the install location to the folder containing `Dungeons.exe`. It should be in a parent folder of the `~mods` folder from earlier
2. Select where you want your symbolic mods folder to be (it should not be in the same location as `~mods` folder from earlier)
3. Click on `Install Symbolic Link`
4. Folder modyfikacji Twojej gry powinien być teraz powiązany z symbolicznym folderem modyfikacji

# Jak aktualizować
1. Naciśnij na `Odinstaluj symboliczne powiązanie`
2. Naciśnij na `Zaktualizuj poprawkę sklepową`
3. Jeśli to konieczne, powtórz kroki 3-6 z części 1
4. Powtórz kroki 1-4 z części 2
5. Gotowe



