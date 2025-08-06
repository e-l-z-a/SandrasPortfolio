# Use official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy everything and restore dependencies
COPY . ./
RUN dotnet restore

# Build and publish the app
RUN dotnet publish -c Release -o out

# Use runtime image for final container
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Expose port
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "SandrasPortfolio.dll"]
