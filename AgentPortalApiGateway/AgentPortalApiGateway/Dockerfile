FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

ENV APP_HOME /opt/app
RUN mkdir $APP_HOME
WORKDIR $APP_HOME

COPY AgentPortalApiGateway/AgentPortalApiGateway.Api/*.csproj $APP_HOME/AgentPortalApiGateway.Api/
COPY AgentPortalApiGateway/AgentPortalApiGateway/*.csproj $APP_HOME/AgentPortalApiGateway/
RUN dotnet restore $APP_HOME/AgentPortalApiGateway/AgentPortalApiGateway.csproj

COPY AgentPortalApiGateway/AgentPortalApiGateway.Api/ $APP_HOME/AgentPortalApiGateway.Api/
COPY AgentPortalApiGateway/AgentPortalApiGateway/ $APP_HOME/AgentPortalApiGateway/
RUN dotnet build $APP_HOME/AgentPortalApiGateway/AgentPortalApiGateway.csproj

FROM build AS publish
WORKDIR $APP_HOME
RUN dotnet publish $APP_HOME/AgentPortalApiGateway/AgentPortalApiGateway.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8099
ENV ASPNETCORE_ENVIRONMENT=docker
COPY --from=publish /opt/app/out ./
ENTRYPOINT ["dotnet", "AgentPortalApiGateway.dll"]
