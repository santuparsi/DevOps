FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["../TestApp1/TestApp1.csproj", "../TestApp1/"]
RUN dotnet restore "../TestApp1/TestApp1.csproj"
COPY . .
WORKDIR "/src/../TestApp1"
RUN dotnet build "TestApp1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestApp1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestApp1.dll"]