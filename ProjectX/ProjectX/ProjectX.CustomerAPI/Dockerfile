FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 50837
EXPOSE 44338

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY ProjectX.CustomerAPI/ProjectX.CustomerAPI.csproj ProjectX.CustomerAPI/
RUN dotnet restore ProjectX.CustomerAPI/ProjectX.CustomerAPI.csproj
COPY . .
WORKDIR /src/ProjectX.CustomerAPI
RUN dotnet build ProjectX.CustomerAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProjectX.CustomerAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProjectX.CustomerAPI.dll"]
