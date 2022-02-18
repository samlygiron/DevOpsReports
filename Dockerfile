FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY ReleaseCoordination/bin/Release/net5.0/publish App/
WORKDIR /App
EXPOSE 80
ENTRYPOINT ["dotnet", "ReleaseCoordination.dll"]
