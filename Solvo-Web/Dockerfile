# Build aþamasý
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Proje dosyalarýný kopyala
COPY Solvo-Web/*.csproj ./Solvo-Web/
RUN dotnet restore ./Solvo-Web/Solvo-Web.csproj

COPY . .
RUN dotnet publish ./Solvo-Web/Solvo-Web.csproj -c Release -o /app/publish

# Runtime aþamasý
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .

# Uygulamayý baþlat
ENTRYPOINT ["dotnet", "Solvo-Web.dll"]
