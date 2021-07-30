#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebApi/TopLevelDomain.ProjectName.WebApi.csproj", "WebApi/"]
COPY ["Application/TopLevelDomain.ProjectName.Application.csproj", "Application/"]
COPY ["Domain/TopLevelDomain.ProjectName.Domain.csproj", "Domain/"]
COPY ["Infrastructure/TopLevelDomain.ProjectName.Infrastructure.csproj", "Infrastructure/"]
RUN dotnet restore "WebApi/TopLevelDomain.ProjectName.WebApi.csproj"
COPY . .
WORKDIR "/src/WebApi"
RUN dotnet build "TopLevelDomain.ProjectName.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TopLevelDomain.ProjectName.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TopLevelDomain.ProjectName.WebApi.dll"]