FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 83

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY CatalogMicroservicesDocker.sln ./
COPY CatalogMicroservicesDocker/CatalogMicroservicesDocker.csproj CatalogMicroservicesDocker/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/CatalogMicroservicesDocker
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CatalogMicroservicesDocker.dll"]
