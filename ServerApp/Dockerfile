# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["ServerApp/ServerApp.csproj", "ServerApp/"]
RUN dotnet restore "ServerApp/ServerApp.csproj"

# Copy the remaining files and build the application
COPY . .
WORKDIR "/src/ServerApp"
RUN dotnet build "ServerApp.csproj" -c $BUILD_CONFIGURATION -o /build

# Publish the application
RUN dotnet publish "ServerApp.csproj" -c $BUILD_CONFIGURATION -o /publish --no-restore

# Stage 2: Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app
COPY --from=build /publish ./

# Ensure the database directory exists inside the container
RUN mkdir -p /app/Data/SQLite

# Copy the SQLite database file to the container if needed (optional)
# COPY ServerApp/Data/SQLite/data.db /app/Data/SQLite/data.db

# Expose the application port
EXPOSE 80

# Entry point for running the application
ENTRYPOINT ["dotnet", "ServerApp.dll"]