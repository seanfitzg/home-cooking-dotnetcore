FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# Create this "restore-solution" section by running ./Create-DockerfileSolutionRestore.ps1, to optimize build cache reuse
COPY ["HomeCooking.Logging/HomeCooking.Logging.csproj", "./"]
COPY ["HomeCooking.Domain/HomeCooking.Domain.csproj", "./HomeCooking.Domain"]
RUN dotnet restore "HomeCooking.Logging.csproj"

# Copy everything else and build
COPY ./HomeCooking.Logging/ ./
COPY ./HomeCooking.Domain /HomeCooking.Domain
RUN dotnet publish HomeCooking.Logging.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "HomeCooking.Logging.dll"]
