FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Xerris.SRE.ProductCatalog/Xerris.SRE.ProductCatalog.csproj", "Xerris.SRE.ProductCatalog/"]
RUN dotnet restore "Xerris.SRE.ProductCatalog/Xerris.SRE.ProductCatalog.csproj"
COPY . .
WORKDIR "/src/Xerris.SRE.ProductCatalog"
RUN dotnet build "Xerris.SRE.ProductCatalog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Xerris.SRE.ProductCatalog.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Xerris.SRE.ProductCatalog.dll"]
