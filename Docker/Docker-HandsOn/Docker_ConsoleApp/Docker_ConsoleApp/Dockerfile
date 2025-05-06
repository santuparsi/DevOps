#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Docker_ConsoleApp/Docker_ConsoleApp.csproj", "Docker_ConsoleApp/"]
RUN dotnet restore "Docker_ConsoleApp/Docker_ConsoleApp.csproj"
COPY . .
WORKDIR "/src/Docker_ConsoleApp"
RUN dotnet build "Docker_ConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Docker_ConsoleApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Docker_ConsoleApp.dll"]