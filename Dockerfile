FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
COPY ./Artifacts .
EXPOSE 44330
ENTRYPOINT ["dotnet", "HSMServer.dll"]