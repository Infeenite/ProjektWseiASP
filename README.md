# ProjektWseiASP

Projekt został wykonany poprzez dotnet SDK 6.x i poniższa instrukcja dotyczy postawienia projektu przez dotnet CLI

Należy Zainstalować:
Dotnet SDK 6.x
Node.js (LTS)
Docker

Dockera należy skonfigurować zgodnie z systemem operacyjnym a następnie dodać nowy obraz o nazwie example_sql_server, user id=sa oraz haśle Strong.Pwd-123
(W związku z konfiguracją może być konieczna akceptacja EULA)

Konfigurując node.js należy po zainstalowaniu wpisać npm i -g @angular/cli (Na systemach innych niż windows może być konieczne użycie sudo)

Konfigurując dotneta należy upewnić się że dotnet CLI zostało prawidłowo zainstalowane używając komendy dotnet --version.
Następnie należy zainstalować narzędzia entity framework poleceniem dotnet tool install --global dotnet-ef


Otwierając projekt należy użyć polecenia dotnet restore, następnie za pomocą cd przejść do ClientApp oraz wykonać polecenie npm i, aby przywrócić pakiety npm
z pliku package.json.

Następnie należy zaseedować bazę danych poleceniem dotnet ef database update.
Projekt powinien uruchomić się za pomocą komendy dotnet run.
