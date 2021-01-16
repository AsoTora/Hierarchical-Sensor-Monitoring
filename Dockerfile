FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
COPY ./Release .
EXPOSE 44330
ENTRYPOINT ["dotnet", "HSMServer.dll"]