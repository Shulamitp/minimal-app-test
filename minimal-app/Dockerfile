#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#WORKDIR /app
#EXPOSE 8080
#EXPOSE 8081
#
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#WORKDIR /src
#COPY ["minimal-app.csproj", "./"]
#RUN dotnet restore "minimal-app.csproj"
#COPY . .
#RUN dotnet build "minimal-app.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "minimal-app.csproj" -c Release -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "minimal-app.dll"]
#

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# ����� ���
WORKDIR /app_minimal
COPY . .

# Restore + Build + Publish (���� ����� ���)
RUN dotnet publish -c Release -o out

## ����� �����
ENV DB_CONNECTION="your_connection_string_here"


# ����� ���������
WORKDIR /app_minimal/out
CMD ["dotnet", "minimal-app.dll"]