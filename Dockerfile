FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

COPY ConsoleApp2/ConsoleApp2.csproj .
RUN dotnet restore

COPY ConsoleApp2 .
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/runtime:5.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "./ConsoleApp2.dll"]
