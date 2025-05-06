#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["HandsOnDockertoConnectSQL/HandsOnDockertoConnectSQL.csproj", "HandsOnDockertoConnectSQL/"]
RUN dotnet restore "HandsOnDockertoConnectSQL/HandsOnDockertoConnectSQL.csproj"
COPY . .
WORKDIR "/src/HandsOnDockertoConnectSQL"
RUN dotnet build "HandsOnDockertoConnectSQL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HandsOnDockertoConnectSQL.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HandsOnDockertoConnectSQL.dll"]