FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["To-Do-App-MVC/To-Do-App-MVC.csproj", "To-Do-App-MVC/"]
RUN dotnet restore "To-Do-App-MVC/To-Do-App-MVC.csproj"
COPY . .
WORKDIR "/src/To-Do-App-MVC"
RUN dotnet build "To-Do-App-MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "To-Do-App-MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "To-Do-App-MVC.dll"]
