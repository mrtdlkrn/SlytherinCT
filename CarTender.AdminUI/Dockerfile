#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CT.AdminUI/CT.AdminUI.csproj", "CT.AdminUI/"]
COPY ["Business/Business.csproj", "Business/"]
COPY ["Common/Common.csproj", "Common/"]
COPY ["Entity/Entity.csproj", "Entity/"]
RUN dotnet restore "CT.AdminUI/CT.AdminUI.csproj"
COPY . .
WORKDIR "/src/CT.AdminUI"
RUN dotnet build "CT.AdminUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CT.AdminUI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CT.AdminUI.dll"]