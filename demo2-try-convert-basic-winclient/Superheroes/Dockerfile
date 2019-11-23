FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Superheroes/Superheroes.csproj", "Superheroes/"]
RUN dotnet restore "Superheroes/Superheroes.csproj"
COPY . .
WORKDIR "/src/Superheroes"
RUN dotnet build "Superheroes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Superheroes.csproj" -c Release -o /app/publish
COPY Superheroes/Protos/superheroes.proto /app/publish/Protos/superheroes.proto

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Superheroes.dll"]