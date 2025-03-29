dotnet --version
dotnet clean   -c Release -tl
dotnet restore
dotnet build   -c Release -tl
dotnet test    --no-build --verbosity normal
