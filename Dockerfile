FROM microsoft/dotnet:2.1-sdk as build  
WORKDIR /PatternAppChainOfResponsibility
COPY PatternAppChainOfResponsibility . 

RUN dotnet restore
RUN dotnet publish "PatternAppChainOfResponsibility.csproj" -c Release -o /app

FROM microsoft/dotnet:2.1-runtime as deployment
WORKDIR /app 
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "PatternAppChainOfResponsibility.dll" ]