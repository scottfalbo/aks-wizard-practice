# Using the same base as before.
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Using the SDK for building.
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WizardPractice.ReagentReservoir.Service.csproj", "WizardPractice.ReagentReservoir.Service/"]
WORKDIR "/src/WizardPractice.ReagentReservoir.Service"
RUN dotnet restore
COPY . .
RUN dotnet build -c Release -o /app/build

# Publishing
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# Final Stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WizardPractice.ReagentReservoir.Service.dll"]