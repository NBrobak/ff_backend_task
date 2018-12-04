FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY FundayChallenge/FundayChallenge.csproj FundayChallenge/
RUN dotnet restore FundayChallenge/FundayChallenge.csproj
COPY . .
WORKDIR /src/FundayChallenge
RUN dotnet build FundayChallenge.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FundayChallenge.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FundayChallenge.dll"]
