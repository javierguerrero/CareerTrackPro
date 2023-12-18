#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ms.jobseekers/ms.jobseekers.api/ms.jobseekers.api.csproj", "ms.jobseekers/ms.jobseekers.api/"]
COPY ["ms.jobseekers/ms.jobseekers.application/ms.jobseekers.application.csproj", "ms.jobseekers/ms.jobseekers.application/"]
COPY ["ms.communications/ms.rabbitmq/ms.rabbitmq.csproj", "ms.communications/ms.rabbitmq/"]
COPY ["ms.jobseekers/ms.jobseekers.domain/ms.jobseekers.domain.csproj", "ms.jobseekers/ms.jobseekers.domain/"]
COPY ["ms.jobseekers/ms.jobseekers.infrastructure/ms.jobseekers.infrastructure.csproj", "ms.jobseekers/ms.jobseekers.infrastructure/"]
RUN dotnet restore "./ms.jobseekers/ms.jobseekers.api/./ms.jobseekers.api.csproj"
COPY . .
WORKDIR "/src/ms.jobseekers/ms.jobseekers.api"
RUN dotnet build "./ms.jobseekers.api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ms.jobseekers.api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ms.jobseekers.api.dll"]