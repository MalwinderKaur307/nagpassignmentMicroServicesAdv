FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Assignment.AggregatorService/Assignment.AggregatorService.csproj", "Assignment.AggregatorService/"]
RUN dotnet restore "Assignment.AggregatorService/Assignment.AggregatorService.csproj"
COPY . .
WORKDIR "/src/Assignment.AggregatorService"
RUN dotnet build "Assignment.AggregatorService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Assignment.AggregatorService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Assignment.AggregatorService.dll"]