#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ArchitectureSkeleton/ArchitectureSkeleton.csproj", "ArchitectureSkeleton/"]
RUN dotnet restore "ArchitectureSkeleton/ArchitectureSkeleton.csproj"
COPY . .
WORKDIR "/src/ArchitectureSkeleton"
RUN dotnet build "ArchitectureSkeleton.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ArchitectureSkeleton.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ArchitectureSkeleton.dll"]