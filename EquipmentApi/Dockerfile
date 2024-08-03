
FROM mcr.microsoft.com/dotnet/aspnet:7.0-bullseye-slim AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:7.0-bullseye-slim AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["EquipmentApi/EquipmentApi.csproj", "EquipmentApi/"]
RUN dotnet restore "./EquipmentApi/EquipmentApi.csproj"

COPY . .
WORKDIR "/src/EquipmentApi"
RUN dotnet build "./EquipmentApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./EquipmentApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EquipmentApi.dll"]