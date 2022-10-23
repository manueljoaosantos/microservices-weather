dotnet new sln
dotnet new console -o Weather.DataLoader
dotnet new webapi -o Weather.Report
dotnet new webapi -o Weather.Temperature
dotnet new webapi -o Weather.Precipitation
dotnet sln add .\Weather.Temperature\
dotnet sln add .\Weather.DataLoader\
dotnet sln add .\Weather.Report\
dotnet sln add .\Weather.Precipitation\

dotnet build

