docker run -v c:\tmp\hostname-core:c:\hostname -ti microsoft/dotnet:nanoserver

docker build -t hostname-core:latest -f .\docker\Dockerfile.server2016 .\docker\
docker run --rm -p5000:5000 -v c:\tmp\hostname-core\src\bin\Debug\netcoreapp1.0\publish:c:\hostname\bin -ti hostname-core:latest
