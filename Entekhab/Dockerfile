#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Entekhab/Entekhab.Endpoints.WebApi.csproj", "Entekhab/"]
COPY ["Entekhab.Application/Entekhab.Applications.csproj", "Entekhab.Application/"]
COPY ["Entekhab.Domain/Entekhab.Domain.csproj", "Entekhab.Domain/"]
COPY ["Entekhab.OvetimePolicies/Entekhab.OvetimePolicies.csproj", "Entekhab.OvetimePolicies/"]
COPY ["Entekhab.Infrastructure.Dapper/Entekhab.Infrastructure.Dapper.csproj", "Entekhab.Infrastructure.Dapper/"]
COPY ["Entekhab.Infrastructure.Ef/Entekhab.Infrastructure.EfPersistance.csproj", "Entekhab.Infrastructure.Ef/"]
RUN dotnet restore "Entekhab/Entekhab.Endpoints.WebApi.csproj"
COPY . .
WORKDIR "/src/Entekhab"
RUN dotnet build "Entekhab.Endpoints.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Entekhab.Endpoints.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Entekhab.Endpoints.WebApi.dll"]