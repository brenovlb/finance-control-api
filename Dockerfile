FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY . .

RUN dotnet restore src/FinanceControl.Api/FinanceControl.Api.csproj
RUN dotnet publish src/FinanceControl.Api/FinanceControl.Api.csproj -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /out .

ENTRYPOINT ["dotnet", "FinanceControl.Api.dll"]