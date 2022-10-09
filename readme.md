# Observability with OpenTelemetry and dotnet

## Web contains a react frontend (in ClientApp/) and .net 6 backend

## Api contains a web service called by .net 6 backend

## Api persists data to a postgres db

## Solution created with

- mkdir hello-dotnet-distributed-tracing
- cd hello-dotnet-distributed-tracing
- mkdir Web
- mkdir Api
- dotnet new react -n Web
- dotnet new web -n Api
- dotnet new sln
- dotnet sln add ./Web/ ./Api/
- dotnet restore

- cd Web
- cd ClientApp && npx browserslist@latest --update-db && npm install && npm audit fix

- cd Web
- dotnet watch run
- Web asp.net backend runs on :7163
- Web react frontend runs on :44418

- cd Api (in another console)
- dotnet watch run
- Api runs on :7068

- Add docker support to both Web\ and Api\ using VS
- Add container orchestration support (I choose docker-compose) to both Web\ and Api\ using VS
  
