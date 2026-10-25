# TH4 Insurance Microservices

This workspace contains the .NET 8 insurance-agent microservices sample plus the supplied Vue, Blazor, PostgreSQL, Eureka, and Docker assets.

## Stack
- .NET 8, ASP.NET Core, MediatR, PostgreSQL, RabbitMQ, Elasticsearch, Eureka
- Vue SPA uses npm lockfile; do not regenerate dependencies as part of .NET work.

## Commands
- Build all .NET projects: `dotnet build TH4InsuranceMicroservices.sln --nologo`
- Run tests: `dotnet test TH4InsuranceMicroservices.sln --no-build`
- The integration-test project may require Docker and Elasticsearch.

## Layout
- `<Service>/<Service.Api>/`: service contracts, commands, queries, DTOs, and events
- `<Service>/<Service>/`: service implementation
- `<Service>/<Service.Test>/`: unit or integration test projects
- `AgentPortalApiGateway/AgentPortalApiGateway/`: API Gateway project
- `BlazorWasmClient/BlazorWasmClient/`: Blazor client; API project references resolve from the workspace root
- `Web/Web/`: Vue client
- `postgres/postgres/`, `eureka-server/eureka-server/`, `scripts/scripts/`: supplied infrastructure assets

## Gotchas
- Keep `.env*`, `appsettings*.json`, database backups, and credentials out of Git.
- The original Docker scripts are nested under `scripts/scripts`; verify paths before using them.
- Do not edit extracted RAR files; use the solution projects and source folders.
