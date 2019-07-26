
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS publish
WORKDIR /src
COPY /src .
RUN dotnet publish "OSeage.LMS.COM.API/OSeage.LMS.COM.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OSeage.LMS.COM.API.dll"]