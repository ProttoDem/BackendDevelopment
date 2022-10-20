#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BackendLab/BackendLab.csproj", "BackendLab/"]
RUN dotnet restore "BackendLab/BackendLab.csproj"
COPY . .
WORKDIR "/src/BackendLab"
RUN dotnet build "BackendLab.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BackendLab.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BackendLab.dll"]