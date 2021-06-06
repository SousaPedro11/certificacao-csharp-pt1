FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["certificacao-csharp-pt1/certificacao-csharp-pt1.csproj", "certificacao-csharp-pt1/"]
RUN dotnet restore "certificacao-csharp-pt1/certificacao-csharp-pt1.csproj"
COPY . .
WORKDIR "/src/certificacao-csharp-pt1"
RUN dotnet build "certificacao-csharp-pt1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "certificacao-csharp-pt1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "certificacao-csharp-pt1.dll"]
