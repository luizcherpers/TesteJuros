#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Calculo/Calculo.csproj", "Calculo/"]
RUN dotnet restore "Calculo/Calculo.csproj"
COPY . .
WORKDIR "/src/Calculo"
RUN dotnet build "Calculo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Calculo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Calculo.dll"]
