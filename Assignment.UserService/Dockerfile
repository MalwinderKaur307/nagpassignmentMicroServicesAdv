FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Assignment.UserService/Assignment.UserService.csproj", "Assignment.UserService/"]
RUN dotnet restore "Assignment.UserService/Assignment.UserService.csproj"
COPY . .
WORKDIR "/src/Assignment.UserService"
RUN dotnet build "Assignment.UserService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Assignment.UserService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Assignment.UserService.dll"]