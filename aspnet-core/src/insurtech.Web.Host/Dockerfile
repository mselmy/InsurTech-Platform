FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/insurtech.Web.Host/insurtech.Web.Host.csproj", "src/insurtech.Web.Host/"]
COPY ["src/insurtech.Web.Core/insurtech.Web.Core.csproj", "src/insurtech.Web.Core/"]
COPY ["src/insurtech.Application/insurtech.Application.csproj", "src/insurtech.Application/"]
COPY ["src/insurtech.Core/insurtech.Core.csproj", "src/insurtech.Core/"]
COPY ["src/insurtech.EntityFrameworkCore/insurtech.EntityFrameworkCore.csproj", "src/insurtech.EntityFrameworkCore/"]
WORKDIR "/src/src/insurtech.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/insurtech.Web.Host", "src/insurtech.Web.Host"]
COPY ["src/insurtech.Web.Core", "src/insurtech.Web.Core"]
COPY ["src/insurtech.Application", "src/insurtech.Application"]
COPY ["src/insurtech.Core", "src/insurtech.Core"]
COPY ["src/insurtech.EntityFrameworkCore", "src/insurtech.EntityFrameworkCore"]
WORKDIR "/src/src/insurtech.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "insurtech.Web.Host.dll"]
