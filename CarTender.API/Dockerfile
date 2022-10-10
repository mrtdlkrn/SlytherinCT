#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000
ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CT.API/CT.API.csproj", "CT.API/"]
COPY ["CT.Business/CT.Business.csproj", "CT.Business/"]
COPY ["CT.Core/CT.Core.csproj", "CT.Core/"]
COPY ["CT.Entities/CT.Entities.csproj", "CT.Entities/"]
COPY ["CT.DataAccess/CT.DataAccess.csproj", "CT.DataAccess/"]
COPY ["CT.Common/CT.Common.csproj", "CT.Common/"]
RUN dotnet restore "CT.API/CT.API.csproj"
COPY . .
WORKDIR "/src/CT.API"
RUN dotnet build "CT.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CT.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CT.API.dll","--environment=Development"]