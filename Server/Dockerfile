FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /source

# copy entire Server context (API + DAL + solution)
COPY . .
RUN dotnet restore API/API.csproj
WORKDIR /source/API
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app ./

ENTRYPOINT ["dotnet", "API.dll"]