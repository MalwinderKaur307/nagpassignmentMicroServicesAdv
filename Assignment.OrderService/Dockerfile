FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Assignment.OrderService/Assignment.OrderService.csproj", "Assignment.OrderService/"]
RUN dotnet restore "Assignment.OrderService/Assignment.OrderService.csproj"
COPY . .
WORKDIR "/src/Assignment.OrderService"
RUN dotnet build "Assignment.OrderService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Assignment.OrderService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Assignment.OrderService.dll"]