FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["CarvedRock.Api/CarvedRock.Api.csproj", "CarvedRock.Api/"]
RUN dotnet restore "CarvedRock.Api/CarvedRock.Api.csproj"
COPY . .
WORKDIR "/src/CarvedRock.Api"
RUN dotnet build "CarvedRock.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CarvedRock.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CarvedRock.Api.dll"]