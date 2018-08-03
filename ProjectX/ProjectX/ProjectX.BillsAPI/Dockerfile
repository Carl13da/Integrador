FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 51875
EXPOSE 44316

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY ProjectX.BillsAPI/ProjectX.BillsAPI.csproj ProjectX.BillsAPI/
RUN dotnet restore ProjectX.BillsAPI/ProjectX.BillsAPI.csproj
COPY . .
WORKDIR /src/ProjectX.BillsAPI
RUN dotnet build ProjectX.BillsAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProjectX.BillsAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProjectX.BillsAPI.dll"]
