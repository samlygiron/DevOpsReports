# Instruccions to create and run in container

**SO**: Ubuntu 20.04.3 LTS

## Running/Publish the project

In a terminal, in the repo root, run:
```
dotnet build
dotnet run --project ReleaseCoordination/ReleaseCoordination.csproj 
dotnet publish -c Release
```

## Creating the image
```
docker build -t reports .
docker run -it --rm -p 8080:80 --name reports reports
```

Navigate to 
http://localhost:8080/
